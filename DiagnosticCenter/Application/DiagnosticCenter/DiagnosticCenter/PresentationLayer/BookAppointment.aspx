<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Patient.master" AutoEventWireup="true"
    CodeBehind="BookAppointment.aspx.cs" Inherits="DiagnosticCenter.BookAppointment" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <div style="height: 350px; width: 1000px">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="lblAppointmentID" runat="server" Font-Bold="True" 
                style="z-index: 1; left: 349px; top: 14px; position: absolute" 
                Text="Label" ForeColor="Green"></asp:Label>
        <asp:Panel ID="panelAppiontment" runat="server" BackColor="Silver" Style="z-index: 101; position: absolute;
            top: 50px; left: 122px; height: 300px;" Width="550px">
            <asp:Label ID="Label1" runat="server" Text="APPOINTMENT APPLICATION PAGE" Style="z-index: 1;
            left: 80px; position: absolute; top: 2px" Font-Bold="True" Font-Size="Larger"
            ForeColor="#333300" AssociatedControlID="TxtFN"></asp:Label>
            <asp:Label ID="LabelFN" runat="server" Style="z-index: 1; left: 50px; top: 50px;
                position: absolute" Text="Patient Full Name" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TxtFN" runat="server" Style="z-index: 1; left: 200px; top: 50px;
                position: absolute" TabIndex="1" ReadOnly = "true" CausesValidation="true"></asp:TextBox>
            <asp:Label ID="LabelGender" runat="server" Style="z-index: 1; left: 50px; top: 90px;
                position: absolute" Text="Gender" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TxtGender" runat="server" Style="z-index: 1; left: 200px; top: 90px;
                position: absolute" TabIndex="2" ReadOnly = "true" CausesValidation="true"></asp:TextBox>
            <asp:Label ID="LabelService" runat="server" Style="z-index: 1; left: 50px; top: 130px;
                position: absolute" Text="Service Type" Font-Size="Medium"></asp:Label>
            <asp:DropDownList ID="DropDownListService" runat="server" Style="z-index: 1; left: 200px; top: 130px;
                position: absolute;width:154px;height:20px" TabIndex = "3">
                <asp:ListItem></asp:ListItem>
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
                Style="z-index: 1; left: 370px; top: 133px; position: absolute" 
                Font-Size="Medium"></asp:RequiredFieldValidator>
            <asp:Label ID="LabelReason" runat="server" Style="z-index: 1; left: 50px; top: 170px;
                position: absolute" Text="Reason For Visit" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TxtReason" runat="server" Style="z-index: 1; left: 200px; top: 170px;
                position: absolute" TabIndex="4" CausesValidation="true"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorReason" runat="server" ControlToValidate="TxtReason"
                ErrorMessage="Please Enter Reason" ForeColor="Red" Style="z-index: 1; left: 370px;
                top: 170px; position: absolute" SetFocusOnError="true" Font-Size="Medium"></asp:RequiredFieldValidator>
            <asp:Label ID="LabelDate" runat="server" Style="z-index: 1; left: 50px; top: 210px;
                position: absolute" Text="Appointment Date" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TxtDate" runat="server" Style="z-index: 1; left: 200px; top: 210px;
                position: absolute" TabIndex="5"></asp:TextBox>
            <cc1:CalendarExtender ID="TxtDate_CalendarExtender" runat="server" Enabled="True"
                PopupPosition="Right" TargetControlID="TxtDate">
            </cc1:CalendarExtender>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorDate" runat="server" ControlToValidate="TxtDate"
                ErrorMessage="Please Enter DOB" ForeColor="Red" Style="z-index: 1; left: 370px;
                top: 210px; position: absolute" SetFocusOnError="true" Font-Size="Medium"></asp:RequiredFieldValidator>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" Style="z-index: 1; left: 203px;
                top: 259px; position: absolute; height: 26px;"  TabIndex="6" 
                onclick="ButtonConfirm_Click" />
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" Style="z-index: 1; left: 290px;
                top: 259px; position: absolute" TabIndex="7" 
                onclick="ButtonCancel_Click" CausesValidation="False" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TxtReason" ErrorMessage="Enter Only Alphabets" 
                style="z-index: 1; left: 370px; top: 170px; position: absolute" 
                ValidationExpression="[a-zA-Z\s]+" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="TxtDate"  Type="Date"
                ErrorMessage="Appointment available for next week only" ForeColor="Red" 
                style="z-index: 1; left: 371px; top: 209px; position: absolute"></asp:RangeValidator>
        </asp:Panel>
        <cc1:RoundedCornersExtender ID="panelAppiontment_RoundedCornersExtender" 
            runat="server" Enabled="True"
            TargetControlID="panelAppiontment" Radius="30">
        </cc1:RoundedCornersExtender>
    </div>
</asp:Content>
