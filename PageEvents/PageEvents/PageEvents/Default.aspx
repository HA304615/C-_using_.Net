<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PageEvents.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="1">Male</asp:ListItem>
            <asp:ListItem Value="1">Female</asp:ListItem>
        </asp:DropDownList>
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
