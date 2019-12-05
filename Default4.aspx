<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #aligncentre{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <thead>
                <td id="aligncentre" colspan ="2">JOKER (2019)</td>
                <td id="aligncentre">Showtime: </td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </thead>
            <tr>
                <td colspan="2"  id="aligncentre">Drama, Thriller</td>
                <td id="aligncentre" colspan="2">Select Seats</td>
            </tr>
            <tr>
                <td colspan="2"><img src="JOKER.jpg" /></td>
                <td style="padding:50px">

                    <table>
                        <tr>
                            <td id="aligncentre" colspan ="3">Screen Here</td>
                        </tr>
                        
                        <tr>
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton1_Click" BackColor="Green" />
                            </td>         
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton2_Click" BackColor="Green" />
                            </td>
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton3" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton3_Click" BackColor="Green" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton4" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton4_Click" BackColor="Green" />
                            </td>         
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton5" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton5_Click" BackColor="Green" />
                            </td>
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton6" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton6_Click" BackColor="Green" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton7" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton7_Click" BackColor="Green" />
                            </td>         
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton8" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton8_Click" BackColor="Green" />
                            </td>
                            <td style="padding:5px">
                                <asp:ImageButton ID="ImageButton9" runat="server" Height="50px" ImageUrl="~/21-512.png" Width="50px" OnClick="ImageButton9_Click" BackColor="Green" />
                            </td>
                        </tr>
                    </table>

                </td>
            </tr>
            <tr>
                <td colspan="2"  id="aligncentre">Ratings</td>
                <td rowspan="4">

                    <table>
                        <tr>
                            <td id ="aligncentre">Seat Selected: </td>
                            <td>
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td id ="aligncentre">Total Amount: </td>
                            <td>
                                <asp:Label ID="Label2" runat="server">0</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Payment" style="height: 26px" />
                            </td>
                        </tr>
                    </table>

                </td>
            </tr>
            <tr>
                <td id="aligncentre">IMDB</td>
                <td id="aligncentre">8.8/10</td>
            </tr>
            <tr>
                <td id="aligncentre">Rotten Tomato</td>
                <td id="aligncentre">69%</td>
            </tr>
            <tr>
                <td colspan="2"  id="aligncentre">Trailer</td>
            </tr>
            <tr>
                <td colspan="2"><iframe src="https://www.youtube.com/embed/zAGVQLHvwOY" frameborder="0" allowfullscreen></iframe></td>
            </tr>
        </table>
    </form>
</body>
</html>
