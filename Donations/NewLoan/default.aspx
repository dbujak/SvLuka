<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SvLuka.Donations.NewLoan._default" %>

<%@ Register Src="~/Donations/NewLoan/NewLoan.ascx" TagPrefix="uc1" TagName="NewLoan" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:NewLoan runat="server" id="NewLoan" />
    </div>
    </form>
</body>
</html>
