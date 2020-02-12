<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ARRAYS.aspx.vb" Inherits="MyWebSite.ARRAYS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pruebas y más pruebas</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid" style="border:1px solid red;">
            Esto es un <b>Container-fluid</b>
        </div>
        <br />
        <div class="container" style="border:1px solid blue;">
            esto es un <b>Container</b>
        </div>
        <br />
        <div class="row" style="border:1px solid green;">
            esto es un <b>Row</b>
        </div>
        <br />
        <div class="container" style="border:1px solid pink">
            <div class="row" style="border:1px solid blue">
                <div class="col-md-8" style="border:1px solid brown">.col-md-8</div>
                <div class="col-md-4" style="border:1px solid yellow">.col-md-4</div>
                <div class="w-100"></div>
                <div class="col-md-8" style="border:1px solid brown">.col-md-8</div>
                <div class="col-md-4" style="border:1px solid yellow">.col-md-4</div>
            </div>
        </div>
        <button type="button" id="miBoton" onclick="return operaciones();">Botón</button>
    </form>
    <script type="text/javascript">
        function CalculoDNI() {
            var Letras = ['T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E', 'T'];
            var numero = prompt("Escriba su Número del DNI:", "");
            var Letra = prompt("Escriba su Letra del DNI:", "");
            if (numero == null){
                alert("Necesita introducir valores!");
                return false;
            }
            else{
                if ((numero <= 0) || (numero >= 99999999)) {
                    alert("Debes de introducir un número valido.");
                    return false;
                }
                else {
                    var division = numero % 23;
                    if (Letras[division] == Letra) {
                        alert("Letra y Números son correctos. Todo OK!");
                    }
                    else {
                        alert("Lo sentimos pero no ha introducido sus datos correctamente.");
                        return false;
                    }
                }
            }
        }

        function mostrarMeses() {
            var Meses = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'];
            for (i = 1; i <= Meses.length; i++) {
                alert("Posición: " + i + " , Mes: " + Meses[i-1]);
            }
        }

        function operaciones() {
            var valores = [true, 5, false, "Hola", "Adios", 2];
            document.write("El arreglo es [" + valores + "] <br />");
            if (valores[1] >= valores[5])
                document.write("<br />El mayor de los valores numéricos es " + valores[1]);
            else
                document.write("El mayor de los valores numéricos es " + valores[5] + "<br />");
            if (valores[0] == true)
                alert(true);
            else
                alert(false);
            document.write("<br />" + "A continuación, la tabla de multiplicar de los valores numéricos");
            document.write("<br />" + valores[1] + "+" + valores[1] + "=" + (valores[1] * valores[5]));

        }
    </script>
</body>
</html>
