<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="v38.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" placeholder="name" id="uname" />
            <input type="text" placeholder="surname" id="surname" />
            <input type="button" value="submit" id="btn" />
            <h2 id="result"></h2>
        </div>
    </form>
    <script src="scripts/Jquery.js"></script> <!-- Ensure jQuery is loaded correctly -->
    <script>
        $(document).ready(function () {
            $('#btn').click(function () {
                var uname = $("#uname").val();
                var surname = $("#surname").val();

                // Check if both fields are filled
                if (uname == "" || surname == "") {
                    alert("All fields are required");
                } else {
                    $.ajax({
                        url: 'WebForm2.aspx/GetData',  // URL of the WebMethod
                        type: 'POST',
                        contentType: 'application/json; charset=utf-8',
                        data: JSON.stringify({ uname: uname, surname: surname }), // Send data as JSON
                        dataType: 'json',
                        success: function (result) {
                            $('#result').text(result.d); // Display the result in <h2>
                        },
                        error: function (xhr, status, error) {
                            alert("An error occurred: " + error); // Show error if any
                        }
                    });
                }
            });
        });
    </script>
</body>
</html>
