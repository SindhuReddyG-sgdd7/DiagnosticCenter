<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Staff.master" AutoEventWireup="true"
    CodeBehind="ChangePasswordS.aspx.cs" Inherits="DiagnosticCenter.ChangePasswordS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentStaff" runat="server">
    <div style="height: 500px; width: 500px">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="lblChangePwd" runat="server" 
                style="z-index: 1; left: 170px; top: 30px; position: absolute" 
                Text="Label" ForeColor="#009900"></asp:Label>
        <asp:Panel ID="panelChangePwd" runat="server" BackColor="Silver" Style="z-index: 101; position: absolute;
            left: 160px; top: 50px; width: 480px; height: 220px;">
            <asp:Label ID="Label1" runat="server" Text="CHANGE PASSWORD" Style="z-index: 1; left: 139px; top:8px;
            position: absolute" Font-Bold="True" Font-Size="Larger" ForeColor="#333300"></asp:Label>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="txtNewPwd" ControlToValidate="txtConfirmPwd" 
                ErrorMessage="Passwords are not matched" ForeColor="Red" 
                style="z-index: 1; left: 254px; top: 219px; position: absolute"></asp:CompareValidator>
            <br />
            <br />
            <asp:Label ID="LabelOld" runat = "server" Text="Old Password" Font-Size="Medium"  style="left:80px; position:absolute; top: 55px;"></asp:Label>
            <asp:TextBox ID="txtOldPwd" runat = "server" 
                style="left:250px; position:absolute; top: 55px;" TextMode="Password" 
                TabIndex="1"></asp:TextBox>
            <asp:Label ID="Label2" runat = "server" Text="New Password" Font-Size="Medium" style="left:80px; position:absolute; top: 100px;"></asp:Label>
            <asp:TextBox ID="txtNewPwd" runat = "server" 
                style="left:250px; position:absolute; top: 100px;" TextMode="Password" 
                TabIndex="2" ></asp:TextBox>
            <asp:Label ID="Label3" runat = "server" Text="Re-Enter New Password" Font-Size="Medium" style="left:80px; position:absolute; top: 145px;"></asp:Label>
            <asp:TextBox ID="txtConfirmPwd" runat = "server" 
                style="left:250px; position:absolute; top: 145px;" TextMode="Password" 
                TabIndex="3" ></asp:TextBox>
            <asp:Button ID="ButtonConfirm" runat="server" Text="Submit" 
                onclick="ButtonConfirm_Click" 
                style="left:250px; position:absolute; top: 180px;" TabIndex="4" />
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" 
                style="left:340px; position:absolute; top: 180px;" 
                CausesValidation="False" onclick="ButtonCancel_Click" TabIndex="5"  />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtOldPwd" ErrorMessage="*" ForeColor="Red" 
                style="z-index: 1; left: 412px; top: 55px; position: absolute"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtNewPwd" ErrorMessage="*" ForeColor="Red" 
                style="z-index: 1; left: 412px; top: 100px; position: absolute"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtConfirmPwd" ErrorMessage="*" ForeColor="Red" 
                style="z-index: 1; left: 412px; top: 145px; position: absolute"></asp:RequiredFieldValidator>
        </asp:Panel>
        <cc1:roundedcornersextender ID="panelChangePwd_RoundedCornersExtender" 
            runat="server" Enabled="True"
            TargetControlID="panelChangePwd" Radius="30">
        </cc1:roundedcornersextender>
    </div>
</asp:Content>
