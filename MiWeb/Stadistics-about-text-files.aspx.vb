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
                        Dim location As String = "C:\Users\Sanchez\source\repos\MyWebSite\MiWeb\" & fname
                        file.SaveAs(Path.Combine("C:\Users\Sanchez\source\repos\MyWebSite\MiWeb", fname))

                        Dim MiArray() As String, VDatos As String

                        Dim sr As StreamReader = New StreamReader(location)
                        Dim full_text As StreamReader = New StreamReader(location)
                        Dim line As String, count_line As Integer
                        line = Trim(sr.ReadLine())
                        ReDim MiArray(line.Length)
                        While (Not line Is Nothing And line <> "")
                            For i = 0 To line.Length - 1
                                VDatos = line(i)
                                MiArray(i) = VDatos
                            Next
                            count_line += 1
                            wordCount.Items.Add(New ListItem("Line [" & count_line & "] have " & line.Length & " words", count_line))
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

    Public Function MeanMedianMode(ByRef location As String, ByVal countLine As Integer) As Boolean
        Dim check As Boolean = False


        Return check
    End Function
End Class