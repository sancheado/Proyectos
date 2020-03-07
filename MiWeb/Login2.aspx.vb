Public Class Login21
    Inherits System.Web.UI.Page
    Dim clsGeneral As New ClasseGeneral
    'Dim clsBD As New ClasseAccesBD
    Dim VectorSQL(0) As String
    Dim DS As DataSet
    Dim IDFira As Integer = 901
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            clsGeneral.FicaFitxersBootstrap(bootstrap_min_css, bootstrap_datetimepicker_min_css, jquery_1_9_1_min_js, bootstrap_min_js, bootstrap_datetimepicker_js, bootbox_min_js, bootstrap_datetimepicker_es_js, , , , segmented_controls_css)
            txtEmail.Attributes.Add("Placeholder", "Introduzca su Email")
            txtPassword.Attributes.Add("Placeholder", "Introduzca su Contraseña")
            contPass.Visible = False
        Else
            Acciones()
            'If txtEmail.Value.Length > 1 Then
            '    Dim IDContacte As Integer, Criteri As String = "NIT"
            '    If Not clsGeneral.TornaIDContacteSegonsParametre(IDFira, "Email", Trim(txtEmail.Value), IDContacte, , Criteri,,, True) Then
            '        ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script type='text/javascript'>LlançaAvis('No se ha encontrado el email en nuestra Base de datos.<b>Por favor introduzca un email valido!');</script>")
            '        Exit Sub
            '    Else

            'txtCriterio.Value = Criteri
            'Dim idioma = checkIdioma(IDFira, Criteri)



            'If idioma = "2" Then
            '        If (contPass.Style("display") = "none") Then
            '            translate()
            '            ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script type='text/javascript'>LlançaAvis('Hemos detectado que ya estaba previamente registrado por ello, introduzca su contraseña por favor.');</script>")
            '            contPass.Style("display") = "Block"
            '        Else
            '            VectorSQL(0) = "Select Password FROM EEContactes WHERE idFira = " & IDFira & " AND NIT = '" & Criteri & "'"
            '            DS = New DataSet
            '            If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then 'Lo encontramos en nuestra BD con ese criterio
            '                Dim contrasena = DS.Tables(0).Rows(0)("Password")
            '                If contrasena = txtPassword.Value Then 'La Pass coincide
            '                    Response.Redirect("index3.aspx?p=" & Criteri)
            '                Else 'No coincide y le devolvemos al login
            '                    Response.Redirect("index.aspx")
            '                End If
            '            Else 'no encontramos ese parametro

            '            End If
            '        End If
            '    Else
            '        If (contPass.Style("display") = "none") Then
            '            ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script type='text/javascript'>LlançaAvis('Hemos detectado que ya estaba previamente registrado por ello, introduzca su contraseña por favor.');</script>")
            '            contPass.Style("display") = "Block"
            '        Else
            '            VectorSQL(0) = "Select Password FROM EEContactes WHERE idFira = " & IDFira & " AND NIT = '" & Criteri & "'"
            '            DS = New DataSet
            '            If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then 'Lo encontramos en nuestra BD con ese criterio
            '                Dim contrasena = DS.Tables(0).Rows(0)("Password")
            '                If contrasena = txtPassword.Value Then 'La Pass coincide
            '                    Response.Redirect("index3.aspx?p=" & Criteri)
            '                Else 'No coincide y le devolvemos al login
            '                    Response.Redirect("index.aspx")
            '                End If
            '            Else 'no encontramos ese parametro

            '            End If
            '        End If
            '    End If


            'If (contPass.Style("display") = "none") Then
            '    ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script type='text/javascript'>LlançaAvis('Hemos detectado que ya estaba previamente registrado por ello, introduzca su contraseña por favor.');</script>")
            '    contPass.Style("display") = "Block"
            '    Else
            '        VectorSQL(0) = "Select Password FROM EEContactes WHERE idFira = " & IDFira & " AND NIT = '" & Criteri & "'"
            '    DS = New DataSet
            '    If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then 'Lo encontramos en nuestra BD con ese criterio
            '        Dim contrasena = DS.Tables(0).Rows(0)("Password")
            '        If contrasena = txtPassword.Value Then 'La Pass coincide
            '            Response.Redirect("index3.aspx?p=" & Criteri)
            '        Else 'No coincide y le devolvemos al login
            '            Response.Redirect("index.aspx")
            '        End If
            '    Else 'no encontramos ese parametro

            '    End If
            'End If
            'Server.Transfer("index.aspx?p=" & Criteri)
        End If
    End Sub

    Public Function Acciones()
        Dim clsGeneral As New ClasseGeneral
        'Dim clsBD As New ClasseAccesBD
        Dim VectorSQL(0) As String
        Dim DS As DataSet
        Dim IDFira As Integer = 901
        Dim Data As String, Idioma As Integer
        DS = New DataSet
        Idioma = IIf(rbEspanol.Checked, 1, 2)
        '        Try
        '            VectorSQL(0) = "Select Password, NIT AS Parametre FROM EEContactes WHERE (idFira = " & IDFira & " AND Email = '" & clsBD.Cometes(Left(Trim(txtEmail.Value), 100)) & "' AND idTipusContacte = 0)"
        '            If Not clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
        '                ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('" & IIf(Idioma = 1, "Problemas en la verificación. Incidencia registrada para su análisis. Perdone las molestias.", "Problems accessing the database. Issue registered. Sorry for the inconvenience.") & "');</script>")
        '            ElseIf DS.Tables(0).Rows.Count = 0 Then
        '                ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('" & IIf(Idioma = 1, "Por favor, introduzca un email válido.", "Please, type in a valid email.") & "');</script>")
        '            ElseIf DS.Tables(0).Rows(0).Item("Password") = "" Then
        '                GoTo Seguim
        '            ElseIf DS.Tables(0).Rows(0).Item("Password") <> Trim(txtPassword.Value) Then
        '                If contPass.Visible Then
        '                    ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('" & IIf(Idioma = 1, "Por favor, revise su password (distinguiendo mayúsculas y minúsculas).", "Please, check out your password, which is case sensitive.") & "');</script>")
        '                Else
        '                    contPass.Visible = True
        '                    If Idioma = 2 Then
        '                        txtPassword.Attributes.Add("placeholder", "Enter your Password here...")
        '                        rbEspanol.Checked = False
        '                        rbIngles.Checked = True
        '                        lblIngles.Attributes("data-value") = "English ✔&check;"
        '                        lblEspanol.Attributes("data-value") = "Spanish;"
        '                    Else
        '                        rbEspanol.Checked = True
        '                        rbIngles.Checked = False
        '                        lblEspanol.Attributes("data-value") = "Español ✔&check;"
        '                    End If
        '                    ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('" & IIf(Idioma = 1, "La plataforma de registro ha detectado que ya se registró anteriormente.<br><br>Por favor, introduzca el password que indicó cuando se registró.", "The registration platform has detected you are already registered.<br><br>Please, type in the password you specified during the registration process.") & "');</script>")
        '                End If
        '            Else
        'Seguim:
        '                Response.Redirect("index3.aspx?p=" & DS.Tables(0).Rows(0).Item("Parametre") & "&i=" & Idioma, False)
        '                'Response.Redirect("FERARH2019_2.aspx?a=" & DS.Tables(0).Rows(0).Item("Parametre") & "&i=" & Idioma, False)
        '            End If
        '        Catch ex As Exception
        '            Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
        '            VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,MissatgeSistema,Info1,Info2,Data) VALUES(100,'','','Problema executant btnSubmit_Click de la plana Login2.aspx. Les dades eren: " & clsBD.Cometes(VectorSQL(0)) & ", Ex: " & clsBD.Cometes(ex.Message) & "','" & Data & "')"
        '            clsBD.BaseDades(2, VectorSQL)
        '            ClientScript.RegisterStartupScript(Me.GetType(), "Missatge", "<script language='javascript'>LlançaAvis('" & IIf(Idioma = 2, "Problems accessing the database. Issue registered. Sorry for the inconvenience.", "Problemas accediendo a la base de datos. Incidencia registrada para su análisis. Perdone las molestias.") & "');</script>")

        'End Try
    End Function


    Public Function checkIdioma(ByRef idFeria As Integer, ByVal Criterio As String) As String
        Dim comprobar As Integer
        VectorSQL(0) = "Select idOrigen FROM EEContactes WHERE idFira = " & IDFira & " AND NIT = '" & Criterio & "'"
        DS = New DataSet
        'If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then 'Lo encontramos en nuestra BD con ese criterio
        '    comprobar = DS.Tables(0).Rows(0)("idOrigen")
        'Else 'No lo hemos encontrado
        '    comprobar = 0
        'End If
        Return comprobar
    End Function




End Class