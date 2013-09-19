<%@ Control Language="c#" AutoEventWireup="True" Codebehind="Footer.ascx.cs" Inherits="SvLuka.controls.Footer" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" border="0">
	<TR>
		<TD colSpan="3" height="30">
			<P align="center">
				<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="0">
					<TR>
						<TD>
							<asp:ImageButton id="cmdCirilicaImg" runat="server" ImageUrl="/SvLuka/imgs/flag_scg.gif" CausesValidation="False"></asp:ImageButton>
							<asp:LinkButton id="cmdCirilica" runat="server" CausesValidation="False" onclick="cmdCirilica_Click">Cirilica</asp:LinkButton></TD>
						<TD>
							<asp:ImageButton id="cmdEnglishimg" runat="server" ImageUrl="/SvLuka/imgs/flag_us.gif" CausesValidation="False"></asp:ImageButton>
							<asp:LinkButton id="cmdEnglish" runat="server" CausesValidation="False" onclick="cmdEnglish_Click">English</asp:LinkButton></TD>
						<TD>
							<asp:ImageButton id="cmdLatinicaimg" runat="server" ImageUrl="/SvLuka/imgs/flag_scg.gif" CausesValidation="False"></asp:ImageButton>
							<asp:LinkButton id="cmdLatinica" runat="server" CausesValidation="False" onclick="cmdLatinica_Click">Latinica</asp:LinkButton></TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
	<TR>
		<TD colSpan="3">
			<P align="center">
				<asp:Label id="lblChat" runat="server">Chat</asp:Label></P>
		</TD>
	</TR>
	<TR>
		<TD colSpan="3" height="30" align="center">
			10660 River Road; Potomac, Maryland 20854 &nbsp;&nbsp; tel: 
			301.299.2704&nbsp;&nbsp;&nbsp; fax: 301.576.5664&nbsp;&nbsp;&nbsp; web: <A href="http://www.svluka.org">
				www.svluka.org</A>
		</TD>
	</TR>
	<TR>
		<TD colSpan="3">
			<P align="center">
				<asp:Label id="lblCopyright" runat="server">Copyright © 2006 by St. Luke Serbian Orthodox Church. All rights reserved.</asp:Label></P>
		</TD>
	</TR>
</TABLE>


<!--
<script language="JavaScript">
// METATRAFFIC -- COPYRIGHT (C) 2002-2005, Brinkster Site Statistics Corp.

var pagetitle = document.title; //INSERT CUSTOM PAGE NAME IN QUOTES
var action = ""; //ACTION CODE
var amount = "0"; //ACTION AMOUNT (LEAVE BLANK OR 0 IF NO AMOUNT)
var order = ""; //INSERT UNIQUE ORDER NUMBER

var scriptlocation = "/stats/track.asp";

var pagedata = 'mtpt=' + escape(pagetitle) + '&mtac=' + escape(action) + '&mta=' + amount + '&mto=' + escape(order) + '&mtr=' + escape(document.referrer) + '&mtt=2&mts=' + window.screen.width + 'x' + window.screen.height + '&mti=1&mtz=' + Math.random(); 
document.write ('<img height=1 width=1 ');
document.write ('src="' + scriptlocation + '?' + pagedata + '">');
</script>
<noscript>
	<a href="http://www.metasun.com/" target="_blank"><img src="/stats/track.asp?mtt=2&amp;mti=1" alt="website analytics software" border="0"></a>
</noscript>
-->