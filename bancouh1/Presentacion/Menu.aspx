<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="bancouh1.Presentacion.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="/css/Estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a class="active" href="Menu.aspx">Inicio</a></li>
                <li><a href="CatalogoUsuarios.aspx">Usuario</a></li>
                <li><a href="Contacto.aspx">Contacto</a></li>
                <li><a href="AcercaDe.aspx">Acerca de</a></li>
            </ul>
        </div>
    </form>
</body>
</html>
