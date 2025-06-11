<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="v2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 117%;
        }
        .auto-style3 {
            width: 197px;
        }
        .auto-style4 {
            width: 75px;
        }
        .auto-style5 {
            width: 75px;
            height: 30px; 
        }
        .auto-style6 {
            width: 197px;
            height: 30px;
        }
        .auto-style7 {
            height: 36px;
        }
        .auto-style8 {
            width: 197px;
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registration Form</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Name</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox1" runat="server" Width="198px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Name required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Email required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Invalid email" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Email again</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server" Width="203px"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="not same emails" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Class</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="199px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="must be from 1-12" ForeColor="Red" MaximumValue="12" MinimumValue="1" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                        Gender</td>
                    <td class="auto-style3">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
                        <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" ErrorMessage="Select one " ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <p>
&nbsp;
    </p>
</body>
</html>
