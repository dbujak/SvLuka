<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewLoan2018.aspx.cs" Inherits="SvLuka.Donations.NewLoan2018" %>

<%@ Register src="../controls/Right.ascx" tagname="Right" tagprefix="uc1" %>
<%@ Register src="../controls/MainNavBar.ascx" tagname="MainNavBar" tagprefix="uc1" %>
<%@ Register src="../controls/Footer.ascx" tagname="Footer" tagprefix="uc1" %>
<%@ Register src="../controls/Header.ascx" tagname="Header" tagprefix="uc1" %>

<%@ Register src="NewLoan/NewLoan.ascx" tagname="NewLoan" tagprefix="uc2" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >

<html>
<head runat="server">
    <title>New Loan</title>
</head>
<body>
        <form id="form1" runat="server">
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

                    <uc2:NewLoan ID="NewLoan1" runat="server" />
                    <br />
                    <br />
                    <br />
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
