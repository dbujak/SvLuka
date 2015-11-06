<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="True" Inherits="SvLuka.Folklor._default" %>
<%@ Register TagPrefix="uc1" TagName="MainNavBar" Src="../controls/MainNavBar.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="../controls/Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Right" Src="../controls/Right.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="../controls/Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Prevod" Src="../controls/Prevod.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Folklore</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD vAlign="top" width="20" height="10" rowSpan="2">
						<uc1:MainNavBar id="MainNavBar1" runat="server"></uc1:MainNavBar></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
					<TD vAlign="top" align="center" height="10">
						<uc1:Header id="Header1" runat="server"></uc1:Header></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
				</TR>
				<TR>
					<TD vAlign="top"></TD>
					<TD vAlign="top">
						<P align="left"><BR>
							<asp:Label id="lblFolklore" runat="server">Folklor</asp:Label></P>
                        <center>
                            <img src="Folklore.png" /></center>
                        <p align="left">
                            <asp:Label id="googleGroup" runat="server"></asp:Label>
                        </p>
<%--<iframe id="forum_embed"
   src="javascript:void(0)"
   scrolling="no"
   frameborder="0"
   width="900"
   height="700">
 </iframe>
 <script type="text/javascript">
     document.getElementById('forum_embed').src =
        'https://groups.google.com/a/svluka.org/forum/embed/?place=forum/folklore'
        + '&showsearch=true&showpopout=true&showtabs=false'
        + '&parenturl=' + encodeURIComponent(window.location.href);
 </script> --%>

					</TD>
					<TD vAlign="top"></TD>
					<TD vAlign="top">
						<uc1:Right id="Right1" runat="server"></uc1:Right></TD>
				</TR>
				<TR>
					<TD height="10"></TD>
					<TD align="center" height="10"></TD>
					<TD align="center" height="10">
						<uc1:Footer id="Footer1" runat="server"></uc1:Footer></TD>
					<TD align="center" height="10"></TD>
					<TD align="center" height="10"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
