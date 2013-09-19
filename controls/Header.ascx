<%@ Control Language="c#" AutoEventWireup="True" Codebehind="Header.ascx.cs" Inherits="SvLuka.controls.Header" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="300" border="0">
	<TR>
		<TD>
			<P align="center"><asp:label id="lblTitle" Font-Size="Large" Font-Names="Arial Black" runat="server">St. Luke Serbian Orthodox Church</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD height="10"></TD>
	</TR>
	<TR>
		<TD>
			<P align="center"><asp:label id="lblPageTitle" Font-Size="Medium" Font-Names="Arial" runat="server" Font-Bold="True"
					ForeColor="Firebrick">PageTitle</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD height="10"></TD>
	</TR>
	<TR>
		<TD>
			<P align="center">
				<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="0">
					<TR>
						<TD><IMG src="/SvLuka/imgs/vines.gif"><IMG src="/SvLuka/imgs/newcross5.gif"><IMG src="/SvLuka/imgs/vines.gif"></TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
	<TR>
		<TD>
			<P align="center">
				<asp:Label id="lblDonations" runat="server" Visible="False">Donacije</asp:Label></P>
		</TD>
	</TR>
	<TR>
		<TD height="40"></TD>
	</TR>
</TABLE>
<div id="dbujakSpecialNeeds"><a href="https://secure.etransfer.com/SLSOC/donate.cfm" target=_blank><img border="0" src="/SvLuka/imgs/click-to-donate-big.gif"></a></div>

<!--
<div id="dbujakSpecialNeeds"><a href="/SvLuka/newsletter/reportnews.aspx"><img border="0" src="/SvLuka/imgs/newsletter.gif"></a></div>

<div id="dbujakSpecialNeeds"><a href="/SvLuka/MailingList/default.aspx"><img border="0" src="/SvLuka/imgs/mailingList.gif"></a></div>
-->
