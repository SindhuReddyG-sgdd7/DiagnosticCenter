<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/Manager.master" AutoEventWireup="true" CodeBehind="ViewStaffDetails.aspx.cs" Inherits="DiagnosticCenter.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="newcontent" runat="server">
    <div style="position:absolute;left:30px;top:10px;">
<asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" AutoGenerateColumns="False" 
        onpageindexchanging="GridView1_PageIndexChanging1" Height="10px" 
    Width="572px" AllowPaging="True" style="margin-left: 64px" PageSize="2" >
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="FirstName,UserName,PhoneNo,Email,City,Pincode" 
                DataNavigateUrlFormatString="~/PresentationLayer/StaffUpdateandRemove.aspx?FirstName={0}&amp;UserName={1}&amp;PhoneNo={2}&amp;EMail={3}&amp;City={4}&amp;Pincode={5}" 
                DataTextField="FirstName" HeaderText="Name" />
            <asp:TemplateField HeaderText="User Name ">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" 
                        Text='<%# DataBinder.Eval(Container.DataItem, "UserName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Phone No">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" 
                        Text='<%# DataBinder.Eval(Container.DataItem, "PhoneNo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EMail">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" 
                        Text='<%# DataBinder.Eval(Container.DataItem, "EMail") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" 
                        Text='<%# DataBinder.Eval(Container.DataItem, "City") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PinCode">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" 
                        Text='<%# DataBinder.Eval(Container.DataItem, "Pincode") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
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
    </div>
</asp:Content>
