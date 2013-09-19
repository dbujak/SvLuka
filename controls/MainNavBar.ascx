<%@ Control Language="c#" AutoEventWireup="True" Codebehind="MainNavBar.ascx.cs" Inherits="SvLuka.controls.MainNavBar" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<style type="text/css">BODY { FONT-SIZE: 11px; COLOR: black; FONT-FAMILY: Arial, Helvetica, sans-serif; BACKGROUND-COLOR: #ffecc6 }
	TD { FONT-SIZE: 11pt; COLOR: black; FONT-FAMILY: Arial, Helvetica, sans-serif }
	P { FONT-SIZE: 11pt; COLOR: black; FONT-FAMILY: Arial, Helvetica, sans-serif }
	.headerLinks { FONT-WEIGHT: bold; FONT-SIZE: 16px; COLOR: black; FONT-FAMILY: Arial, Helvetica, sans-serif }
	.headerLinks A { COLOR: #cc6633; FONT-FAMILY: arial, helvetica, sans-serif }
	.headerLinks A:hover { BACKGROUND: antiquewhite; COLOR: #993333; FONT-FAMILY: arial, helvetica, sans-serif; TEXT-DECORATION: underline overline }
	.Links A { COLOR: #cc6633; FONT-FAMILY: arial, helvetica, sans-serif }
	.Links A:hover { BACKGROUND: antiquewhite; COLOR: #993333; FONT-FAMILY: arial, helvetica, sans-serif; TEXT-DECORATION: underline overline }
	#HeaderTable { }
	#HeaderTable TABLE { BORDER-TOP-WIDTH: 0px; BORDER-LEFT-WIDTH: 0px; BORDER-BOTTOM-WIDTH: 0px; BORDER-RIGHT-WIDTH: 0px }
	#HeaderTable TD { PADDING-RIGHT: 8px; PADDING-LEFT: 8px; PADDING-BOTTOM: 8px; VERTICAL-ALIGN: top; PADDING-TOP: 8px }
	#HeaderTable P { FONT-SIZE: 18pt; COLOR: black; LINE-HEIGHT: 22pt; FONT-FAMILY: Times new Roman }
	#dbujakNavContainer .regular A { BORDER-RIGHT: 0px; PADDING-RIGHT: 0px; BORDER-TOP: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; BORDER-LEFT: 0px; CURSOR: pointer; TEXT-INDENT: 0px; PADDING-TOP: 0px; BORDER-BOTTOM: 0px; FONT-FAMILY: arial; BACKGROUND-COLOR: #39586d; TEXT-DECORATION: none }
	#dbujakNavContainer .regular A:hover { BORDER-RIGHT: 0px; PADDING-RIGHT: 0px; BORDER-TOP: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; BORDER-LEFT: 0px; CURSOR: pointer; PADDING-TOP: 0px; BORDER-BOTTOM: 0px; FONT-FAMILY: arial; BACKGROUND-COLOR: #39586d; TEXT-DECORATION: none }
	#dbujakNavContainer .regular A:visited { BORDER-RIGHT: 0px; PADDING-RIGHT: 0px; BORDER-TOP: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; BORDER-LEFT: 0px; CURSOR: pointer; PADDING-TOP: 0px; BORDER-BOTTOM: 0px; FONT-FAMILY: arial; BACKGROUND-COLOR: #39586d; TEXT-DECORATION: none }
	#dbujakNavContainer .search { FONT-WEIGHT: bold; FONT-SIZE: 95%; MARGIN-LEFT: 3px; COLOR: white; FONT-FAMILY: Arial }
	#dbujakNavContainer { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; FONT: 1em Verdana, Arial; WIDTH: 180px; COLOR: #f1f1f1; PADDING-TOP: 0px; POSITION: relative; TOP: 0px }
	#dbujakNavLI { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px }
	#dbujakNavContainer UL { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px; FONT-FAMILY: Arial, Helvetica, sans-serif; LIST-STYLE-TYPE: none }
	#dbujakNavContainer A { BORDER-RIGHT: #274056 1px solid; BORDER-TOP: #274056 1px solid; MARGIN-TOP: -3px; DISPLAY: block; PADDING-BOTTOM: 8px; BORDER-LEFT: #274056 1px solid; WIDTH: 180px; TEXT-INDENT: 7px; PADDING-TOP: 9px; BORDER-BOTTOM: #274056 1px solid; BACKGROUND-COLOR: #2b465b }
	#dbujakNavContainer A:link { FONT-WEIGHT: bold; FONT-SIZE: 13px; COLOR: #ffffff; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif; TEXT-DECORATION: none }
	#dbujakNavList A:visited { FONT-WEIGHT: bold; FONT-SIZE: 13px; COLOR: #ffffff; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif; TEXT-DECORATION: none }
	#dbujakNavContainer A:hover { COLOR: #8396a7; BACKGROUND-COLOR: #2b465b }
	#dbujakNavContainer2 { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; FONT: 1em Verdana, Arial; WIDTH: 180px; PADDING-TOP: 0px }
	#dbujakNavLI2 { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px }
	#dbujakNavContainer2 UL { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px; FONT-FAMILY: Arial, Helvetica, sans-serif; LIST-STYLE-TYPE: none }
	#dbujakNavContainer2 A { BORDER-RIGHT: #264561 1px solid; BORDER-TOP: #264561 1px solid; MARGIN-TOP: -2px; DISPLAY: block; PADDING-BOTTOM: 5px; BORDER-LEFT: #264561 1px solid; WIDTH: 180px; TEXT-INDENT: 7px; PADDING-TOP: 5px; BORDER-BOTTOM: #264561 1px solid; BACKGROUND-COLOR: #d02720 }
	#dbujakNavContainer2 A:link { FONT-WEIGHT: bold; FONT-SIZE: 11px; COLOR: white; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif; TEXT-DECORATION: none }
	#dbujakNavList2 A:visited { FONT-WEIGHT: bold; FONT-SIZE: 11px; COLOR: white; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif; TEXT-DECORATION: none }
	#dbujakNavContainer2 A:hover { COLOR: #2b465b; BACKGROUND-COLOR: #dddddd }
	A { FONT: bold 1em Arial; COLOR: #39586d; TEXT-DECORATION: underline }
	A:hover { COLOR: firebrick; TEXT-DECORATION: underline }
	#dbujakSpecialNeeds { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; RIGHT: 20px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px; POSITION: absolute; TOP: 40px }
	#dbujakSpecialNeeds2 { PADDING-RIGHT: 0px; PADDING-LEFT: 0px; LEFT: 180px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px; POSITION: absolute; TOP: 40px }

</style>
<TABLE id="Table1" cellSpacing="1" cellPadding="1" border="0">
	<TR>
		<TD align="center"><A href="/SvLuka/default.aspx"><IMG src="/SvLuka/imgs/grbpic.gif" border="0"></A></TD>
	</TR>
	<TR>
		<TD height="30"></TD>
	</TR>
	<TR>
		<TD>
			<div id="dbujakNavContainer">
				<ul id="dbujakNavList">
					<li id="dbujakNavLI" style="MARGIN-TOP: 2px">
						<asp:linkbutton id="cmdIntroduction" CausesValidation="False" runat="server" onclick="cmdIntroduction_Click" Text="<%$ Resources:Strings, 3_introduction %>"></asp:linkbutton></li></ul>
				<div id="dbujakNavContainer2">
					<ul id="dbujakNavList2">
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdHome" CausesValidation="False" runat="server" onclick="cmdHome_Click" Text="<%$ Resources:Strings, 4_home %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdSchedules" CausesValidation="False" runat="server" onclick="cmdSchedules_Click" Text="<%$ Resources:Strings, 6_schedules %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdContact" CausesValidation="False" runat="server" onclick="cmdContact_Click" Text="<%$ Resources:Strings, 29_contactus %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdPhotos" CausesValidation="False" runat="server" onclick="cmdPhotos_Click" Text="<%$ Resources:Strings, 30_photos %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdDirections" CausesValidation="False" runat="server" onclick="cmdDirections_Click" Text="<%$ Resources:Strings, 12_directions %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdDonations" CausesValidation="False" runat="server" onclick="cmdDonations_Click" Text="<%$ Resources:Strings, 27_donations %>"></asp:linkbutton></li></ul>
				</div>

				<ul id="dbujakNavList">
					<li id="dbujakNavLI" style="MARGIN-TOP: 2px">
						<asp:linkbutton id="cmdTeen" CausesValidation="False" runat="server" onclick="cmdTeen_Click" Text="<%$ Resources:Strings, 32_teenpage %>"></asp:linkbutton></li></ul>
				<div id="dbujakNavContainer2">
					<ul id="dbujakNavList2">
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdTeenHome" CausesValidation="False" runat="server" onclick="cmdTeenHome_Click" Text="<%$ Resources:Strings, 33_teenhome %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdTeenGroup" CausesValidation="False" runat="server" onclick="cmdTeenGroup_Click" Text="<%$ Resources:Strings, 34_teenyouthgroup %>"></asp:linkbutton></li></ul>
				</div>
				<ul id="dbujakNavList">
					<li id="dbujakNavLI" style="MARGIN-TOP: 2px">
						<asp:linkbutton id="cmdFolklore" CausesValidation="False" runat="server" onclick="cmdFolklore_Click" Text="<%$ Resources:Strings, 92_folklore %>"></asp:linkbutton></li></ul>
				<div id="dbujakNavContainer2">
					<ul id="dbujakNavList2">
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdFolkloreHome" CausesValidation="False" runat="server" onclick="cmdFolkloreHome_Click" Text="<%$ Resources:Strings, 93_folklorehome %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdFolkloreCalendar" CausesValidation="False" runat="server" onclick="cmdFolkloreCalendar_Click" Text="<%$ Resources:Strings, 97_folklore_calendar %>"></asp:linkbutton></li></ul>
				</div>
				<ul id="dbujakNavList">
					<li id="dbujakNavLI" style="MARGIN-TOP: 2px">
						<asp:linkbutton id="cmdOther" CausesValidation="False" runat="server" onclick="cmdOther_Click" Text="<%$ Resources:Strings, 28_other %>"></asp:linkbutton></li></ul>
				<div id="dbujakNavContainer2">
					<ul id="dbujakNavList2">
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdNewsletter" CausesValidation="False" runat="server" onclick="cmdNewsletter_Click" Text="<%$ Resources:Strings, 31_newsletter %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdConstruction" CausesValidation="False" runat="server" onclick="cmdConstruction_Click" Text="<%$ Resources:Strings, 67_construction_diary %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdForms" CausesValidation="False" runat="server" onclick="cmdForms_Click" Text="<%$ Resources:Strings, 68_forms %>"></asp:linkbutton>
						<li id="dbujakNavLI2">
							<asp:linkbutton id="cmdLinks" CausesValidation="False" runat="server" onclick="cmdLinks_Click" Text="<%$ Resources:Strings, 79_links %>"></asp:linkbutton></li>
					</ul>
				</div>
			</div>
		</TD>
	</TR>
<%--	<TR>
		<TD height="20"></TD>
	</TR>
	<TR>
		<TD height="20">
			<!--<asp:TextBox id="txtSearch" runat="server" Height="18px" Width="112px" Font-Size="8pt"></asp:TextBox>&nbsp;
			<asp:LinkButton id="cmdSearch" runat="server">Search</asp:LinkButton>--></TD>
	</TR>--%>
<%--	<TR>
		<TD height="20"></TD>
	</TR>
	<TR>
		<TD align="center"><asp:LinkButton id="cmdAdmin" runat="server" CausesValidation="False" onclick="cmdAdmin_Click" Visible="False">Log-in</asp:LinkButton>
		</TD>
	</TR>--%>
</TABLE>

<%-- Subscribe to News part--%>
<table border=0>
<tr><td height=10px></td></tr>
<tr><td align=center><asp:Label ID="lblSubscribe" runat="server" Text="Label" Font-Size=10pt></asp:Label></td></tr>
<tr><td align=center><asp:TextBox ID="txtSubscribe" runat="server"></asp:TextBox></td></tr>
<tr><td align=center><asp:Button ID="cmdSubscribe" runat="server" Text="Button" OnClick="cmdSubscribe_Click" /></td></tr>
<tr><td align=center style="height: 19px">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSubscribe"
        ErrorMessage="RequiredFieldValidator" SetFocusOnError="True"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtSubscribe" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td></tr>
</table>
