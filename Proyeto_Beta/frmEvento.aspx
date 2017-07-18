<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEvento.aspx.cs" Inherits="Proyeto_Beta.frmEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 670px;
        }
        #TextArea1 {
            height: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Código:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIDEvento" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre:&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion:<asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Costo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCosto" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
       <br />
        <br />
        Cupo:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
        <br />
        <br />
        ID Dirección:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIDDireccion" runat="server"></asp:TextBox>
        <br />
        <br />
        ID Organizador:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIDOrganizador" runat="server"></asp:TextBox>
        <br />
        <br />
        ID Claificación:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIDClasificacion" runat="server"></asp:TextBox>
        <br />
        <br />
        Categoria:
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="NOMBRE" DataValueField="NOMBRE" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConectarConProyecto %>" SelectCommand="SELECT [NOMBRE] FROM [CLASIFICACION]"></asp:SqlDataSource>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Horario<br />
        <br />
        Código:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <br />
        <br />
        Fecha Inicio:&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtFechaInicio" runat="server" TextMode="DateTime"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        Fecha Fin:&nbsp; 
        <asp:TextBox ID="txtFechaFin" runat="server" TextMode="DateTime"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <br />
        &nbsp;Dia:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDia" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="Accion" Text="Agregar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModificar" runat="server" OnClick="Accion" Text="Modificar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEliminar" runat="server" OnClick="Accion" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVer" runat="server" OnClick="btnVer_Click" Text="Ver" />
        <br />
        <br />
        <asp:GridView ID="dgvDatos" runat="server" OnRowCommand="Seleccionar">
            <Columns>
                <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" />
            </Columns>
        </asp:GridView>
        <br />
        
    </form>
</body>
</html>
