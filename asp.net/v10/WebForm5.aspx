<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="v10.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<a href="WebForm6.aspx">third Page</a>--%>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm6.aspx">Third Page</asp:LinkButton>
        </div>
    </form>
</body>
</html>
