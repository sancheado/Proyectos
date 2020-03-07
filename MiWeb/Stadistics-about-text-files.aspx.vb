Imports System.Diagnostics.Eventing
Imports System.IO

Public Class Stadistics_about_text_files
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            restart()
        Else
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


                        'If Path.GetFileName(file.ContentType) = "plain" Then type.Value = ".txt"
                        dimensions.Value = Path.GetFileName(file.ContentLength)
                        txtArea.Value = ""

                        Dim sr As New System.IO.StreamReader(location)
                        txtArea.Value = sr.ReadToEnd()

                        Dim leer As New StreamReader(location)
                        Dim MyArray() As String
                        Dim VDatos() As String




                        Dim contWords As Integer
                        Dim ConjuntLinies As System.IO.StreamReader
                        ConjuntLinies = New System.IO.StreamReader(location)
                        Dim Linia As String
                        Linia = Trim(ConjuntLinies.ReadLine())
                        Dim cont As String = "0"
                        While Not Linia Is Nothing
                            VDatos = Linia.Split(vbTab)
                            contWords += VDatos.Length
                            MyArray = VDatos
                            'Dim VDades2 As String
                            'VDades2 = VDatos(0)
                            'Dim separar() As String = VDades2.Split(",")
                            'Dim idOrigen As String = separar(0)
                            Linia = Trim(ConjuntLinies.ReadLine())
                            cont += 1
                        End While
                        lineCount.Value = cont
                        wordCount.Value = contWords
                        ConjuntLinies.Close()
                        leer.Close()
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
        'secretPanel.Attributes.Add(“style”, ” display:none;”)
        PrincipalPanel.Attributes.Add(“style”, ” display:Block;”)
        wordCount.Value = ""
        lineCount.Value = ""
        txtArea.Value = ""
    End Function
End Class