<%@ Page Language="c#" CodeBehind="Donation.aspx.cs" AutoEventWireup="True" Inherits="SvLuka.Donations.Donation" %>

<%@ Register TagPrefix="uc1" TagName="Header" Src="../controls/Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="../controls/Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Right" Src="../controls/Right.ascx" %>
<%@ Register TagPrefix="uc1" TagName="MainNavBar" Src="../controls/MainNavBar.ascx" %>
<%@ Register Src="~/Donations/90Month/90Month.ascx" TagPrefix="uc1" TagName="Month" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>Donation</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">

</head>
<body>


    <form id="Form1" method="post" runat="server">
        <table id="Table3" height="100%" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td valign="top" width="20" height="10" rowspan="2">
                    <uc1:MainNavBar ID="MainNavBar1" runat="server"></uc1:MainNavBar>
                </td>
                <td valign="top" align="center" width="10" height="10"></td>
                <td valign="top" align="center" height="10">
                    <uc1:Header ID="Header1" runat="server"></uc1:Header>
                </td>
                <td valign="top" align="center" width="10" height="10"></td>
                <td valign="top" align="center" width="10" height="10"></td>
            </tr>
            <tr>
                <td valign="top"></td>
                <td valign="top">
                    <uc1:Month runat="server" ID="Month" />
                    <p>&nbsp;</p>
                    <p>&nbsp;</p>
                </td>
                <td valign="top"></td>
                <td valign="top" align="center" width="300px">
                    <div style="text-align: center; width: 100%; padding-top: 200px">
                        <a href='https://secure.etransfer.com/SLSOC/Campaign.cfm' target="_blank">
                            <img border="0" src="/SvLuka/imgs/click-to-donate-big.gif"></a>
                    </div>

                </td>
            </tr>
            <tr>
                <td height="10"></td>
                <td align="center" height="10"></td>
                <td align="center" height="10">
                    <uc1:Footer ID="Footer1" runat="server"></uc1:Footer>
                </td>
                <td align="center" height="10"></td>
                <td align="center" height="10"></td>
            </tr>
        </table>
    </form>
</body>
</html>
