<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoUsuarios.aspx.cs" Inherits="bancouh1.Presentacion.CatalogoUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" type="text/css" href="/css/Estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
    <li><a class="active" href="Menu.aspx">Inicio</a></li>
    <li><a href="CatalogoUsuarios.aspx">Usuario</a></li>
    <li><a href="Presentacion/Contacto.aspx">Contacto</a></li>
    <li><a href="Presentacion/AcercaDe.aspx">Acerca de</a></li>
</ul>
        <div>
        <div>
            <h2>Catalogo de Usuarios</h2>
            <p>Bienvenido al catalogo de usuarios.</p>
        </div>
            <br />
            <div>
                
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />                
            </div>

            <div>
                <label for="txtNombre">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <br />
                <label for="txtcorreo">Correo:</label>
                <asp:TextBox ID="txtcorreo"  runat="server" > </asp:TextBox>
                <br />
                <label for="txtclave">Clave:</label>
                <asp:TextBox ID="txtclave" TextMode="Password" runat="server"></asp:TextBox>
                <br />
            </div>
            <br />
            <div>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"  />
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"  />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
           
            </div>
    </form>
</body>
</html>
