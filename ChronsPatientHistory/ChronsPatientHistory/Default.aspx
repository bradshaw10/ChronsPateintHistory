<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChronsPatientHistory._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="CheckBoxLabel" runat="server">Gender: </asp:Label>
        <asp:RadioButton ID="CheckBox1" runat="server" GroupName="gender" Text="Male" />
        <asp:RadioButton ID="CheckBox2" runat="server" GroupName="gender" Text="Female" />
    </div>
    <div>
        <asp:Label ID="HeightLabel" runat="server">Height:</asp:Label>
        <asp:TextBox ID="HeightBox" runat="server" ToolTip="Height in CM"></asp:TextBox>

        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>CM</asp:ListItem>
            <asp:ListItem>Inches</asp:ListItem>
        </asp:DropDownList>
        :<br />

    </div>
    Weight:<asp:TextBox ID="WeightBox" runat="server"></asp:TextBox>
    <asp:DropDownList ID="WeightDropdown" runat="server">
    </asp:DropDownList>
    <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />

</asp:Content>
