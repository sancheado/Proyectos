<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login2.aspx.vb" Inherits="EntradaE.Login21" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function LlançaAvis(Text) {
            bootbox.alert({ title: "FEMSA - TESTEO JOSE", message: Text });
        }   
    </script>
    <title>LOGIN [FEMSA] - TESTEO JOSE</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1" />
    <asp:Literal ID="bootstrap_min_css" runat="server"></asp:Literal>
    <asp:Literal ID="segmented_controls_css" runat="server"></asp:Literal>
    <asp:Literal ID="bootstrap_datetimepicker_min_css" runat="server"></asp:Literal>
    <asp:Literal ID="jquery_1_9_1_min_js" runat="server"></asp:Literal>
    <asp:Literal ID="bootstrap_min_js" runat="server"></asp:Literal>
    <asp:Literal ID="bootstrap_datetimepicker_js" runat="server"></asp:Literal>
    <asp:Literal ID="bootbox_min_js" runat="server"></asp:Literal>
    <asp:Literal ID="bootstrap_datetimepicker_es_js" runat="server"></asp:Literal>
    <link href="https://fonts.googleapis.com/css?family=Poppins|Rokkitt&display=swap" rel="stylesheet" />
    <style type="text/css">

        /* Varios */
        .centrar{display:block;margin: 5px auto;}
        .miPadding{padding:10px;}
        /* Img Responsive */
        .img-responsive{display:block;margin: 25px auto;padding: 10px;}

        /* Panel */
        .panel{width:520px;box-shadow: 0px 0px 6px rgba(0, 0, 0, 0.8);border-radius: 4px;background: #CCCCCC;color:#ffffff;border:1px solid black;}
        .panel-header{background-color:#6F1F2A;border-top-left-radius: 4px;border-top-right-radius:4px;padding: 10px;text-align:justify;font-family: 'Poppins', sans-serif;font-size:17px;font-weight:Bold;width: 94.5%;margin: 0 0 10px 15px;}

        /* Chk Idioma */
        .chkIdioma{margin-top:-10px;padding:10px;}

        .segmented-control1 {box-shadow: 0px 0px 12px rgba(0, 0, 0, 0.8);border: solid 1px #bbbbbb;background-color: #58585A;width: 102%;max-width: 262px;height: 32px;}
        .selSegmented-Control1{font-family: Tahoma;font-size: 14px;background-color: #58585A;color: #FFFFFF;line-height: 32px !important;text-align: center !important;}
        .segmented-control > label:before{background: #870027;}
        .AmpleLabel {min-width: 378px;font-size: 12px}

        .obligatorio{font-weight:800; color: red;}
        .caja{font-size: 16px; padding: 4px; padding-left: 8px;background-color: #ffffff;color: Black; border-radius: 0px; border: none; width: 98%; box-shadow: 0px 0px 5px rgba(0, 0, 0, 1);}
        label[for=txtEmail]{font-size:22.5px;font-weight:400;text-align:right !important;width:100%;font-family: 'Rokkitt', serif;margin-top:.5px;color:Black}

        /* Botón envio */
        .btnBoto1 {box-shadow: 0px 0px 6px rgba(0, 0, 0, 0.8); font-family: Arial; font-size: 15px; font-weight: bold; background-color: #6F1F2A; color: #FFFFFF; border: solid 1px #CCCCCC;margin-top:15px;}
        .btnBoto1:hover {background-color: #ffffff; color: #6F1F2A;border: solid 1px #6F1F2A;}

        .modal {text-align: center;padding: 0 !important;top: 0%;}
        .modal-header{background-color:#6F1F2A;color:#fff;}
        .modal:before{content: '';display: inline-block;height: 100%;vertical-align: middle;margin-right: -4px;}
        .modal-dialog{display: inline-block;text-align: left;vertical-align: middle;}


        /* Media Querys */
        @media screen and (max-width: 1000px) {
	        .img-responsive{width:95%;}            
        }
        @media screen and (max-width: 530px) {
	        .panel{width:97%;}       
            .col-xs-6{width:100%;}
            label[for=txtEmail]{text-align:justify;font-size:20px;text-align:center !important;}
            .panel-header{width:94.5%;font-size:16px}
            .col-xs-5,.col-xs-7{width:100%;}
            .caja{display:block;width:95%;margin:5px auto;}
        }
    </style>
</head>
<body>
    <img class="img-responsive" src="imatges/cabecera_RAD20.jpg" />
    <form id="form1" runat="server">        
        <input type="hidden" id="txtSegmentTransport1" value="" runat="server" name="txtSegmentTransport1" />
        <input type="hidden" id="txtCriterio" value="" runat="server" name="txtCriterio" />
        <div class="container">
            <div class="row">
                <div class="panel centrar">
                    <div class="row">
                        <div id="txtCabesera" class="panel-header" runat="server">
                            Validación
                        </div>
                    </div>
                    <div class="chkIdioma">
                        <div class="row">
                            <div class="col-xs-12" style="margin: 10px; padding: 10px;">
                                <center>
                                    <div id="DIVSegmentTransport1" class="segmented-control segmented-control1" style="max-width: 166px;"><input type='radio' name='Tria2' id='rbEspanol' checked onclick="CambiarIdioma(1);" runat="server" /><input type='radio' name='Tria2' id='rbIngles' onclick="CambiarIdioma(2);" runat="server"><label id="lblEspanol" for='rbEspanol' data-value='Español ✔&check;' class='selSegmented-Control1' runat="server">Español</label><label id="lblIngles" for='rbIngles' data-value='Inglés&nbsp;&nbsp;&check;' class='selSegmented-Control1' runat="server">Inglés</label></div>
                                </center>
                            </div>
                        </div>
                    </div>
                    <div class="row miPadding">
                        <div class="col-xs-5">
                            <label id="lblEmail" for="txtEmail" runat="server">
                                Email ( <span class="obligatorio">*</span> )
                            </label>
                        </div>
                        <div class="col-xs-7">
                            <input type="Email" id="txtEmail" class="caja" runat="server" /> 
                        </div>
                    </div>
                    <div id="contPass" class="row miPadding" runat="server">
                        <div class="col-xs-5">
                            <label id="lblPass" for="txtEmail" runat="server">
                                Password ( <span class="obligatorio">*</span> )
                            </label>
                        </div>
                        <div class="col-xs-7">
                            <input type="text" id="txtPassword" class="caja" runat="server" /> 
                        </div>
                    </div>
                </div>
            </div>
            <br />
        </div>            
        <center>
            <button id='btnSubmit' type="button" class='btn btnBoto1' onclick="return ComprovarEmail();" runat="server" style="padding-top: 8px; padding-left: 16px; padding-right: 16px; border-radius: 10px;" >
                <span Class="glyphicon glyphicon-check" id="SPANSubmit"></span>
                <Font id ='lbSubmit' runat="server">&nbsp;&nbsp;IDENTIFICACIÓN</font>
            </button>
        </center>
        <script type="text/javascript" src="../../extra/ComunicacioAJAX.js"></script> 
    <script type="text/javascript">

        function CambiarIdioma(x) {
            document.getElementById('txtCabesera').innerHTML = x == 1 ? "Validación" : "Validation";
            document.getElementById('lbSubmit').innerHTML = x == 1 ? "IDENTIFICACIÓN" : "IDENTIFICATION";
            document.getElementById('txtEmail').placeholder = x == 1 ? "Introduce tu Email aquí..." : "Enter your name here...";
            document.getElementById('rbEspanol').checked = x == 1 ? true : false;
            document.getElementById('rbIngles').checked = x == 1 ? false : true;
            document.getElementById('lblEspanol').dataset.value = x == 1 ? "Español ✔" : "Spanish";
            document.getElementById("lblEspanol").innerText = x == 1 ? "Español" : "Spanish";
            document.getElementById('lblIngles').dataset.value = x == 2 ? "English ✔" : "Inglés";
            document.getElementById('lblIngles').innerText = x == 1 ? "Inglés" : "English";
            document.getElementById('txtPassword').placeholder = x == 1 ? "Introduce tu Contraseña aquí..." : "Enter your password here...";   
        }

        function EnviemFormulari() {
            var theform;
            if (window.navigator.appName.toLowerCase().indexOf("microsoft") > -1) theform = document.form1;
            else theform = document.forms["form1"];
            theform.submit();

        }
        function ComprovarEmail() {
            var Email = document.getElementById('txtEmail').value;
            if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/.test(Email)) {
                EnviemFormulari();
            }
            else {
                if (document.getElementById('rbEspanol').checked == true) LlançaAvis("Introduzca el Email en un formato correcto(info@femsa.com).");
                else LlançaAvis("Enter the Email in a correct format (info@femsa.com).");
                return false;
            }
        }     

    </script>
    </form>    
</body>
</html>
