<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="SvLuka.Error" %>

<%@ Register Src="controls/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<%@ Register Src="controls/MainNavBar.ascx" TagName="MainNavBar" TagPrefix="uc2" %>
<%@ Register Src="controls/Footer.ascx" TagName="Footer" TagPrefix="uc3" %>
<%@ Register Src="controls/Right.ascx" TagName="Right" TagPrefix="uc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sv Luka</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="Table1" border="0" cellpadding="0" cellspacing="0" height="100%" width="100%">
            <tr>
                <td height="10" rowspan="2" valign="top" width="20">
                    &nbsp;<uc2:MainNavBar ID="MainNavBar2" runat="server" />
                </td>
                <td align="center" height="10" valign="top" width="10">
                </td>
                <td align="center" height="10" valign="top">
                    <uc1:Header ID="Header1" runat="server" />
                </td>
                <td align="center" height="10" valign="top" width="10">
                </td>
                <td align="center" height="10" valign="top" width="10">
                </td>
            </tr>
            <tr>
                <td valign="top">
                </td>
                <td valign="top">
                    <p align="center">
                        <asp:Label ID="lblTroparon" runat="server" Text="OUPS - some problem occured with our web site... We apologize..."></asp:Label><br />
                        <br />
                    </p>
                    <p align="left">
                        &nbsp;</p>
                </td>
                <td valign="top">
                </td>
                <td valign="top">
                    &nbsp;<uc4:Right ID="Right2" runat="server" />
                </td>
            </tr>
            <tr>
                <td height="10">
                </td>
                <td align="center" height="10">
                </td>
                <td align="center" height="10">
                    <uc3:Footer ID="Footer1" runat="server" />
                </td>
                <td align="center" height="10">
                </td>
                <td align="center" height="10">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
