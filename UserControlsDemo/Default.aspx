<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControlsDemo.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="NumIngredientsDropDownList" runat="server" OnSelectedIndexChanged="NumIngredientsDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button Text="Generate" runat="server" ID="GenerateButton" OnClick="GenerateButton_Click" />
    <asp:panel runat="server" ID="IngredientsPanel">
        <asp:Label Text="N/A" runat="server" />
    </asp:panel>
    </div>
    </form>
</body>
</html>
