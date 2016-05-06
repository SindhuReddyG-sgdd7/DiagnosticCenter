<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Manager.master" AutoEventWireup="true" CodeBehind="ConfirmRequests.aspx.cs" Inherits="DiagnosticCenter.PresentationLayer.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="newcontent" runat="server">
    <div>
       <br />
       <asp:DropDownList ID="ddlLoadDate" runat="server" 
           
            
            style="z-index: 1; left: 304px; top: 34px; position: absolute; height: 22px; width: 116px;" 
            TabIndex="1">
           <asp:ListItem Value="-1">----Select----</asp:ListItem>
       </asp:DropDownList>
       <br />
       <asp:Label ID="Label3" runat="server" 
           style="z-index: 1; left: 217px; top: 37px; position: absolute" 
           Text="Select date:"></asp:Label>
       <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
           style="z-index: 1; left: 432px; top: 33px; position: absolute; height: 22px" 
           Text="Get Details" TabIndex="2" />
     <asp:Button ID="btnConfirm" runat="server" Text="Confirm Request" 
           style="z-index: 1; left: 530px; top: 33px; position: absolute; height: 22px" 
           onclick="btnConfirm_Click" TabIndex="3" />
       <br />
       <asp:Label ID="lblStatusGetDetails" runat="server" 
           style="z-index: 1; left: 304px; top: 75px; position: absolute" 
           Text="Please Select Appointment Date" ForeColor="Red"></asp:Label>
       <br />
        <asp:Label ID="lblCnfrm" runat="server" ForeColor="#009900" 
            style="z-index: 1; left: 306px; top: 76px; position: absolute" 
            Text="Application Request Confirmed Successfully.................!"></asp:Label>
       <br />
       <br />
       <br />
       <br />
       <asp:GridView ID="GridView1" runat="server" 
           
           style="z-index: 1; left: 40px; top: 115px; position: absolute; height: 54px; width: 723px" 
           AllowPaging="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" 
           BorderWidth="1px" CellPadding="3" CellSpacing="2" PageSize="1" 
            onpageindexchanging="GridView1_PageIndexChanging">
           <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
           <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
           <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
           <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
           <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
           <SortedAscendingCellStyle BackColor="#FFF1D4" />
           <SortedAscendingHeaderStyle BackColor="#B95C30" />
           <SortedDescendingCellStyle BackColor="#F1E5CE" />
           <SortedDescendingHeaderStyle BackColor="#93451F" />
       </asp:GridView>
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
    </div>
</asp:Content>
