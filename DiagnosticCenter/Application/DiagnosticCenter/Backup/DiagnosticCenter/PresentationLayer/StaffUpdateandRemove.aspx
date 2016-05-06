<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Manager.master" AutoEventWireup="true" CodeBehind="StaffUpdateandRemove.aspx.cs" Inherits="DiagnosticCenter.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="newcontent" runat="server">
<div>
    <br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="Enter Valid Phone Number"  ValidationExpression="^([7-9]{1})([0-9]{9})$"
        style="z-index: 1; left: 420px; top: 124px; position: absolute" 
        ForeColor="Red" ControlToValidate="txtPhoneNo"></asp:RegularExpressionValidator>
    <br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
        ErrorMessage="Enter Only Alphabets" ValidationExpression="[a-zA-Z]{1,25}"
        style="z-index: 1; left: 420px; top: 192px; position: absolute" 
        ControlToValidate="txtCity" ForeColor="Red"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label1" runat="server" 
        style="z-index: 1; left: 144px; top: 51px; position: absolute" Text="Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" 
        style="z-index: 1; left: 258px; top: 48px; position: absolute" 
        ReadOnly="True"></asp:TextBox>
    <asp:TextBox ID="txtUserName" runat="server" 
        style="z-index: 1; left: 258px; top: 85px; position: absolute" 
        ReadOnly="True"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ErrorMessage="Enter Valid EMail"  ValidationExpression="^[\w\.\*]+@+(gmail|yahoo|techmahindra)+\.(com)$"
        style="z-index: 1; left: 420px; top: 160px; position: absolute" 
        ControlToValidate="txtEmail" ForeColor="Red"></asp:RegularExpressionValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
        ErrorMessage="Enter Valid Pincode" ValidationExpression="^5+([0-9]{5})$"
        style="z-index: 1; left: 420px; top: 230px; position: absolute" 
        ControlToValidate="txtPinCode" ForeColor="Red"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label3" runat="server" 
        style="z-index: 1; left: 144px; top: 123px; position: absolute" 
        Text="Phone No"></asp:Label>
    <asp:TextBox ID="txtPhoneNo" runat="server" 
        style="z-index: 1; left: 258px; top: 122px; position: absolute"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtPhoneNo" ErrorMessage="Please Enter Phone Number" 
        ForeColor="Red" 
        style="z-index: 1; left: 420px; top: 124px; position: absolute"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" 
        style="z-index: 1; left: 144px; top: 87px; position: absolute" 
        Text="UserName"></asp:Label>
    <br />
    <asp:TextBox ID="txtEmail" runat="server" 
        style="z-index: 1; left: 258px; top: 156px; position: absolute"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" 
        style="z-index: 1; left: 144px; top: 157px; position: absolute; height: 20px" 
        Text="E Mail"></asp:Label>
    <asp:TextBox ID="txtCity" runat="server" 
        style="z-index: 1; left: 258px; top: 191px; position: absolute"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtEmail" ErrorMessage="Please Enter EMail" ForeColor="Red" 
        style="z-index: 1; left: 420px; top: 160px; position: absolute"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" 
        style="z-index: 1; left: 144px; top: 223px; position: absolute" 
        Text="PinCode"></asp:Label>
    <asp:TextBox ID="txtPinCode" runat="server" 
        style="z-index: 1; left: 258px; top: 225px; position: absolute"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="txtCity" ErrorMessage="Please Enter City" ForeColor="Red" 
        style="z-index: 1; left: 420px; top: 193px; position: absolute"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label5" runat="server" 
        style="z-index: 1; left: 144px; top: 189px; position: absolute; height: 19px" 
        Text="City"></asp:Label>
    <br />
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txtPinCode" ErrorMessage="Please Enter Pincode" 
        ForeColor="Red" style="z-index: 1; left: 420px; top: 230px; position: absolute"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="z-index: 1; left: 187px; top: 268px; position: absolute" Text="Update" />
    <asp:Button ID="Button2" runat="server" 
        
        style="z-index: 1; left: 281px; top: 266px; position: absolute; width: 61px;" 
        Text="Remove" onclick="Button2_Click" />
    <br />
    <br />
    <asp:Label ID="lblUpdate" runat="server" 
        style="z-index: 1; left: 229px; top: 311px; position: absolute" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    
</div>
</asp:Content>

