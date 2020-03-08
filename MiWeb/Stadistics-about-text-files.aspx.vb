Imports System
Imports System.IO
Public Class Stadistics_about_text_files
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            restart()
        Else
            restart()
            Dim file = Request.Files("fileItem")
            If (file.ToString <> "" And file.ContentLength > 0) Then '1º Check, input with something
                Dim fname As String = Path.GetFileName(file.FileName)
                Dim extension As String = Path.GetFileName(file.ContentType)
                If extension = "plain" Then '2º Check, file its txt file
                    If Path.GetFileName(file.ContentLength) < 1200 Then 'Ponemos límite a la subida del txt. No más de 1200 de longitud total.
                        'activamos/desactivamos paneles y renombramos el panel que estaba disable, ahora se llamará como el archivo subido (:
                        secretPanel.Attributes.Add(“style”, ” display:Block;”)
                        PrincipalPanel.Attributes.Add(“style”, ” display:none;”)
                        spOculto.InnerHtml = fname & "<i class='fas fa-file-upload miI'></i>"

                        'Guardamos el archivo subido para su posterior analisis.
                        Dim location As String = "C:\Users\el_re\source\repos\Proyectos\MiWeb\" & fname
                        'Dim location As String = "C:\Users\Sanchez\source\repos\MyWebSite\MiWeb\" & fname
                        file.SaveAs(Path.Combine("C:\Users\el_re\source\repos\Proyectos\MiWeb\", fname))
                        'file.SaveAs(Path.Combine("C:\Users\Sanchez\source\repos\MyWebSite\MiWeb", fname))

                        Dim MiArray() As String, VDatos As String, ModeArray() As Integer

                        Dim sr As StreamReader = New StreamReader(location)
                        Dim full_text As StreamReader = New StreamReader(location)
                        Dim line As String, count_line As Integer
                        line = Trim(sr.ReadLine())
                        ReDim MiArray(line.Length)

                        While (Not line Is Nothing And line <> "")
                            For i = 0 To line.Length - 1
                                VDatos = line(i).ToString
                                MiArray(i) = VDatos

                                ModeArray = calculateMode(line)
                                mode.Items.Add(New ListItem("Line [" & count_line & "] mode= " & ModeArray(i) & " words", count_line))
                            Next
                            count_line += 1
                            wordCount.Items.Add(New ListItem("Line [" & count_line & "] have " & Trim(line.Length) & " words", count_line))

                            line = Trim(sr.ReadLine())
                        End While

                        txtArea.Value = full_text.ReadToEnd() 'Put the complete text inside txt file in the textarea
                        lineCount.Value = count_line
                        full_text.Close()
                        sr.Close()
                        If (System.IO.File.Exists(location)) Then
                            System.IO.File.Delete(location)
                        End If
                    Else
                        restart()
                        ClientScript.RegisterStartupScript(Page.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('ERROR! The fyle its to big, please choose a different file.');</script>")
                    End If
                Else
                    restart()
                    ClientScript.RegisterStartupScript(Page.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('ERROR! You need to choose any txt file');</script>")
                End If
            Else
                restart()
                ClientScript.RegisterStartupScript(Page.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('ERROR! You need to choose any file');</script>")
            End If
        End If
    End Sub

    Public Function restart() 'Function for reset every input
        secretPanel.Attributes.Add(“style”, ” display:none;”)
        PrincipalPanel.Attributes.Add(“style”, ” display:Block;”)
        wordCount.Value = ""
        lineCount.Value = ""
        txtArea.Value = ""
        wordCount.Items.Clear()
    End Function

    Public Function calculateMode(ByRef line As String) As Integer() 'Hola me llamo Jose
        Dim MyArray(line.Length / 2) As Integer '18
        For i = 0 To line.Length - 1
            Dim primeraPalabra As String = line(i)
            For z = i + 1 To line.Length / 2
                MyArray(z) = 1
                If ((primeraPalabra = line(z) And primeraPalabra <> "")) Then
                    MyArray(z) += 1
                End If
            Next
        Next
        Return MyArray 'solucion, crea array de palabras y comparas y sumas si esta..
    End Function
End Class

'0 H
'1 o
'2 l
'3 a