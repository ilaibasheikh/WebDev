<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="v38.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" id="btn" value="click to get data" />
            <div id="result">
                 
            </div>
        </div>
    </form>
    <script src="scripts/Jquery.js"></script>
    <script>
        $(document).ready(function () {
            $('#btn').click(function () {
                //$('#result').load('pages/TextFile1.txt');
                $('#result').load('pages/HtmlPage1.html', function (responseTxt, statusTxt, xhr) {
                    alert(responseTxt);
                    alert(statusTxt);
                    alert(xhr);
                });
            });
        });
    </script>
</body>
</html>
