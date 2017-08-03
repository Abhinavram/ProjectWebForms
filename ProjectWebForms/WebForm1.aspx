<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProjectWebForms.WebForm1" %>

<!DOCTYPE html>

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
    <h2> Details </h2>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <p>
            &nbsp;</p>
        <table border="1">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="Employee Details" Width="130px" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Height="30px" OnClick="Button2_Click" Text="Customer Details" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
