<%@ Page Title="" Language="C#" MasterPageFile="~/inicio.Master" AutoEventWireup="true" CodeBehind="CrearCuentaU.aspx.cs" Inherits="Chocoloco.CrearCuentaU" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 93px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="contenido">
    <div id="sesion">
        <p>
            CREAR UNA CUENTA</p>
        <table class="cuenta">
            <tr>
                <p class="cuentasup">
                    Informacion personal
                </p>
            </tr>
            <tr>
                <td>
                    Nombre:
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>
                Rut:
                </td>
                <td>
                    <asp:TextBox ID="txtRut" type="password" runat="server"></asp:TextBox>
                </td>
                <td class="style1">
                    Apellido Materno:
                </td>
                <td>
                    <asp:TextBox ID="txtAp" runat="server"></asp:TextBox>
                </td>
                <td>
                    Apellido Paterno:
                </td>
                <td>
                    <asp:TextBox ID="txtApM" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Direccion de email:
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    Direccion:
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
                <td class="style1">
                Fecha nacimiento:
                </td>
                <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                <td>
                    Telefono:
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Contraseña:
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" type="password" runat="server"></asp:TextBox>
                </td>
                <td>
                    Repita contraseña:
                </td>
                <td>
                    <asp:TextBox ID="txtPassword2" type="password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Crear Cuenta" 
                    onclick="Button2_Click" />
            </td>
            </tr>
        </table>
         </div>
    </div>
</asp:Content>
