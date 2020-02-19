<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Mostrar-Ocultar.aspx.vb" Inherits="MyWebSite.Mostrar_Ocultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Testeo Mostrar/Ocultar con Javascript</title>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/css/all.css">
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,500i,700,800i" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Cambay&display=swap" rel="stylesheet">
    <script src="https://code.jquery.com/jquery-3.4.1.min.js" integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <style type="text/css">
        body {margin: 0;padding: 0;box-sizing: border-box;}
        /*Varios*/
        .row{margin-left:-10px !important;margin-right:-10px !important;}
        .resaltar{font-weight:800;text-decoration:underline}
        /* Segmented Control */
        .segmented-control{display: table;width: 100%;margin: 2em 0;padding: 0;}
        .segmented-control__item {display: table-cell;margin: 0;padding: 0;list-style-type: none;}
        .segmented-control__input {position: absolute;visibility: hidden;}
        .segmented-control__label {display: block;margin: 0 -1px -1px 0;padding: 1em .25em;border: 1px solid #ddd;font: 14px/1.5 sans-serif;text-align: center;cursor: pointer;}
        .segmented-control__label:hover {background: #fafafa;}        
        .segmented-control__input:checked + .segmented-control__label {background: #eee;color: #333;}        

        .misegmented{display:table;width:100%;margin:5px auto;padding:2.5px;}
        .misegmented__item{display:table-cell;margin:0;padding:0;list-style-type:none;}
        .misegmented__input{position: absolute;visibility: hidden;}
        .misegmented__label{display: block;margin: 0 -1px -1px 0;padding: 5px 5px;border: 1px solid #ddd;font: 14px sans-serif;text-align: center;cursor: pointer;background-color:#ffffff;}
        .misegmented__label:hover {background: #fafafa;}        
        .misegmented__input:checked + .misegmented__label {background-color: #FF5500;color: #fff;}

        /* Panel */
        .panel{width:570px; margin: 10px auto;padding:10px;border:1PX solid Black;background-color:#eee;box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.8);}
        .panel-header{background-color:#FF5500;color:#ffffff;margin-top:-10px;padding:10px;width:100%;}

        label[for=textos]{text-align:right;font-size:15px;margin-top:10px;}
        label[for=textos2]{text-align:left !important;font-size:15px;margin-top:10px;width:100%;}
        .caja{font-size: 15px; padding: 4px; padding-left: 6px;background-color: #ffffff;color: Black; border-radius: 0px; border: none; width: 98%; box-shadow: 0px 0px 5px rgba(0, 0, 0, 1);}
        .ponerSegmented{width:350px;margin:10px auto;}

        
        /* Media Querys */
        @media screen and (max-width: 720px) {
            .col-sm-2,.col-sm-4{width:100%;}
        }
        @media screen and (max-width: 575px) {            
            .panel{width:95%;}
            .panel-header{width:106% !important;}
        }
    </style>
</head>
<body style="background-color: #fff;">
    <form id="form1" runat="server">
        <center>
            <h3>Testeo de Mostrar/Ocultar con <span class="resaltar">Segmented-Control CSS</span></h3>
            <br />
            <p>Un simple css para crear un segmented control usando radi buttons y labels</p>
        </center>
        <div class="container" style="background-color:#fff;">
            <div class="row">
                <div class="panel">
                    <div class="row">
                        <div class="panel-header">
                            Información del viaje
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            <label for="textos">
                                Nombre
                            </label>
                        </div>
                        <div class="col-sm-4" style="padding: 10px;">
                            <input type="text" id="txtNombre" class="caja" placeholder="Introduzca su Nombre." />
                        </div>
                        <div class="col-sm-2">
                            <label for="textos">
                                Apellidos
                            </label>
                        </div>
                        <div class="col-sm-4" style="padding: 10px;">
                            <input type="text" id="txtApellidos" class="caja" placeholder="Introduzca sus Apellidos." />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            <label for="textos">
                                Email
                            </label>
                        </div>
                        <div class="col-sm-4" style="padding: 10px;">
                            <input type="text" id="txtEmail" class="caja" placeholder="Introduzca su Email." />
                        </div>
                        <div class="col-sm-2">
                            <label for="textos">
                                Edad
                            </label>
                        </div>
                        <div class="col-sm-4" style="padding: 10px;">
                            <input type="text" id="txtEdad" class="caja" placeholder="Introduzca su Edad." />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <label for="textos">
                                ¿Requiere transporte? (<span class="requerido">*</span>)
                            </label>
                        </div>
                        <div class="col-md-7">
                            <ul class="misegmented">
                                <li class="misegmented__item">
                                    <input class="misegmented__input" type="radio" value="1" name="Transporte" id="TransporteSi" checked onclick="$('#segmentedTransporte').slideDown(300);" />
                                    <label class="misegmented__label" for="TransporteSi">Si</label>
                                </li>
                                <li class="misegmented__item">
                                    <input class="misegmented__input" type="radio" value="2" name="Transporte" id="TransporteNo" onclick="$('#segmentedTransporte').slideUp(300);" />
                                    <label class="misegmented__label" for="TransporteNo">No</label>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="row" id="segmentedTransporte" style="padding:10px;">
                        <div class="col-md-6">
                            <label for="textos2">
                                Dia de salida:
                            </label>
                            <input type="text" id="txtDireccion" class="caja" placeholder="Introduzca su Dirección." />
                        </div>
                        <div class="col-md-6">
                            <label for="textos2">
                                Num Vuelo:
                            </label>
                            <input type="text" id="txtVuelo" class="caja" placeholder="Introduzca su Num Vuelo." />
                        </div>
                        <div class="col-md-6">
                            <label for="textos2">
                                Aerolinea:
                            </label>
                            <input type="text" id="txtCompania" class="caja" placeholder="Introduzca su Compañia de Vuelo." />
                        </div>
                        <div class="col-md-6">
                            <label for="textos2">
                                Tipo de Vuelo:
                            </label>
                            <input type="text" id="txtTipo" class="caja" placeholder="Introduzca su Num Vuelo." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel">
                <div class="row">
                    <div class="panel-header">
                        Datos del acompañante
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <label for="textos2">
                            Irá acompañado?
                        </label>
                    </div>
                    <div class="col-md-8">
                        <ul class="misegmented">
                            <li class="misegmented__item">
                                <input class="misegmented__input" type="radio" value="1" name="Acompanado" id="AcompanadoSi" checked onclick="$('#acompanante').slideDown(300);" />
                                <label class="misegmented__label" for="AcompanadoSi">Si</label>
                            </li>
                            <li class="misegmented__item">
                                <input class="misegmented__input" type="radio" value="2" name="Acompanado" id="AcompanadoNo" onclick="$('#acompanante').slideUp(300);" />
                                <label class="misegmented__label" for="AcompanadoNo">No</label>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="row" id="acompanante">
                    <div class="col-md-6">
                        <label for="textos2">
                                Nombre:
                        </label>
                        <input type="text" id="txtNombreAcompa" class="caja" placeholder="Introduzca el nombre de su acompañante." />
                    </div>
                    <div class="col-md-6">
                        <label for="textos2">
                                Apellidos:
                        </label>
                        <input type="text" id="txtApeAcompa" class="caja" placeholder="Introduzca los Apellidos de su acompañante." />
                    </div>
                    <div class="col-md-6">
                        <label for="textos2">
                                Num.Telefono:
                        </label>
                        <input type="text" id="txtNumeroAcompa" class="caja" placeholder="Introduzca el número de telefono de su acompañante." />
                    </div>
                    <div class="col-md-6">
                        <label for="textos2">
                                Email:
                        </label>
                        <input type="text" id="txtApeAcompa" class="caja" placeholder="Introduzca el Email de su acompañante." />
                    </div>
                </div>
            </div>
        </div>

        <ul class="segmented-control">
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="1" name="option1" id="option-1" checked>
                <label class="segmented-control__label" for="option-1">Thing 1</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="2" name="option1" id="option-2">
                <label class="segmented-control__label" for="option-2">Thing 2</label>
            </li>
        </ul>


        <ul class="segmented-control">
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="3" name="option" id="option-3" checked>
                <label class="segmented-control__label" for="option-3">Thing 1</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="4" name="option" id="option-4">
                <label class="segmented-control__label" for="option-4">Thing 2</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="5" name="option" id="option-5">
                <label class="segmented-control__label" for="option-5">Thing 3</label>
            </li>
        </ul>


        <ul class="segmented-control">
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="6" name="option" id="option-6" checked>
                <label class="segmented-control__label" for="option-6">Thing 1</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="7" name="option" id="option-7">
                <label class="segmented-control__label" for="option-7">Thing 2</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="8" name="option" id="option-8">
                <label class="segmented-control__label" for="option-8">Thing 3</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="9" name="option" id="option-9">
                <label class="segmented-control__label" for="option-9">Thing 4</label>
            </li>
        </ul>


        <ul class="segmented-control">
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="10" name="option" id="option-10" checked>
                <label class="segmented-control__label" for="option-10">Thing 1</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="11" name="option" id="option-11">
                <label class="segmented-control__label" for="option-11">Thing 2</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="12" name="option" id="option-12">
                <label class="segmented-control__label" for="option-12">Thing 3</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="13" name="option" id="option-13">
                <label class="segmented-control__label" for="option-13">Thing 4</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="14" name="option" id="option-14">
                <label class="segmented-control__label" for="option-14">Thing 5</label>
            </li>
        </ul>


        <ul class="segmented-control">
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="15" name="option" id="option-15" checked>
                <label class="segmented-control__label" for="option-15">Thing 1</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="16" name="option" id="option-16">
                <label class="segmented-control__label" for="option-16">Thing 2</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="17" name="option" id="option-17">
                <label class="segmented-control__label" for="option-17">Thing 3</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="18" name="option" id="option-18">
                <label class="segmented-control__label" for="option-18">Thing 4</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="19" name="option" id="option-19">
                <label class="segmented-control__label" for="option-19">Thing 5</label>
            </li>
            <li class="segmented-control__item">
                <input class="segmented-control__input" type="radio" value="20" name="option" id="option-20">
                <label class="segmented-control__label" for="option-20">Thing 6</label>
            </li>
        </ul>

    </form>
</body>
</html>
