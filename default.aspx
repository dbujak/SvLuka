<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="True" Inherits="SvLuka._default" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>St Luke Serbian Orthodox Church / Crkva Sv Luke</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<style type="text/css">BODY { FONT-SIZE: 11px; COLOR: black; FONT-FAMILY: Arial, Helvetica, sans-serif; BACKGROUND-COLOR: #ffecc6 }
		</style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P align="center">
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="80%" border="0">
					<TR>
						<TD height="20"></TD>
						<TD height="20"></TD>
						<TD height="20"></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD vAlign="middle" align="center">
							<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
								<TR>
									<TD align="center">
										<asp:ImageButton id="cmdSerbian" runat="server" ImageUrl="imgs/srpski_c.gif"></asp:ImageButton></TD>
									<TD></TD>
									<TD align="center">
										<asp:ImageButton id="cmdEnglish" runat="server" ImageUrl="/SvLuka/imgs/english.gif"></asp:ImageButton></TD>
									<TD></TD>
									<TD align="center">
										<asp:ImageButton id="cmdLatinica" runat="server" ImageUrl="/SvLuka/imgs/srpski_l.gif"></asp:ImageButton></TD>
								</TR>
							</TABLE>
						</TD>
						<TD></TD>
					</TR>
					<TR>
						<TD height="20"></TD>
						<TD vAlign="middle" align="center" height="20"></TD>
						<TD height="20"></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD vAlign="middle" align="center">
							<asp:Label id="Label1" runat="server">
								<font size="4">St Luke Serbian Orthodox Church</font></asp:Label><BR>
							<IMG height="236" src="/SvLuka/imgs/lukaicon.gif" width="180" border="0"><BR>
							<asp:Label id="Label2" runat="server">
								<font size="4">Srpska pravoslavna crkva Sv Luke</font></asp:Label></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD height="30"></TD>
						<TD height="30"></TD>
						<TD height="30"></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD>
						</TD>
						<TD></TD>
					</TR>
				</TABLE>
			</P>
		</form>
	</body>
</HTML>
