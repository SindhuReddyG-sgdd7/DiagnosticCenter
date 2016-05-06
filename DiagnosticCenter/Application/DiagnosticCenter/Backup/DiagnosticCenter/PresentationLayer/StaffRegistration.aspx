<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Manager.master" AutoEventWireup="true"
    CodeBehind="StaffRegistration.aspx.cs" Inherits="DiagnosticCenter.WebForm2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="newcontent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        <div>
            <asp:Label ID="lblUser" runat="server" 
                
                style="z-index: 1; left: 109px; top: 63px; position: absolute; width: 34px;" 
                Text="Label" ForeColor="#009900"></asp:Label>
            <asp:Label ID="lblUserName" runat="server" 
                style="z-index: 1; left: 18px; top: 62px; position: absolute" 
                Text="User Name :" ForeColor="Black"></asp:Label>
            <asp:Label ID="lblReg" runat="server" ForeColor="#009900" 
                style="z-index: 1; left: 14px; top: 32px; position: absolute" 
                Text="Registered Successfully..............!"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" 
                
                style="z-index: 1; left: 17px; top: 89px; position: absolute; height: 19px;" 
                Text="Password :" ForeColor="Black"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblPwd" runat="server" 
            
                style="z-index: 1; left: 99px; top: 89px; position: absolute; height: 19px; width: 34px;" 
                Text="Label" ForeColor="#009900"></asp:Label>
        </div>
    <asp:Label ID="lblTitle" runat="server" Text="STAFF REGISTRATION FORM" Style="z-index: 1;
        left: 233px; top: 14px; position: absolute" Font-Bold="True" Font-Size="Larger"
        ForeColor="#333300" AssociatedControlID="TxtFN"></asp:Label>
    <asp:Panel ID="staffReg" runat="server" BackColor="Silver" Style="z-index: 101; left: 100px;
        position: absolute; top: 50px; height: 400px; width: 550px;">
        <asp:Label ID="LabelFN" runat="server" Style="z-index: 1; left: 73px; top: 20px;
            position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="TxtFN" runat="server" Style="z-index: 1; left: 202px; top: 20px;
            position: absolute" TabIndex="1"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorFN" runat="server"
            ControlToValidate="TxtFN" ErrorMessage="Enter only alphabets" ForeColor="Red"
            ValidationExpression="[a-zA-Z]+" Style="z-index: 1; left: 377px; top: 20px;
            position: absolute" SetFocusOnError="true"></asp:RegularExpressionValidator>
        <asp:Label ID="LabelLN" runat="server" Style="z-index: 1; left: 73px; top: 50px;
            position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="TxtLN" runat="server" Style="z-index: 1; left: 202px; top: 50px;
            position: absolute" TabIndex="2"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLN" runat="server" ControlToValidate="TxtLN"
            ErrorMessage="Please Enter Last Name" ForeColor="Red" Style="z-index: 1; left: 377px;
            top: 50px; position: absolute" SetFocusOnError="true">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorLN" runat="server"
            ControlToValidate="TxtLN" ErrorMessage="Enter Only Alphabets" ForeColor="Red"
            ValidationExpression="[a-zA-Z]+" Style="z-index: 1; left: 377px; top: 50px;
            position: absolute" SetFocusOnError="true"></asp:RegularExpressionValidator>
        <asp:Label ID="LabelGender" runat="server" Style="z-index: 1; left: 73px; top: 80px;
            position: absolute" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonListGender" runat="server" RepeatColumns="2"
            Style="z-index: 1; left: 195px; top: 80px; position: absolute" 
            TabIndex="3">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorGender" runat="server" ControlToValidate="RadioButtonListGender"
            ErrorMessage="Please Mention Gender" ForeColor="Red" Style="z-index: 1; left: 377px;
            top: 80px; position: absolute" SetFocusOnError="true">
        </asp:RequiredFieldValidator>
        <asp:Label ID="LabelDOB" runat="server" Style="z-index: 1; left: 73px; top: 110px;
            position: absolute" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="TxtDOB" runat="server" Style="z-index: 1; left: 202px; top: 110px;
            position: absolute" TabIndex="4"></asp:TextBox>
        <cc1:calendarextender id="TxtDOB_CalendarExtender" runat="server" Enabled="True" Format="MM/dd/yyyy" 
            popupposition="Right" targetcontrolid="TxtDOB" onclientdateselectionchanged="SelectDate" >
            </cc1:calendarextender>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDOB" runat="server" ControlToValidate="TxtDOB"
            ErrorMessage="Please Enter DOB" ForeColor="Red" Style="z-index: 1; left: 377px;
            top: 110px; position: absolute" SetFocusOnError="true">
        </asp:RequiredFieldValidator>
        <script type="text/javascript">
            function SelectDate(e) {
                var today = new Date();
                var dob = e.get_selectedDate();
                var year = (today.getFullYear() - dob.getFullYear());
                document.getElementById('<%=TxtAge.ClientID%>').value = year;
            }
        </script>
        <asp:Label ID="LabelAge" runat="server" Style="z-index: 1; left: 73px; top: 140px;
            position: absolute" Text="Age"></asp:Label>
        <asp:TextBox ID="TxtAge" runat="server" Style="z-index: 1; left: 202px; top: 140px;
            position: absolute" ReadOnly="True" TabIndex="5"></asp:TextBox>
        <asp:Label ID="LabelMobile" runat="server" Style="z-index: 1; left: 73px; top: 170px;
            position: absolute" Text="Contact No"></asp:Label>
        <asp:TextBox ID="TxtMobile" runat="server" Style="z-index: 1; left: 202px; top: 170px;
            position: absolute" TabIndex="6"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorMobile" runat="server"
            ControlToValidate="TxtMobile" ErrorMessage="Enter Valid Mobile Number" ForeColor="Red"
            ValidationExpression="^([7-9]{1})([0-9]{9})$" Style="z-index: 1; left: 377px;
            top: 170px; position: absolute; width: 187px;" SetFocusOnError="true"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorMobile" runat="server" ControlToValidate="TxtMobile"
            ErrorMessage="Please Enter Mobile Number" ForeColor="Red" SetFocusOnError="true"
            
            Style="z-index: 1; left: 377px; top: 170px; position: absolute; width: 193px;">
        </asp:RequiredFieldValidator>
        <asp:Label ID="LabelEmail" runat="server" Style="z-index: 1; left: 73px; top: 200px;
            position: absolute" Text="Email ID"></asp:Label>
        <asp:TextBox ID="TxtEmail" runat="server" Style="z-index: 1; left: 202px; top: 200px;
            position: absolute" TabIndex="7"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="TxtEmail"
            ErrorMessage="Please Enter Email ID" ForeColor="Red" Style="z-index: 1; left: 377px;
            top: 204px; position: absolute" SetFocusOnError="true">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server"
            ControlToValidate="TxtEmail" ErrorMessage="Enter Valid Email ID" ForeColor="Red"
            ValidationExpression="^[\w\.\*]+@+(gmail|yahoo|techmahindra)+\.(com)$" Style="z-index: 1;
            left: 377px; top: 202px; position: absolute" SetFocusOnError="true"></asp:RegularExpressionValidator>
        <asp:Label ID="LabelQual" runat="server" Style="z-index: 1; left: 73px; top: 230px;
            position: absolute" Text="Qualification"></asp:Label>
        <asp:TextBox ID="TxtQual" runat="server" Style="z-index: 1; left: 202px; top: 230px;
            position: absolute" TabIndex="8" CausesValidation="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorQual" runat="server" ControlToValidate="TxtQual"
            ErrorMessage="Please Enter Qualification" ForeColor="Red" SetFocusOnError="true"
            
            
            
            Style="z-index: 1; left: 377px; top: 232px; position: absolute; right: -1px;">
        </asp:RequiredFieldValidator>
        <asp:Label ID="LabelExp" runat="server" Style="z-index: 1; left: 73px; top: 260px;
            position: absolute" Text="Experience"></asp:Label>
        <asp:TextBox ID="TxtExp" runat="server" Style="z-index: 1; left: 202px; top: 260px;
            position: absolute" TabIndex="9" CausesValidation="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorExp" runat="server" ControlToValidate="TxtExp"
            ErrorMessage="Please Enter Experience" ForeColor="Red" SetFocusOnError="true"
            Style="z-index: 1; left: 377px; top: 262px; position: absolute">
        </asp:RequiredFieldValidator>
        <asp:Label ID="LabelAddress" runat="server" Style="z-index: 1; left: 71px; top: 290px;
            position: absolute; height: 18px;" Text="Address"></asp:Label>
        <asp:TextBox ID="TxtAddress" runat="server" Style="z-index: 1; left: 202px; top: 290px;
            position: absolute; width: 148px;" TabIndex="10" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" ControlToValidate="TxtAddress"
            ErrorMessage="Please Enter Address" ForeColor="Red" Style="z-index: 1; left: 379px;
            top: 292px; position: absolute" SetFocusOnError="true">
        </asp:RequiredFieldValidator>
        <asp:Label ID="LabelCity" runat="server" Style="z-index: 1; left: 72px; top: 335px;
            position: absolute" Text="City"></asp:Label>
        <asp:TextBox ID="TxtCity" runat="server" Style="z-index: 1; left: 203px; top: 336px;
            position: absolute" TabIndex="11"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server" ControlToValidate="TxtCity"
            ErrorMessage="Please Enter City Name" ForeColor="Red" Style="z-index: 1; left: 379px;
            top: 337px; position: absolute; right: 19px;" SetFocusOnError="true">
        </asp:RequiredFieldValidator>
        <asp:Label ID="LabelPin" runat="server" Style="z-index: 1; left: 73px; top: 374px;
            position: absolute" Text="Pin Code"></asp:Label>
        <asp:TextBox ID="TxtPin" runat="server" Style="z-index: 1; left: 203px; top: 372px;
            position: absolute" TabIndex="12"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPin" runat="server" ControlToValidate="TxtPin"
            ErrorMessage="Please Enter Pincode" ForeColor="Red" Style="z-index: 1; left: 379px;
            top: 373px; position: absolute" SetFocusOnError="true">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorPin" runat="server"
            ControlToValidate="TxtPin" ErrorMessage="Enter Valid Pincode" ForeColor="Red"
            ValidationExpression="^5+([0-9]{5})$" Style="z-index: 1; left: 380px; top: 373px;
            position: absolute" SetFocusOnError="true"></asp:RegularExpressionValidator>
        <asp:Button ID="Button1" runat="server" Text="Register" Style="z-index: 1; left: 202px;
            top: 412px; position: absolute" onclick="Button1_Click" TabIndex="13" />
        <asp:Label ID="lblExist" runat="server" Text="Already Exist" Style="z-index: 1; left: 315px;
            top: 419px; position: absolute" ForeColor="Red"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFN" runat="server" ControlToValidate="TxtFN"
            ErrorMessage="Please enter First Name" ForeColor="Red" SetFocusOnError="true"
            Style="z-index: 1; left: 377px; top: 20px; position: absolute">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorQualification" runat="server" 
            ErrorMessage="Enter Only Alphabets" 
            Style="z-index: 1; left: 377px; top: 233px; position: absolute" 
            ForeColor="Red" ValidationExpression="[a-zA-Z]+" 
            ControlToValidate="TxtQual"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorExperience" runat="server" 
            ErrorMessage="Enter Only Numbers" 
             Style="z-index: 1; left: 377px; top: 262px; position: absolute; height: 19px;" 
            ControlToValidate="TxtExp" ForeColor="Red" 
            ValidationExpression="[0-9]{1,2}"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
            ErrorMessage="Enter Only Alphabets" 
            Style="z-index: 1; left: 380px;
            top: 336px; position: absolute" ControlToValidate="TxtCity" ValidationExpression="[a-zA-Z]+"
            ForeColor="Red"></asp:RegularExpressionValidator>
        
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="TxtDOB" 
            ErrorMessage="Date of birth should be between 01/01/1996 and 01/01/1974" Type="Date"
            ForeColor="Red" 
            
            style="z-index: 1; left: 377px; top: 109px; position: absolute; width: 208px;" 
            MaximumValue="01/01/1996" MinimumValue="01/01/1974"></asp:RangeValidator>
        
    </asp:Panel>
    <cc1:roundedcornersextender id="staffReg_RoundedCornersExtender" runat="server" enabled="True"
        targetcontrolid="staffReg" radius="30">
        </cc1:roundedcornersextender>
</asp:Content>
