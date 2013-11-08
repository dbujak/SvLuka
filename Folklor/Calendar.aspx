<%@ Page language="c#" Codebehind="Calendar.aspx.cs" AutoEventWireup="True" Inherits="SvLuka.Folklor.FolkloreCalendar" %>
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
						<P align="left"><iframe src="http://www.google.com/calendar/embed?showTitle=0&amp;showTz=0&amp;height=600&amp;wkst=1&amp;bgcolor=%23ffecc6&amp;src=aea5db1h2ssolond3llcnpul7g%40group.calendar.google.com&amp;color=%23B1365F&amp;ctz=America%2FNew_York"
								style=" BORDER-TOP-WIDTH:0px; BORDER-LEFT-WIDTH:0px; BORDER-BOTTOM-WIDTH:0px; BORDER-RIGHT-WIDTH:0px"
								width="800" height="600" frameborder="0" scrolling="no"></iframe>
						</P>
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
