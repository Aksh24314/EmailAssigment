<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmailForm.aspx.cs" Inherits="EmailForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Send Mails</h1>

    </div>
        <table cellpadding="2" cellspacing="5" class="auto-style1">
            <tr>
                <td>FROM:</td>
                <td>
                    <asp:TextBox ID="txtFrom" runat="server" Width ="250PX"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>To :</td>
                <td>
                    <asp:TextBox ID="txtTo" runat="server" Width="250PX"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>CC :</td>
                <td>
                    <asp:TextBox ID="TxtCC" runat="server" Width="250PX"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>SUBJECT</td>
                <td>
                    <asp:TextBox ID="TxtSubject" runat="server" Width="250PX"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>BODY</td>
                <td>
                    <asp:TextBox ID="TxtBody" runat="server" Width="250PX" Height="100px" TextMode="MultiLine" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="BtnSend" runat="server" Text="SEND" OnClick="BtnSend_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
