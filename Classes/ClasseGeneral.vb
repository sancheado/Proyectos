Imports System.Text
Imports System.Text.RegularExpressions
Imports System.IO

Public Class ClasseGeneral

    Public VPaisosESP As String() = New String(173) {"Afganistán", "Albania", "Alemania", "Algeria", "Andorra", "Angola", "Antigua & Barbuda", "Arabia Saudí", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaiyán", "Bahréin", "Bangladesh", "Barbados", "Bélgica", "Benin", "Bielorusia", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brasil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Centroafricana, Rep.", "Chad", "Chequia", "Chile", "China", "Chipre", "Colombia", "Congo", "Congo Rep.", "Corea del Sur", "Costa de Marfil", "Croacia", "Cuba", "Dinamarca", "Dominicana, Rep.", "Ecuador", "Egipto", "El Salvador", "Emiratos Arabes Unidos", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Feroe, Islas", "Filipinas", "Finlandia", "Fiyis, Islas", "Francia", "Gabón", "Gambia", "Gana", "Georgia", "Gibraltar", "Grecia", "Groenlandia", "Guadeloupe", "Guam", "Guatemala", "Guayana franc.", "Guernsey", "Haití", "Honduras", "Hong Kong", "Hungría", "India", "Indonesia", "Irán", "Irak", "Irlanda", "Islandia", "Israel", "Italia", "Jamaica", "Japón", "Jersey", "Jordania", "Kazajstán", "Kenia", "Kirguizistán", "Kuwait", "Lesoto", "Letonia", "Líbano", "Liberia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas, Las", "Mali", "Malta", "Man, Isla de", "Marruecos", "Martinica", "Mauricio, Isla", "Mauritania", "Mexico", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Caledonia", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palestina", "Panama", "Paraguay", "Perú", "Polinesia", "Polonia", "Portugal", "Puerto Rico", "Qatar", "Reino Unido", "Reunión", "Ruanda", "Rumania", "Rusia", "Senegal", "Serbia", "Sierra Leona", "Singapur", "Siria", "Sri Lanka", "Sudáfrica", "Sudán", "Suecia", "Suiza", "Swazilandia", "Tailandia", "Taiwán", "Tanzania", "Togo", "Trinidad y Tobago", "Túnez", "Turquía", "Ucrania", "Uganda", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Vírgenes brit, Islas", "Yemen", "Zambia", "Zimbabue"}
    Public VPaisosENG As String() = New String(173) {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Benin", "Bhutan", "Bolivia", "Bosnia-Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African, Rep.", "Chad", "Chile", "China", "Colombia", "Congo", "Congo Rep.", "Croatia", "Cuba", "Cyprus", "Czech Rep.", "Denmark", "Dominican, Rep.", "Ecuador", "Egypt", "El Salvador", "Estonia", "Ethiopia", "Faroe, Islands", "Fiji, Islands", "Finland", "France", "French Guiana", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Haiti", "Honduras", "Hong Kong", "Hongary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jersey", "Jordania", "Kazakhstan", "Kenya", "Kuwait", "Kyrgyzstan", "Latvia", "Lebanon", "Lesotho", "Liberia", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Man, Isla de", "Martinique", "Mauritania", "Mauritius", "Mexico", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nepal", "Netherlands", "New Caledonia", "New Zeland", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palestine", "Panama", "Paraguay", "Peru", "Philippines", "Poland", "Polynesia, French", "Portugal", "Puerto Rico", "Qatar", "Réunion", "Romania", "Russia", "Rwanda", "Saudi Arabia", "Senegal", "Serbia", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "South Africa", "South Korea", "Spain", "Sri Lanka", "Sudan", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tanzania", "Thailand", "Togo", "Trinidad and Tobago", "Tunisia", "Turkey", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Virgin, Islands", "Yemen", "Zambia", "Zimbabwe"}
    Public VPaisosENG_OrdreEspanyol As String() = New String(173) {"Afganistán", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaiyán", "Bahréin", "Bangladesh", "Barbados", "Bielorusia", "Bélgica", "Benin", "Bután", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brasil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Camboya", "Camerún", "Canadá", "Cabo Verde", "Centroafricana, Rep.", "Chad", "Chile", "China", "Colombia", "Congo", "Congo Rep.", "Croacia", "Cuba", "Chipre", "Chequia", "Dinamarca", "Dominicana, Rep.", "Ecuador", "Egipto", "El Salvador", "Estonia", "Etiopía", "Feroe, Islas", "Fiyis, Islas", "Finlandia", "Francia", "Guayana franc.", "Gabón", "Gambia", "Georgia", "Alemania", "Gana", "Gibraltar", "Grecia", "Groenlandia", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Haití", "Honduras", "Hong Kong", "Hungría", "Islandia", "India", "Indonesia", "Irán", "Irak", "Irlanda", "Israel", "Italia", "Costa de Marfil", "Jamaica", "Japón", "Jersey", "Jordania", "Kazajstán", "Kenia", "Kuwait", "Kirguizistán", "Letonia", "Líbano", "Lesoto", "Liberia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malaui", "Malasia", "Maldivas, Las", "Mali", "Malta", "Man, Isla de", "Martinica", "Mauritania", "Mauricio, Isla", "Mexico", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Marruecos", "Mozambique", "Namibia", "Nepal", "Países Bajos", "Nueva Caledonia", "Nueva Zelanda", "Nicaragua", "Níger", "Nigeria", "Noruega", "Omán", "Pakistán", "Palestina", "Panama", "Paraguay", "Perú", "Filipinas", "Polonia", "Polinesia", "Portugal", "Puerto Rico", "Qatar", "Reunión", "Rumania", "Rusia", "Ruanda", "Arabia Saudí", "Senegal", "Serbia", "Sierra Leona", "Singapur", "Eslovaquia", "Eslovenia", "Sudáfrica", "Corea del Sur", "España", "Sri Lanka", "Sudán", "Swazilandia", "Suecia", "Suiza", "Siria", "Taiwán", "Tanzania", "Tailandia", "Togo", "Trinidad y Tobago", "Túnez", "Turquía", "Uganda", "Ucrania", "Emiratos Arabes Unidos", "Reino Unido", "Estados Unidos", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Vírgenes brit, Islas", "Yemen", "Zambia", "Zimbabue"}
    Public VPaisosAmbPrefixENG As String() = New String(173) {"Afghanistan (+93)", "Albania (+355)", "Algeria (+213)", "Andorra (+376)", "Angola (+244)", "Antigua & Barbuda (+1268)", "Argentina (+54)", "Armenia (+374)", "Aruba (+297)", "Australia (+61)", "Austria (+43)", "Azerbaijan (+994)", "Bahrain (+973)", "Bangladesh (+880)", "Barbados (+1246)", "Belarus (+375)", "Belgium (+32)", "Benin (+229)", "Bhutan (+975)", "Bolivia (+591)", "Bosnia-Herzegovina (+387)", "Botswana (+267)", "Brazil (+55)", "Brunei (+673)", "Bulgaria (+359)", "Burkina Faso (+226)", "Burundi (+257)", "Cambodia (+855)", "Cameroon (+237)", "Canada (+1)", "Cape Verde (+238)", "Central African, Rep. (+236)", "Chad (+235)", "Chile (+56)", "China (+86)", "Colombia (+57)", "Congo (+242)", "Congo Rep. (+243)", "Croatia (+385)", "Cuba (+53)", "Cyprus (+357)", "Czech Rep. (+420)", "Denmark (+45)", "Dominican, Rep. (+1809)", "Ecuador (+593)", "Egypt (+20)", "El Salvador (+503)", "Estonia (+372)", "Ethiopia (+251)", "Faroe, Islands (+298)", "Fiji, Islands (+679)", "Finland (+358)", "France (+33)", "French Guiana (+594)", "Gabon (+241)", "Gambia (+220)", "Georgia (+995)", "Germany (+49)", "Ghana (+233)", "Gibraltar (+350)", "Greece (+30)", "Greenland (+299)", "Guadeloupe (+590)", "Guam (+671)", "Guatemala (+502)", "Guernsey (+44)", "Haiti (+509)", "Honduras (+504)", "Hong Kong (+852)", "Hongary (+36)", "Iceland (+354)", "India (+91)", "Indonesia (+62)", "Iran (+98)", "Iraq (+964)", "Ireland (+353)", "Israel (+972)", "Italy (+39)", "Ivory Coast (+225)", "Jamaica (+1876)", "Japan (+81)", "Jersey (+44)", "Jordania (+962)", "Kazakhstan (+7)", "Kenya (+254)", "Kuwait (+965)", "Kyrgyzstan (+996)", "Latvia (+371)", "Lebanon (+961)", "Lesotho (+266)", "Liberia (+231)", "Liechtenstein (+423)", "Lithuania (+370)", "Luxembourg (+352)", "Macau (+853)", "Macedonia (+389)", "Madagascar (+261)", "Malawi (+265)", "Malaysia (+60)", "Maldives (+960)", "Mali (+223)", "Malta (+356)", "Man, Isla de (+44)", "Martinique (+596)", "Mauritania (+222)", "Mauritius (+230)", "Mexico (+52)", "Moldova (+373)", "Monaco (+377)", "Mongolia (+976)", "Montenegro (+381)", "Morocco (+212)", "Mozambique (+258)", "Namibia (+264)", "Nepal (+977)", "Netherlands (+31)", "New Caledonia (+687)", "New Zeland (+64)", "Nicaragua (+505)", "Niger (+227)", "Nigeria (+234)", "Norway (+47)", "Oman (+968)", "Pakistan (+92)", "Palestine (+970)", "Panama (+507)", "Paraguay (+595)", "Peru (+51)", "Philippines (+63)", "Poland (+48)", "Polynesia, French (+689)", "Portugal (+351)", "Puerto Rico (+1787)", "Qatar (+974)", "Réunion (+262)", "Romania (+40)", "Russia (+7)", "Rwanda (+250)", "Saudi Arabia (+966)", "Senegal (+221)", "Serbia (+381)", "Sierra Leone (+232)", "Singapore (+65)", "Slovakia (+421)", "Slovenia (+386)", "South Africa (+27)", "South Korea (+82)", "Spain (+34)", "Sri Lanka (+94)", "Sudan (+249)", "Swaziland (+268)", "Sweden (+46)", "Switzerland (+41)", "Syria (+963)", "Taiwan (+886)", "Tanzania (+255)", "Thailand (+66)", "Togo (+228)", "Trinidad and Tobago (+1868)", "Tunisia (+216)", "Turkey (+90)", "Uganda (+256)", "Ukraine (+380)", "United Arab Emirates (+971)", "United Kingdom (+44)", "United States (+1)", "Uruguay (+598)", "Uzbekistan (+998)", "Venezuela (+58)", "Vietnam (+84)", "Virgin, Islands (+1284)", "Yemen (+967)", "Zambia (+260)", "Zimbabwe (+263)"}
    Public VPaisosESP_2 As String() = New String(172) {"Afganistán", "Albania", "Alemania", "Algeria", "Andorra", "Angola", "Antigua & Barbuda", "Arabia Saudí", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaiyán", "Bahréin", "Bangladesh", "Barbados", "Bélgica", "Benin", "Bielorusia", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brasil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Centroafricana, Rep.", "Chad", "Chequia", "Chile", "China", "Chipre", "Colombia", "Congo", "Congo Rep.", "Corea del Sur", "Costa de Marfil", "Croacia", "Cuba", "Dinamarca", "Dominicana, Rep.", "Ecuador", "Egipto", "El Salvador", "Emiratos Arabes Unidos", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Feroe, Islas", "Filipinas", "Finlandia", "Fiyis, Islas", "Francia", "Gabón", "Gambia", "Gana", "Georgia", "Gibraltar", "Grecia", "Groenlandia", "Guadeloupe", "Guam", "Guatemala", "Guayana franc.", "Guernsey", "Haití", "Honduras", "Hong Kong", "Hungría", "India", "Indonesia", "Irán", "Irlanda", "Islandia", "Israel", "Italia", "Jamaica", "Japón", "Jersey", "Jordania", "Kazajstán", "Kenia", "Kirguizistán", "Kuwait", "Lesoto", "Letonia", "Líbano", "Liberia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas, Las", "Mali", "Malta", "Man, Isla de", "Marruecos", "Martinica", "Mauricio, Isla", "Mauritania", "Mexico", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Caledonia", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palestina", "Panama", "Paraguay", "Perú", "Polinesia", "Polonia", "Portugal", "Puerto Rico", "Qatar", "Reino Unido", "Reunión", "Ruanda", "Rumania", "Rusia", "Senegal", "Serbia", "Sierra Leona", "Singapur", "Siria", "Sri Lanka", "Sudáfrica", "Sudán", "Suecia", "Suiza", "Swazilandia", "Tailandia", "Taiwán", "Tanzania", "Togo", "Trinidad y Tobago", "Túnez", "Turquía", "Ucrania", "Uganda", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Vírgenes brit, Islas", "Yemen", "Zambia", "Zimbabue"}
    Public VPaisosESP_2_ID As String() = New String(172) {6, 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 166, 20, 21, 22, 23, 24, 25, 26, 27, 28, 32, 29, 30, 31, 33, 34, 44, 35, 36, 43, 37, 38, 167, 39, 40, 41, 42, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 61, 59, 58, 60, 62, 63, 65, 64, 66, 67, 68, 69, 70, 171, 72, 71, 173, 172, 73, 74, 76, 77, 78, 79, 75, 80, 81, 82, 83, 84, 85, 86, 87, 89, 88, 92, 90, 91, 93, 94, 95, 96, 97, 98, 99, 101, 100, 102, 103, 104, 105, 106, 107, 109, 108, 110, 111, 112, 113, 114, 115, 168, 116, 170, 119, 120, 121, 117, 118, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 138, 136, 137, 139, 140, 141, 142, 149, 144, 143, 145, 146, 148, 147, 152, 150, 151, 169, 153, 154, 155, 157, 156, 158, 159, 160, 161, 162, 163, 164, 165}
    Public VPaisosESP_2_Prefix As String() = New String(172) {"+93", "+355", "+49", "+213", "+376", "+244", "+1268", "+966", "+54", "+374", "+297", "+61", "+43", "+994", "+973", "+880", "+1246", "+32", "+229", "+375", "+591", "+387", "+267", "+55", "+673", "+359", "+226", "+257", "+975", "+238", "+855", "+237", "+1", "+236", "+235", "+420", "+56", "+86", "+357", "+57", "+242", "+243", "+82", "+225", "+385", "+53", "+45", "+1809", "+593", "+20", "+503", "+971", "+421", "+386", "+34", "+1", "+372", "+251", "+298", "+63", "+358", "+679", "+33", "+241", "+220", "+233", "+995", "+350", "+30", "+299", "+590", "+671", "+502", "+594", "+44", "+509", "+504", "+852", "+36", "+91", "+62", "+98", "+353", "+354", "+972", "+39", "+1876", "+81", "+44", "+962", "+7", "+254", "+996", "+965", "+266", "+371", "+961", "+231", "+423", "+370", "+352", "+853", "+389", "+261", "+60", "+265", "+960", "+223", "+356", "+44", "+212", "+596", "+230", "+222", "+52", "+373", "+377", "+976", "+381", "+258", "+264", "+977", "+505", "+227", "+234", "+47", "+687", "+64", "+968", "+31", "+92", "+970", "+507", "+595", "+51", "+689", "+48", "+351", "+1787", "+974", "+44", "+262", "+250", "+40", "+7", "+221", "+381", "+232", "+65", "+963", "+94", "+27", "+249", "+46", "+41", "+268", "+66", "+886", "+255", "+228", "+1868", "+216", "+90", "+380", "+256", "+598", "+998", "+58", "+84", "+1284", "+967", "+260", "+263"}
    Public VPaisosENG_2 As String() = New String(172) {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Benin", "Bhutan", "Bolivia", "Bosnia-Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African, Rep.", "Chad", "Chile", "China", "Colombia", "Congo", "Congo Rep.", "Croatia", "Cuba", "Cyprus", "Czech Rep.", "Denmark", "Dominican, Rep.", "Ecuador", "Egypt", "El Salvador", "Estonia", "Ethiopia", "Faroe, Islands", "Fiji, Islands", "Finland", "France", "French Guiana", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Guadeloupe", "Guam", "Guatemala", "Guernsey", "Haiti", "Honduras", "Hong Kong", "Hongary", "Iceland", "India", "Indonesia", "Iran", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jersey", "Jordania", "Kazakhstan", "Kenya", "Kuwait", "Kyrgyzstan", "Latvia", "Lebanon", "Lesotho", "Liberia", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Man, Isla de", "Martinique", "Mauritania", "Mauritius", "Mexico", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nepal", "Netherlands", "New Caledonia", "New Zeland", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palestine", "Panama", "Paraguay", "Peru", "Philippines", "Poland", "Polynesia, French", "Portugal", "Puerto Rico", "Qatar", "Réunion", "Romania", "Russia", "Rwanda", "Saudi Arabia", "Senegal", "Serbia", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "South Africa", "South Korea", "Spain", "Sri Lanka", "Sudan", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tanzania", "Thailand", "Togo", "Trinidad and Tobago", "Tunisia", "Turkey", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Virgin, Islands", "Yemen", "Zambia", "Zimbabwe"}
    Public VPaisosENG_2_ID As String() = New String(172) {6, 1, 3, 4, 5, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 166, 18, 19, 28, 20, 21, 22, 23, 24, 25, 26, 27, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 167, 41, 42, 43, 44, 45, 46, 47, 48, 49, 55, 56, 57, 58, 59, 60, 72, 62, 63, 64, 2, 65, 66, 67, 68, 69, 70, 171, 71, 173, 172, 73, 74, 75, 76, 77, 78, 79, 80, 81, 40, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 107, 108, 109, 110, 111, 112, 113, 114, 106, 115, 168, 116, 123, 117, 118, 170, 119, 120, 121, 122, 124, 125, 126, 127, 128, 61, 130, 129, 131, 132, 133, 135, 136, 137, 138, 8, 139, 140, 141, 142, 51, 52, 143, 39, 53, 144, 145, 147, 146, 148, 149, 150, 151, 152, 169, 153, 154, 155, 156, 157, 50, 134, 54, 158, 159, 160, 161, 162, 163, 164, 165}
    Public VPaisosENG_2_Prefix As String() = New String(172) {"+93", "+355", "+213", "+376", "+244", "+1268", "+54", "+374", "+297", "+61", "+43", "+994", "+973", "+880", "+1246", "+375", "+32", "+229", "+975", "+591", "+387", "+267", "+55", "+673", "+359", "+226", "+257", "+855", "+237", "+1", "+238", "+236", "+235", "+56", "+86", "+57", "+242", "+243", "+385", "+53", "+357", "+420", "+45", "+1809", "+593", "+20", "+503", "+372", "+251", "+298", "+679", "+358", "+33", "+594", "+241", "+220", "+995", "+49", "+233", "+350", "+30", "+299", "+590", "+671", "+502", "+44", "+509", "+504", "+852", "+36", "+354", "+91", "+62", "+98", "+353", "+972", "+39", "+225", "+1876", "+81", "+44", "+962", "+7", "+254", "+965", "+996", "+371", "+961", "+266", "+231", "+423", "+370", "+352", "+853", "+389", "+261", "+265", "+60", "+960", "+223", "+356", "+44", "+596", "+222", "+230", "+52", "+373", "+377", "+976", "+381", "+212", "+258", "+264", "+977", "+31", "+687", "+64", "+505", "+227", "+234", "+47", "+968", "+92", "+970", "+507", "+595", "+51", "+63", "+48", "+689", "+351", "+1787", "+974", "+262", "+40", "+7", "+250", "+966", "+221", "+381", "+232", "+65", "+421", "+386", "+27", "+82", "+34", "+94", "+249", "+268", "+46", "+41", "+963", "+886", "+255", "+66", "+228", "+1868", "+216", "+90", "+256", "+380", "+971", "+44", "+1", "+598", "+998", "+58", "+84", "+1284", "+967", "+260", "+263"}

    'Public Function TornaComboEvents(ByRef combo As DropDownList, ByVal NomCarpeta As String, Optional ByVal FiltremPerIDContacte As Integer = 0) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL() As String, i As Integer
    '    ReDim VectorSQL(0)
    '    If FiltremPerIDContacte = 0 Then
    '        VectorSQL(0) = "SELECT idFira, TitolImatgeQRWAP FROM EEPersonalitzacioFira WHERE (NomCarpeta = N'" & NomCarpeta & "') ORDER BY idFira DESC"
    '    Else
    '        VectorSQL(0) = "SELECT EEPersonalitzacioFira.idFira, EEPersonalitzacioFira.TitolImatgeQRWAP FROM EEPersonalitzacioFira INNER JOIN EEContactes ON EEPersonalitzacioFira.idFira = EEContactes.idFira WHERE (EEContactes.idContacte = " & FiltremPerIDContacte & ")"
    '    End If
    '    combo.Items.Clear()
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '        combo.Items.Add(New ListItem("SELECCIONAR EVENTO ...", -2))
    '        If DS.Tables(0).Rows.Count > 0 Then combo.Items.Add(New ListItem("------------------------------------", -1))
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            combo.Items.Add(New ListItem(DS.Tables(0).Rows(i).Item("TitolImatgeQRWAP"), DS.Tables(0).Rows(i).Item("idFira")))
    '        Next
    '        Return True
    '    End If
    'End Function

    'Public Function TornaComboInscrits(ByRef combo As DropDownList, ByVal IDFira As Integer, Optional ByVal IncloureAfegir As Boolean = False, Optional ByVal IncloureEmail As Boolean = False, Optional ByVal Filtre As String = "", Optional ByVal DeixarForaIDTipusContacte As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL() As String, i As Integer, Nom As String, Cognoms As String
    '    ReDim VectorSQL(0)
    '    VectorSQL(0) = "SELECT idContacte, Nom, Cognoms" & IIf(IncloureEmail, ", Email", "") & " FROM EEContactes WHERE (idFira = " & IDFira & IIf(DeixarForaIDTipusContacte, "", " AND idTipusContacte = 0") & " AND idContacte > 0" & IIf(IncloureEmail, " AND Email <> ''", "") & Filtre & ") ORDER BY Cognoms"
    '    combo.Items.Clear()
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        combo.Items.Add(New ListItem(IIf(IncloureAfegir, "NUEVA INSCRIPCIÓN", "SELECCIONAR INSCRITO ..."), -2))
    '        If DS.Tables(0).Rows.Count > 0 Then combo.Items.Add(New ListItem("------------------------------------", -1))
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            Nom = Trim(DS.Tables(0).Rows(i).Item("Nom"))
    '            Cognoms = Trim(DS.Tables(0).Rows(i).Item("Cognoms"))
    '            If Nom <> "" And Cognoms <> "" Then
    '                Cognoms += ", " & Nom
    '            ElseIf Nom <> "" And Cognoms = "" Then
    '                Cognoms = Nom
    '            End If
    '            If IncloureEmail Then
    '                combo.Items.Add(New ListItem(Cognoms & " (" & DS.Tables(0).Rows(i).Item("Email") & ")", DS.Tables(0).Rows(i).Item("idContacte")))
    '            Else
    '                combo.Items.Add(New ListItem(Cognoms, DS.Tables(0).Rows(i).Item("idContacte")))
    '            End If
    '        Next
    '        Return True
    '    End If
    'End Function

    'Public Function TornaTotalInscritsAmbEmail(ByVal IDFira As Integer, Optional ByVal FiltremPerEmail As Boolean = True) As Integer
    '    Try
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As New DataSet
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT COUNT(*) AS Quants FROM EEContactes WHERE (idFira = " & IDFira & " AND idTipusContacte = 0 AND idContacte > 0" & IIf(FiltremPerEmail, " AND Email <> ''", "") & ")"
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '            Return DS.Tables(0).Rows(0).Item("Quants")
    '        End If
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    'Public Function TornaUltim(ByVal IDFira As Integer, Optional ByVal Criteri As String = "", Optional ByVal EsBDMySQL As Boolean = False) As Integer
    '    Try
    '        Dim DS As New DataSet
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT " & IIf(Criteri <> "", Criteri, "MAX(ABS(idContacte))") & " AS MAXIM FROM EEContactes WHERE (idFira = " & IDFira & ")"
    '        If EsBDMySQL Then
    '            Dim clsBDMySQL As New ClasseMySQL
    '            If Not clsBDMySQL.BaseDades(1, VectorSQL, DS) Then Return 0
    '        Else
    '            Dim clsBD As New ClasseAccesBD
    '            If Not clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then Return 0
    '        End If
    '        If IsDBNull(DS.Tables(0).Rows(0).Item("MAXIM")) Then
    '            Return 1
    '        Else
    '            Return IIf(DS.Tables(0).Rows(0).Item("MAXIM") < 0, 0, DS.Tables(0).Rows(0).Item("MAXIM")) + 1
    '        End If
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    'Public Function VerificaSiExisteixEmail(ByVal IDFira As Integer, ByVal Email As String, ByVal IDContacte As String, Optional ByRef MiremATaulaExtra1 As Boolean = False, Optional ByRef Password As String = "", Optional ByRef NIT As String = "", Optional ByRef IDContacteOriginal As Integer = -1, Optional ByRef IDEventwo As String = "", Optional ByVal MiremIDTipusContacte As Boolean = False, Optional ByVal FiltremPerSubEvent As Integer = -1, Optional ByRef FiquemCondicioExtra As String = "", Optional ByRef LlistatIDTipusContacte As String = "") As Boolean
    '    Try
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As DataSet
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT Email FROM EEContactes WHERE idFira = " & IDFira & " AND Email = '" & clsBD.Cometes(Email) & "' AND idContacte <> " & IDContacte & IIf(MiremIDTipusContacte, IIf(LlistatIDTipusContacte <> "", " AND idTipusContacte IN (" & LlistatIDTipusContacte & ")", " AND idTipusContacte = 0"), "") & IIf(FiltremPerSubEvent > -1, " AND idAlta = " & FiltremPerSubEvent, "") & IIf(FiquemCondicioExtra <> "", FiquemCondicioExtra, "")
    '        DS = New DataSet
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '            If DS.Tables(0).Rows.Count > 0 Then
    '                If MiremATaulaExtra1 Then MiremATaulaExtra1 = False
    '                Return True
    '            Else
    '                If MiremATaulaExtra1 Then
    '                    MiremATaulaExtra1 = False
    '                    VectorSQL(0) = "SELECT Camp2 AS Password, Camp3 AS NIT, Camp4, Camp5 FROM EETaulaExtra1 WHERE (idFira = " & IDFira & " AND Camp1 = '" & clsBD.Cometes(Email) & "')"
    '                    DS = New DataSet
    '                    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '                        If DS.Tables(0).Rows.Count > 0 Then
    '                            MiremATaulaExtra1 = True
    '                            Password = DS.Tables(0).Rows(0).Item("Password")
    '                            NIT = DS.Tables(0).Rows(0).Item("NIT")
    '                            If IDContacteOriginal = 0 Then IDContacteOriginal = DS.Tables(0).Rows(0).Item("Camp4")
    '                            If IDEventwo <> "" Then IDEventwo = DS.Tables(0).Rows(0).Item("Camp5")
    '                            Return True
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '        If MiremATaulaExtra1 Then MiremATaulaExtra1 = False
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    'Public Function VerificaSiExisteixEmail_MySQL(ByVal IDFira As Integer, ByVal Email As String, ByVal IDContacte As String) As Boolean
    '    Try
    '        Dim clsBD As New ClasseMySQL
    '        Dim DS As New DataSet
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT Email FROM EEContactes WHERE idFira = " & IDFira & " AND Email = '" & clsBD.Cometes(Email) & "' AND idContacte <> " & IDContacte & " AND idTipusContacte = 0"
    '        If clsBD.BaseDades(1, VectorSQL, DS) Then
    '            Return DS.Tables(0).Rows.Count > 0
    '        End If
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    'Public Function CercaEmpleats(ByVal IDFira As Integer, ByVal Criteri As String, ByRef combo As DropDownList, Optional ByVal FiltraSenseAssistencia As Boolean = False) As Integer
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL(0) As String
    '    Dim Dades As String, i As Integer
    '    combo.Items.Clear()
    '    Dades = clsBD.Cometes(Trim(Criteri).ToLower.Replace("á", "a").Replace("à", "a").Replace("ä", "a").Replace("a", "[a-á-à-ä]").Replace("é", "e").Replace("è", "e").Replace("ë", "e").Replace("e", "[e-é-è-ë]").Replace("í", "i").Replace("ï", "i").Replace("i", "[i-í-ï]").Replace("ó", "o").Replace("ò", "o").Replace("ö", "o").Replace("o", "[o-ó-ò-ö]").Replace("ú", "u").Replace("ü", "u").Replace("u", "[u-ú-ü]"))
    '    If FiltraSenseAssistencia Then
    '        Dim Llistat As String = ""
    '        TornaParticipantsQueHanAssistit(IDFira, , Llistat)
    '        VectorSQL(0) = "SELECT idContacte, Nom, Cognoms FROM EEContactes WHERE idFira = " & IDFira & " AND idTipusContacte = 0 AND NIT <> '' AND idContacte > 0 " & IIf(Llistat <> "", "AND idContacte NOT IN(" & Llistat & ") ", "") & "AND Cognoms LIKE N'%" & Dades & "%' ORDER BY Cognoms"
    '    Else
    '        VectorSQL(0) = "SELECT idContacte, Nom, Cognoms FROM EEContactes WHERE idFira = " & IDFira & " AND idTipusContacte = 0 AND idContacte > 0 AND Cognoms LIKE N'%" & Dades & "%' ORDER BY Cognoms"
    '    End If
    '    If Not clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        Return -1
    '    ElseIf DS.Tables(0).Rows.Count = 0 Then
    '        Return 0
    '    Else
    '        If DS.Tables(0).Rows.Count > 1 Then
    '            combo.Items.Add(New ListItem("Listado de coincidencias ...", -2))
    '            combo.Items.Add(New ListItem("------------------------------------", -1))
    '        End If
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            combo.Items.Add(New ListItem(Trim(DS.Tables(0).Rows(i).Item("Cognoms")) & ", " & Trim(DS.Tables(0).Rows(i).Item("Nom")), DS.Tables(0).Rows(i).Item("idContacte")))
    '        Next
    '        Return 1
    '    End If
    'End Function

    'Public Function TornaParticipantsQueHanAssistit(ByVal IDFira As Integer, Optional ByRef HTIDContactes As Hashtable = Nothing, Optional ByRef Llistat As String = "-", Optional ByVal IncloureTotsDies As Boolean = False, Optional ByVal IncloureNIT As Boolean = False, Optional ByVal EsMySQL As Boolean = False, Optional ByVal FiltrarPerHui As Boolean = False, Optional ByRef HTDataMinuts As Hashtable = Nothing, Optional ByVal IDSubevent As Integer = -1) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL(0) As String, i As Integer, SBCadena As New System.Text.StringBuilder
    '    Dim Taula As DataTable, Fila As DataRow
    '    Dim j As Integer, k As Integer, Posicio As Integer = 0, HTNITs As New Hashtable, Hui As String, Fiquem As Boolean
    '    Dim DS2 As New DataSet
    '    Taula = New DataTable("Dades")
    '    Taula.Columns.Add("idContacte")
    '    If IncloureTotsDies Then Taula.Columns.Add("Data")
    '    If IncloureNIT Then Taula.Columns.Add("NIT")
    '    If Not IsNothing(HTDataMinuts) Then Taula.Columns.Add("DataMinuts")
    '    DS.Tables.Add(Taula)
    '    If FiltrarPerHui Then Hui = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#")
    '    VectorSQL(0) = "SELECT DISTINCT NIT" & IIf(IncloureTotsDies, ", LEFT(DataHora, 8) AS Data", "") & IIf(Not IsNothing(HTDataMinuts), ", LEFT(DataHora, 12) AS DataMinuts", "") & " FROM EEIdentificacioAcces WHERE (idFira = " & IDFira & ") AND (NIT <> '') AND (Validacio = " & IIf(IDSubevent > -1, IDSubevent, "1") & ")" & IIf(FiltrarPerHui, " AND (DataHora LIKE '" & Hui & "%')", "") & IIf(Not IsNothing(HTDataMinuts), " ORDER BY NIT, DataMinuts", "")
    '    If EsMySQL Then
    '        Dim clsBDMySQL As New ClasseMySQL
    '        If Not clsBDMySQL.BaseDades(1, VectorSQL, DS2) Then Return False
    '    Else
    '        If Not clsBD.BaseDades(1, VectorSQL, DS2, 3, IDFira) Then Return False
    '    End If
    '    If DS2.Tables(0).Rows.Count = 0 Then Return True
    '    For i = 0 To DS2.Tables(0).Rows.Count - 1
    '        If Not HTNITs.ContainsKey(DS2.Tables(0).Rows(i).Item("NIT")) Then
    '            SBCadena.Append("'" & DS2.Tables(0).Rows(i).Item("NIT") & "',")
    '            HTNITs.Add(DS2.Tables(0).Rows(i).Item("NIT"), i + 1)
    '        End If
    '    Next
    '    SBCadena.Length -= 1
    '    Dim DS3 As New DataSet
    '    VectorSQL(0) = "SELECT DISTINCT idContacte, NIT FROM EEContactes WHERE idFira = " & IDFira & " AND NIT IN (" & SBCadena.ToString & ") ORDER BY idContacte"
    '    If EsMySQL Then
    '        Dim clsBDMySQL As New ClasseMySQL
    '        If Not clsBDMySQL.BaseDades(1, VectorSQL, DS3) Then Return False
    '    Else
    '        If Not clsBD.BaseDades(1, VectorSQL, DS3, 3, IDFira) Then Return False
    '    End If
    '    For i = 0 To DS3.Tables(0).Rows.Count - 1
    '        For j = 0 To DS2.Tables(0).Rows.Count - 1
    '            If DS2.Tables(0).Rows(j).Item("NIT") = DS3.Tables(0).Rows(i).Item("NIT") Then
    '                Fila = DS.Tables(0).NewRow
    '                Fila(0) = DS3.Tables(0).Rows(i).Item("idContacte")
    '                If IncloureTotsDies Then Fila(1) = DS2.Tables(0).Rows(j).Item("Data")
    '                If IncloureNIT Then Fila(1) = DS2.Tables(0).Rows(j).Item("NIT")
    '                If Not IsNothing(HTDataMinuts) Then Fila(Taula.Columns.Count - 1) = DS2.Tables(0).Rows(j).Item("DataMinuts")
    '                DS.Tables(0).Rows.Add(Fila)
    '            End If
    '        Next
    '    Next
    '    For i = 0 To DS.Tables(0).Rows.Count - 1
    '        If Not IsNothing(HTIDContactes) Then
    '            If IncloureTotsDies Then
    '                If Not HTIDContactes.ContainsKey("_" & DS.Tables(0).Rows(i).Item("idContacte") & "_" & DS.Tables(0).Rows(i).Item("Data")) Then
    '                    HTIDContactes.Add("_" & DS.Tables(0).Rows(i).Item("idContacte") & "_" & DS.Tables(0).Rows(i).Item("Data"), i + 1)
    '                    Fiquem = True
    '                End If
    '            Else
    '                If IncloureNIT Then
    '                    If Not HTIDContactes.ContainsKey(DS.Tables(0).Rows(i).Item("idContacte") & "_" & DS.Tables(0).Rows(i).Item("NIT")) Then
    '                        HTIDContactes.Add(DS.Tables(0).Rows(i).Item("idContacte") & "_" & DS.Tables(0).Rows(i).Item("NIT"), i + 1)
    '                        Fiquem = True
    '                    End If
    '                Else
    '                    If IsNothing(HTDataMinuts) Then
    '                        HTIDContactes.Add(CInt(DS.Tables(0).Rows(i).Item("idContacte")), i + 1)
    '                    Else
    '                        If Not HTIDContactes.ContainsKey(CInt(DS.Tables(0).Rows(i).Item("idContacte"))) Then
    '                            HTIDContactes.Add(CInt(DS.Tables(0).Rows(i).Item("idContacte")), i + 1)
    '                            Fiquem = True
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '        If Fiquem And Not IsNothing(HTDataMinuts) Then
    '            HTDataMinuts.Add(i + 1, DS.Tables(0).Rows(i).Item("DataMinuts"))
    '        End If
    '        If Llistat <> "-" Then Llistat += DS.Tables(0).Rows(i).Item("idContacte") & ","
    '        Fiquem = False
    '    Next
    '    If Llistat <> "-" And Llistat <> "" Then Llistat = Left(Llistat, Len(Llistat) - 1)
    '    Return True
    'End Function

    'Public Function TornaParticipantsQueHanAssistit(ByVal IDFira As Integer, Optional ByRef HTIDContactes As Hashtable = Nothing, Optional ByRef Llistat As String = "-", Optional ByVal IncloureTotsDies As Boolean = False, Optional ByVal IncloureNIT As Boolean = False, Optional ByVal EsMySQL As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As DataSet
    '    Dim VectorSQL(0) As String, i As Integer, SBCadena As New System.Text.StringBuilder
    '    VectorSQL(0) = "SELECT DISTINCT EEContactes.idContacte" & IIf(IncloureTotsDies, ", LEFT(EEIdentificacioAcces.DataHora, 8) AS Data", "") & IIf(IncloureNIT, ", EEContactes.NIT", "") & " FROM EEIdentificacioAcces INNER JOIN EEContactes ON EEIdentificacioAcces.idFira = EEContactes.idFira AND EEIdentificacioAcces.NIT = EEContactes.NIT WHERE (EEIdentificacioAcces.idFira = " & IDFira & ") AND (EEIdentificacioAcces.NIT <> '') ORDER BY EEContactes.idContacte"
    '    DS = New DataSet
    '    If EsMySQL Then
    '        Dim clsBDMySQL As New ClasseMySQL
    '        If Not clsBDMySQL.BaseDades(1, VectorSQL, DS) Then Return False
    '    Else
    '        If Not clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then Return False
    '    End If
    '    If DS.Tables(0).Rows.Count = 0 Then Return True
    '    For i = 0 To DS.Tables(0).Rows.Count - 1
    '        If Not IsNothing(HTIDContactes) Then
    '            If IncloureTotsDies Then
    '                HTIDContactes.Add("_" & DS.Tables(0).Rows(i).Item("idContacte") & "_" & DS.Tables(0).Rows(i).Item("Data"), i + 1)
    '            Else
    '                If IncloureNIT Then
    '                    HTIDContactes.Add(DS.Tables(0).Rows(i).Item("idContacte") & "_" & DS.Tables(0).Rows(i).Item("NIT"), i + 1)
    '                Else
    '                    HTIDContactes.Add(DS.Tables(0).Rows(i).Item("idContacte"), i + 1)
    '                End If
    '            End If
    '        End If
    '        If Llistat <> "-" Then Llistat += DS.Tables(0).Rows(i).Item("idContacte") & ","
    '    Next
    '    If Llistat <> "-" Then Llistat += Left(Llistat, Len(Llistat) - 1)
    '    Return True
    'End Function

    'Public Function TornaParticipantsQueHanAssistit_2Consultes(ByVal IDFira As Integer, Optional ByRef HTIDContactes As Hashtable = Nothing, Optional ByRef Llistat As String = "-", Optional ByVal IncloureNIT As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As DataSet
    '    Dim VectorSQL(0) As String, i As Integer, SBNITs As New StringBuilder
    '    VectorSQL(0) = "SELECT DISTINCT NIT FROM EEIdentificacioAcces WHERE (idFira = " & IDFira & ") AND (NIT <> '') AND (Validacio = 1)"
    '    DS = New DataSet
    '    If Not clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then Return False
    '    If DS.Tables(0).Rows.Count = 0 Then Return True
    '    For i = 0 To DS.Tables(0).Rows.Count - 1
    '        SBNITs.Append("'" & DS.Tables(0).Rows(i).Item("NIT") & "',")
    '    Next
    '    SBNITs.Length -= 1
    '    VectorSQL(0) = "SELECT idContacte" & IIf(IncloureNIT, ", NIT", "") & " FROM EEContactes WHERE (idFira = " & IDFira & ") AND (NIT IN (" & SBNITs.ToString & ")) ORDER BY idContacte"
    '    DS = New DataSet
    '    If Not clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then Return False
    '    If DS.Tables(0).Rows.Count = 0 Then Return True
    '    For i = 0 To DS.Tables(0).Rows.Count - 1
    '        If Not IsNothing(HTIDContactes) Then
    '            If IncloureNIT Then
    '                HTIDContactes.Add(DS.Tables(0).Rows(i).Item("idContacte") & "_" & DS.Tables(0).Rows(i).Item("NIT"), i + 1)
    '            Else
    '                HTIDContactes.Add(DS.Tables(0).Rows(i).Item("idContacte"), i + 1)
    '            End If
    '        End If
    '        If Llistat <> "-" Then Llistat += DS.Tables(0).Rows(i).Item("idContacte") & ","
    '    Next
    '    If Llistat <> "-" Then Llistat += Left(Llistat, Len(Llistat) - 1)
    '    Return True
    'End Function

    'Public Function TornaParticipantsQueHanAssistitSegonsSala(ByVal IDFira As Integer, ByVal LlistatControladors As String, Optional ByRef HTIDContactes As Hashtable = Nothing, Optional ByRef TornaTotal As Integer = -1, Optional ByVal Criteri As String = "", Optional ByRef combo As DropDownList = Nothing, Optional ByVal IncloureHoraLectura As Boolean = False, Optional ByVal ApliquemDiferenciaHoraria As Integer = 0, Optional ByVal MiremNomesHui As Boolean = False, Optional ByVal FiltremPerDia As Date = Nothing, Optional ByVal VolemFiltrarPerDia As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As DataSet
    '    Dim VectorSQL(0) As String, i As Integer, Llistat As String = "", dtData As Date
    '    dtData = Now
    '    If VolemFiltrarPerDia And Not IsNothing(FiltremPerDia) Then dtData = FiltremPerDia
    '    If ApliquemDiferenciaHoraria <> 0 Then
    '        dtData = DateAdd(DateInterval.Minute, ApliquemDiferenciaHoraria, dtData)
    '    End If
    '    VectorSQL(0) = "SELECT DISTINCT NIT FROM EEIdentificacioAcces WHERE (idFira = " & IDFira & ") AND (idContacte IN (" & LlistatControladors & "))" & IIf(MiremNomesHui, " AND (DataHora LIKE '" & Year(dtData) & Format(Month(dtData), "0#") & Format(Day(dtData), "0#") & "%')", "")
    '    DS = New DataSet
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        If TornaTotal >= 0 Then
    '            TornaTotal = DS.Tables(0).Rows.Count
    '            Return True
    '        ElseIf DS.Tables(0).Rows.Count = 0 Then
    '            Return True
    '        End If
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            Llistat += "'" & DS.Tables(0).Rows(i).Item("NIT") & "',"
    '        Next
    '        VectorSQL(0) = "SELECT " & IIf(Criteri <> "", Criteri, "idContacte") & " FROM EEContactes WHERE (idFira = " & IDFira & ") AND (NIT IN (" & Left(Llistat, Len(Llistat) - 1) & "))"
    '        DS = New DataSet
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '            For i = 0 To DS.Tables(0).Rows.Count - 1
    '                If Criteri <> "" Then
    '                    combo.Items.Add(New ListItem(Trim(DS.Tables(0).Rows(i).Item(Criteri)), i + 1))
    '                Else
    '                    If Not IsNothing(HTIDContactes) Then HTIDContactes.Add(DS.Tables(0).Rows(i).Item("idContacte"), i + 1)
    '                End If
    '            Next
    '            Return True
    '        End If
    '    End If
    'End Function

    'Public Function TornaParticipantsQueHanVisitatExpositor(ByVal IDFira As Integer, ByVal NIT As String, ByVal NomCamp As String, ByRef combo As DropDownList) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As DataSet
    '    Dim VectorSQL(0) As String, i As Integer, Llistat As String = ""
    '    VectorSQL(0) = "SELECT idContacte, " & NomCamp & " FROM EEContactes WHERE (idFira = " & IDFira & ") AND (idContacte IN (SELECT DISTINCT idContacte FROM EEIdentificacioAcces WHERE (idFira = " & IDFira & ") AND (NIT = N'" & clsBD.Cometes(NIT) & "'))) AND (idTipusContacte = 0) ORDER BY " & NomCamp
    '    DS = New DataSet
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            combo.Items.Add(New ListItem(Trim(DS.Tables(0).Rows(i).Item(NomCamp)), DS.Tables(0).Rows(i).Item("idContacte")))
    '        Next
    '        Return True
    '    End If
    'End Function

    'Public Function TornaParticipantsSegonsSala(ByVal IDFira As Integer, ByVal IDSala As Integer, Optional ByRef HTIDContactes As Hashtable = Nothing) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL(0) As String, i As Integer, Llistat As String = ""
    '    VectorSQL(0) = "SELECT EEContactes.idContacte " &
    '                    "FROM EEAppControlCodisSala INNER JOIN EEContactes ON EEAppControlCodisSala.idFira = EEContactes.idFira AND EEAppControlCodisSala.NIT = EEContactes.NIT " &
    '                    "WHERE (EEAppControlCodisSala.idFira = " & IDFira & ") AND (EEAppControlCodisSala.idSala = " & IDSala & ")"
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        If DS.Tables(0).Rows.Count = 0 Then Return True
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            If Not IsNothing(HTIDContactes) Then HTIDContactes.Add(DS.Tables(0).Rows(i).Item("idContacte"), i + 1)
    '        Next
    '        Return True
    '    End If
    'End Function

    'Public Function TornaAforament(ByVal IDFira As Integer, Optional ByVal MiremNomesHui As Boolean = True, Optional ByVal ApliquemDiferenciaHoraria As Integer = 0, Optional ByVal LlistatNITs As String = "", Optional ByVal ApliquemIDSubevent As Integer = -1) As Integer
    '    Dim i As Integer, Entrades As Integer = 0, dtData As Date
    '    Dim VectorSQL(0) As String
    '    Dim DS As New DataSet
    '    Dim clsBD As New ClasseAccesBD
    '    dtData = Now
    '    If ApliquemDiferenciaHoraria <> 0 Then
    '        dtData = DateAdd(DateInterval.Minute, ApliquemDiferenciaHoraria, dtData)
    '    End If
    '    VectorSQL(0) = "SELECT COUNT(DISTINCT NIT) AS Quants FROM EEIdentificacioAcces WHERE (idFira IN (" & IDFira & ")) AND (Validacio = " & IIf(ApliquemIDSubevent > 0, ApliquemIDSubevent, 1) & ")" & IIf(MiremNomesHui, " AND (DataHora LIKE '" & Year(dtData) & Format(Month(dtData), "0#") & Format(Day(dtData), "0#") & "%')", "") & IIf(LlistatNITs <> "", " AND NIT IN(" & LlistatNITs & ")", "")
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        Return DS.Tables(0).Rows(0).Item("Quants")
    '    End If
    'End Function

    'Public Function TornaIDControlador(ByVal IDFira As Integer, ByVal EsOnline As Boolean) As Integer
    '    Try
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As New DataSet
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT idContacte FROM EEContactes WHERE (idFira = " & IDFira & ") AND (idTipusContacte = 40) AND (idOrigen = " & IIf(EsOnline, "3", "1") & ") ORDER BY idContacte"
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3) Then
    '            If DS.Tables(0).Rows.Count > 0 Then
    '                Return DS.Tables(0).Rows(0).Item("idContacte")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    'Public Function VerificaSiCanviPassword(ByVal IDFira As Integer, ByVal IDContacte As Integer, ByVal Password As String) As Boolean
    '    Try
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As New DataSet
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT Password FROM EEContactes WHERE (idFira = " & IDFira & " AND idContacte = " & IDContacte & ")"
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '            Return Password = DS.Tables(0).Rows(0).Item("Password")
    '        End If
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    'Public Function TornaLlistatNITsTaulaExtra1(ByVal IDFira As Integer) As String
    '    Try
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As New DataSet
    '        Dim VectorSQL(0) As String, i As Integer, Llistat As String = ""
    '        VectorSQL(0) = "SELECT Camp3 AS NIT FROM EETaulaExtra1 WHERE (idFira = " & IDFira & ")"
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '            If DS.Tables(0).Rows.Count > 0 Then
    '                For i = 0 To DS.Tables(0).Rows.Count - 1
    '                    Llistat += "'" & DS.Tables(0).Rows(i).Item("NIT") & "',"
    '                Next
    '                Return Left(Llistat, Len(Llistat) - 1)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    Public Function TornaContingutMailingAcabat(Optional ByVal NomesUn As Boolean = False) As String
        Dim HTML As String
        HTML = "<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.0 Transitional//EN'><html><head><meta http-equiv='Content-Type' content='text/html; charset=windows-1252'></head>"
        HTML += "<body><p style='color:#222222;font-family:Arial;font-size:13px'>Este es un email automático enviado para comunicar que se ha completado el mailing satisfactoriamente.<br><br>Los datos son los siguientes:<br><br><b>- Emails enviados:</b> " & IIf(NomesUn, "1", "#CORRECTES#") & "<br><b>- Emails no enviados:</b> " & IIf(NomesUn, "0", "#INCORRECTES#")
        HTML += "<br><br>Equipo de Entrada Electrónica</p></body></html>"
        Return HTML
    End Function

    Public Function VerificaEMAIL(ByVal Email As String) As Boolean
        Try
            Return System.Text.RegularExpressions.Regex.IsMatch(Email, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Catch ex As Exception
            '
        End Try
    End Function

    'Public Function TornaDadesSMTP(ByVal IDFira As Integer, ByRef Servidor As String, ByRef Usuari As String, ByRef Password As String, Optional ByRef Port As Integer = -1, Optional ByRef ConnexioTLS As Integer = -1, Optional ByVal EsMySQL As Boolean = False) As Boolean
    '    Try
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As New DataSet
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT ServidorSMTP, UsuariSMTP, PasswordSMTP, PortSMTP, ConnexioTLS FROM EEClientsSMTP WHERE (idFira = " & IDFira & ")"
    '        If EsMySQL Then
    '            Dim clsBDMySQL As New ClasseMySQL
    '            If Not clsBDMySQL.BaseDades(1, VectorSQL, DS, 3) Then Return False
    '        Else
    '            If Not clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then Return False
    '        End If
    '        If DS.Tables(0).Rows.Count > 0 Then
    '            Servidor = DS.Tables(0).Rows(0).Item("ServidorSMTP")
    '            Usuari = DS.Tables(0).Rows(0).Item("UsuariSMTP")
    '            Password = DS.Tables(0).Rows(0).Item("PasswordSMTP")
    '            If Port > -1 Then Port = DS.Tables(0).Rows(0).Item("PortSMTP")
    '            If ConnexioTLS > -1 Then ConnexioTLS = DS.Tables(0).Rows(0).Item("ConnexioTLS")
    '        Else
    '            Servidor = "EntradaElectronica"
    '            If Port > -1 Then Port = 25
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    Public Function TornaMissatgeModal(ByVal Contingut As String, Optional ByVal Idioma As Integer = 0) As String
        Dim Capçalera As String, Acceptar As String
        Select Case Idioma
            Case 1
                Capçalera = "Attention"
                Acceptar = "Accept"
            Case 2
                Capçalera = "Beachtung"
                Acceptar = "Akzeptieren"
            Case 3
                Capçalera = "Attention"
                Acceptar = "Accepter"
            Case Else
                Capçalera = "Atención"
                Acceptar = "Aceptar"
        End Select
        Return "<div class='modal-content'><div class='header'>" & Capçalera & "</div>" &
                 "<div class='copy'>" & Contingut & "</div><div class='cf footer'>" &
                 "<a href='#' onclick=" & Chr(34) & "document.getElementById('DIVContingutMissatge').innerHTML='';document.getElementById('DIVContingutMissatge').className='mmodalno'" & Chr(34) & " class='btn2'>" & Acceptar & "</a>" &
                 "</div></div><div class='overlay'></div>"
    End Function

    Public Sub PlenaComboMesos(ByVal combo As HtmlSelect, ByVal Idioma As Integer, Optional ByVal FicaZerosAlValor As Boolean = False)
        Dim i As Integer, Zero As String = ""
        For i = 1 To 12
            If FicaZerosAlValor Then Zero = IIf(Len(CStr(i)) = 1, "0", "")
            combo.Items.Add(New ListItem(TornaMesSegonsNumero(Idioma, i), Zero & i))
        Next
    End Sub

    Public Function TornaMesSegonsNumero(ByVal IDIdioma As Integer, ByVal IDMes As Integer) As String
        If IDIdioma = 1 Then
            Select Case IDMes
                Case 1
                    Return "Enero"
                Case 2
                    Return "Febrero"
                Case 3
                    Return "Marzo"
                Case 4
                    Return "Abril"
                Case 5
                    Return "Mayo"
                Case 6
                    Return "Junio"
                Case 7
                    Return "Julio"
                Case 8
                    Return "Agosto"
                Case 9
                    Return "Septiembre"
                Case 10
                    Return "Octubre"
                Case 11
                    Return "Noviembre"
                Case 12
                    Return "Diciembre"
            End Select
        ElseIf IDIdioma = 2 Then
            Select Case IDMes
                Case 1
                    Return "January"
                Case 2
                    Return "February"
                Case 3
                    Return "March"
                Case 4
                    Return "April"
                Case 5
                    Return "May"
                Case 6
                    Return "June"
                Case 7
                    Return "July"
                Case 8
                    Return "August"
                Case 9
                    Return "September"
                Case 10
                    Return "October"
                Case 11
                    Return "November"
                Case 12
                    Return "December"
            End Select
        End If
    End Function

    'Public Function DescarregaImatgeDesDeURL(ByVal URL As String, Optional ByRef TornaExit As Boolean = False) As Byte()
    '    Dim downloadedData As Byte() = New Byte(0) {}
    '    Try
    '        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(URL)
    '        Dim response As System.Net.WebResponse = req.GetResponse()
    '        Dim stream As System.IO.Stream = response.GetResponseStream()
    '        Dim Buffer As Byte() = New Byte(1023) {}
    '        Dim dataLength As Integer = response.ContentLength
    '        Dim memStream As System.IO.MemoryStream = New System.IO.MemoryStream()
    '        While True
    '            Dim bytesRead As Integer = stream.Read(Buffer, 0, Buffer.Length)
    '            If bytesRead = 0 Then
    '                Exit While
    '            Else
    '                memStream.Write(Buffer, 0, bytesRead)
    '            End If
    '        End While
    '        downloadedData = memStream.ToArray()
    '        stream.Close()
    '        memStream.Close()
    '    Catch ex As Exception
    '        If TornaExit Then TornaExit = False
    '        Dim clsBD As New ClasseAccesBD
    '        Dim Data As String = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,MissatgeSistema,Info1,Info2,Data) VALUES(100,'','','Problema executant DescarregaImatgeDesDeURL, URL: " & URL & ", Ex: " & clsBD.Cometes(ex.Message) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Try
    '    Return downloadedData
    'End Function

    'Public Function GeneraNovaImatgeMenysPesada(ByRef VImatge() As Byte, ByVal Qualitat As Integer) As Boolean
    '    Try
    '        Dim MS As New System.IO.MemoryStream
    '        Dim source As New Bitmap(New System.IO.MemoryStream(VImatge))
    '        Dim target As New Bitmap(source.Width, source.Height)
    '        Dim g As Graphics = Graphics.FromImage(target)
    '        Dim e As System.Drawing.Imaging.EncoderParameters
    '        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed
    '        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low
    '        Dim recCompression As New Rectangle(0, 0, source.Width, source.Height)
    '        g.DrawImage(source, recCompression)
    '        e = New System.Drawing.Imaging.EncoderParameters(2)
    '        e.Param(0) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, Qualitat)
    '        e.Param(1) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Compression, System.Drawing.Imaging.EncoderValue.CompressionLZW)
    '        target.Save(MS, GetEncoderInfo("image/jpeg"), e)
    '        g.Dispose()
    '        MS.Dispose()
    '        target.Dispose()
    '        VImatge = DirectCast(MS, System.IO.MemoryStream).ToArray()
    '        Return True
    '    Catch ex As Exception
    '        Dim clsBD As New ClasseAccesBD
    '        Dim VectorSQL(0) As String
    '        Dim Data As String = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema omplint GeneraNovaImatgeMenysPesada de la ClasseApp. Problema: " & clsBD.Cometes(ex.Message) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Try
    'End Function

    'Public Function GeneraNovaImatge(ByVal CamiInicial As String, ByVal CamiFinal As String, ByVal Qualitat As Integer) As Boolean
    '    Try
    '        Dim source As New Bitmap(CamiInicial)
    '        Dim target As New Bitmap(source.Width, source.Height)
    '        Dim g As Graphics = Graphics.FromImage(target)
    '        Dim e As System.Drawing.Imaging.EncoderParameters
    '        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed
    '        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low
    '        Dim recCompression As New Rectangle(0, 0, source.Width, source.Height)
    '        g.DrawImage(source, recCompression)
    '        e = New System.Drawing.Imaging.EncoderParameters(2)
    '        e.Param(0) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, Qualitat)
    '        e.Param(1) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Compression, System.Drawing.Imaging.EncoderValue.CompressionLZW)
    '        target.Save(CamiFinal, GetEncoderInfo(IIf(Right(LCase(CamiInicial), 3) = "jpg", "image/jpeg", IIf(Right(LCase(CamiInicial), 3) = "bmp", "image/bmp", IIf(Right(LCase(CamiInicial), 3) = "gif", "image/gif", "image/png")))), e)
    '        g.Dispose()
    '        target.Dispose()
    '        'Dim bitmap As Bitmap = DirectCast(System.Drawing.Image.FromFile(CamiInicial), Bitmap)
    '        'Dim newBitmap As New Bitmap(bitmap)
    '        'Dim Quin As System.Drawing.Imaging.ImageFormat = IIf(Right(LCase(CamiInicial), 3) = "jpg", System.Drawing.Imaging.ImageFormat.Jpeg, IIf(Right(LCase(CamiInicial), 3) = "bmp", System.Drawing.Imaging.ImageFormat.Bmp, IIf(Right(LCase(CamiInicial), 3) = "gif", System.Drawing.Imaging.ImageFormat.Gif, System.Drawing.Imaging.ImageFormat.Png)))
    '        'newBitmap.SetResolution(Qualitat, Qualitat)
    '        'newBitmap.Save(CamiFinal, IIf(Right(LCase(CamiInicial), 3) = "jpg", System.Drawing.Imaging.ImageFormat.Jpeg, IIf(Right(LCase(CamiInicial), 3) = "bmp", System.Drawing.Imaging.ImageFormat.Bmp, IIf(Right(LCase(CamiInicial), 3) = "gif", System.Drawing.Imaging.ImageFormat.Gif, System.Drawing.Imaging.ImageFormat.Png))))
    '        Return True
    '    Catch ex As Exception
    '        Dim clsBD As New ClasseAccesBD
    '        Dim VectorSQL(0) As String, Data As String
    '        Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema omplint GeneraImatgePetita de la ClasseRPA. Problema: " & clsBD.Cometes(ex.Message) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Try
    'End Function

    Public Shared Function GetEncoderInfo(ByVal sMime As String) As System.Drawing.Imaging.ImageCodecInfo
        Dim objEncoders As System.Drawing.Imaging.ImageCodecInfo()
        objEncoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        For iLoop As Integer = 0 To (objEncoders.Length - 1)
            If objEncoders(iLoop).MimeType = sMime Then
                Return objEncoders(iLoop)
            End If
        Next
        Return Nothing
    End Function

    Public Function TornaDataCorrecta(ByVal Data As String, ByVal MiremHui As Boolean, ByRef DataBona As String, Optional ByVal MiremHoraMinuts As Boolean = False, Optional ByVal MiremAny4Xifres As Boolean = False, Optional ByVal MinutsMultiples5 As Boolean = True, Optional ByVal MiremPosteriorAHui As Boolean = False) As Integer
        Dim VData() As String, HoraMinuts As String, Hores As String, Minuts As String
        If MiremHoraMinuts Then
            If InStr(Data, " ") = 0 Then Return 1
            HoraMinuts = Trim(Right(Data, Len(Data) - InStr(Data, " ")))
            Data = Trim(Left(Data, InStr(Data, " ") - 1))
            If InStr(HoraMinuts, ":") = 0 Then Return 1
            Hores = Trim(Left(HoraMinuts, InStr(HoraMinuts, ":") - 1))
            Minuts = Trim(Right(HoraMinuts, Len(HoraMinuts) - InStr(HoraMinuts, ":")))
            If Not IsNumeric(Hores) Then Return 1
            If Not IsNumeric(Minuts) Then Return 1
            If CInt(Hores) < 0 Or CInt(Hores) > 23 Then Return 1
            If CInt(Minuts) < 0 Or CInt(Minuts) > 59 Then Return 1
            If MinutsMultiples5 AndAlso CInt(Minuts) Mod 5 <> 0 Then Return 3
        End If
        VData = Trim(Data).Split("/")
        If VData.Length <> 3 Then
            Return 1
        ElseIf Not IsNumeric(VData(0)) Or Not IsNumeric(VData(1)) Or Not IsNumeric(VData(2)) Then
            Return 1
        End If
        If VData(0) < 1 Or VData(0) > 31 Or VData(1) < 1 Or VData(1) > 12 Then
            Return 1
        End If
        If MiremAny4Xifres Then
            If Len(VData(2)) <> 4 Then Return 1
        End If
        If Not IsDate("#" & VData(0) & "/" & VData(1) & "/" & VData(2) & "#") Then
            Return 1
        End If
        If MiremHui Then
            If CDate(("#" & VData(0) & "/" & VData(1) & "/" & VData(2) & "#")) > Now Then
                Return 2
            End If
        ElseIf MiremPosteriorAHui Then
            If CDate(("#" & VData(0) & "/" & VData(1) & "/" & VData(2) & "#")) < Now Then
                Return 2
            End If
        End If
        DataBona = VData(2)
        If Len(CStr(VData(1))) = 1 Then
            DataBona += "0" & VData(1)
        Else
            DataBona += VData(1)
        End If
        If Len(CStr(VData(0))) = 1 Then
            DataBona += "0" & VData(0)
        Else
            DataBona += VData(0)
        End If
        If MiremHoraMinuts Then
            If Len(CStr(Hores)) = 1 Then
                DataBona += "0" & Hores
            Else
                DataBona += Hores
            End If
            If Len(CStr(Minuts)) = 1 Then
                DataBona += "0" & Minuts
            Else
                DataBona += Minuts
            End If
        End If
        Return 0
    End Function

    Public Sub FicaFitxersBootstrap(Optional ByRef bootstrap_min_css As Literal = Nothing, Optional ByRef bootstrap_datetimepicker_min_css As Literal = Nothing, Optional ByRef jquery_1_9_1_min_js As Literal = Nothing, Optional ByRef bootstrap_min_js As Literal = Nothing, Optional ByRef bootstrap_datetimepicker_js As Literal = Nothing, Optional ByRef bootbox_min_js As Literal = Nothing, Optional ByRef bootstrap_datetimepicker_es_js As Literal = Nothing, Optional ByVal FicarNouPath As String = "../../Bootstrap/", Optional ByRef bootstrap_datetimepicker_fr_js As Literal = Nothing, Optional ByRef icheck_bootstrap_min_css As Literal = Nothing, Optional ByRef segmented_controls_css As Literal = Nothing, Optional ByRef bootstrap_min_js2 As Literal = Nothing, Optional ByRef jquery_ui_min_css As Literal = Nothing, Optional ByRef jquery_ui_min_js As Literal = Nothing, Optional ByRef particles_js As Literal = Nothing, Optional ByRef particles_app_js As Literal = Nothing, Optional ByRef font_awesome_css As Literal = Nothing, Optional ByRef loader_css As Literal = Nothing, Optional ByRef iframe_sizer_min_js As Literal = Nothing, Optional ByRef iframe_resizer_contentwindow_min_js As Literal = Nothing, Optional ByRef Google_Roboto As Literal = Nothing)
        If Not IsNothing(bootstrap_min_css) Then bootstrap_min_css.Text = "<link href='" & FicarNouPath & "css/bootstrap.min.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(bootstrap_datetimepicker_min_css) Then bootstrap_datetimepicker_min_css.Text = "<link href='" & FicarNouPath & "css/bootstrap-datetimepicker.min.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(jquery_1_9_1_min_js) Then jquery_1_9_1_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/jquery-1.9.1.min.js' charset='UTF-8'></script>"
        If Not IsNothing(bootstrap_min_js) Then bootstrap_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/bootstrap.min.js'></script>"
        If Not IsNothing(bootstrap_datetimepicker_js) Then bootstrap_datetimepicker_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/bootstrap-datetimepicker.js' charset='UTF-8'></script>"
        If Not IsNothing(bootbox_min_js) Then bootbox_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/bootbox.min.js'></script>"
        If Not IsNothing(bootstrap_datetimepicker_es_js) Then bootstrap_datetimepicker_es_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "locales/bootstrap-datetimepicker.es.js' charset='UTF-8'></script>"
        If Not IsNothing(bootstrap_datetimepicker_fr_js) Then bootstrap_datetimepicker_fr_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "locales/bootstrap-datetimepicker.fr.js' charset='UTF-8'></script>"
        If Not IsNothing(icheck_bootstrap_min_css) Then icheck_bootstrap_min_css.Text = "<link href='" & FicarNouPath & "css/icheck-bootstrap.min.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(segmented_controls_css) Then segmented_controls_css.Text = "<link href='" & FicarNouPath & "css/segmented-controls2.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(bootstrap_min_js2) Then bootstrap_min_js2.Text = "<script type='text/javascript' src='https://netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js'></script>"
        If Not IsNothing(jquery_ui_min_css) Then jquery_ui_min_css.Text = "<link href='" & FicarNouPath & "css/jquery-ui.min.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(jquery_ui_min_js) Then jquery_ui_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/jquery-ui.min.js'></script>"
        If Not IsNothing(particles_js) Then particles_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/particles.js' charset='UTF-8'></script>"
        If Not IsNothing(particles_app_js) Then particles_app_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/app.js' charset='UTF-8'></script>"
        If Not IsNothing(font_awesome_css) Then font_awesome_css.Text = "<link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.0.13/css/all.css' integrity='sha384-DNOHZ68U8hZfKXOrtjWvjxusGo9WQnrNx2sqG0tfsghAvtVlRW3tvkXWZh58N9jp' crossorigin='anonymous'>"
        If Not IsNothing(loader_css) Then loader_css.Text = "<link href='" & FicarNouPath & "css/loader.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(iframe_sizer_min_js) Then iframe_sizer_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/iframeSizer.min.js' charset='UTF-8'></script>"
        If Not IsNothing(iframe_resizer_contentwindow_min_js) Then iframe_resizer_contentwindow_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/iframeResizer.contentWindow.min.js' charset='UTF-8'></script>"
        If Not IsNothing(Google_Roboto) Then Google_Roboto.Text = "<link href='//fonts.googleapis.com/css?family=Roboto:400,100,100italic,300,300italic,400italic,500,500italic,700,700italic,900italic,900' rel='stylesheet' media='screen' type='text/css'>"
    End Sub

    Public Sub FicaFitxersCSSControlCognoms(Optional ByRef LocalitzacioFitxerCSS As Literal = Nothing, Optional ByVal FicarNouPath As String = "")
        LocalitzacioFitxerCSS.Text = "<link href='" & FicarNouPath & "FontCognoms.css' rel='stylesheet' media='screen' type='text/css'>"
    End Sub

    '    Public Function TornaParametre_6Caracters(ByVal IDFira As String, ByVal NomCamp As String, ByRef DadesTornades As String, Optional ByVal CaseInsensitive As Boolean = False, Optional ByVal EsTaulaExtra1 As Boolean = False, Optional ByVal CriteriTaulaExtra1 As String = "", Optional ByVal NumeroCaracters As Integer = 6) As Boolean
    '        Dim VectorSQL(0) As String, Curt As String, i As Integer, Tipus As Integer, Valor As Integer, Llistat As String = ","
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As New DataSet
    '        Try
    '            If EsTaulaExtra1 Then
    '                VectorSQL(0) = "SELECT " & NomCamp & " FROM EETaulaExtra1 WHERE (idFira IN (" & IDFira & ")) AND (" & NomCamp & " <> '')" & CriteriTaulaExtra1
    '            Else
    '                VectorSQL(0) = "SELECT " & NomCamp & " FROM EEContactes WHERE (idFira IN (" & IDFira & ")) AND (idTipusContacte = 0) AND (" & NomCamp & " <> '')"
    '            End If
    '            If Not clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '                Return False
    '            ElseIf DS.Tables(0).Rows.Count > 0 Then
    '                For i = 0 To DS.Tables(0).Rows.Count - 1
    '                    Llistat += DS.Tables(0).Rows(i).Item(NomCamp) & ","
    '                Next
    '            End If
    'Repetim:
    '            Curt = ""
    '            For i = 0 To NumeroCaracters - 1
    '                Randomize()
    '                Tipus = CInt(2 * Rnd())
    '                Randomize()
    '                If Tipus = 0 Then '0-9
    '                    Valor = CInt(9 * Rnd())
    '                    Curt = Curt & Valor
    '                ElseIf Tipus = 1 Then 'a-z
    '                    Valor = CInt(25 * Rnd())
    '                    Curt = Curt & Chr(97 + Valor)
    '                Else 'A-Z
    '                    Valor = CInt(25 * Rnd())
    '                    Curt = Curt & Chr(65 + Valor)
    '                End If
    '            Next
    '            If CaseInsensitive Then
    '                If InStr(LCase(Llistat), "," & LCase(Curt) & ",") > 0 Then
    '                    System.Threading.Thread.Sleep(50)
    '                    GoTo Repetim
    '                End If
    '            Else
    '                If InStr(Llistat, "," & Curt & ",") > 0 Then
    '                    System.Threading.Thread.Sleep(50)
    '                    GoTo Repetim
    '                End If
    '            End If
    '            DadesTornades = Curt
    '            Return True
    '        Catch ex As Exception
    '            Dim Ara As String
    '            Ara = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '            VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,MissatgeSistema,Info1,Info2,Data) VALUES(100,'','','Problema executant la funció ''TornaParametre_6Caracters'' de la plana ficheros.cls. Les dades eren: IDFira: " & IDFira & ", NomCamp: " & NomCamp & ", Problema:" & clsBD.Cometes(ex.Message) & "','" & Ara & "')"
    '            clsBD.BaseDades(2, VectorSQL)
    '        End Try
    '    End Function

    'Public Sub FicaCel_lesBuides(ByRef Fila As CarlosAg.ExcelXmlWriter.WorksheetRow, ByVal Quantes As Integer)
    '    Dim i As Integer
    '    For i = 0 To Quantes - 1
    '        Fila.Cells.Add("")
    '    Next
    'End Sub

    '    Public Sub OmplirPlantillesEmail(ByVal IDFira As Integer, ByVal combo As System.Web.UI.WebControls.DropDownList)
    '        Dim i As Integer, Data As String
    '        Dim clsBD As New ClasseAccesBD
    '        Dim VectorSQL(0) As String
    '        Dim DS As New DataSet
    '        Try
    '            Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '            combo.Items.Clear()
    '            VectorSQL(0) = "SELECT idPlantilla, NomPlantilla FROM EEPlantillesEmail WHERE (idFira = " & IDFira & ") ORDER BY NomPlantilla"
    '            If Not clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '                GoTo Problema
    '            Else
    '                combo.Items.Add(New ListItem("AÑADIR PLANTILLA...", -2))
    '                If DS.Tables(0).Rows.Count > 0 Then
    '                    combo.Items.Add(New ListItem("-------------------", -1))
    '                    For i = 0 To DS.Tables(0).Rows.Count - 1
    '                        combo.Items.Add(New ListItem(DS.Tables(0).Rows(i).Item("NomPlantilla"), DS.Tables(0).Rows(i).Item("idPlantilla")))
    '                    Next
    '                End If
    '            End If
    '            Exit Sub
    'Problema:
    '            VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema omplint combo en OmplirPlantillesEmail de la ClasseGeneral. La consulta era: " & clsBD.Cometes(VectorSQL(0)) & "','" & Data & "')"
    '            clsBD.BaseDades(2, VectorSQL)
    '        Catch ex As Exception
    '            VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema omplint OmplirPlantillesEmail de la ClasseGeneral. La consulta era: " & clsBD.Cometes(VectorSQL(0)) & ", problema: " & clsBD.Cometes(ex.Message) & "','" & Data & "')"
    '            clsBD.BaseDades(2, VectorSQL)
    '        End Try
    '    End Sub

    Public Function TornaContingutEmailAmbParametres(ByVal Contingut As String, Optional ByVal Parametre As String = "-", Optional ByVal Nom As String = "-", Optional ByVal Cognoms As String = "-", Optional ByVal Email As String = "-", Optional ByVal Password As String = "-") As String
        Do While InStr(UCase(Contingut), "#PARAMETRO#") > 0 Or InStr(UCase(Contingut), "#NOMBRE#") > 0 Or InStr(UCase(Contingut), "#APELLIDOS#") > 0 Or InStr(UCase(Contingut), "#QR#") > 0 Or InStr(UCase(Contingut), "#EMAIL#") > 0 Or InStr(UCase(Contingut), "#PASSWORD#") > 0
            If InStr(UCase(Contingut), "#PARAMETRO#") > 0 And Parametre <> "-" Then
                Contingut = Left(Contingut, InStr(UCase(Contingut), "#PARAMETRO#") - 1) & Parametre & Right(Contingut, Len(Contingut) - InStr(UCase(Contingut), "#PARAMETRO#") - Len("#PARAMETRO#") + 1)
            End If
            If InStr(UCase(Contingut), "#NOMBRE#") > 0 And Nom <> "-" Then
                Contingut = Left(Contingut, InStr(UCase(Contingut), "#NOMBRE#") - 1) & Nom & Right(Contingut, Len(Contingut) - InStr(UCase(Contingut), "#NOMBRE#") - Len("#NOMBRE#") + 1)
            End If
            If InStr(UCase(Contingut), "#APELLIDOS#") > 0 And Cognoms <> "-" Then
                Contingut = Left(Contingut, InStr(UCase(Contingut), "#APELLIDOS#") - 1) & Cognoms & Right(Contingut, Len(Contingut) - InStr(UCase(Contingut), "#APELLIDOS#") - Len("#APELLIDOS#") + 1)
            End If
            If InStr(UCase(Contingut), "#EMAIL#") > 0 And Email <> "-" Then
                Contingut = Left(Contingut, InStr(UCase(Contingut), "#EMAIL#") - 1) & Email & Right(Contingut, Len(Contingut) - InStr(UCase(Contingut), "#EMAIL#") - Len("#EMAIL#") + 1)
            End If
            If InStr(UCase(Contingut), "#PASSWORD#") > 0 And Password <> "-" Then
                Contingut = Left(Contingut, InStr(UCase(Contingut), "#PASSWORD#") - 1) & Password & Right(Contingut, Len(Contingut) - InStr(UCase(Contingut), "#PASSWORD#") - Len("#PASSWORD#") + 1)
            End If
            If InStr(UCase(Contingut), "#QR#") > 0 And Parametre <> "-" Then
                Contingut = Left(Contingut, InStr(UCase(Contingut), "#QR#") - 1) & Parametre & Right(Contingut, Len(Contingut) - InStr(UCase(Contingut), "#QR#") - Len("#QR#") + 1)
            End If
        Loop
        Return Contingut
    End Function

    Public Function LlevarAccents(ByVal aString As String, Optional ByVal LlevarEspais As Boolean = False) As String
        Dim toReplace() As Char = "àèìòùÀÈÌÒÙ äëïöüÄËÏÖÜ âêîôûÂÊÎÔÛ áéíóúÁÉÍÓÚðÐýÝ ãñõÃÑÕšŠžŽçÇåÅøØ".ToCharArray
        Dim replaceChars() As Char = "aeiouAEIOU aeiouAEIOU aeiouAEIOU aeiouAEIOUdDyY anoANOsSzZcCaAoO".ToCharArray
        For index As Integer = 0 To toReplace.GetUpperBound(0)
            aString = aString.Replace(toReplace(index), replaceChars(index))
        Next
        If LlevarEspais Then
            Return aString.Replace(" ", "")
        Else
            Return aString
        End If
    End Function

    Public Function DescarregaFitxer(ByVal Cami As String, ByVal Pagina As Page) As Boolean
        Try
            Dim file As New System.IO.FileInfo(Cami)
            If file.Exists Then
                'Pagina.Response.Clear()
                'Pagina.Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name)
                'Pagina.Response.AddHeader("Content-Length", file.Length.ToString())
                'Pagina.Response.ContentType = "application/octet-stream"
                'Pagina.Response.WriteFile(file.FullName)
                'Pagina.Response.End()

                Pagina.Response.Clear()
                Pagina.Response.ContentType = "application/octet-stream"
                Pagina.Response.AppendHeader("Content-Disposition", "attachment; filename=" & file.Name)
                Pagina.Response.AddHeader("Content-Length", file.Length.ToString())
                Pagina.Response.TransmitFile(file.FullName)
                Pagina.Response.Flush()

            End If
            Return True
        Catch ex As Exception
            '
        End Try
    End Function

    Public Function GeneraParametre6Caracters(ByRef DadesTornades As String) As Boolean
        Dim Curt As String, i As Integer, Tipus As Integer, Valor As Integer
        Try
            Curt = ""
            For i = 0 To 5
                Randomize()
                Tipus = CInt(2 * Rnd())
                Randomize()
                If Tipus = 0 Then '0-9
                    Valor = CInt(9 * Rnd())
                    Curt = Curt & Valor
                ElseIf Tipus = 1 Then 'a-z
                    Valor = CInt(25 * Rnd())
                    Curt = Curt & Chr(97 + Valor)
                Else 'A-Z
                    Valor = CInt(25 * Rnd())
                    Curt = Curt & Chr(65 + Valor)
                End If
            Next
            DadesTornades = Curt
            Return True
        Catch ex As Exception
            '
        End Try
    End Function

    'Public Function TornaLlistatParametres(ByVal IDFira As Integer, ByVal NomCamp As String, ByVal Quants As Integer, ByRef VParametres() As String, Optional ByVal CerquemControlador As Boolean = False) As Boolean
    '    Try
    '        Dim i As Integer, Parametre As String, LlistatParametres As New StringBuilder
    '        Dim VectorSQL(0) As String
    '        Dim clsBD As New ClasseAccesBD
    '        Dim DS As New DataSet
    '        VectorSQL(0) = "SELECT " & NomCamp & " FROM EEContactes WHERE (idFira " & IIf(CerquemControlador, "<> ", "= ") & IDFira & ") AND (idTipusContacte = " & IIf(CerquemControlador, "40", "0") & ") AND (" & NomCamp & " <> '')"
    '        If Not clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '            Return False
    '        ElseIf DS.Tables(0).Rows.Count > 0 Then
    '            For i = 0 To DS.Tables(0).Rows.Count - 1
    '                LlistatParametres.Append(DS.Tables(0).Rows(i).Item(NomCamp) & ",")
    '            Next
    '        End If
    '        ReDim VParametres(Quants - 1)
    '        i = 0
    '        Do While i < Quants
    '            If GeneraParametre6Caracters(Parametre) Then
    '                If InStr(LlistatParametres.ToString, Parametre) = 0 Then
    '                    LlistatParametres.Append(Parametre & ",")
    '                    VParametres(i) = Parametre
    '                    i += 1
    '                End If
    '            End If
    '        Loop
    '        Return True
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    'Public Function TornaPlantillaEmail(ByVal IDFira As Integer, ByVal NomPlantilla As String, ByRef ContingutPlantilla As String) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim VectorSQL(0) As String
    '    Dim DS As New DataSet
    '    VectorSQL(0) = "SELECT Contingut FROM EEPlantillesEmail WHERE (idFira = " & IDFira & ") AND (NomPlantilla LIKE '%" & clsBD.Cometes(NomPlantilla) & "%')"
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        If DS.Tables(0).Rows.Count > 0 Then
    '            ContingutPlantilla = DS.Tables(0).Rows(0).Item("Contingut")
    '            Return True
    '        End If
    '    End If
    'End Function

    Public Sub PlenaComboNumeros(ByVal combo As Object, ByVal Primer As Integer, ByVal Ultim As Integer, ByVal Pas As Integer)
        Dim i As Integer
        combo.Items.Add(New ListItem("---", "0"))
        For i = Primer To Ultim Step Pas
            combo.Items.Add(New ListItem(i, IIf(Len(CStr(i)) = 1, "0", "") & i))
        Next
    End Sub

    'Public Function TornaComboEventsAmbImportacio(ByRef combo As DropDownList, ByVal NomCarpeta As String, Optional ByVal FiltremPerIDContacte As Integer = 0, Optional ByVal EsAngles As Boolean = False, Optional ByVal FiquemSubgrup As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL() As String, i As Integer
    '    ReDim VectorSQL(0)
    '    If FiltremPerIDContacte = 0 Then
    '        VectorSQL(0) = "SELECT idFira, TitolImatgeQRWAP AS NomEvent, RemitentSMS AS Subgrup FROM EEPersonalitzacioFira WHERE (NomCarpeta = N'" & NomCarpeta & "' AND DespresVerificarMostrarAltaNova = 1) ORDER BY idFira DESC"
    '    Else
    '        VectorSQL(0) = "SELECT EEPersonalitzacioFira.idFira, EEPersonalitzacioFira.TitolImatgeQRWAP AS NomEvent, RemitentSMS AS Subgrup FROM EEPersonalitzacioFira INNER JOIN EEContactes ON EEPersonalitzacioFira.idFira = EEContactes.idFira WHERE (EEPersonalitzacioFira.NomCarpeta = N'" & NomCarpeta & "') AND (EEContactes.idContacte = " & FiltremPerIDContacte & ") AND (EEContactes.idTipusContacte > 0) AND (EEPersonalitzacioFira.DespresVerificarMostrarAltaNova = 1) ORDER BY EEPersonalitzacioFira.idFira DESC"
    '    End If
    '    combo.Items.Clear()
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '        combo.Items.Add(New ListItem(IIf(EsAngles, "SELECT EVENT ...", "SELECCIONAR EVENTO ..."), -2))
    '        If DS.Tables(0).Rows.Count > 0 Then combo.Items.Add(New ListItem("------------------------------------", -1))
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            combo.Items.Add(New ListItem(DS.Tables(0).Rows(i).Item("NomEvent"), DS.Tables(0).Rows(i).Item("idFira") & IIf(FiquemSubgrup, "_" & DS.Tables(0).Rows(i).Item("Subgrup"), "")))
    '        Next
    '        Return True
    '    End If
    'End Function

    'Public Function TornaComboEventsAmbSubevents(ByRef combo As DropDownList, ByVal NomCarpeta As String, Optional ByVal FiltremPerIDContacte As Integer = 0, Optional ByVal EsAngles As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL() As String, i As Integer
    '    ReDim VectorSQL(0)
    '    If FiltremPerIDContacte = 0 Then
    '        VectorSQL(0) = "SELECT idFira, TitolImatgeQRWAP AS NomEvent FROM EEPersonalitzacioFira WHERE (NomCarpeta = N'" & NomCarpeta & "' AND EmailExpositorsATreballadors = 1) ORDER BY idFira DESC"
    '    Else
    '        VectorSQL(0) = "SELECT EEPersonalitzacioFira.idFira, EEPersonalitzacioFira.TitolImatgeQRWAP AS NomEvent FROM EEPersonalitzacioFira INNER JOIN EEContactes ON EEPersonalitzacioFira.idFira = EEContactes.idFira WHERE (EEPersonalitzacioFira.NomCarpeta = N'" & NomCarpeta & "') AND (EEContactes.idContacte = " & FiltremPerIDContacte & ") AND (EEContactes.idTipusContacte > 0) AND (EEPersonalitzacioFira.EmailExpositorsATreballadors = 1) ORDER BY EEPersonalitzacioFira.idFira DESC"
    '    End If
    '    combo.Items.Clear()
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '        combo.Items.Add(New ListItem(IIf(EsAngles, "SELECT EVENT ...", "SELECCIONAR EVENTO ..."), -2))
    '        If DS.Tables(0).Rows.Count > 0 Then combo.Items.Add(New ListItem("------------------------------------", -1))
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            combo.Items.Add(New ListItem(DS.Tables(0).Rows(i).Item("NomEvent"), DS.Tables(0).Rows(i).Item("idFira")))
    '        Next
    '        Return True
    '    End If
    'End Function

    Public Shared Function GetIPAddress() As String
        Dim context As System.Web.HttpContext = System.Web.HttpContext.Current
        Dim sIPAddress As String = context.Request.ServerVariables("HTTP_X_FORWARDED_FOR")
        If String.IsNullOrEmpty(sIPAddress) Then
            Return context.Request.ServerVariables("REMOTE_ADDR")
        Else
            Dim ipArray As String() = sIPAddress.Split(New [Char]() {","c})
            Return ipArray(0)
        End If
    End Function

    'Public Function TornaIDContacteSegonsParametre(ByVal IDFira As Integer, ByVal NomCamp As String, ByVal Parametre As String, ByRef IDContacte As Integer, Optional ByRef Email As String = "-", Optional ByRef Criteri As String = "-", Optional ByVal NumeroCaracters As Integer = 100, Optional ByVal QuinaBD As Integer = 3, Optional ByVal PassaAMinuscules As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL(0) As String, i As Integer, j As Integer, VDades() As String
    '    VectorSQL(0) = "Select idContacte, " & NomCamp & " AS Parametre" & IIf(Email = "", ", Email", "") & IIf(Criteri <> "-", ", " & Criteri, "") & " FROM EEContactes WHERE (idFira = " & IDFira & " AND LEFT(" & NomCamp & "," & NumeroCaracters & ") = '" & clsBD.Cometes(Left(Parametre, 200)) & "' AND idTipusContacte = 0)"
    '    If clsBD.BaseDades(1, VectorSQL, DS, QuinaBD, , False) Then
    '        If DS.Tables(0).Rows.Count > 0 Then
    '            For i = 0 To DS.Tables(0).Rows.Count - 1
    '                If Parametre = Left(IIf(PassaAMinuscules, LCase(DS.Tables(0).Rows(i).Item("Parametre")), DS.Tables(0).Rows(i).Item("Parametre")), NumeroCaracters) Then Exit For
    '            Next
    '            If i < DS.Tables(0).Rows.Count Then
    '                IDContacte = DS.Tables(0).Rows(i).Item("idContacte")
    '                If Email = "" Then Email = DS.Tables(0).Rows(i).Item("Email")
    '                If Criteri <> "-" Then
    '                    VDades = Criteri.Split(",")
    '                    Criteri = ""
    '                    For j = 0 To VDades.Length - 1
    '                        Criteri += DS.Tables(0).Rows(i).Item(Trim(VDades(j))) & "¦"
    '                    Next
    '                    Criteri = Left(Criteri, Len(Criteri) - 1)
    '                End If
    '                Return True
    '            End If
    '        End If
    '    End If
    'End Function

    Public Sub PlenaHoresMinuts(ByVal combo As DropDownList, ByVal ValorInical As Integer, ByVal ValorFinal As Integer, ByVal Pas As Integer, ByVal AfegirSeleccioBuida As Boolean)
        Dim i As Integer
        If AfegirSeleccioBuida Then combo.Items.Add(New ListItem("--", -2))
        For i = ValorInical To ValorFinal Step Pas
            combo.Items.Add(New ListItem(IIf(Len(CStr(i)) = 1, "0", "") & i, IIf(Len(CStr(i)) = 1, "0", "") & i))
        Next
    End Sub

    Public Sub TornaComboPaisos(ByVal VPaisos() As String, Optional ByRef combo As System.Web.UI.HtmlControls.HtmlSelect = Nothing, Optional ByRef combo2 As System.Web.UI.WebControls.DropDownList = Nothing, Optional ByVal FiquemSELECCIONAR As Boolean = False)
        Dim i As Integer, SeleccioEspanya As Integer, EsEspanyol As Boolean
        If FiquemSELECCIONAR Then
            For i = 0 To VPaisos.Length - 1
                If LCase(VPaisos(i)) = "españa" Then
                    EsEspanyol = True
                    Exit For
                End If
            Next
        End If
        If IsNothing(combo2) Then
            combo.Items.Clear()
            If FiquemSELECCIONAR Then
                combo.Items.Add(New ListItem(IIf(EsEspanyol, "SELECCIONAR ...", "SELECT ..."), -2))
                combo.Items.Add(New ListItem("-------------------", -1))
            End If
            For i = 0 To VPaisos.Length - 1
                combo.Items.Add(New ListItem(VPaisos(i), VPaisos(i)))
                If LCase(VPaisos(i)) = "españa" Or LCase(VPaisos(i)) = "spain" Then SeleccioEspanya = i
            Next
            combo.SelectedIndex = SeleccioEspanya
            If FiquemSELECCIONAR Then combo.SelectedIndex = 0
        Else
            combo2.Items.Clear()
            If FiquemSELECCIONAR Then
                combo2.Items.Add(New ListItem(IIf(EsEspanyol, "SELECCIONAR ...", "SELECT ..."), -2))
                combo2.Items.Add(New ListItem("-------------------", -1))
            End If
            For i = 0 To VPaisos.Length - 1
                combo2.Items.Add(New ListItem(VPaisos(i), VPaisos(i)))
                If LCase(VPaisos(i)) = "españa" Or LCase(VPaisos(i)) = "spain" Then SeleccioEspanya = i
            Next
            combo2.SelectedIndex = SeleccioEspanya
            If FiquemSELECCIONAR Then combo2.SelectedIndex = 0
        End If
    End Sub

    'Public Function DividirNomEnNomCognoms(ByVal IDFira As Integer) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim VectorSQL(0) As String
    '    Dim DS As New DataSet
    '    Dim i As Integer, VDades() As String, j As Integer, VSQL() As String, Nom As String, Cognoms As String, Cadena As String
    '    VectorSQL(0) = "SELECT idContacte, idOrigen, Nom, Password FROM EEContactes WHERE (idFira = 103) AND (idTipusContacte = 0) AND idContacte >0 ORDER BY idContacte"
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, IDFira) Then
    '        ReDim VSQL(0)
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            Nom = ""
    '            Cognoms = ""
    '            If VSQL(0) <> "" Then ReDim Preserve VSQL(VSQL.Length)
    '            Cadena = CStr(DS.Tables(0).Rows(i).Item("Nom")).Replace("  ", " ")
    '            VDades = Cadena.Split(" ")
    '            If DS.Tables(0).Rows(i).Item("Password") = 0 Then
    '                Nom = Trim(VDades(0))
    '                For j = 1 To VDades.Length - 1
    '                    Cognoms += Trim(VDades(j)) & " "
    '                Next
    '            Else
    '                Nom = Trim(VDades(0)) & " " & Trim(VDades(1))
    '                For j = 2 To VDades.Length - 1
    '                    Cognoms += Trim(VDades(j)) & " "
    '                Next
    '            End If
    '            Cognoms = Trim(Cognoms)
    '            VSQL(VSQL.Length - 1) = "UPDATE EEContactes SET Nom = '" & clsBD.Cometes(Nom) & "', Cognoms = '" & clsBD.Cometes(Cognoms) & "', Nickfacebook = '" & clsBD.Cometes(DS.Tables(0).Rows(i).Item("Nom")) & "' WHERE idFira = 103 AND idContacte = " & DS.Tables(0).Rows(i).Item("idContacte") & " AND idOrigen = " & DS.Tables(0).Rows(i).Item("idOrigen")
    '        Next
    '        If clsBD.BaseDades(2, VSQL, , 3, IDFira) Then
    '            Return True
    '        End If
    '    End If
    'End Function

    'Public Function TornaNITSegonsIDContacte(ByVal IDFira As Integer, ByVal IDContacte As Integer, ByRef NIT As String, Optional ByVal FiquemIDContacteSiNoHiHaNIT As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL(0) As String
    '    VectorSQL(0) = "SELECT NIT FROM EEContactes WHERE idFira = " & IDFira & " AND idContacte = " & IDContacte
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '        If DS.Tables(0).Rows.Count > 0 Then
    '            NIT = DS.Tables(0).Rows(0).Item("NIT")
    '            If FiquemIDContacteSiNoHiHaNIT And NIT = "" Then NIT = IDContacte
    '            Return True
    '        End If
    '    End If
    'End Function

    'clsGeneral.PassarExtensioAPNG(Request.PhysicalApplicationPath & "bayer\119\qr\400", Request.PhysicalApplicationPath & "bayer\119\qr\400")
    Public Function PassarExtensioAPNG(ByVal CamiOriginal As String, ByVal CamiFinal As String) As Boolean
        Dim Directori As New System.IO.DirectoryInfo(CamiOriginal)
        Dim TotalFitxers As System.IO.FileInfo() = Directori.GetFiles()
        Dim Fitxer As System.IO.FileInfo
        For Each Fitxer In TotalFitxers
            Fitxer.CopyTo(CamiFinal & "\" & Left(Fitxer.Name, Len(Fitxer.Name) - 4) & ".png")
        Next
        Return True
    End Function

    Public Function TornaXifraAmb2Decimals(ByVal Valor As Double, Optional ByVal TornaSempreDecimals As Boolean = False) As String
        If TornaSempreDecimals Then
            If InStr(CStr(Valor), ",") = 0 Then Return CStr(Valor) & ".00"
            Return Format(Valor, "#0.#0").Replace(",", ".")
        Else
            If Valor = 0 Then Return "0"
            Return Format(Valor, "#0.#0").Replace(",", ".").Replace(".00", "")
        End If
    End Function

    Public Function TornaPosicioPais(ByVal combo As HtmlSelect, ByVal NomPais As String) As Integer
        Dim i As Integer, j As Integer
        For i = 0 To VPaisosESP.Length - 1
            If LCase(NomPais) = LCase(VPaisosESP(i)) Then
                If LCase(NomPais) = LCase(combo.Items(i).Text) Then
                    Return i
                Else
                    For j = 0 To VPaisosENG_OrdreEspanyol.Length - 1
                        If LCase(NomPais) = LCase(VPaisosENG_OrdreEspanyol(j)) Then Return j
                    Next
                End If
            End If
        Next
        For i = 0 To VPaisosESP.Length - 1
            If LCase(NomPais) = LCase(VPaisosENG(i)) Then
                If LCase(NomPais) = LCase(combo.Items(i).Text) Then
                    Return i
                Else
                    For j = 0 To VPaisosESP.Length - 1
                        If LCase(VPaisosENG_OrdreEspanyol(i)) = LCase(VPaisosESP(j)) Then Return j
                    Next
                End If
            End If
        Next
        Return 0
    End Function

    'Public Function TornaIDContacteMAXIDEmpresaMAX(ByVal idFira As Integer, ByRef idContacte As Integer, ByRef idEmpresa As Integer) As Boolean
    '    Try
    '        Dim clsBD As New ClasseAccesBD
    '        Dim VectorSQL(0) As String
    '        VectorSQL(0) = "SELECT MAX(idContacte) AS IDContacteMAX FROM EEContactes WHERE (idFira = " & idFira & ")"
    '        Dim DS As DataSet
    '        DS = New DataSet
    '        If Not clsBD.BaseDades(1, VectorSQL, DS, 3, idFira) Then
    '            Return False
    '        Else
    '            If IsDBNull(DS.Tables(0).Rows(0).Item("IDContacteMAX")) Then
    '                idContacte = 1
    '            Else
    '                idContacte = DS.Tables(0).Rows(0).Item("IDContacteMAX") + 1
    '            End If
    '            VectorSQL(0) = "SELECT MAX(idEmpresa) AS IDEmpresaMAX FROM EEEmpreses WHERE (idFira = " & idFira & ")"
    '            DS = New DataSet
    '            If Not clsBD.BaseDades(1, VectorSQL, DS, 3, idFira) Then
    '                Return False
    '            Else
    '                If IsDBNull(DS.Tables(0).Rows(0).Item("IDEmpresaMAX")) Then
    '                    idEmpresa = 1
    '                Else
    '                    idEmpresa = DS.Tables(0).Rows(0).Item("IDEmpresaMAX") + 1
    '                End If
    '                Return True
    '            End If
    '        End If
    '    Catch ex As Exception
    '        '
    '    End Try
    'End Function

    '    Public Function TornaSeguentIDMaximContacte(ByVal IDFira As Integer, ByVal QuinaBD As Integer) As Integer
    '        Dim clsBD As New ClasseAccesBD
    '        Dim VectorSQL(0) As String
    '        Dim DS As New DataSet
    '        Dim Data As String, Descripcio As String
    '        Try
    '            VectorSQL(0) = "SELECT MAX(idContacte) AS IDContacteMAX FROM EEContactes WHERE (idFira = " & IDFira & ")"
    '            If Not clsBD.BaseDades(1, VectorSQL, DS, QuinaBD, IDFira) Then
    '                Descripcio = "Problema fent un SELECT a TornaSeguentIDMaximContacte."
    '                GoTo Problema
    '            ElseIf IsDBNull(DS.Tables(0).Rows(0).Item("IDContacteMAX")) Then
    '                Return 1
    '            Else
    '                Return DS.Tables(0).Rows(0).Item("IDContacteMAX") + 1
    '            End If
    '            Exit Function
    '        Catch ex As Exception
    '            Descripcio = "Error: " & ex.Message
    '        End Try
    'Problema:
    '        Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema executant TornaSeguentIDMaximContacte per a EntradaE. Les dades eren: " & clsBD.Cometes(Descripcio) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Function

    '    Public Function TornaSeguentIDMaximEmpresa(ByVal IDFira As Integer, ByVal QuinaBD As Integer) As Integer
    '        Dim clsBD As New ClasseAccesBD
    '        Dim VectorSQL(0) As String
    '        Dim DS As New DataSet
    '        Dim Data As String, Descripcio As String
    '        Try
    '            VectorSQL(0) = "SELECT MAX(idEmpresa) AS IDEmpresaMAX FROM EEEmpreses WHERE (idFira = " & IDFira & ")"
    '            If Not clsBD.BaseDades(1, VectorSQL, DS, QuinaBD, IDFira) Then
    '                Descripcio = "Problema fent un SELECT a TornaSeguentIDMaximEmpresa."
    '                GoTo Problema
    '            ElseIf IsDBNull(DS.Tables(0).Rows(0).Item("IDEmpresaMAX")) Then
    '                Return 1
    '            Else
    '                Return DS.Tables(0).Rows(0).Item("IDEmpresaMAX") + 1
    '            End If
    '            Exit Function
    '        Catch ex As Exception
    '            Descripcio = "Error: " & ex.Message
    '        End Try
    'Problema:
    '        Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema executant TornaSeguentIDMaximEmpresa per a EntradaE. Les dades eren: " & clsBD.Cometes(Descripcio) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Function

    'Public Function TornaLlistatContactesSegonsCognom(ByVal IDFira As Integer, ByVal Cognom As String, ByRef VIDs() As Integer, ByRef VText() As String, Optional ByVal Criteri As String = "") As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim VectorSQL(0) As String
    '    Dim DS As New DataSet
    '    Dim Data As String, i As Integer
    '    Try
    '        Cognom = LCase(Cognom).Replace("á", "a").Replace("à", "a").Replace("ä", "a").Replace("a", "[a-á-à-ä]").Replace("é", "e").Replace("è", "e").Replace("ë", "e").Replace("e", "[e-é-è-ë]").Replace("í", "i").Replace("ï", "i").Replace("i", "[i-í-ï]").Replace("ó", "o").Replace("ò", "o").Replace("ö", "o").Replace("o", "[o-ó-ò-ö]").Replace("ú", "u").Replace("ü", "u").Replace("u", "[u-ú-ü]")
    '        VectorSQL(0) = "SELECT idContacte, Nom, Cognoms FROM EEContactes WHERE (idFira = " & IDFira & " AND Cognoms LIKE '%" & clsBD.Cometes(Cognom) & "%'" & Criteri & ") ORDER BY Cognoms, Nom"
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '            If DS.Tables(0).Rows.Count > 0 Then
    '                ReDim VIDs(DS.Tables(0).Rows.Count - 1)
    '                ReDim VText(DS.Tables(0).Rows.Count - 1)
    '                For i = 0 To DS.Tables(0).Rows.Count - 1
    '                    VIDs(i) = DS.Tables(0).Rows(i).Item("idContacte")
    '                    VText(i) = IIf(Trim(DS.Tables(0).Rows(i).Item("Cognoms")) <> "", DS.Tables(0).Rows(i).Item("Cognoms") & ", ", "") & DS.Tables(0).Rows(i).Item("Nom")
    '                Next
    '                Return True
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema executant TornaLlistatContactesSegonsCognom per a EntradaE. Les dades eren: " & clsBD.Cometes(Cognom) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Try
    'End Function

    'Public Function TornaLlistatNITsOrdenats(ByVal IDFira As Integer, ByRef VNITs() As String) As Boolean
    '    Dim VectorSQL(0) As String, i As Integer
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    VectorSQL(0) = "SELECT NIT FROM EECodisFira WHERE (idFira = " & IDFira & ") ORDER BY NIT"
    '    If clsBD.BaseDades(1, VectorSQL, DS, 2) Then
    '        ReDim VNITs(DS.Tables(0).Rows.Count - 1)
    '        For i = 0 To DS.Tables(0).Rows.Count - 1
    '            VNITs(i) = DS.Tables(0).Rows(i).Item("NIT")
    '        Next
    '        Return True
    '    End If
    'End Function

    'Public Function CanviaPrimeraLletraMajuscula(ByVal IDFira As Integer, ByVal NomCamp As String) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim VectorSQL(0) As String
    '    Dim DS As New DataSet
    '    Dim VDades() As String, VDades2() As String, i As Integer, j As Integer, k As Integer, Tros As String, Evitar As String = "-de-del-la-"
    '    Try
    '        VectorSQL(0) = "SELECT idContacte, " & NomCamp & " FROM EEContactes WHERE (idFira = " & IDFira & " AND idTipusContacte = 0) ORDER BY idContacte"
    '        If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '            If DS.Tables(0).Rows.Count > 0 Then
    '                For i = 0 To DS.Tables(0).Rows.Count - 1
    '                    VDades = DS.Tables(0).Rows(i).Item(NomCamp).replace("  ", " ").Split(" ")
    '                    Tros = ""
    '                    For j = 0 To VDades.Length - 1
    '                        If InStr(Evitar, "-" & LCase(VDades(j)) & "-") = 0 Then
    '                            If InStr(VDades(j), "-") = 0 Then
    '                                Tros += UCase(Left(VDades(j), 1)) & LCase(Right(VDades(j), Len(VDades(j)) - 1)) & " "
    '                            Else
    '                                VDades2 = VDades(j).Split("-")
    '                                For k = 0 To VDades2.Length - 1
    '                                    Tros += UCase(Left(VDades2(k), 1)) & LCase(Right(VDades2(k), Len(VDades2(k)) - 1)) & "-"
    '                                Next
    '                                Tros = Left(Tros, Len(Tros) - 1) & " "
    '                            End If
    '                        Else
    '                            Tros += LCase(VDades(j)) & " "
    '                        End If
    '                    Next
    '                    Tros = Trim(Tros)
    '                    VectorSQL(0) = "UPDATE EEContactes SET " & NomCamp & " = '" & clsBD.Cometes(Tros) & "' WHERE (idFira = " & IDFira & " AND idContacte = " & DS.Tables(0).Rows(i).Item("idContacte") & ")"
    '                    clsBD.BaseDades(2, VectorSQL, , 3, , False)
    '                Next
    '                Return True
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Dim Data As String = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema executant CanviaPrimeraLletraMajuscula per a EntradaE. Les dades eren: IDFIra: " & IDFira & ", NomCamp: " & clsBD.Cometes(NomCamp) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Try
    'End Function

    'Public Function TornaDadesTaulaExtra2(ByVal IDFira As Integer, ByVal Cas As Integer, ByVal Tipus As Integer, ByVal CampsCerca As String, ByVal Criteri As String, Optional ByVal Ordre As String = "", Optional ByRef DS As DataSet = Nothing) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim VectorSQL(0) As String
    '    Select Case Cas
    '        Case 1
    '            VectorSQL(0) = "SELECT " & CampsCerca & " FROM EETaulaExtra2 WHERE idFira = " & IDFira & " AND Camp1 = '" & Tipus & "'" & Criteri & IIf(Ordre <> "", " ORDER BY " & Ordre, "")
    '            Return clsBD.BaseDades(1, VectorSQL, DS, 3, , False)
    '        Case Else
    '            Select Case Cas
    '                Case 2
    '                    VectorSQL(0) = "UPDATE EETaulaExtra2 SET " & CampsCerca & " WHERE idFira = " & IDFira & " AND Camp1 = '" & Tipus & "'" & Criteri
    '                Case 3
    '                    VectorSQL(0) = "DELETE FROM EETaulaExtra2 WHERE idFira = " & IDFira & " AND Camp1 = '" & Tipus & "'" & Criteri
    '                Case 4
    '                    VectorSQL(0) = "INSERT INTO EETaulaExtra2 (idFira,Camp1,Camp2,Camp3,Camp4,Camp5,Camp6,Camp7,Camp8,Camp9,Camp10,Camp11,Camp12,Camp13,Camp14,Camp15,Camp16,Camp17,Camp18,Camp19,Camp20,Camp21,Camp22,Camp23,Camp24,Camp25,Camp26,Camp27,Camp28,Camp29,Camp30,Camp31,Camp32,Camp33,Camp34,Camp35,Camp36,Camp37,Camp38,Camp39,Camp40,Camp41,Camp42,Camp43,Camp44,Camp45,Camp46,Camp47,Camp48,Camp49) VALUES(" & CampsCerca & ")"
    '            End Select
    '            Return clsBD.BaseDades(2, VectorSQL, , 3, , False)
    '    End Select
    'End Function

    'Public Function VerificaDimensionsImatge(ByVal CamiImatge As String, ByVal Ample As Integer, ByVal Alt As Integer) As Boolean
    '    Try
    '        Dim Imatge As System.Drawing.Image = System.Drawing.Image.FromFile(CamiImatge)
    '        If Ample > 0 Then
    '            If Imatge.Size.Width <> Ample Then Return False
    '        End If
    '        If Alt > 0 Then
    '            If Imatge.Size.Width <> Ample Then Return False
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        Dim clsBD As New ClasseAccesBD
    '        Dim VectorSQL(0) As String, Data As String
    '        Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#") & Format(Hour(Now), "0#") & Format(Minute(Now), "0#") & Format(Second(Now), "0#")
    '        VectorSQL(0) = "INSERT INTO Problemes(IDUsuari,NumeroSistema,MissatgeSistema,Info1,Info2,Data) VALUES(100,0,'','','Problema omplint GeneraImatgePetita de la ClasseRPA. Problema: " & clsBD.Cometes(ex.Message) & "','" & Data & "')"
    '        clsBD.BaseDades(2, VectorSQL)
    '    End Try
    'End Function

    'Public Function TornaDarreraFira(ByVal NomCarpeta As String) As Integer
    '    Dim clsBD As New ClasseAccesBD
    '    Dim DS As New DataSet
    '    Dim VectorSQL(0) As String
    '    VectorSQL(0) = "SELECT MAX(idFira) AS MAXIDFira FROM EEPersonalitzacioFira WHERE RemitentSMS = '" & NomCarpeta & "'"
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, , False) Then
    '        Return DS.Tables(0).Rows(0).Item("MAXIDFira")
    '    End If
    'End Function

    Public Function TornaXifraAmbPuntsDeMiler(ByVal Xifra As String) As String
        If Len(Xifra) < 4 Then
            Return Xifra
        Else
            Return Left(Xifra, Len(Xifra) - 3) & "." & Right(Xifra, 3)
        End If
    End Function

    'Public Function TornaSiAssistencia(ByVal IDFira As Integer, ByVal NIT As String, Optional ByVal MiremNomesHui As Boolean = True, Optional ByVal FiltremPerControlador As String = "", Optional ByVal ForcemMatching As Boolean = False) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim VSQL(0) As String, Data As String
    '    Dim DS2 As New DataSet
    '    Data = Year(Now) & Format(Month(Now), "0#") & Format(Day(Now), "0#")
    '    If Not ForcemMatching Then
    '        VSQL(0) = "SELECT COUNT(NIT) AS Quants FROM EEIdentificacioAcces WHERE idFira = " & IDFira & " AND idTipusAcces = 1 " & IIf(MiremNomesHui, "AND DataHora LIKE '" & Data & "%'", "") & " AND Validacio = 1 AND NIT IN ('" & clsBD.Cometes(NIT).Replace("'',''", "','") & "')" & IIf(FiltremPerControlador <> "", " AND idContacte IN (" & FiltremPerControlador & ")", "")
    '    Else
    '        VSQL(0) = "SELECT NIT FROM EEIdentificacioAcces WHERE idFira = " & IDFira & " AND idTipusAcces = 1 " & IIf(MiremNomesHui, "AND DataHora LIKE '" & Data & "%'", "") & " AND Validacio = 1 AND NIT IN ('" & clsBD.Cometes(NIT).Replace("'',''", "','") & "')" & IIf(FiltremPerControlador <> "", " AND idContacte IN (" & FiltremPerControlador & ")", "")
    '    End If
    '    If clsBD.BaseDades(1, VSQL, DS2, 3, , False) Then
    '        If Not ForcemMatching Then Return DS2.Tables(0).Rows(0).Item("Quants") > 0
    '        Dim VDades() As String, i As Integer, j As Integer, Quants As Integer
    '        VDades = NIT.Split("','")
    '        For i = 0 To DS2.Tables(0).Rows.Count - 1
    '            For j = 0 To VDades.Length - 1
    '                If DS2.Tables(0).Rows(i).Item("NIT") = VDades(j) Then Quants += 1
    '            Next
    '        Next
    '        Return Quants
    '    End If
    'End Function

    Public Function TornaDiferenciaHoraria() As Integer
        If Format(Month(Now), "0#") & Format(Day(Now), "0#") >= "0331" And Format(Month(Now), "0#") & Format(Day(Now), "0#") < "1027" Then
            Return 2
        Else
            Return 1
        End If
    End Function

    'Public Function TornaDadesEmmerdades(ByVal Dades As String) As String
    '    Dim clsAlgoritmes As New ClasseAlgoritmes
    '    Dim Davant As String = "", Darrera As String = "", i As Integer
    '    Randomize()
    '    Davant = CStr(CLng(9999999 * Rnd()))
    '    Do While Len(Davant) <> 7
    '        Davant = "0" & Davant
    '    Loop
    '    For i = 7 To 1 Step -1
    '        Darrera += Mid(Davant, i, 1)
    '    Next
    '    Return clsAlgoritmes.EmmerdaDades("Davant=" & Davant & "&" & Dades & "&Darrera=" & Darrera, clsAlgoritmes.LlavorInicial("06"))
    'End Function

    'Public Function TornaDadesTaulaExtra1(ByVal IDFira As Integer, ByVal Cas As Integer, ByVal Tipus As Integer, ByVal CampsCerca As String, ByVal Criteri As String, Optional ByVal Ordre As String = "", Optional ByRef DS As DataSet = Nothing) As Boolean
    '    Dim VectorSQL(0) As String
    '    Dim clsBD As New ClasseAccesBD
    '    Select Case Cas
    '        Case 1
    '            VectorSQL(0) = "SELECT " & CampsCerca & " FROM EETaulaExtra1 WHERE idFira = " & IDFira & " AND Camp1 = '" & Tipus & "'" & Criteri & IIf(Ordre <> "", " ORDER BY " & Ordre, "")
    '            Return clsBD.BaseDades(1, VectorSQL, DS, 3, , False)
    '        Case Else
    '            Select Case Cas
    '                Case 2
    '                    VectorSQL(0) = "UPDATE EETaulaExtra1 SET " & CampsCerca & " WHERE idFira = " & IDFira & " AND Camp1 = '" & Tipus & "'" & Criteri
    '                Case 3
    '                    VectorSQL(0) = "DELETE FROM EETaulaExtra1 WHERE idFira = " & IDFira & " AND Camp1 = '" & Tipus & "'" & Criteri
    '                Case 4
    '                    VectorSQL(0) = "INSERT INTO EETaulaExtra1 (idFira, Camp1, Camp2, Camp3, Camp4, Camp5, Camp6, Camp7, Camp8, Camp9, Data) VALUES(" & CampsCerca & ")"
    '            End Select
    '            Return clsBD.BaseDades(2, VectorSQL, , 3, , False)
    '    End Select
    'End Function

    Public Function CarregaDades220(ByVal CamiFitxer As String, ByVal IDFira As Integer, ByVal PrimerID As Integer) As Boolean
        'Try
        '    Dim VNITs As String() = New String(1499) {"001XO2EU", "00BK7TF3", "03BLU3JC", "04F05TYV", "04PP6PDL", "04QTUTAG", "05SFY8RX", "05UKGAFT", "06QT1MAG", "06VX6KEU", "09Q12OW4", "0C0DLLZS", "0CRLH2OA", "0CTX4T20", "0E7LV7JH", "0G8XFN25", "0J7SLXLO", "0JYS4ELO", "0KIXCM21", "0KKP51DW", "0LY0ZIYE", "0N28PVXQ", "0QBX7RE2", "0QE8XNXQ", "0QU8CYCY", "0SRFQ0B6", "0SS85TCM", "0VSXY0E2", "0VZFT4BD", "0WL1TXW4", "0WNFJ7B6", "0XNFS5BD", "0XNL2VJC", "0XRTBJAN", "0XRY8ASF", "0Y087DXQ", "0YEFRZB6", "0YFDDTZS", "0Z2D33ZS", "0ZFF0XBD", "10L7MPJC", "13T6SCFT", "13V6SMF3", "148BCXDL", "15X2ICG9", "17UET3LO", "1DFBAADW", "1G77TNJH", "1IDJ84E2", "1JL695F3", "1JNUZDCM", "1RF2HDG9", "1SSJ0CE2", "1ST20UG9", "1UZ1DYBD", "1VEF01AG", "1WNFQBAG", "1YVF9ZAN", "1YZ16YB6", "1Z1F7UAG", "1ZNJLJEU", "219FAA25", "21TVCCZS", "22RGQASF", "22TA00LO", "23QJKOW4", "24PX7HRX", "24Z3BQOA", "2CAF324J", "2CPJ35W4", "2DMQQCXQ", "2DZLS35P", "2GILAL5P", "2JNL9M5P", "2KWX6IRX", "2KWZLX97", "2NIZE497", "2XNG8SSF", "2XVF3D21", "2Y7Z4E97", "2YMV4KZS", "2YTQY4XQ", "2YYFUB4J", "2Z9F5A20", "40U169AG", "45920QXQ", "45M1F7AN", "45R766ZS", "4EFXC75P", "4FWE6F7K", "4KA15AAG", "4WXEOV7I", "4YUUX7YV", "4ZIR5Y20", "7017FOLO", "70F34LXQ", "70T0TBOA", "73PUAHRX", "73QFS3FT", "74IKVI7I", "74VWR4W4", "75ZN05XQ", "77PWQ5W4", "7CMKSJDW", "7CVZ3X7K", "7DB3SV5Z", "7DMOS7AN", "7DVW6F97", "7EFSJ8ZS", "7ESFT2FT", "7ETFTCF3", "7F7FIDFT", "7F7GKNJH", "7FDFFNYE", "7FNOHBAG", "7FUGA1W4", "7GSFREF3", "7GZ3A35P", "7GZGJSW4", "7I7KLFDL", "7IPCL225", "7IS0ZOJH", "7J0OR8AN", "7J8GITW4", "7JFDXTH8", "7JXF9WF3", "7JYCE925", "7KAG8UJC", "7KLSS3EU", "7KWCBX4J", "7L7UK7RX", "7NDCSG4J", "7NQI085Z", "7QN7Y5LO", "7RG013OA", "7S0GB0W4", "7S9I1X5P", "7UFN50XQ", "7V8CSQ20", "7VYF1UFT", "7WUTXQSF", "7X2C3F20", "7XQOZTAG", "7XZC3G21", "7YBGWSOA", "7YFUSZRX", "7YNO9QAN", "7YSCAY4J", "7YZKNQ7I", "7ZGW9MW4", "7ZPGAXJH", "80VQ8125", "81AWXN5P", "81TD9D7K", "81WT5I5P", "81WTXQ5P", "82IQIM20", "82T7RJ97", "83INGS21", "84AE661B", "84TYJBXQ", "84W3PRZS", "85MLPWCM", "89FYU0XQ", "89U77397", "8CITE95P", "8EIQQ1YE", "8EYQQIYV", "8JT682AG", "8K8W7D5P", "8KQNRL25", "8LY7ZB97", "8NBDSS7I", "8NYNZ921", "8S8Q5P4J", "8SS6ISAG", "8U0TI6YE", "8VFLANCY", "8VZ60HAN", "8X21WVXQ", "8XUA4HE2", "8XYEWG1B", "8XYWYW5Z", "8Y8Q9ZYV", "8Y8T9WYV", "8YIDAC7K", "8YNL8DCM", "8YNS67B6", "8YT24EDL", "907VR0HR", "90NXJJ7K", "90TT9UG9", "917DJLYE", "91RA2I20", "91XAAB21", "92PV1QHR", "92WAI321", "942G825Z", "95TYXV1B", "9CDVI9HR", "9CWDSCYE", "9EDLDUXQ", "9EIQJAZS", "9GVYTWJH", "9ISXKG7I", "9J1YBEJH", "9JDTSBG9", "9KFT8VG9", "9NTD22YE", "9Q9VAYH8", "9QPDABYV", "9VTY3MJH", "9WAYNJOA", "9XVVJPH8", "9YIXU67I", "9YQA0L21", "9YRSWXRX", "9YVDBAYV", "9YZA0P25", "9ZXUAD97", "A0GNDQ1B", "A0LURPLO", "A0TAGGCM", "A0TR13DW", "A0TV6FAG", "A1QZAL20", "A2DZIE21", "A2SI77G9", "A3FZGK25", "A3VNFX7K", "A47ZMZ4J", "A4UAYYCM", "A6URJLDW", "AE9NGU7I", "AFUZ6U25", "AJBR9VDW", "AJPNVMOA", "AK820WYV", "AK83VTW4", "AKQKD6H8", "AKTZR420", "AL43UUW4", "AN801FSF", "APEA6QCM", "ARXF5ZZS", "ASNN0VJC", "ASTA5RCM", "ASVKQCHR", "AUTR2RDL", "AVZK8UHR", "AWINOM7I", "AWNHJ5B6", "AWTALXXQ", "AXWM0OFT", "AYIKX097", "AYXZR5E2", "AZLVG5AG", "AZXMH7FT", "B0NCC3W4", "B2ZBRFYE", "B5DWI9JH", "B9T8YT25", "BDNWN71B", "BDXOWZZS", "BG78FC25", "BI7JHSXQ", "BI93SFLO", "BIV887EU", "BK8S0P97", "BKER8XG9", "BKRW5P1B", "BKV316LO", "BKZWQ1JH", "BL2BZOYV", "BN7OV0ZS", "BNVWM81B", "BQ8BAWYE", "BR9WH5JC", "BSNT5OHR", "BVU8YHEU", "BWI8PY21", "BWP8P225", "BWUVOE7I", "BXBC4BW4", "BXTEY45P", "BYN8RWE2", "BYPWPXJC", "BYS39YLO", "BZFV047K", "BZVWJ8JH", "D0BW2NRX", "D0Q3Z3B6", "D17D3FDW", "D1D23L1B", "D1IKX95Z", "D1T6T4H8", "D2NGP5LO", "D3FLW6EU", "D3GHPSYV", "D3TLWEE2", "D4N9BKOA", "D4S3HLB6", "D4TFLGSF", "D50FCPSF", "D7AEMZ25", "D99Y7C97", "DCDHAWAN", "DCF2CC1B", "DCFKES5Z", "DCV9DWJC", "DDLW2KCY", "DDWHSEAN", "DF2E6F25", "DIS6B5HR", "DJ94S0G9", "DKI1Q67I", "DKV9ALOA", "DKW8OOF3", "DLZ1P97K", "DNREZI21", "DPL8XFF3", "DQV98TLO", "DRW37VB6", "DSEDDUDL", "DST3QJBD", "DSXHGKYE", "DUQHKMAN", "DUT9NMJC", "DVIKN95P", "DVVH0ZAG", "DXE6JEH8", "DXNL4YEU", "DXPDTPDW", "DXY6JXHR", "DY21ZZ7K", "DY4IFUW4", "DYAH98YV", "DYNI63W4", "DYNLEWE2", "DYV24K1B", "DYV41RG9", "DYVK605Z", "DZ710W7I", "DZ74AIG9", "DZ8KWA5Z", "DZMFDOSF", "E0B1OVDL", "E0LRZMBD", "E0XEY6JC", "E0XUKWFT", "E0XVM6JH", "E1FMLGAN", "E1R7AI25", "E2I8C1RX", "E2W1E3CY", "E2YVGTOA", "E4LI67DW", "E4T8LNSF", "E4TA52YE", "E4TBWFHR", "E4VB0GW4", "E5N7KWEU", "E5ZDGRF3", "E60S9LHR", "ECL9DAG9", "ECLVDFJH", "EDQR3N97", "EEP9VSG9", "EFBVK3JC", "EGZDA35Z", "EIT1D4CY", "EIT53FAN", "EITAUDYE", "EITU4CFT", "EIVU4MF3", "EJBI7VDL", "EJD8KDB6", "EJEBXVH8", "EJQ813BD", "EJXRM3SF", "EKP15PDW", "ENIDOF5P", "ENMR1OSF", "EPNB4OH8", "EPTRPWBD", "EQEQ7QEU", "EQK9HXEU", "EQTR9GSF", "EQVQFRG9", "ERLIWHDW", "ERQ1WYDW", "ERQBM6H8", "ES71FFDW", "ES79L2G9", "ESAB5NH8", "ESAN9NZS", "ESEVL2JC", "EST72EEU", "ESW72ME2", "ESZ15CCY", "ESZ5VNAN", "EU7KUSCM", "EUD79E20", "EULUL5F3", "EUUQP8EU", "EVE2WCLO", "EVL93KG9", "EVN7S025", "EVTPMARX", "EVUS8MHR", "EX1UC4FT", "EX1VEEJH", "EXB2VDLO", "EXM1LWCY", "EXN8S5B6", "EXT8UJRX", "EXU5B0AG", "EYEZRUDL", "EYF8WCSF", "EYK5MPAG", "EYNKJFCY", "EYNQGQG9", "EYT70O21", "EYT7BH25", "EYWKJ3CM", "EYYUAT7I", "EZF80XB6", "EZKD8ZF3", "EZT2CWLO", "EZTDHGFT", "F0A52ERX", "F0DBY9JC", "F0R58I21", "F0TJ6RAG", "F18B5A5Z", "F28QDD5P", "F2LYEUCM", "F2T8CJH8", "F4F86C1B", "F4I8PT1B", "F4TY44CM", "F4TY4GCY", "F4VBL8OA", "F5SSG2FT", "F5TOCGSF", "F7AVIFXQ", "F7S8F31B", "F7ZOUYSF", "F97KYC20", "F9GP7L97", "FC4KJR20", "FC9NFTE2", "FCFN3FB6", "FDVL2TSF", "FEAPQ297", "FEB5H820", "FEE5B5RX", "FFF5AXBD", "FFLFZHDW", "FFVXZODL", "FG84OP97", "FG9QYYHR", "FJIGA2XQ", "FJLF97DW", "FJTX9EDL", "FK1A64F3", "FK7SQH7K", "FKZBMT5Z", "FLG7P37K", "FLIQLF5Z", "FMUJO9AG", "FNRS8Z7K", "FNT78I7I", "FNTTMB1B", "FPEJW1AG", "FPU51HEU", "FQTGM4CM", "FR7LBKSF", "FR8NCZYV", "FRD8M9H8", "FRNBHVJH", "FSAT0UJH", "FSDG5LCM", "FSF52OE2", "FSF83BHR", "FUNNPJE2", "FUUBNKJC", "FVFBNS5Z", "FVFN1TYE", "FVTNMWB6", "FVTOW7W4", "FVUSRE7I", "FW8KPQ25", "FWP8YBYE", "FXF5SFBD", "FXZFHZDW", "FY7BPNJH", "FY9NBJYE", "FYD4XG97", "FYFLJCSF", "FYLO6XW4", "FYRNKRYV", "FYYXRWDL", "FYZ50P20", "FYZYWCCM", "FZ2BUZOA", "FZ8ODFSF", "FZNXY0DW", "FZS0CYLO", "FZT07CZS", "FZZ55P25", "G0G3TL97", "G4TJV64J", "GC2PZ25Z", "GC71D7RX", "GCF3SM97", "GIZ6K97K", "GJAK5RSF", "GK730E97", "GKEP7U5Z", "GKI6BI7K", "GKT1OWRX", "GLMUMCXQ", "GNT6S17K", "GSTJ6V4J", "GYDPQ15P", "GYN15FRX", "GYN6AJ7K", "GYZMXFYV", "GYZMXYYE", "GZBMEHYE", "H6P21DAG", "HVS2TSAN", "HXTOSWBD", "I0QNGDSF", "I0TMKO20", "I0VMJF4J", "I1EM2721", "I2VXEHXQ", "I4IFC67I", "I4XIMD97", "ICBSIA4J", "ICFSJK21", "ICNXFGXQ", "ICWS4325", "ICZMJP20", "IDDMUE20", "IDFFTP7I", "IDZ63897", "IDZYPT5P", "IF842A5P", "IIBLKS7I", "IJFNXX97", "IK2SBH4J", "IK7SRC21", "IKASQ24J", "IKSMCW20", "IKUPL7YE", "IKWSCV25", "IKXSRB20", "IN8CKL97", "INALSK7I", "IQRXXYXQ", "K0F2YIJC", "K0S172FT", "K1SALSAN", "K2D279JC", "K2PX7SG9", "K47XX2G9", "K4AWIRB6", "K5B1GTFT", "K5F6XSDW", "K5Q1G3F3", "KJV6QODL", "KKN2QVJH", "KRSAESAG", "KRY1FUFT", "KRY2H4JH", "KSNWB5BD", "KST60EDL", "KX7Z7GHR", "KYLXPAG9", "KZXAGXAN", "L012ZBBD", "L0S3M7G9", "L0VF2TLO", "L1M8ORJH", "L1Z5V6CM", "L2TPPWLO", "L2VAKPZS", "L3WXPCYV", "L4DKZ4EU", "L5XDI1G9", "L9TY2RW4", "LCS5KHCM", "LCS5KTCY", "LDE2LIB6", "LETVPWSF", "LFEIKLJH", "LGNC80DL", "LIBFBWHR", "LJM5XKHR", "LJT2KJB6", "LJTCQIDL", "LK7QN3AG", "LKEFJCLO", "LKNKSJE2", "LKPGNDAG", "LPNGWBAN", "LQYFAXHR", "LRE5MVHR", "LRX81VOA", "LS0F3LH8", "LSLK03EU", "LSQ3L8G9", "LSTF34HR", "LU15UJCY", "LUTFSFHR", "LUTI7FOA", "LXEVLQCM", "LY1GDUAN", "LYFCGSDL", "LYMUEFEU", "LYTHEPF3", "LYTUENE2", "LZK5F2HR", "LZRA36ZS", "M0AK9UJH", "M0EKTROA", "M0ZS6IAG", "M17EEKBD", "M2AW9IEU", "M3FZPTYE", "M42KLZOA", "M4I7J2XQ", "M4ZXLYSF", "M5MWKFE2", "MCAETERX", "MF8OZXDL", "MI8EW2BD", "MJKWUXEU", "MJT7ABXQ", "MJWCGRZS", "MKNK8VJH", "MKQKQDJH", "MLBEKNRX", "MMUSO0AG", "MPNW1YE2", "MQTEVWB6", "MQVKFJJC", "MRASEAAG", "MSL75UCM", "MUBZIHYV", "MVNEM5B6", "MWIZY1YV", "MY7KGNJH", "MYXSYXAN", "MZ0K3HOA", "MZD7QLCY", "MZXOY9DW", "N0F0KQFT", "N0F6375P", "N0FQTNCM", "N0G5F65Z", "N0SSO4DL", "N1EBLKAG", "N1K0QXEU", "N1T01J4J", "N1TVEWB6", "N2FORPOA", "N2IJR797", "N2N7M2DW", "N2W0CRH8", "N2ZW4NAN", "N3QYZ6H8", "N3SJUJG9", "N42MCZ7I", "N483WZYV", "N4B0N821", "N4K9PPAN", "N4MOYWCY", "N57WIIG9", "N5FOP5CY", "N5RX80B6", "N6002IF3", "N6SB14AG", "N7Y0M921", "NC9FFTEU", "NC9JD0G9", "NCK0BZFT", "NCM1ROSF", "NDF6SS5Z", "NEZ0TRF3", "NFW62I5Z", "NINQDFCY", "NIQ5L5DW", "NIUB39AN", "NJNOI0CM", "NJTLX4HR", "NJTOZVCY", "NJUQIYCM", "NJVYGPH8", "NJZ0EG20", "NJZI8VRX", "NKM75JDW", "NKSSNGDW", "NKW7NQDL", "NNA5ON5P", "NNWJJF97", "NNZ0T625", "NPNIP5BD", "NQTWCFAN", "NQY5UWDW", "NQZQM6CY", "NRU9E0AN", "NRYSWWDL", "NS905YH8", "NSFO7NCY", "NSLIBCB6", "NSMVE1LO", "NSPFNLEU", "NST3LZJH", "NSTNW1F3", "NSUL5DH8", "NSZ9XHAN", "NU03NSJC", "NUTO201B", "NWW6KQ5P", "NXA5YN5Z", "NXDV4DBD", "NXV0G7EU", "NY9BRQXQ", "NYEY1XG9", "NZ43E0YE", "NZ7OQSCM", "NZNWAQG9", "NZTX08B6", "NZX49EW4", "P0S3SLSF", "P0Y27B4J", "P1G2AJ21", "P2M6MZW4", "P42IY3ZS", "P4EDSNXQ", "P4EDY7CY", "P4UYP0AN", "P4VLXEG9", "P5AD0FXQ", "P5TDP4CM", "P6UP2JFT", "P79QKUOA", "P7ZIODZS", "PCI5S1YV", "PF7PIDF3", "PGP2E44J", "PJ7K1KB6", "PJLU9HDL", "PJNUQ0DL", "PKEDFQCY", "PKTYN2AN", "PLNPPJ7I", "PLPKKHRX", "PN8PYA7I", "PNQ6XOW4", "PPAD6ZCY", "PQD2H4EU", "PQS2HCE2", "PR93B2SF", "PS926C4J", "PSXD7MCM", "PY85XWYV", "PY88VD5P", "PYBDROXQ", "PYQDNICY", "PYW6F6W4", "PZFUYSDL", "PZVNF1H8", "Q0D3R9H8", "Q0EUMGG9", "Q0V6YJJH", "Q1U5MJFT", "Q2L745AG", "Q47A6FDW", "Q48LNN21", "Q4TM4GCM", "Q5B3XVDW", "Q5ZW0WXQ", "Q6PTB2CM", "Q97LYC21", "QCST39B6", "QDFT2NCY", "QDZTLYBD", "QET30JHR", "QFYYIUFT", "QGAIVIE2", "QI88K77K", "QIVE3ZAG", "QJ7Y9DF3", "QJETI7CY", "QJSLEW21", "QKAMXZCY", "QKZ5LR97", "QMS7OSAN", "QPNB1JE2", "QPV0PGB6", "QQS5D2F3", "QRN075BD", "QRPAWPDW", "QSA85K7I", "QSBAFVDL", "QSP31HRX", "QSPL7220", "QSQOGUYV", "QSU5WJF3", "QSV5W9FT", "QUKTD6BD", "QVNTAFCY", "QVP13SG9", "QXB6E3JH", "QXQI41EU", "QXS3JHH8", "QY05NIFT", "QY8OXWYE", "QY9BRTE2", "QYE5NSF3", "QYGLVJ25", "QYILOM21", "QYK066BD", "QYX8UV7I", "R07O3Z5Z", "R0WTGJXQ", "R0XYMZZS", "R3UOBH5P", "R97OTZ5P", "RD8OSA5Z", "RDEQL1BD", "RETMLKW4", "RFT56O7K", "RFVO205Z", "RIT6JFOA", "RJTLNQYV", "RKBJF8CM", "RKEMVAW4", "RKXT8RXQ", "RNN2E197", "RQ0M50W4", "RSB00VDW", "RSTJ7GCM", "RUZMDSW4", "RV00BKDW", "RVLQTMB6", "RWTQJWB6", "RYF69POA", "RYNJN0CM", "RYRIVI21", "RZE0ZMRX", "S00BCPBD", "S09HTUOA", "S0ALOMDW", "S0EZC1BD", "S0PCR7LO", "S0PUSUSF", "S0Q2E6HR", "S18J977K", "S1FHOIJH", "S1FHQOE2", "S1S25J5Z", "S1U2XH5P", "S2KG5ZF3", "S2QWIL25", "S2TH7ZJH", "S2UCWOG9", "S2X576JC", "S2ZSECCY", "S3NTWYEU", "S3S4SEFT", "S4M5RRJH", "S4N2WOHR", "S4TSYGCM", "S4VHZ7EU", "S5B40OXQ", "S5F5I0JH", "S5N4G0F3", "S6RBU0B6", "S9VWY121", "SCFWSTYE", "SCSCD7G9", "SCV2E05P", "SCVWSAYV", "SDNZLSBD", "SEYGQB97", "SFN9ZNDW", "SFNLZ0DL", "SIFH86E2", "SJT2X4H8", "SJT5SQJH", "SJVZKTBD", "SK22M25Z", "SKN2DOH8", "SKNPNBAN", "SKT0Q6G9", "SKTHQBJC", "SKV9NODL", "SKWG6OFT", "SQPTHLE2", "SQPWABYE", "SQTSM4CY", "SR92MYHR", "SREOACLO", "SSD0LBG9", "SSLB19RX", "SST25FHR", "SSYCLZG9", "SUDXDHW4", "SVADTAAG", "SVT2NR5P", "SW7BJRRX", "SWTZJNB6", "SWYWP920", "SXEHGQEU", "SXSZSLBD", "SYLC9PLO", "SYM4ZHF3", "SYNB2SB6", "SYNDMOAN", "SYS5POJC", "SYTGEGFT", "SYXDDXAN", "SYXUJ3SF", "SYXWOB21", "SZFLPADL", "SZK4HZF3", "SZUJ0E7I", "T0DGB4E2", "T0E4794J", "T0F4MTZS", "T0FIK8FT", "T0NGBWEU", "T0Z4K620", "T0Z538SF", "T0ZMELRX", "T12RJOYV", "T1BBCWZS", "T1DSI6SF", "T1UFOKJH", "T1VYETB6", "T1XJ39DW", "T1ZOBI97", "T2DC19HR", "T2EVMAW4", "T2I6E8XQ", "T2NZ7QG9", "T2ZGH07I", "T37SKFW4", "T38TGQ25", "T39PZYHR", "T3IRP1YE", "T3TPZFH8", "T3U4FE7I", "T3U4UKJC", "T3ZXI4ZS", "T4ILHPW4", "T4L9HMBD", "T4NWCNDW", "T4NXYOZS", "T4QA885Z", "T4ROCK4J", "T4SH631B", "T4TEV1FT", "T4U5LQSF", "T4V3VMF3", "T4XAIY5Z", "T4XSGI1B", "T4ZHV84J", "T5KFPECY", "T5PRP2CY", "T5TGKNEU", "T5TQB9LO", "T6F19TH8", "T6FI2QFT", "T6V6B1CY", "T778VE97", "T78KOBZS", "T7VDGSRX", "T7VZH05P", "T974XW7I", "T9LS2XW4", "T9VOYD25", "TC0RBIF3", "TCD3B6F3", "TCFRB8FT", "TCL2KKCM", "TCLC28HR", "TCP0ADAN", "TCPNEP5Z", "TCPO4220", "TCX3BWFT", "TD24WZ7K", "TD8ZQ3XQ", "TDP222CM", "TDU737YE", "TDWRTF7K", "TEV4VJJC", "TEXSLEW4", "TF7H6C25", "TFA4KUJC", "TFSGPHHR", "TGENTGG9", "TGTXH5ZS", "TI1YWBB6", "TIDDFTRX", "TIEE4SFT", "TIF4L520", "TIPMWUBD", "TIQDW3BD", "TITHLT21", "TJ7RZSCY", "TJA61ZCM", "TJEB4VLO", "TJEF1QCM", "TJERI9CY", "TJPGULE2", "TJTODJ4J", "TJU2IYCY", "TJW5CNOA", "TJZ9RLRX", "TK8LGQW4", "TKT4R425", "TKT9GNBD", "TLBGPS7I", "TLZ4PR4J", "TN74TX20", "TN8DJL97", "TNAD2297", "TNFR447K", "TNI4TY21", "TQ1334FT", "TQERAGYE", "TQQWU5DW", "TQZPKUH8", "TR2YCOYV", "TRNAH5G9", "TRU4J8E2", "TRY87CW4", "TS0NDKDL", "TSD9QDBD", "TSFMEALO", "TSFT5M4J", "TSQSBOW4", "TSU4LTJC", "TSUIJJF3", "TSV2SOCY", "TSV40JJH", "TSVMQTB6", "TUEFNLJH", "TULRK5AG", "TUV3LMFT", "TUZKIFYE", "TV7S3NJC", "TVFIU8F3", "TVQ8I5DW", "TVT45EEU", "TVTG8FH8", "TVTK1DYV", "TVU18DHR", "TVWJBQDL", "TWTR0RCY", "TX1WT6DW", "TX93CVFT", "TXDJT8DL", "TXL3C5F3", "TXLCJ8H8", "TXR5WP1B", "TXSR40E2", "TY0EEIFT", "TY24ZH4J", "TY87BZYE", "TY8OON25", "TYDM5JLO", "TYFR9GAG", "TYLJVHDW", "TYNNV2DL", "TYPTN44J", "TYQR31E2", "TYS5MDOA", "TYTF8VCY", "TYUENJF3", "TYV8F4W4", "TYVSCJJH", "TYWJ1YJC", "TYZ4BG21", "TYZOVG25", "TZ2973ZS", "TZ8RHACY", "TZDJJGJC", "TZLGF8H8", "TZTHYB1B", "TZVRQ1CY", "TZWZ38LO", "TZXC7XAG", "U0TPBNEU", "U0VG23RX", "U17LMDF3", "U22HHZ7I", "U270ESCM", "U2DGCTRX", "U2DYIE20", "U2Z0D35P", "U3TM9V1B", "U42MRAJH", "U4P15BYE", "U4YLVUFT", "U5FLFGAG", "U60HJKDL", "U771VLYE", "U9TE05ZS", "UC20E25P", "UCFAIBH8", "UCIO367I", "UCRYJI25", "UDIOTI7K", "UDT92VCM", "UDWE6X97", "UE2DVAJC", "UEFA0TH8", "UERHG27K", "UF7HZFDW", "UFAAPNHR", "UFEDKLJC", "UFQEGN97", "UI7YLC21", "UILTSPLO", "UJEMBLJC", "UJFZ5CSF", "UJM91WCM", "UJNKL5LO", "UJS7KLBD", "UJSQ5LSF", "UKBHQS7K", "UKTUCO20", "UKVUBF4J", "UKZ2G9W4", "UN1H8A7K", "UN7OSH7I", "UPN060CM", "UPNGP7BD", "UQ7G5KB6", "UQAG5RBD", "UQBDZSOA", "UQR750BD", "URQ0OICM", "USTH03DL", "UVTGMJRX", "UVUKWULO", "UW7UQ3AN", "UXEKVVLO", "UXXCCWF3", "UYKCZZFT", "UYSLY4AN", "UYSZWLSF", "UYWY3MEU", "UZ91EJYV", "UZPPLLE2", "UZT1E2YE", "UZV0H1CY", "UZZHJWG9", "V00VECRX", "V09D8A21", "V0DMR9HR", "V0IVP1RX", "V0LEGMSF", "V0MXJ7AN", "V0ZXTR97", "V17DAC25", "V1T09O7I", "V1V9T1H8", "V2LCWFJH", "V2TDI425", "V2XJCQRX", "V38DFS4J", "V41BV4FT", "V48TFBZS", "V4TKRLG9", "V4TOTEE2", "V4UKU9AN", "V4W8U8LO", "V7S5QWW4", "V7U0LE7K", "VCQKAMAG", "VCXMIZH8", "VDI1QZ1B", "VDR43RYV", "VFN7K5G9", "VFTXH2AG", "VG918H1B", "VIK9B2HR", "VIUGU7YE", "VJFC15CY", "VJLOUDE2", "VJLZZKCY", "VJZZ16CM", "VKFOO8F3", "VKMJYOB6", "VLIHSAZS", "VNFCVLXQ", "VNNJNFRX", "VNP42BYE", "VNRDZI20", "VNVH11ZS", "VQEK21AN", "VQPMAQHR", "VQUJ5HB6", "VR0GC6YV", "VRDGW8DL", "VRDVXTRX", "VRLJ7MBD", "VRZGCPYE", "VSNGD2DW", "VST9Q4H8", "VSTCLQJH", "VSTTDEDL", "VUVC7LOA", "VV8DSQ21", "VVAP0RSF", "VVM73MG9", "VVNX0QAN", "VVV1S120", "VW2CLVXQ", "VW8HRBZS", "VWTDOJ4J", "VX072NG9", "VXL12FJC", "VXLPEFJC", "VXPE8USF", "VXTCWKXQ", "VXUZ9YCM", "VY21CAJH", "VY79U0H8", "VY7H20ZS", "VY94BJYV", "VYID0M25", "VYTPCMJH", "VYXC8MCM", "VYZX9HAN", "VZA1CIE2", "VZT1CAEU", "W0MLPBRX", "W0QETBCY", "W0UMMOG9", "W0ZVKG21", "W1832Q21", "W1IV2Y21", "W2FEE0XQ", "W2IJKGZS", "W2LR7PJH", "W491IX5P", "W4FJGR1B", "W4QIC57K", "W4SLI9BD", "W4VE4OCM", "W5TL8JBD", "W6SEBTCY", "W6ZZ1NAN", "W9T674YE", "W9U9TO5Z", "WCBEK8CM", "WCLEKKCY", "WCZRCN1B", "WDP3U225", "WFVJZ81B", "WGD6ONYE", "WGR1A55P", "WIER6LJC", "WJ9QDU7I", "WKBRKF1B", "WKSR8OJH", "WKT3B64J", "WL7EMSXQ", "WLAQPK7K", "WLFROPOA", "WN83SP4J", "WNEVT721", "WNI10F5P", "WQEOKVH8", "WQTRPOOA", "WRDL7DB6", "WRVLX3RX", "WSPLQUB6", "WSRQ527I", "WSUVFLDW", "WU894D5Z", "WU8EUACY", "WU8R2X1B", "WUWV9V25", "WVLZTVAN", "WVM35FEU", "WWT6YDYE", "WXT33O20", "WXTFCQ97", "WXZMEWG9", "WY0VGKDW", "WYTVBO20", "WZRQ727K", "WZVVPBDW", "X2XZ7HJH", "X3IEPVYV", "X3IYFM7K", "X40MTGE2", "X426KKLO", "X47BVE4J", "X4LHUZLO", "X4S4NLBD", "X4TM9XXQ", "X5MWNKH8", "X5MXPWCY", "X5T4YJRX", "X5ZZI1JC", "X7THT0LO", "X9THTG5Z", "XCF9BQFT", "XCVAXXOA", "XEEBH725", "XEZZFQOA", "XF17P7H8", "XFP7PQHR", "XG8EOWYV", "XGDWY9H8", "XJSEQGDL", "XJXXZMCY", "XK7CKKSF", "XKD4OTRX", "XKU613LO", "XKZXF6CY", "XNTYY17I", "XPUM18E2", "XQD4VDBD", "XQQ453BD", "XQRTVXRX", "XREZH2JC", "XS0W5LHR", "XSIVF797", "XSKX7ECY", "XSZZ50OA", "XUW4DVBD", "XV2A3AJH", "XVVFWGW4", "XWEX09CM", "XWGBOL4J", "XY045CRX", "XYNMIJEU", "XYVW61H8", "XZ8ZUX1B", "XZFWFBHR", "Y07KGSXQ", "Y0LXTEOA", "Y0QF385Z", "Y3VFB05Z", "Y44CM0YV", "Y4TCWQYV", "Y4TT5J97", "Y4XD0EW4", "Y69S40G9", "Y7VCVAYE", "Y9ZC7FYV", "YDEC6GYV", "YFVW6X7K", "YITXJOOA", "YJB9E821", "YKD9CE25", "YNBTEA97", "YNUXS11B", "YPMWXHFT", "YSEWWSF3", "YUFX2R1B", "YWUFKH5P", "YXSXECJH", "YYDX9YOA", "YYFX07OA", "YYNWE0FT", "YYRT4K97", "YYTWN1F3", "YZ7W7W7K", "YZPD95W4", "YZRCERYE", "YZZRZVRX", "Z043JB7I", "Z0D8JWAN", "Z0EG8721", "Z0IMFF5P", "Z0SOP8RX", "Z0TUZJBD", "Z0U4IIOA", "Z0WV3I5P", "Z0Z5A4ZS", "Z1BP2825", "Z1FMX75Z", "Z1TG2H25", "Z1U39L7I", "Z1VNVOCM", "Z2QGHN4J", "Z2VYMBDW", "Z38VBA5P", "Z3FPUDG9", "Z40H4XCY", "Z476WX25", "Z48CRD5P", "Z4FJ5TYE", "Z4IS51YV", "Z4TVR45Z", "Z4VJ5AYV", "Z4VPNTB6", "Z4WJMCYE", "Z4ZTV97I", "Z6LNBKCY", "Z6N66JE2", "Z746LT4J", "Z7FTQ8W4", "Z7W6M321", "Z7XJVKYV", "ZC16F2EU", "ZCAX2NHR", "ZCPP4221", "ZCT6FAE2", "ZCXPID4J", "ZCY63B4J", "ZD7PUC21", "ZDU6UU20", "ZE7GHX20", "ZEIGGO4J", "ZFKCMXE2", "ZFWC6F7I", "ZGQVT8G9", "ZGV0BHXQ", "ZI7PWKB6", "ZIAPWRBD", "ZIEXBEHR", "ZIFU6IJC", "ZILUZPJC", "ZITJU4YE", "ZIW6L320", "ZJ1VS9G9", "ZJ26EF25", "ZJAI1ZCY", "ZJNV9M5Z", "ZJPJNBYE", "ZJU880AG", "ZK2TGIW4", "ZKLZ6FF3", "ZKNPG7BD", "ZKSRVHH8", "ZKV6CD21", "ZKWPQ54J", "ZKZYNZDL", "ZNXQED97", "ZNZHPMXQ", "ZPSZXEFT", "ZPZPPYBD", "ZQFRKBHR", "ZQM181LO", "ZQNHMFCY", "ZQTRKSH8", "ZS1R57H8", "ZSEV1U5Z", "ZSIC5I7K", "ZSLYF7DL", "ZUEXSEH8", "ZUV1GTLO", "ZUVNU1CY", "ZV4GSR25", "ZVB6YRE2", "ZVFC56EU", "ZVKIAECM", "ZVN6YJEU", "ZVS65CEU", "ZVTC5EE2", "ZVXGRD4J", "ZWTDIV1B", "ZXB32S7I", "ZXQXJ6HR", "ZXUNLYCM", "ZY0HYDXQ", "ZY7I8SCY", "ZY9V10G9", "ZYEPF1B6", "ZYFKZ8W4", "ZYFM4TZS", "ZYI3AM7K", "ZYR6UK4J", "ZYT190LO", "ZYTUMOOA", "ZYU44CDL", "ZYUCQO5Z", "ZYUP6HBD", "ZYV3ZX7K", "ZYXM6Y5Z", "ZZ7OQ7RX", "ZZ8IQACY", "ZZP37DAN", "ZZPSEBYE", "ZZX3GXAG"}
        '    Dim clsBD As New ClasseAccesBD
        '    Dim ConjuntLinies As System.IO.StreamReader
        '    Dim VDades() As String, VSQL() As String, Assistencia As Integer
        '    ConjuntLinies = New System.IO.StreamReader(CamiFitxer)
        '    Dim Linia As String
        '    Linia = Trim(ConjuntLinies.ReadLine())
        '    ReDim VSQL(0)
        '    While Not Linia Is Nothing
        '        Assistencia = 0
        '        VDades = Linia.Split(vbTab)
        '        'VDades = [Tipo(idOrigen)0, Club(Carrec)1, Nombre(nom)2, Cognoms(cognoms)3, Matrícula(Mobil)4, Manga(idAlta)5]
        '        Select Case VDades(0)
        '            Case "CLUB"
        '                VDades(0) = 1
        '            Case "Servicios"
        '                VDades(0) = 2
        '            Case "VIP"
        '                VDades(0) = 3
        '            Case "Organización"
        '                VDades(0) = 4
        '            Case "PADDOCK"
        '                VDades(0) = 5
        '        End Select
        '        If VSQL(0) <> "" Then ReDim Preserve VSQL(VSQL.Length)
        '        VSQL(VSQL.Length - 1) = "INSERT INTO EEContactes (idFira, idContacte, idOrigen, idTipusContacte, idAlta, Nom, Cognoms, Mobil, Email, Carrec, NIT, NITactivat, Password, Procedencia, SectorInteres, NickTwitter, NickFacebook, WebPersonal, Blog, Data) " &
        '                                "VALUES(" & IDFira & "," & PrimerID & ",'" & clsBD.Cometes(Trim(VDades(0))) & "',0,'" & clsBD.Cometes(Trim(VDades(5))) & "','" & clsBD.Cometes(Trim(VDades(2))) & "','" & clsBD.Cometes((VDades(3).Replace(" ", "¦"))) & "','" & clsBD.Cometes(Trim(VDades(4))) & "','','" & clsBD.Cometes(Trim(VDades(1))) & "','" & VNITs(PrimerID - 1) & "',0,'','','','','','','','')"
        '        Linia = ConjuntLinies.ReadLine()
        '        PrimerID += 1
        '    End While
        '    ConjuntLinies.Close()
        '    Return clsBD.BaseDades(2, VSQL, , 3, IDFira, False)
        'Catch ex As Exception
        '    '
        '    Return False
        'End Try
    End Function

    Public Sub MeterFicherosBootstrap(Optional ByRef bootstrap_min_css As Literal = Nothing, Optional ByRef bootstrap_datetimepicker_min_css As Literal = Nothing, Optional ByRef jquery_1_9_1_min_js As Literal = Nothing, Optional ByRef bootstrap_min_js As Literal = Nothing, Optional ByRef bootstrap_datetimepicker_js As Literal = Nothing, Optional ByRef bootbox_min_js As Literal = Nothing, Optional ByRef bootstrap_datetimepicker_es_js As Literal = Nothing, Optional ByVal FicarNouPath As String = "../../Bootstrap/", Optional ByRef bootstrap_datetimepicker_fr_js As Literal = Nothing, Optional ByRef icheck_bootstrap_min_css As Literal = Nothing, Optional ByRef segmented_controls_css As Literal = Nothing, Optional ByRef bootstrap_min_js2 As Literal = Nothing, Optional ByRef jquery_ui_min_css As Literal = Nothing, Optional ByRef jquery_ui_min_js As Literal = Nothing, Optional ByRef particles_js As Literal = Nothing, Optional ByRef particles_app_js As Literal = Nothing, Optional ByRef font_awesome_css As Literal = Nothing, Optional ByRef loader_css As Literal = Nothing, Optional ByRef iframe_sizer_min_js As Literal = Nothing, Optional ByRef iframe_resizer_contentwindow_min_js As Literal = Nothing)

        If Not IsNothing(bootstrap_min_css) Then bootstrap_min_css.Text = "<link href='" & FicarNouPath & "css/bootstrap.min.css' rel='stylesheet' media='screen'>"

        If Not IsNothing(bootstrap_datetimepicker_min_css) Then bootstrap_datetimepicker_min_css.Text = "<link href='" & FicarNouPath & "css/bootstrap-datetimepicker.min.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(jquery_1_9_1_min_js) Then jquery_1_9_1_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/jquery-1.9.1.min.js' charset='UTF-8'></script>"
        If Not IsNothing(bootstrap_min_js) Then bootstrap_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "/js/bootstrap.min.js'></script>"
        If Not IsNothing(bootstrap_datetimepicker_js) Then bootstrap_datetimepicker_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/bootstrap-datetimepicker.js' charset='UTF-8'></script>"
        If Not IsNothing(bootbox_min_js) Then bootbox_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/bootbox.min.js'></script>"
        If Not IsNothing(bootstrap_datetimepicker_es_js) Then bootstrap_datetimepicker_es_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "locales/bootstrap-datetimepicker.es.js' charset='UTF-8'></script>"
        If Not IsNothing(bootstrap_datetimepicker_fr_js) Then bootstrap_datetimepicker_fr_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "locales/bootstrap-datetimepicker.fr.js' charset='UTF-8'></script>"
        If Not IsNothing(icheck_bootstrap_min_css) Then icheck_bootstrap_min_css.Text = "<link href='" & FicarNouPath & "css/icheck-bootstrap.min.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(segmented_controls_css) Then segmented_controls_css.Text = "<link href='" & FicarNouPath & "css/segmented-controls2.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(bootstrap_min_js2) Then bootstrap_min_js2.Text = "<script type='text/javascript' src='https://netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js'></script>"
        If Not IsNothing(jquery_ui_min_css) Then jquery_ui_min_css.Text = "<link href='" & FicarNouPath & "css/jquery-ui.min.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(jquery_ui_min_js) Then jquery_ui_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/jquery-ui.min.js'></script>"
        If Not IsNothing(particles_js) Then particles_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/particles.js' charset='UTF-8'></script>"
        If Not IsNothing(particles_app_js) Then particles_app_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/app.js' charset='UTF-8'></script>"
        If Not IsNothing(font_awesome_css) Then font_awesome_css.Text = "<link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.0.13/css/all.css' integrity='sha384-DNOHZ68U8hZfKXOrtjWvjxusGo9WQnrNx2sqG0tfsghAvtVlRW3tvkXWZh58N9jp' crossorigin='anonymous'>"
        If Not IsNothing(loader_css) Then loader_css.Text = "<link href='" & FicarNouPath & "css/loader.css' rel='stylesheet' media='screen'>"
        If Not IsNothing(iframe_sizer_min_js) Then iframe_sizer_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/iframeSizer.min.js' charset='UTF-8'></script>"
        If Not IsNothing(iframe_resizer_contentwindow_min_js) Then iframe_resizer_contentwindow_min_js.Text = "<script type='text/javascript' src='" & FicarNouPath & "js/iframeResizer.contentWindow.min.js' charset='UTF-8'></script>"
    End Sub


    'Public Function CarregaDadesJose(ByVal CamiFitxer As String, ByVal IDFira As Integer, ByVal PrimerID As Integer) As Boolean
    '    Try
    '        Dim VNITs As String() = New String(1499) {"001XO2EU", "00BK7TF3", "03BLU3JC", "04F05TYV", "04PP6PDL", "04QTUTAG", "05SFY8RX", "05UKGAFT", "06QT1MAG", "06VX6KEU", "09Q12OW4", "0C0DLLZS", "0CRLH2OA", "0CTX4T20", "0E7LV7JH", "0G8XFN25", "0J7SLXLO", "0JYS4ELO", "0KIXCM21", "0KKP51DW", "0LY0ZIYE", "0N28PVXQ", "0QBX7RE2", "0QE8XNXQ", "0QU8CYCY", "0SRFQ0B6", "0SS85TCM", "0VSXY0E2", "0VZFT4BD", "0WL1TXW4", "0WNFJ7B6", "0XNFS5BD", "0XNL2VJC", "0XRTBJAN", "0XRY8ASF", "0Y087DXQ", "0YEFRZB6", "0YFDDTZS", "0Z2D33ZS", "0ZFF0XBD", "10L7MPJC", "13T6SCFT", "13V6SMF3", "148BCXDL", "15X2ICG9", "17UET3LO", "1DFBAADW", "1G77TNJH", "1IDJ84E2", "1JL695F3", "1JNUZDCM", "1RF2HDG9", "1SSJ0CE2", "1ST20UG9", "1UZ1DYBD", "1VEF01AG", "1WNFQBAG", "1YVF9ZAN", "1YZ16YB6", "1Z1F7UAG", "1ZNJLJEU", "219FAA25", "21TVCCZS", "22RGQASF", "22TA00LO", "23QJKOW4", "24PX7HRX", "24Z3BQOA", "2CAF324J", "2CPJ35W4", "2DMQQCXQ", "2DZLS35P", "2GILAL5P", "2JNL9M5P", "2KWX6IRX", "2KWZLX97", "2NIZE497", "2XNG8SSF", "2XVF3D21", "2Y7Z4E97", "2YMV4KZS", "2YTQY4XQ", "2YYFUB4J", "2Z9F5A20", "40U169AG", "45920QXQ", "45M1F7AN", "45R766ZS", "4EFXC75P", "4FWE6F7K", "4KA15AAG", "4WXEOV7I", "4YUUX7YV", "4ZIR5Y20", "7017FOLO", "70F34LXQ", "70T0TBOA", "73PUAHRX", "73QFS3FT", "74IKVI7I", "74VWR4W4", "75ZN05XQ", "77PWQ5W4", "7CMKSJDW", "7CVZ3X7K", "7DB3SV5Z", "7DMOS7AN", "7DVW6F97", "7EFSJ8ZS", "7ESFT2FT", "7ETFTCF3", "7F7FIDFT", "7F7GKNJH", "7FDFFNYE", "7FNOHBAG", "7FUGA1W4", "7GSFREF3", "7GZ3A35P", "7GZGJSW4", "7I7KLFDL", "7IPCL225", "7IS0ZOJH", "7J0OR8AN", "7J8GITW4", "7JFDXTH8", "7JXF9WF3", "7JYCE925", "7KAG8UJC", "7KLSS3EU", "7KWCBX4J", "7L7UK7RX", "7NDCSG4J", "7NQI085Z", "7QN7Y5LO", "7RG013OA", "7S0GB0W4", "7S9I1X5P", "7UFN50XQ", "7V8CSQ20", "7VYF1UFT", "7WUTXQSF", "7X2C3F20", "7XQOZTAG", "7XZC3G21", "7YBGWSOA", "7YFUSZRX", "7YNO9QAN", "7YSCAY4J", "7YZKNQ7I", "7ZGW9MW4", "7ZPGAXJH", "80VQ8125", "81AWXN5P", "81TD9D7K", "81WT5I5P", "81WTXQ5P", "82IQIM20", "82T7RJ97", "83INGS21", "84AE661B", "84TYJBXQ", "84W3PRZS", "85MLPWCM", "89FYU0XQ", "89U77397", "8CITE95P", "8EIQQ1YE", "8EYQQIYV", "8JT682AG", "8K8W7D5P", "8KQNRL25", "8LY7ZB97", "8NBDSS7I", "8NYNZ921", "8S8Q5P4J", "8SS6ISAG", "8U0TI6YE", "8VFLANCY", "8VZ60HAN", "8X21WVXQ", "8XUA4HE2", "8XYEWG1B", "8XYWYW5Z", "8Y8Q9ZYV", "8Y8T9WYV", "8YIDAC7K", "8YNL8DCM", "8YNS67B6", "8YT24EDL", "907VR0HR", "90NXJJ7K", "90TT9UG9", "917DJLYE", "91RA2I20", "91XAAB21", "92PV1QHR", "92WAI321", "942G825Z", "95TYXV1B", "9CDVI9HR", "9CWDSCYE", "9EDLDUXQ", "9EIQJAZS", "9GVYTWJH", "9ISXKG7I", "9J1YBEJH", "9JDTSBG9", "9KFT8VG9", "9NTD22YE", "9Q9VAYH8", "9QPDABYV", "9VTY3MJH", "9WAYNJOA", "9XVVJPH8", "9YIXU67I", "9YQA0L21", "9YRSWXRX", "9YVDBAYV", "9YZA0P25", "9ZXUAD97", "A0GNDQ1B", "A0LURPLO", "A0TAGGCM", "A0TR13DW", "A0TV6FAG", "A1QZAL20", "A2DZIE21", "A2SI77G9", "A3FZGK25", "A3VNFX7K", "A47ZMZ4J", "A4UAYYCM", "A6URJLDW", "AE9NGU7I", "AFUZ6U25", "AJBR9VDW", "AJPNVMOA", "AK820WYV", "AK83VTW4", "AKQKD6H8", "AKTZR420", "AL43UUW4", "AN801FSF", "APEA6QCM", "ARXF5ZZS", "ASNN0VJC", "ASTA5RCM", "ASVKQCHR", "AUTR2RDL", "AVZK8UHR", "AWINOM7I", "AWNHJ5B6", "AWTALXXQ", "AXWM0OFT", "AYIKX097", "AYXZR5E2", "AZLVG5AG", "AZXMH7FT", "B0NCC3W4", "B2ZBRFYE", "B5DWI9JH", "B9T8YT25", "BDNWN71B", "BDXOWZZS", "BG78FC25", "BI7JHSXQ", "BI93SFLO", "BIV887EU", "BK8S0P97", "BKER8XG9", "BKRW5P1B", "BKV316LO", "BKZWQ1JH", "BL2BZOYV", "BN7OV0ZS", "BNVWM81B", "BQ8BAWYE", "BR9WH5JC", "BSNT5OHR", "BVU8YHEU", "BWI8PY21", "BWP8P225", "BWUVOE7I", "BXBC4BW4", "BXTEY45P", "BYN8RWE2", "BYPWPXJC", "BYS39YLO", "BZFV047K", "BZVWJ8JH", "D0BW2NRX", "D0Q3Z3B6", "D17D3FDW", "D1D23L1B", "D1IKX95Z", "D1T6T4H8", "D2NGP5LO", "D3FLW6EU", "D3GHPSYV", "D3TLWEE2", "D4N9BKOA", "D4S3HLB6", "D4TFLGSF", "D50FCPSF", "D7AEMZ25", "D99Y7C97", "DCDHAWAN", "DCF2CC1B", "DCFKES5Z", "DCV9DWJC", "DDLW2KCY", "DDWHSEAN", "DF2E6F25", "DIS6B5HR", "DJ94S0G9", "DKI1Q67I", "DKV9ALOA", "DKW8OOF3", "DLZ1P97K", "DNREZI21", "DPL8XFF3", "DQV98TLO", "DRW37VB6", "DSEDDUDL", "DST3QJBD", "DSXHGKYE", "DUQHKMAN", "DUT9NMJC", "DVIKN95P", "DVVH0ZAG", "DXE6JEH8", "DXNL4YEU", "DXPDTPDW", "DXY6JXHR", "DY21ZZ7K", "DY4IFUW4", "DYAH98YV", "DYNI63W4", "DYNLEWE2", "DYV24K1B", "DYV41RG9", "DYVK605Z", "DZ710W7I", "DZ74AIG9", "DZ8KWA5Z", "DZMFDOSF", "E0B1OVDL", "E0LRZMBD", "E0XEY6JC", "E0XUKWFT", "E0XVM6JH", "E1FMLGAN", "E1R7AI25", "E2I8C1RX", "E2W1E3CY", "E2YVGTOA", "E4LI67DW", "E4T8LNSF", "E4TA52YE", "E4TBWFHR", "E4VB0GW4", "E5N7KWEU", "E5ZDGRF3", "E60S9LHR", "ECL9DAG9", "ECLVDFJH", "EDQR3N97", "EEP9VSG9", "EFBVK3JC", "EGZDA35Z", "EIT1D4CY", "EIT53FAN", "EITAUDYE", "EITU4CFT", "EIVU4MF3", "EJBI7VDL", "EJD8KDB6", "EJEBXVH8", "EJQ813BD", "EJXRM3SF", "EKP15PDW", "ENIDOF5P", "ENMR1OSF", "EPNB4OH8", "EPTRPWBD", "EQEQ7QEU", "EQK9HXEU", "EQTR9GSF", "EQVQFRG9", "ERLIWHDW", "ERQ1WYDW", "ERQBM6H8", "ES71FFDW", "ES79L2G9", "ESAB5NH8", "ESAN9NZS", "ESEVL2JC", "EST72EEU", "ESW72ME2", "ESZ15CCY", "ESZ5VNAN", "EU7KUSCM", "EUD79E20", "EULUL5F3", "EUUQP8EU", "EVE2WCLO", "EVL93KG9", "EVN7S025", "EVTPMARX", "EVUS8MHR", "EX1UC4FT", "EX1VEEJH", "EXB2VDLO", "EXM1LWCY", "EXN8S5B6", "EXT8UJRX", "EXU5B0AG", "EYEZRUDL", "EYF8WCSF", "EYK5MPAG", "EYNKJFCY", "EYNQGQG9", "EYT70O21", "EYT7BH25", "EYWKJ3CM", "EYYUAT7I", "EZF80XB6", "EZKD8ZF3", "EZT2CWLO", "EZTDHGFT", "F0A52ERX", "F0DBY9JC", "F0R58I21", "F0TJ6RAG", "F18B5A5Z", "F28QDD5P", "F2LYEUCM", "F2T8CJH8", "F4F86C1B", "F4I8PT1B", "F4TY44CM", "F4TY4GCY", "F4VBL8OA", "F5SSG2FT", "F5TOCGSF", "F7AVIFXQ", "F7S8F31B", "F7ZOUYSF", "F97KYC20", "F9GP7L97", "FC4KJR20", "FC9NFTE2", "FCFN3FB6", "FDVL2TSF", "FEAPQ297", "FEB5H820", "FEE5B5RX", "FFF5AXBD", "FFLFZHDW", "FFVXZODL", "FG84OP97", "FG9QYYHR", "FJIGA2XQ", "FJLF97DW", "FJTX9EDL", "FK1A64F3", "FK7SQH7K", "FKZBMT5Z", "FLG7P37K", "FLIQLF5Z", "FMUJO9AG", "FNRS8Z7K", "FNT78I7I", "FNTTMB1B", "FPEJW1AG", "FPU51HEU", "FQTGM4CM", "FR7LBKSF", "FR8NCZYV", "FRD8M9H8", "FRNBHVJH", "FSAT0UJH", "FSDG5LCM", "FSF52OE2", "FSF83BHR", "FUNNPJE2", "FUUBNKJC", "FVFBNS5Z", "FVFN1TYE", "FVTNMWB6", "FVTOW7W4", "FVUSRE7I", "FW8KPQ25", "FWP8YBYE", "FXF5SFBD", "FXZFHZDW", "FY7BPNJH", "FY9NBJYE", "FYD4XG97", "FYFLJCSF", "FYLO6XW4", "FYRNKRYV", "FYYXRWDL", "FYZ50P20", "FYZYWCCM", "FZ2BUZOA", "FZ8ODFSF", "FZNXY0DW", "FZS0CYLO", "FZT07CZS", "FZZ55P25", "G0G3TL97", "G4TJV64J", "GC2PZ25Z", "GC71D7RX", "GCF3SM97", "GIZ6K97K", "GJAK5RSF", "GK730E97", "GKEP7U5Z", "GKI6BI7K", "GKT1OWRX", "GLMUMCXQ", "GNT6S17K", "GSTJ6V4J", "GYDPQ15P", "GYN15FRX", "GYN6AJ7K", "GYZMXFYV", "GYZMXYYE", "GZBMEHYE", "H6P21DAG", "HVS2TSAN", "HXTOSWBD", "I0QNGDSF", "I0TMKO20", "I0VMJF4J", "I1EM2721", "I2VXEHXQ", "I4IFC67I", "I4XIMD97", "ICBSIA4J", "ICFSJK21", "ICNXFGXQ", "ICWS4325", "ICZMJP20", "IDDMUE20", "IDFFTP7I", "IDZ63897", "IDZYPT5P", "IF842A5P", "IIBLKS7I", "IJFNXX97", "IK2SBH4J", "IK7SRC21", "IKASQ24J", "IKSMCW20", "IKUPL7YE", "IKWSCV25", "IKXSRB20", "IN8CKL97", "INALSK7I", "IQRXXYXQ", "K0F2YIJC", "K0S172FT", "K1SALSAN", "K2D279JC", "K2PX7SG9", "K47XX2G9", "K4AWIRB6", "K5B1GTFT", "K5F6XSDW", "K5Q1G3F3", "KJV6QODL", "KKN2QVJH", "KRSAESAG", "KRY1FUFT", "KRY2H4JH", "KSNWB5BD", "KST60EDL", "KX7Z7GHR", "KYLXPAG9", "KZXAGXAN", "L012ZBBD", "L0S3M7G9", "L0VF2TLO", "L1M8ORJH", "L1Z5V6CM", "L2TPPWLO", "L2VAKPZS", "L3WXPCYV", "L4DKZ4EU", "L5XDI1G9", "L9TY2RW4", "LCS5KHCM", "LCS5KTCY", "LDE2LIB6", "LETVPWSF", "LFEIKLJH", "LGNC80DL", "LIBFBWHR", "LJM5XKHR", "LJT2KJB6", "LJTCQIDL", "LK7QN3AG", "LKEFJCLO", "LKNKSJE2", "LKPGNDAG", "LPNGWBAN", "LQYFAXHR", "LRE5MVHR", "LRX81VOA", "LS0F3LH8", "LSLK03EU", "LSQ3L8G9", "LSTF34HR", "LU15UJCY", "LUTFSFHR", "LUTI7FOA", "LXEVLQCM", "LY1GDUAN", "LYFCGSDL", "LYMUEFEU", "LYTHEPF3", "LYTUENE2", "LZK5F2HR", "LZRA36ZS", "M0AK9UJH", "M0EKTROA", "M0ZS6IAG", "M17EEKBD", "M2AW9IEU", "M3FZPTYE", "M42KLZOA", "M4I7J2XQ", "M4ZXLYSF", "M5MWKFE2", "MCAETERX", "MF8OZXDL", "MI8EW2BD", "MJKWUXEU", "MJT7ABXQ", "MJWCGRZS", "MKNK8VJH", "MKQKQDJH", "MLBEKNRX", "MMUSO0AG", "MPNW1YE2", "MQTEVWB6", "MQVKFJJC", "MRASEAAG", "MSL75UCM", "MUBZIHYV", "MVNEM5B6", "MWIZY1YV", "MY7KGNJH", "MYXSYXAN", "MZ0K3HOA", "MZD7QLCY", "MZXOY9DW", "N0F0KQFT", "N0F6375P", "N0FQTNCM", "N0G5F65Z", "N0SSO4DL", "N1EBLKAG", "N1K0QXEU", "N1T01J4J", "N1TVEWB6", "N2FORPOA", "N2IJR797", "N2N7M2DW", "N2W0CRH8", "N2ZW4NAN", "N3QYZ6H8", "N3SJUJG9", "N42MCZ7I", "N483WZYV", "N4B0N821", "N4K9PPAN", "N4MOYWCY", "N57WIIG9", "N5FOP5CY", "N5RX80B6", "N6002IF3", "N6SB14AG", "N7Y0M921", "NC9FFTEU", "NC9JD0G9", "NCK0BZFT", "NCM1ROSF", "NDF6SS5Z", "NEZ0TRF3", "NFW62I5Z", "NINQDFCY", "NIQ5L5DW", "NIUB39AN", "NJNOI0CM", "NJTLX4HR", "NJTOZVCY", "NJUQIYCM", "NJVYGPH8", "NJZ0EG20", "NJZI8VRX", "NKM75JDW", "NKSSNGDW", "NKW7NQDL", "NNA5ON5P", "NNWJJF97", "NNZ0T625", "NPNIP5BD", "NQTWCFAN", "NQY5UWDW", "NQZQM6CY", "NRU9E0AN", "NRYSWWDL", "NS905YH8", "NSFO7NCY", "NSLIBCB6", "NSMVE1LO", "NSPFNLEU", "NST3LZJH", "NSTNW1F3", "NSUL5DH8", "NSZ9XHAN", "NU03NSJC", "NUTO201B", "NWW6KQ5P", "NXA5YN5Z", "NXDV4DBD", "NXV0G7EU", "NY9BRQXQ", "NYEY1XG9", "NZ43E0YE", "NZ7OQSCM", "NZNWAQG9", "NZTX08B6", "NZX49EW4", "P0S3SLSF", "P0Y27B4J", "P1G2AJ21", "P2M6MZW4", "P42IY3ZS", "P4EDSNXQ", "P4EDY7CY", "P4UYP0AN", "P4VLXEG9", "P5AD0FXQ", "P5TDP4CM", "P6UP2JFT", "P79QKUOA", "P7ZIODZS", "PCI5S1YV", "PF7PIDF3", "PGP2E44J", "PJ7K1KB6", "PJLU9HDL", "PJNUQ0DL", "PKEDFQCY", "PKTYN2AN", "PLNPPJ7I", "PLPKKHRX", "PN8PYA7I", "PNQ6XOW4", "PPAD6ZCY", "PQD2H4EU", "PQS2HCE2", "PR93B2SF", "PS926C4J", "PSXD7MCM", "PY85XWYV", "PY88VD5P", "PYBDROXQ", "PYQDNICY", "PYW6F6W4", "PZFUYSDL", "PZVNF1H8", "Q0D3R9H8", "Q0EUMGG9", "Q0V6YJJH", "Q1U5MJFT", "Q2L745AG", "Q47A6FDW", "Q48LNN21", "Q4TM4GCM", "Q5B3XVDW", "Q5ZW0WXQ", "Q6PTB2CM", "Q97LYC21", "QCST39B6", "QDFT2NCY", "QDZTLYBD", "QET30JHR", "QFYYIUFT", "QGAIVIE2", "QI88K77K", "QIVE3ZAG", "QJ7Y9DF3", "QJETI7CY", "QJSLEW21", "QKAMXZCY", "QKZ5LR97", "QMS7OSAN", "QPNB1JE2", "QPV0PGB6", "QQS5D2F3", "QRN075BD", "QRPAWPDW", "QSA85K7I", "QSBAFVDL", "QSP31HRX", "QSPL7220", "QSQOGUYV", "QSU5WJF3", "QSV5W9FT", "QUKTD6BD", "QVNTAFCY", "QVP13SG9", "QXB6E3JH", "QXQI41EU", "QXS3JHH8", "QY05NIFT", "QY8OXWYE", "QY9BRTE2", "QYE5NSF3", "QYGLVJ25", "QYILOM21", "QYK066BD", "QYX8UV7I", "R07O3Z5Z", "R0WTGJXQ", "R0XYMZZS", "R3UOBH5P", "R97OTZ5P", "RD8OSA5Z", "RDEQL1BD", "RETMLKW4", "RFT56O7K", "RFVO205Z", "RIT6JFOA", "RJTLNQYV", "RKBJF8CM", "RKEMVAW4", "RKXT8RXQ", "RNN2E197", "RQ0M50W4", "RSB00VDW", "RSTJ7GCM", "RUZMDSW4", "RV00BKDW", "RVLQTMB6", "RWTQJWB6", "RYF69POA", "RYNJN0CM", "RYRIVI21", "RZE0ZMRX", "S00BCPBD", "S09HTUOA", "S0ALOMDW", "S0EZC1BD", "S0PCR7LO", "S0PUSUSF", "S0Q2E6HR", "S18J977K", "S1FHOIJH", "S1FHQOE2", "S1S25J5Z", "S1U2XH5P", "S2KG5ZF3", "S2QWIL25", "S2TH7ZJH", "S2UCWOG9", "S2X576JC", "S2ZSECCY", "S3NTWYEU", "S3S4SEFT", "S4M5RRJH", "S4N2WOHR", "S4TSYGCM", "S4VHZ7EU", "S5B40OXQ", "S5F5I0JH", "S5N4G0F3", "S6RBU0B6", "S9VWY121", "SCFWSTYE", "SCSCD7G9", "SCV2E05P", "SCVWSAYV", "SDNZLSBD", "SEYGQB97", "SFN9ZNDW", "SFNLZ0DL", "SIFH86E2", "SJT2X4H8", "SJT5SQJH", "SJVZKTBD", "SK22M25Z", "SKN2DOH8", "SKNPNBAN", "SKT0Q6G9", "SKTHQBJC", "SKV9NODL", "SKWG6OFT", "SQPTHLE2", "SQPWABYE", "SQTSM4CY", "SR92MYHR", "SREOACLO", "SSD0LBG9", "SSLB19RX", "SST25FHR", "SSYCLZG9", "SUDXDHW4", "SVADTAAG", "SVT2NR5P", "SW7BJRRX", "SWTZJNB6", "SWYWP920", "SXEHGQEU", "SXSZSLBD", "SYLC9PLO", "SYM4ZHF3", "SYNB2SB6", "SYNDMOAN", "SYS5POJC", "SYTGEGFT", "SYXDDXAN", "SYXUJ3SF", "SYXWOB21", "SZFLPADL", "SZK4HZF3", "SZUJ0E7I", "T0DGB4E2", "T0E4794J", "T0F4MTZS", "T0FIK8FT", "T0NGBWEU", "T0Z4K620", "T0Z538SF", "T0ZMELRX", "T12RJOYV", "T1BBCWZS", "T1DSI6SF", "T1UFOKJH", "T1VYETB6", "T1XJ39DW", "T1ZOBI97", "T2DC19HR", "T2EVMAW4", "T2I6E8XQ", "T2NZ7QG9", "T2ZGH07I", "T37SKFW4", "T38TGQ25", "T39PZYHR", "T3IRP1YE", "T3TPZFH8", "T3U4FE7I", "T3U4UKJC", "T3ZXI4ZS", "T4ILHPW4", "T4L9HMBD", "T4NWCNDW", "T4NXYOZS", "T4QA885Z", "T4ROCK4J", "T4SH631B", "T4TEV1FT", "T4U5LQSF", "T4V3VMF3", "T4XAIY5Z", "T4XSGI1B", "T4ZHV84J", "T5KFPECY", "T5PRP2CY", "T5TGKNEU", "T5TQB9LO", "T6F19TH8", "T6FI2QFT", "T6V6B1CY", "T778VE97", "T78KOBZS", "T7VDGSRX", "T7VZH05P", "T974XW7I", "T9LS2XW4", "T9VOYD25", "TC0RBIF3", "TCD3B6F3", "TCFRB8FT", "TCL2KKCM", "TCLC28HR", "TCP0ADAN", "TCPNEP5Z", "TCPO4220", "TCX3BWFT", "TD24WZ7K", "TD8ZQ3XQ", "TDP222CM", "TDU737YE", "TDWRTF7K", "TEV4VJJC", "TEXSLEW4", "TF7H6C25", "TFA4KUJC", "TFSGPHHR", "TGENTGG9", "TGTXH5ZS", "TI1YWBB6", "TIDDFTRX", "TIEE4SFT", "TIF4L520", "TIPMWUBD", "TIQDW3BD", "TITHLT21", "TJ7RZSCY", "TJA61ZCM", "TJEB4VLO", "TJEF1QCM", "TJERI9CY", "TJPGULE2", "TJTODJ4J", "TJU2IYCY", "TJW5CNOA", "TJZ9RLRX", "TK8LGQW4", "TKT4R425", "TKT9GNBD", "TLBGPS7I", "TLZ4PR4J", "TN74TX20", "TN8DJL97", "TNAD2297", "TNFR447K", "TNI4TY21", "TQ1334FT", "TQERAGYE", "TQQWU5DW", "TQZPKUH8", "TR2YCOYV", "TRNAH5G9", "TRU4J8E2", "TRY87CW4", "TS0NDKDL", "TSD9QDBD", "TSFMEALO", "TSFT5M4J", "TSQSBOW4", "TSU4LTJC", "TSUIJJF3", "TSV2SOCY", "TSV40JJH", "TSVMQTB6", "TUEFNLJH", "TULRK5AG", "TUV3LMFT", "TUZKIFYE", "TV7S3NJC", "TVFIU8F3", "TVQ8I5DW", "TVT45EEU", "TVTG8FH8", "TVTK1DYV", "TVU18DHR", "TVWJBQDL", "TWTR0RCY", "TX1WT6DW", "TX93CVFT", "TXDJT8DL", "TXL3C5F3", "TXLCJ8H8", "TXR5WP1B", "TXSR40E2", "TY0EEIFT", "TY24ZH4J", "TY87BZYE", "TY8OON25", "TYDM5JLO", "TYFR9GAG", "TYLJVHDW", "TYNNV2DL", "TYPTN44J", "TYQR31E2", "TYS5MDOA", "TYTF8VCY", "TYUENJF3", "TYV8F4W4", "TYVSCJJH", "TYWJ1YJC", "TYZ4BG21", "TYZOVG25", "TZ2973ZS", "TZ8RHACY", "TZDJJGJC", "TZLGF8H8", "TZTHYB1B", "TZVRQ1CY", "TZWZ38LO", "TZXC7XAG", "U0TPBNEU", "U0VG23RX", "U17LMDF3", "U22HHZ7I", "U270ESCM", "U2DGCTRX", "U2DYIE20", "U2Z0D35P", "U3TM9V1B", "U42MRAJH", "U4P15BYE", "U4YLVUFT", "U5FLFGAG", "U60HJKDL", "U771VLYE", "U9TE05ZS", "UC20E25P", "UCFAIBH8", "UCIO367I", "UCRYJI25", "UDIOTI7K", "UDT92VCM", "UDWE6X97", "UE2DVAJC", "UEFA0TH8", "UERHG27K", "UF7HZFDW", "UFAAPNHR", "UFEDKLJC", "UFQEGN97", "UI7YLC21", "UILTSPLO", "UJEMBLJC", "UJFZ5CSF", "UJM91WCM", "UJNKL5LO", "UJS7KLBD", "UJSQ5LSF", "UKBHQS7K", "UKTUCO20", "UKVUBF4J", "UKZ2G9W4", "UN1H8A7K", "UN7OSH7I", "UPN060CM", "UPNGP7BD", "UQ7G5KB6", "UQAG5RBD", "UQBDZSOA", "UQR750BD", "URQ0OICM", "USTH03DL", "UVTGMJRX", "UVUKWULO", "UW7UQ3AN", "UXEKVVLO", "UXXCCWF3", "UYKCZZFT", "UYSLY4AN", "UYSZWLSF", "UYWY3MEU", "UZ91EJYV", "UZPPLLE2", "UZT1E2YE", "UZV0H1CY", "UZZHJWG9", "V00VECRX", "V09D8A21", "V0DMR9HR", "V0IVP1RX", "V0LEGMSF", "V0MXJ7AN", "V0ZXTR97", "V17DAC25", "V1T09O7I", "V1V9T1H8", "V2LCWFJH", "V2TDI425", "V2XJCQRX", "V38DFS4J", "V41BV4FT", "V48TFBZS", "V4TKRLG9", "V4TOTEE2", "V4UKU9AN", "V4W8U8LO", "V7S5QWW4", "V7U0LE7K", "VCQKAMAG", "VCXMIZH8", "VDI1QZ1B", "VDR43RYV", "VFN7K5G9", "VFTXH2AG", "VG918H1B", "VIK9B2HR", "VIUGU7YE", "VJFC15CY", "VJLOUDE2", "VJLZZKCY", "VJZZ16CM", "VKFOO8F3", "VKMJYOB6", "VLIHSAZS", "VNFCVLXQ", "VNNJNFRX", "VNP42BYE", "VNRDZI20", "VNVH11ZS", "VQEK21AN", "VQPMAQHR", "VQUJ5HB6", "VR0GC6YV", "VRDGW8DL", "VRDVXTRX", "VRLJ7MBD", "VRZGCPYE", "VSNGD2DW", "VST9Q4H8", "VSTCLQJH", "VSTTDEDL", "VUVC7LOA", "VV8DSQ21", "VVAP0RSF", "VVM73MG9", "VVNX0QAN", "VVV1S120", "VW2CLVXQ", "VW8HRBZS", "VWTDOJ4J", "VX072NG9", "VXL12FJC", "VXLPEFJC", "VXPE8USF", "VXTCWKXQ", "VXUZ9YCM", "VY21CAJH", "VY79U0H8", "VY7H20ZS", "VY94BJYV", "VYID0M25", "VYTPCMJH", "VYXC8MCM", "VYZX9HAN", "VZA1CIE2", "VZT1CAEU", "W0MLPBRX", "W0QETBCY", "W0UMMOG9", "W0ZVKG21", "W1832Q21", "W1IV2Y21", "W2FEE0XQ", "W2IJKGZS", "W2LR7PJH", "W491IX5P", "W4FJGR1B", "W4QIC57K", "W4SLI9BD", "W4VE4OCM", "W5TL8JBD", "W6SEBTCY", "W6ZZ1NAN", "W9T674YE", "W9U9TO5Z", "WCBEK8CM", "WCLEKKCY", "WCZRCN1B", "WDP3U225", "WFVJZ81B", "WGD6ONYE", "WGR1A55P", "WIER6LJC", "WJ9QDU7I", "WKBRKF1B", "WKSR8OJH", "WKT3B64J", "WL7EMSXQ", "WLAQPK7K", "WLFROPOA", "WN83SP4J", "WNEVT721", "WNI10F5P", "WQEOKVH8", "WQTRPOOA", "WRDL7DB6", "WRVLX3RX", "WSPLQUB6", "WSRQ527I", "WSUVFLDW", "WU894D5Z", "WU8EUACY", "WU8R2X1B", "WUWV9V25", "WVLZTVAN", "WVM35FEU", "WWT6YDYE", "WXT33O20", "WXTFCQ97", "WXZMEWG9", "WY0VGKDW", "WYTVBO20", "WZRQ727K", "WZVVPBDW", "X2XZ7HJH", "X3IEPVYV", "X3IYFM7K", "X40MTGE2", "X426KKLO", "X47BVE4J", "X4LHUZLO", "X4S4NLBD", "X4TM9XXQ", "X5MWNKH8", "X5MXPWCY", "X5T4YJRX", "X5ZZI1JC", "X7THT0LO", "X9THTG5Z", "XCF9BQFT", "XCVAXXOA", "XEEBH725", "XEZZFQOA", "XF17P7H8", "XFP7PQHR", "XG8EOWYV", "XGDWY9H8", "XJSEQGDL", "XJXXZMCY", "XK7CKKSF", "XKD4OTRX", "XKU613LO", "XKZXF6CY", "XNTYY17I", "XPUM18E2", "XQD4VDBD", "XQQ453BD", "XQRTVXRX", "XREZH2JC", "XS0W5LHR", "XSIVF797", "XSKX7ECY", "XSZZ50OA", "XUW4DVBD", "XV2A3AJH", "XVVFWGW4", "XWEX09CM", "XWGBOL4J", "XY045CRX", "XYNMIJEU", "XYVW61H8", "XZ8ZUX1B", "XZFWFBHR", "Y07KGSXQ", "Y0LXTEOA", "Y0QF385Z", "Y3VFB05Z", "Y44CM0YV", "Y4TCWQYV", "Y4TT5J97", "Y4XD0EW4", "Y69S40G9", "Y7VCVAYE", "Y9ZC7FYV", "YDEC6GYV", "YFVW6X7K", "YITXJOOA", "YJB9E821", "YKD9CE25", "YNBTEA97", "YNUXS11B", "YPMWXHFT", "YSEWWSF3", "YUFX2R1B", "YWUFKH5P", "YXSXECJH", "YYDX9YOA", "YYFX07OA", "YYNWE0FT", "YYRT4K97", "YYTWN1F3", "YZ7W7W7K", "YZPD95W4", "YZRCERYE", "YZZRZVRX", "Z043JB7I", "Z0D8JWAN", "Z0EG8721", "Z0IMFF5P", "Z0SOP8RX", "Z0TUZJBD", "Z0U4IIOA", "Z0WV3I5P", "Z0Z5A4ZS", "Z1BP2825", "Z1FMX75Z", "Z1TG2H25", "Z1U39L7I", "Z1VNVOCM", "Z2QGHN4J", "Z2VYMBDW", "Z38VBA5P", "Z3FPUDG9", "Z40H4XCY", "Z476WX25", "Z48CRD5P", "Z4FJ5TYE", "Z4IS51YV", "Z4TVR45Z", "Z4VJ5AYV", "Z4VPNTB6", "Z4WJMCYE", "Z4ZTV97I", "Z6LNBKCY", "Z6N66JE2", "Z746LT4J", "Z7FTQ8W4", "Z7W6M321", "Z7XJVKYV", "ZC16F2EU", "ZCAX2NHR", "ZCPP4221", "ZCT6FAE2", "ZCXPID4J", "ZCY63B4J", "ZD7PUC21", "ZDU6UU20", "ZE7GHX20", "ZEIGGO4J", "ZFKCMXE2", "ZFWC6F7I", "ZGQVT8G9", "ZGV0BHXQ", "ZI7PWKB6", "ZIAPWRBD", "ZIEXBEHR", "ZIFU6IJC", "ZILUZPJC", "ZITJU4YE", "ZIW6L320", "ZJ1VS9G9", "ZJ26EF25", "ZJAI1ZCY", "ZJNV9M5Z", "ZJPJNBYE", "ZJU880AG", "ZK2TGIW4", "ZKLZ6FF3", "ZKNPG7BD", "ZKSRVHH8", "ZKV6CD21", "ZKWPQ54J", "ZKZYNZDL", "ZNXQED97", "ZNZHPMXQ", "ZPSZXEFT", "ZPZPPYBD", "ZQFRKBHR", "ZQM181LO", "ZQNHMFCY", "ZQTRKSH8", "ZS1R57H8", "ZSEV1U5Z", "ZSIC5I7K", "ZSLYF7DL", "ZUEXSEH8", "ZUV1GTLO", "ZUVNU1CY", "ZV4GSR25", "ZVB6YRE2", "ZVFC56EU", "ZVKIAECM", "ZVN6YJEU", "ZVS65CEU", "ZVTC5EE2", "ZVXGRD4J", "ZWTDIV1B", "ZXB32S7I", "ZXQXJ6HR", "ZXUNLYCM", "ZY0HYDXQ", "ZY7I8SCY", "ZY9V10G9", "ZYEPF1B6", "ZYFKZ8W4", "ZYFM4TZS", "ZYI3AM7K", "ZYR6UK4J", "ZYT190LO", "ZYTUMOOA", "ZYU44CDL", "ZYUCQO5Z", "ZYUP6HBD", "ZYV3ZX7K", "ZYXM6Y5Z", "ZZ7OQ7RX", "ZZ8IQACY", "ZZP37DAN", "ZZPSEBYE", "ZZX3GXAG"}
    '        Dim clsBD As New ClasseAccesBD
    '        Dim ConjuntLinies As System.IO.StreamReader
    '        Dim VDades() As String, VSQL() As String, Assistencia As Integer
    '        ConjuntLinies = New System.IO.StreamReader(CamiFitxer)
    '        Dim Linia As String
    '        Linia = Trim(ConjuntLinies.ReadLine())
    '        ReDim VSQL(0)

    '        While Not Linia Is Nothing
    '            Dim Password As String = "", idOrigen As Integer = 0
    '            Password = AsignaPasswordJose(Password)

    '            If compruebaPass(IDFira, Password) Then
    '                Assistencia = 0
    '                'VDades = Linia.Split(vbTab)
    '                VDades = Linia.Split("¦")
    '                'VDades = [Nombre(Nom)0, Apellidos(Cognoms)1, Email(email)2]
    '                Dim Nom As String = VDades(0)
    '                Dim Cognom As String = VDades(1)
    '                Dim Email As String = VDades(2)
    '                If VSQL(0) <> "" Then ReDim Preserve VSQL(VSQL.Length)
    '                VSQL(VSQL.Length - 1) = "INSERT INTO EEContactes (idFira, idContacte, idOrigen, idTipusContacte, idAlta, Nom, Cognoms, Mobil, Email, Carrec, NIT, NITactivat, Password, Procedencia, SectorInteres, NickTwitter, NickFacebook, WebPersonal, Blog, Data) " &
    '                                        "VALUES(" & IDFira & "," & PrimerID & ",'" & idOrigen & "',0,0,'" & clsBD.Cometes(Trim(VDades(0))) & "','" & clsBD.Cometes((VDades(1).Replace(" ", "¦"))) & "',0,'" & clsBD.Cometes(Trim(VDades(2))) & "',0,0,0,'" & clsBD.Cometes(Trim(Password)) & "','','','','','','','')"
    '                Linia = ConjuntLinies.ReadLine()
    '                PrimerID += 1
    '            Else
    '                Return False
    '                Exit Function
    '            End If
    '        End While
    '        ConjuntLinies.Close()
    '        Return clsBD.BaseDades(2, VSQL, , 3, IDFira, False)
    '    Catch ex As Exception
    '        Return False
    '    End Try

    'End Function

    Public Function AsignaPasswordJose(ByRef password) As String
        Dim obj = New Random
        Dim posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim longitud = posibles.Length
        Dim letra As Char
        Dim longitudnuevacadena = 4
        Dim i As Integer

        For i = 0 To longitudnuevacadena - 1
            letra = posibles(obj.[Next](longitud))
            password += letra.ToString
        Next

        Return password
    End Function

    'Public Function compruebaPass(ByRef Idfira, ByVal password) As Boolean
    '    Dim clsBD As New ClasseAccesBD
    '    Dim VectorSQL(0) As String
    '    Dim DS As New DataSet
    '    VectorSQL(0) = "SELECT Password FROM EEContactes WHERE idFira = " & Idfira & " AND Password='" & password & "'"
    '    If clsBD.BaseDades(1, VectorSQL, DS, 3, Idfira) Then
    '        If DS.Tables(0).Rows.Count > 0 Then
    '            Return False
    '            Exit Function
    '        Else
    '            Return True
    '        End If
    '    End If
    'End Function

End Class