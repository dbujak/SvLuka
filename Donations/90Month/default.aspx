<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SvLuka.Donations._90Month._default" %>

<%@ Register Src="~/Donations/90Month/90Month.ascx" TagPrefix="uc1" TagName="Month" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Month runat="server" ID="Month" />
    </div>
    </form>
</body>
</html>
