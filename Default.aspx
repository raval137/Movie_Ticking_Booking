<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #header
        {
            font-size:larger;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <thead>
                <td colspan="2"id="header">Welcome to MyShowBooking</td>
            </thead>
            <tr>
                <td colspan="2">Please Pick a Title</td>
            </tr>
            <tr>
                <td>WAR</td>
                <td>JOKER</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="war1" runat="server" Text="10:00 PM" OnClick="war1_Click" />
                </td>
                <td>
                    <asp:Button ID="joker1" runat="server" Text="08:00 PM" OnClick="joker1_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="war2" runat="server" Text="11:45 PM" OnClick="war2_Click" />
                </td>
                <td>
                    <asp:Button ID="joker2" runat="server" Text="11:00 PM" OnClick="joker2_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
