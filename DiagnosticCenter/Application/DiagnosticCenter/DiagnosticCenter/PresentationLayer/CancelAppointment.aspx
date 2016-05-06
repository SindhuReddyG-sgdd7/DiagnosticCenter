<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Patient.master" AutoEventWireup="true"
    CodeBehind="CancelAppointment.aspx.cs" Inherits="DiagnosticCenter.CancelAppointment" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <div style="height: 350px; width: 1000px">
        <asp:Label ID="LabelAppID" runat="server" Style="z-index: 1; left: 125px; top: 30px;
            position: absolute" Text="Enter Application ID :" Font-Bold="True" Font-Size="Medium"
            ForeColor="#333300"></asp:Label>
        <asp:TextBox ID="TxtAppID" runat="server" Style="z-index: 1; left: 290px; top: 28px;
            position: absolute" CausesValidation="true" TabIndex="1"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" Text="Search" Style="z-index: 1; left: 460px;
            top: 28px; position: absolute; height: 23px;" TabIndex="2" 
            OnClick="ButtonSearch_Click" />
        <asp:Button ID="ButtonCancel" runat="server" Visible="false" Text="Cancel" Style="z-index: 1;
            left: 529px; top: 28px;height: 22px; position: absolute" TabIndex="3" 
            OnClick="ButtonCancel_Click" />
        <asp:DetailsView ID="DetailsView1" runat="server" Visible="False" Style="z-index: 1;
            left: 201px; top: 134px; position: absolute"
            Width="400px" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="50px" 
                BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:Label ID="LabelSuccess" runat="server" Visible="False" Style="z-index: 1; left: 291px;
            top: 78px; position: absolute" Font-Bold="True" Font-Size="Larger" 
            ForeColor="#CC0066"></asp:Label>
    </div>
</asp:Content>
