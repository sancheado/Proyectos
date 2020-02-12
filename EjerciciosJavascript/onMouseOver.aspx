<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="onMouseOver.aspx.vb" Inherits="MyWebSite.onMouseOver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>OnMouseOver()</title>
    <style type="text/css">
        .cuadrado{margin: 10px; padding:15px; border:1px solid black;width:5%}
        .azul{background-color:blue;}
        .rojo{background-color:Red;}
        .amarillo{background-color:Yellow;}
        .verde{background-color:Green;}
        .negro{background-color:Black;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cuadrado azul" onmouseover="changecolor('Blue')">
        </div>
        <div class="cuadrado verde" onmouseover="changecolor('Green')">
        </div>
        <div class="cuadrado amarillo" onmouseover="changecolor('Yellow')">
        </div>
        <div class="cuadrado rojo" onmouseover="changecolor('Red')">
        </div>
        <div class="cuadrado negro" onmouseover="changecolor('Black')">
        </div>
    </form>
    <script type="text/javascript">
        function changecolor(code) {
            document.bgColor = code
        }
        // - End of JavaScript - -->
    </script>
</body>
</html>
