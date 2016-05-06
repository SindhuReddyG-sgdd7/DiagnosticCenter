<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Patient.master" AutoEventWireup="true" CodeBehind="ApplicationStatus.aspx.cs" Inherits="DiagnosticCenter.ApplicationStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
<div style="height: 350px; width: 1000px">
<asp:Label ID="Label3" runat="server" Text="" Style="z-index: 1; left: 315px; top: 79px;
                position: absolute; height: 20px;" Font-Bold="True" Font-Size="Large" 
            ForeColor="#CC0000"></asp:Label>
        <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 142px; top: 32px;
                position: absolute" Text="Enter Application ID :" Font-Bold="True" 
            Font-Size="Medium" ForeColor="#003399"></asp:Label>
        <asp:TextBox ID="TxtAppID" runat="server" Style="z-index: 1; left: 315px; top: 29px;
                position: absolute" CausesValidation="true" TabIndex="1"></asp:TextBox>        
        <asp:Button ID="ButtonCheck" runat="server" Text="Check Status" Style="z-index: 1; left: 480px;
                top: 28px; position: absolute; height: 23px; width: 100px;" TabIndex="2" 
        onclick="ButtonCheck_Click"/>
        <asp:Label ID="Label2" runat="server" Style="z-index: 1; left: 231px; top: 81px;
                position: absolute; height: 20px;" Text="Status   :" 
        Visible="False" Font-Bold="True" 
            Font-Size="Large" ForeColor="#0033CC"></asp:Label>
        
</div>
</asp:Content>
