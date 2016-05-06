<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Staff.master" AutoEventWireup="true"
    CodeBehind="AddPatient.aspx.cs" Inherits="DiagnosticCenter.AddPatient" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentStaff" runat="server">
    <div style="height: 350px; width: 1000px">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="lblDetialsStatus" runat="server" 
                style="z-index: 1; left: 217px; top: 20px; position: absolute; height: 19px;" 
                Text="Label" ForeColor="#009900"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" BackColor="Silver" Style="z-index: 101; position: absolute;
            top: 50px; left: 100px; height: 297px; width: 532px;">
            <asp:Label ID="Label2" runat="server" Text="ADD PATIENT DETAILS" Style="z-index: 1;
                left: 141px; position: absolute; top: 4px" Font-Bold="True" Font-Size="Larger"
                ForeColor="#333300"></asp:Label>
            <asp:Label ID="LabelName" runat="server" Style="z-index: 1; left: 50px; top: 80px;
                position: absolute" Text="Patient Full Name" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server" Style="z-index: 1; left: 198px; top: 80px;
                position: absolute" TabIndex="2" CausesValidation="true"></asp:TextBox>
            <asp:Label ID="LabelAge" runat="server" Style="z-index: 1; left: 50px; top: 141px;
                position: absolute" Text="Age" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TxtAge" runat="server" Style="z-index: 1; left: 198px; top: 139px;
                position: absolute" TabIndex="4" CausesValidation="true"></asp:TextBox>
            <asp:Label ID="LabelService" runat="server" Style="z-index: 1; left: 50px; top: 177px;
                position: absolute" Text="Service Type" Font-Size="Medium"></asp:Label>
            <asp:DropDownList ID="DropDownListService" runat="server" Style="z-index: 1; left: 198px;
                top: 175px; position: absolute; height: 20px; width: 157px;" TabIndex="5">
                <asp:ListItem> </asp:ListItem>
                <asp:ListItem>Blood Test</asp:ListItem>
                <asp:ListItem>Urine Test</asp:ListItem>
                <asp:ListItem>Lipid Profile</asp:ListItem>
                <asp:ListItem>Thyroid Test</asp:ListItem>
                <asp:ListItem>Ultra Sound Test</asp:ListItem>
                <asp:ListItem>X-Ray</asp:ListItem>
                <asp:ListItem>ECG</asp:ListItem>
                <asp:ListItem>EEG</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorService" InitialValue="" 
                runat="server" ControlToValidate="DropDownListService"
                ErrorMessage="Please Select Service" ForeColor="Red" SetFocusOnError="true"
                Style="z-index: 1; left: 366px; top: 176px; position: absolute" 
                Font-Size="Medium"></asp:RequiredFieldValidator>
            <asp:Label ID="LabelDoctor" runat="server" Style="z-index: 1; left: 50px; top: 214px;
                position: absolute" Text="Referred by doctor" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TxtDoctor" runat="server" Style="z-index: 1; left: 198px; top: 211px;
                position: absolute" TabIndex="6" CausesValidation="true"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorDoctor" runat="server" ControlToValidate="TxtDoctor"
                ErrorMessage="Please enter Doctor Name" ForeColor="Red" SetFocusOnError="true"
                Style="z-index: 1; left: 365px; top: 210px; position: absolute" 
                Font-Size="Medium"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorDoctor" runat="server"
                ControlToValidate="TxtDoctor" ErrorMessage="Enter only alphabets" ForeColor="Red"
                ValidationExpression="[a-zA-Z]+" Style="z-index: 1; left: 365px; top: 211px;
                position: absolute" SetFocusOnError="true" Font-Size="Medium"></asp:RegularExpressionValidator>
            <asp:Button ID="Button1" runat="server" Text="Submit" Style="z-index: 1; left: 200px;
                top: 260px; position: absolute;" TabIndex="7" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" Style="z-index: 1; left: 280px;
                top: 260px; position: absolute; height: 24px;" TabIndex="8" 
                CausesValidation="False" onclick="Button2_Click" />
            <asp:Label ID="Label3" runat="server" 
                style="z-index: 1; left: 52px; top: 45px; position: absolute" 
                Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" 
                style="z-index: 1; left: 198px; top: 40px; position: absolute" 
                ReadOnly="True" TabIndex="1"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" 
                style="z-index: 1; left: 51px; top: 113px; position: absolute" 
                Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal" 
                
                
                style="z-index: 1; left: 191px; top: 106px; position: absolute; height: 27px; width: 142px" 
                TabIndex="3">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TxtName" ErrorMessage="Please Enter Full Name" 
                ForeColor="Red" 
                style="z-index: 1; left: 364px; top: 82px; position: absolute"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TxtName" ErrorMessage="Enter Only Alphabets" ForeColor="Red" 
                style="z-index: 1; left: 364px; top: 82px; position: absolute" 
                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="rblGender" ErrorMessage="Please Select Gender" 
                ForeColor="Red" 
                
                style="z-index: 1; left: 365px; top: 110px; position: absolute; height: 18px"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TxtAge" ErrorMessage="Please Enter Age" ForeColor="Red" 
                style="z-index: 1; left: 365px; top: 141px; position: absolute"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ErrorMessage="Age Should be between 5-70 years"  MaximumValue="70" 
                MinimumValue="5" Type="Integer" ControlToValidate="TxtAge"
                style="z-index: 1; left: 365px; top: 141px; position: absolute" 
                ForeColor="Red"></asp:RangeValidator>
        </asp:Panel>
        <cc1:RoundedCornersExtender ID="Panel1_RoundedCornersExtender" runat="server" Enabled="True"
            TargetControlID="Panel1" Radius="30">
        </cc1:RoundedCornersExtender>
    </div>
</asp:Content>
