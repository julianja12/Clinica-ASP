<%@ Page Title="" Language="C#" MasterPageFile="~/PgMaster.Master" AutoEventWireup="true" CodeBehind="InformeCitasPacienteMedico.aspx.cs" Inherits="Clinica_ASP.InformeCitasPacienteMedico" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <h1>
        Informe de Citas Medicas</h1>
    <p>
        &nbsp;</p>
    <p>

    <asp:Label ID="Label3" runat="server" Text="Cedula Usuario:"></asp:Label>
        <asp:TextBox ID="txtCedulaReporte" runat="server"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionReporte" runat="server" 
             ErrorMessage="Debe Ingresar  su Cedula" ForeColor="Red" 
             ValidationExpression="^[0-9]*$" ControlToValidate="txtCedulaReporte"></asp:RegularExpressionValidator>
    <asp:Button ID="btnReporte" runat="server" CssClass="btn btn-primary" 
            Text="Buscar" onclick="btnReporte_Click" />
    </p>
    <p>
    <asp:Label ID="Label2" runat="server" Text="Tipo de Usuario"></asp:Label>
    <asp:DropDownList ID="ddlTipo" runat="server" Height="16px" Width="129px">
        <asp:ListItem Value="02">Medico</asp:ListItem>
        <asp:ListItem Value="03">Paciente</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnTipoU" runat="server" CssClass="btn btn-primary" 
        onclick="btnRol_Click" Text="Buscar Tipo Usuario" />
      </p>
    <p>
        &nbsp;</p>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" InteractiveDeviceInfos="(Colección)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="683px">
        <LocalReport ReportPath="ReporteInformeCitas.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Clinica_ASP.PortalWebDataSetTableAdapters.InformeCitasTableAdapter">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtCedulaReporte" Name="cedula" 
                PropertyName="Text" Type="Int32" />
            <asp:ControlParameter ControlID="ddlTipo" Name="TipoUsuario" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    </form>
</asp:Content>
