<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTipo_Usuario.aspx.cs" Inherits="Proyeto_Beta.Tipo_Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 490px; width: 312px">
    
        ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Contraseña:
        <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
        <br />
        <br />
        ID Usuario
        <asp:TextBox ID="txtIDUsu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="rbtUsuario" runat="server" Text="Usuario" OnCheckedChanged="rbtUsuario_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbtOrganizador" runat="server" Text="Organizador" OnCheckedChanged="rbtOrganizador_CheckedChanged" />
        <br />
        <br />
        Primero debe ingresar sus datos --&gt;<a href="frmUsuario.aspx">Enlace</a>
        <br />
        <br />
        <asp:GridView ID="dgvUsuario" runat="server" OnRowCommand="Seleccionar">
            <Columns>
                <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" />
            </Columns>
        </asp:GridView>
    
        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="Accion" Text="Agregar" />
        <asp:Button ID="btnModificar" runat="server" OnClick="Accion" Text="Modificar" />
        <asp:Button ID="btnEliminar" runat="server" OnClick="Accion" Text="Eliminar" />
        <asp:Button ID="btnLimpiar" runat="server" OnClick="Accion" Text="Limpiar" />
    
    </div>
    </form>
</body>
</html>
