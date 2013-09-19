<html>
  <head>
    <title>submit</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </head>
  <body>

<form action="https://www.linkpointcentral.com/lpc/servlet/lppay" method=post name=frmSvLuka>

<%
' Needed this path since credit card processing place doesn't allow aspx pages to submit, and session values won't stay from aspx to asp pages, and I can't have querystring in the address - credit card place reports error
If Request.QueryString("amount")<>"" then
	Session("amount") = Request.QueryString("amount")
	Response.Redirect("submit.asp")
end if
%>
<INPUT type="hidden" name="storename" value="1003475">
<INPUT type="hidden" name="mode" value="fullpay">
<INPUT type="hidden" name="chargetotal" value="<%=Session("amount")%>">
<script language=javascript>
	frmSvLuka.submit();
</script>
</form>
  </body>
</html>
