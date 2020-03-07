<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Stadistics-about-text-files.aspx.vb" Inherits="MyWebSite.Stadistics_about_text_files" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1" />
    <!-- Estilos CSS de Boostrap, Font-Awesome y más -->
    
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/5.4.0/bootbox.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/css/all.css">
    <link href="https://fonts.googleapis.com/css?family=Lacquer|Open+Sans|PT+Sans|Raleway|Caladea&display=swap" rel="stylesheet">   
    <title>Small website that calculates stadistics about text files</title>
    <script type="text/javascript">
        function LlançaAvis(Text) {
            bootbox.alert({ title:"Small website that calculates stadistics about text files", message: Text });
        }
    </script>
    <style type="text/css">
        .glyphicon-refresh-animate {-animation: spin .7s infinite linear;-ms-animation: spin .7s infinite linear;-webkit-animation: spinw .7s infinite linear;-moz-animation: spinm .7s infinite linear;}
        @keyframes spin {
            from { transform: scale(1) rotate(0deg);}
            to { transform: scale(1) rotate(360deg);}
        } 
        @-webkit-keyframes spinw {
            from { -webkit-transform: rotate(0deg);}
            to { -webkit-transform: rotate(360deg);}
        }
        @-moz-keyframes spinm {
            from { -moz-transform: rotate(0deg);}
            to { -moz-transform: rotate(360deg);}
        }
        /* Text of the Header*/
        .headerTitulo{display:block; width: 560px; margin:10px auto;text-align:center;padding:10px;color: #61dafb;font-family: 'Open Sans', sans-serif;font-size:18px;}
        .headerTitulo2{display:block; width: 560px; margin:10px auto;text-align:center;padding:10px;color: #282c34;font-family: 'Open Sans', sans-serif;font-size:18px;}

        /* Panel */
        .panel,.panel-oculto{display:block;width:500px;margin:25px auto; padding:10px; background-color: #aeaeae;border-radius:4.7px;border:1px solid #fff;color:#fff;box-shadow: 0 3px 6px 0 #61dafb}
        .panel-header{margin-left:-10px;width:104.1%;margin-top:-10.5px;background-color:#fff;color:black;text-align:justify;padding:10px;padding-left:15px;font-weight:600;}
        .panel-header span{float:right; color:#ec008c;font-size:1.5em;margin-top:-5px;}
        .panel-oculto .panel-header span{float:right; color:Black;font-size:17px;margin-top:-2.5px;}
        .panel-body{display:block;width:450px;margin:10px auto;padding:10px;padding-left:50px;color:#ec008c;}

        .miI{padding-left:15px;color:#ec008c}
        .filas{margin-left:-10px;width:104%;padding:10px;border-bottom:1.5px solid #61dafb;}
        .filas2{margin-left:-10px;width:104%;padding:10px;}
        label[for=infoText]{float:right; font-size:25px;text-align:justify; color:black;font-family: 'Caladea', serif;}
        .form-control{border:.5px solid black;}

        /* TextArea */
        .myTextArea{display:block;width:75%;height:75px;margin:10px auto;padding:5px;border:1px solid black;border-radius: .25rem;}

        /* Send Button */
        .btn-pink-moon {background: #ec008c;background: -webkit-linear-gradient(to right, #fc6767, #ec008c);background: linear-gradient(to right, #fc6767, #ec008c);color: #fff;border: 1px solid black;display: block;width: 35%;margin: 0 auto;border-radius: 10px;font-weight: 600;padding: 3.5px;}
        .btn-pink-moon:hover {background: #61dafb;background: -webkit-linear-gradient(to right, #61dafb, #282c34);background: linear-gradient(to right, #61dafb, #282c34);color: #fff;border: 1px solid #eee;}

        /* Modal Content */
        .modal-content {background-color: #282c34;color: #fff;margin-top: 10%;}
        .modal-dialog {background-color: #282c34;}
        .modal-header {background-color: #61dafb;color:#ec008c;}
        .modal-header h5{font-size:17px !important;}
        .modal-body{display:block;margin: 5px auto;}

        .b1 {border: 1px solid black;}
        .b2 {border: 1px solid red;}
        .b3 {border: 1px solid green;}
        .b4{border:1px solid blue;}


        @media(max-width: 768px) {
            label[for=infoText] {
                float: left;
            }
        }
        @media(max-width: 506px) {
            .panel,.panel-oculto {
                width: 92.5%;
            }

            .panel-header {
                width: 105%;
            }

            .panel-body {
                width: 90%;
            }

            .headerTitulo {
                font-size: 16px;
            }            
        }
        @media(max-width: 455px) {
            .panel-header {
                width: 106%;
            }

            .panel-body {
                width: 92.5%;
                padding: 5px;
                font-size: 15px;
                display: block;
                margin: 5px auto;
            }
        }
        @media(max-width: 333px) {            
            .panel-header{width:107.35%;}
            .panel-body {
                width: 90.5%;
                padding: 2.5px;
                font-size: 13px;
                display: block;
                margin: 5px auto;
            }
        }
    </style>
</head>
<body style="background-color: #282c34;">
    <input type="hidden" id="txtData" value="" runat="server" name="txtData" />
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div class="container">
            <div class="row">
                <div class="headerTitulo" id="headerTitu">
                    Small website that calculates stadistics about text files
                </div>
            </div>
            <div class="row">
                <div class="panel" id="PrincipalPanel" runat="server">
                    <div class="panel-header">
                        Choose your file:
                        <span><i class="fas fa-file"></i></span>
                    </div>
                    <div class="panel-body">
                        <input id="fileItem" type="file" runat="server">
                    </div> 
                    <div class="row">
                        <asp:Button runat="server" ID="btnFile" Text="Send" CssClass="btn-pink-moon" />                        
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="panel-oculto" id="secretPanel" style="display:none;" runat="server">
                    <div class="panel-header">
                        Results for your file:
                        <span id="spOculto" runat="server"></span>
                    </div>
                    <div class="row filas">
                        <div class="col-md-6">
                            <label for="infoText">
                                · Whitespace delimited word count 
                            </label>
                        </div>
                        <div class="col-md-6">
                            <input type="text" class="form-control" id="wordCount" runat="server" />
                        </div>                        
                    </div>
                    <div class="row filas">
                        <div class="col-md-6">
                            <label for="infoText">
                                ·   
                            </label>
                        </div>
                        <div class="col-md-6">
                            <input type="text" class="form-control" id="lineCount" runat="server" />
                        </div>                        
                    </div>
                    <div class="row filas" >
                        <div class="col-md-6">
                            <label for="infoText">
                                · Line count  
                            </label>
                        </div>
                        <div class="col-md-6">
                            <input type="text" class="form-control" id="dimensions"  runat="server"/>
                        </div>                        
                    </div>
                    <div class="row filas2">
                        <textarea class="myTextArea" id="txtArea" runat="server" maxlength="255"></textarea>                       
                    </div>
                     <div class="row">
                        <button type="button" onclick="comeBack();" id="btnVuelta" class="btn-pink-moon">Back</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        function dataVerification() {
            var input = document.getElementById('fileItem');
            //Control the input file
            if (input.value != "") {
                file = input.files[0];
                //Only txt files                
                if (file.type == "text/plain") {       
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        //document.getElementById('txtData').value = e.target.result;
                    };
                    reader.readAsDataURL(file);
                    var path = (window.URL || window.webkitURL).createObjectURL(file);
                    alert(path);
                    document.getElementById('txtData').value = path;
                    setTimeout("mostrarOcultar()", 1500);
                }
                else {
                    LlançaAvis('ERROR! You need to choose any txt file');
                }
            }
            else {
                LlançaAvis('ERROR! You need to choose any file');
            }
        }

        function mostrarOcultar() {
            document.getElementById('secretPanel').style.display = "Block";
            document.getElementById('PrincipalPanel').style.display = "none";
            SendForm();
        }

        function comeBack() {
            document.getElementById('PrincipalPanel').style.display = "Block";
            document.getElementById('secretPanel').style.display = "none";
        }

        function SendForm() {
            var theform;
            if (window.navigator.appName.toLowerCase().indexOf("microsoft") > -1) theform = document.form1;
            else theform = document.forms["form1"];
            theform.submit();
        }
                
    </script>
</body>
</html>