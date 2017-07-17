<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="Proyeto_Beta.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 351px">
    
        Nombre:<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Apellido Paterno:<asp:TextBox ID="txtApeP" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Apellido Materno:<asp:TextBox ID="txtApeM" runat="server"></asp:TextBox>
        <br />
        <br />
        Correo:<asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono:<asp:TextBox ID="txtTelefono" runat="server" MaxLength="10" OnTextChanged="SoloNumeros"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID:<asp:TextBox ID="txtDNI" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="Accion" Text="Agregar" />
        <asp:Button ID="btnModificar" runat="server" OnClick="Accion" Text="Modificar" />
        <asp:Button ID="btnEliminar" runat="server" OnClick="Accion" Text="Eliminar" />
        <asp:Button ID="btnLimpiar" runat="server" OnClick="Accion" Text="Limpiar" />
        <br />
        <asp:GridView ID="dgvDatos" runat="server" OnRowCommand="Seleccionar" OnSelectedIndexChanged="dgvDatos_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" />
            </Columns>
        </asp:GridView>


        <br />


        <a href="frmTipo_Usuario.aspx"><--Go Back</a>
    
    </div>
    </form>
</body>
</html>
