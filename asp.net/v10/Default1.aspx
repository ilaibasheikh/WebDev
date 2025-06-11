<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="v10.Default1" %>

<!DOCTYPE html>
<script runat="server">

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int value;
        
        if (int.TryParse(args.Value, out value))
        {
            
            if (value % 2 == 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        else
        {
            args.IsValid = false;
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Even number</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        
                        <!-- CustomValidator for checking even number -->
                        <asp:CustomValidator ID="CustomValidator1" runat="server" 
                            ControlToValidate="TextBox1" 
                            Display="Dynamic" 
                            ErrorMessage="Input must be an even number." 
                            ForeColor="Red" 
                            OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <!-- CausesValidation is set to true to trigger validation -->
                        <asp:Button ID="Button1" runat="server" Text="Submit" CausesValidation="true" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
