<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VArios.aspx.vb" Inherits="MyWebSite.VArios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EJERCICIOS JAVASCRIPT</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/css/all.css">
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,500,500i,700,800i" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Cambay&display=swap" rel="stylesheet">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <style type="text/css">
        .putEjercicios{display:block;width:500px;margin:10px auto;border:1px solid green;text-align:center;background-color:black;padding:10px;}
        .putEjercicios:hover{background-color:chocolate;}
        .putEjercicios a{color:#FFFFFF;font-size:18px;}
        .putEjercicios a:hover{text-decoration:none}

        .div_oculto{display:none;width:350px;margin:15px auto;text-align:center}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="border:1px solid red;">
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="saludar();" href="#">Ejercicio 1</a>
                </div>
            </div> 
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="escribir();" href="#">Ejercicio 2</a>
                </div>
            </div> 
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="escribir_suma();" href="#">Ejercicio 3</a>
                </div>
            </div>  
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="saludarUsuario();" href="#">Ejercicio 4</a>
                </div>
            </div>  
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="compruebaMayor();" href="#">Ejercicio 5</a>
                </div>
            </div> 
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="compruebaMayorDe3();" href="#">Ejercicio 6</a>
                </div>
            </div>    
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="divisible2();" href="#">Ejercicio 7</a>
                </div>
            </div>  
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="contarA();" href="#">Ejercicio 8</a>
                </div>
            </div>  
            <div class="row">
                <div class="putEjercicios">
                    <a onclick="contarVocales();" href="#">Ejercicio 9</a>
                </div>
            </div>            
        </div>
        <div id="escribir" class="div_oculto"></div>
    </form>
    <script type="text/javascript">

        function saludar() { alert('Hola Mundo!!'); }

        function escribir() {
            document.getElementById('escribir').innerHTML = "";
            dar_estilo();
            document.getElementById('escribir').innerHTML = "Hello World!!!";
            setTimeout(limpieza, 5000);
        }

        function escribir_suma() {
            document.getElementById('escribir').innerHTML = "";
            var a = 3, b = 5, suma = a + b;
            dar_estilo();
            document.getElementById('escribir').innerHTML = "La suma de a (" + a + ") + b(" + b + ") es = [" + suma + "]";
            setTimeout(limpieza, 1000);
        }

        function dar_estilo() {
            document.getElementById('escribir').style.padding = '15px';
            document.getElementById('escribir').style.display = 'Block';
            document.getElementById('escribir').style.backgroundColor = '#6F1F2A';
            document.getElementById('escribir').style.color = '#ffffff';
            document.getElementById('escribir').style.border = '1px solid #ffffff';
        }

        function limpieza() {
            document.getElementById('escribir').style.display = 'none';
        }

        function saludarUsuario() {
            var nombre = prompt("Digame su nombre:", "");
            alert('Hola ' + nombre + ", que tal va tu día?");
        }

        function compruebaMayor() {
            var num1 = prompt("Introduzca el primer número.", "");
            var num2 = prompt("Introduzca el segundo número.", "");
            var comparacion;
            if (num1 > num2) {
                comparacion = "El número(" + num1 + "), es mayor que el número(" + num2 + ")";
            }
            else if (num2 > num1) {
                comparacion = "El número(" + num2 + "), es mayor que el número(" + num1 + ")";
            }
            else {
                comparacion = "Parece que los numeros son iguales, 1º("+num1+") y 2º("+num2+")";
            }
            document.getElementById('escribir').innerHTML = "";
            dar_estilo();
            document.getElementById('escribir').innerHTML = comparacion;
            setTimeout(limpieza, 2000);
        }

        function compruebaMayorDe3() {
            var num1 = prompt("Introduzca el primer número.", "");
            var num2 = prompt("Introduzca el segundo número.", "");
            var num3 = prompt("Introduzca el tercer número.", "");
            var comparacion;
            if ((num1 > num2) || (num1 > num3)) {
                comparacion = "El número(" + num1 + "), es mayor que el número(" + num2 + ") y que número(" + num3 + ")";
            }
            else if ((num2 > num1) || (num2 > num3)) {
                comparacion = "El número(" + num2 + "), es mayor que el número(" + num1 + ") y que número(" + num3 + ")";
            }
            else if ((num3 > num1) || (num3 > num2)) {
                comparacion = "El número(" + num3 + "), es mayor que el número(" + num1 + ") y que número(" + num2 + ")";
            }
            else {
                comparacion = "Alguno de los números es igual a otro. Num1(" + num1 + "),Num2(" + num2 + "),Num3(" + num3 + "),";
            }
            document.getElementById('escribir').innerHTML = "";
            dar_estilo();
            document.getElementById('escribir').innerHTML = comparacion;
            setTimeout(limpieza, 4000);
        }

        function divisible2() {
            var num = prompt("Introduzca un número:", "");
            var comparacion;
            if (num % 2 === 0) {
                comparacion = "Sí es divisible entre 2!!!!";
            }
            else {
                comparacion = "No es divisible entre 2!!!!";
            }
            document.getElementById('escribir').innerHTML = "";
            dar_estilo();
            document.getElementById('escribir').innerHTML = comparacion;
            setTimeout(limpieza, 2000);
        }
        function contarA() {
            var a = 0;
            var frase = prompt("Introduzca su frase:", "");
            var frase2 = frase.toLowerCase().split("");

            for (k = 0; k < frase2.length; k++) {
                switch (frase[k]) {
                    case "a":
                    case "á":
                    case "à":
                        a++;
                        break;
                }
            }
            document.getElementById('escribir').innerHTML = "";
            dar_estilo();
            document.getElementById('escribir').innerHTML = "Hay [- " + a + " -] A en esa frase. :)";
            setTimeout(limpieza, 2000);
        }

        function contarVocales() {
            var a = e = i = o = u = 0;
            var frase = prompt("Introduzca su frase:", "");
            var frase2 = frase.toLowerCase().split("");

            for (k = 0; k < frase2.length; k++) {
                switch (frase[k]) {
                    case "a":
                    case "á":
                    case "à":
                        a++;
                        break;
                    case "e":
                    case "é":
                    case "è":
                        e++;
                        break;
                    case "i":
                    case "í":
                    case "í":
                        i++;
                        break;
                    case "o":
                    case "ó":
                    case "ò":
                        o++;
                        break;
                    case "u":
                    case "ù":
                    case "ú":
                        u++;
                        break;
                }
            }
            document.getElementById('escribir').innerHTML = "";
            dar_estilo();
            document.getElementById('escribir').innerHTML = "Hay [- " + a + " -] A en esa frase. :)<br />";
            document.getElementById('escribir').innerHTML += "Hay [- " + e + " -] E en esa frase. :)<br />";
            document.getElementById('escribir').innerHTML += "Hay [- " + i + " -] I en esa frase. :)<br />";
            document.getElementById('escribir').innerHTML += "Hay [- " + o + " -] O en esa frase. :)<br />";
            document.getElementById('escribir').innerHTML += "Hay [- " + u + " -] U en esa frase. :)<br />";
            setTimeout(limpieza, 2000);
        }

        function divisiblex4() {
            var num = prompt("Introduzca un número:", "");
            var opc = prompt("Introduce el número por el que quieres adivinar si es divisible(2,3,5 o 7):");
            var comparacion;
            if ((opc != 2) || (opc != 3) || (opc != 5) || (opc != 7)){
                comparacion = "Lo sentimos tiene que poner un número valido!! (2,3,5 o 7)";
            }
            else {
                switch (opc) {
                    case 2:
                        break;
                    case 3:
                        break;
                    case 5:
                        break;
                    case 7:
                        break;
                }
            }
            document.getElementById('escribir').innerHTML = "";
            dar_estilo();
            document.getElementById('escribir').innerHTML = comparacion;
            setTimeout(limpieza, 2000);
        }
    </script>
</body>
</html>
