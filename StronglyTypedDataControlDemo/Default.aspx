<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server" ItemType="Customer">
            <HeaderTemplate>
                <h1>List of Available Customers!!</h1>
            </HeaderTemplate>
            <ItemTemplate>
                <p style="background-color:#000066;color:#FFFFFF;font-weight:bold">
                    Customer Name - <%#Item.ContactName %></p>
                <p style="background-color:#000066;color:#FFFFFF;font-weight:bold">
                    State Name - <%#Item.State %></p>
                <p style="background-color:#000066;color:#FFFFFF;font-weight:bold">
                    Country Name - <%#Item.Country %></p><br />
            </ItemTemplate>
            <FooterTemplate>
                <h3>The above list shows all the customers excluding the Discontinued Customers!!</h3>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
