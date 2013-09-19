<%@ Register TagPrefix="uc1" TagName="Footer" Src="../controls/Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="../controls/Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Right" Src="../controls/Right.ascx" %>
<%@ Register TagPrefix="uc1" TagName="MainNavBar" Src="../controls/MainNavBar.ascx" %>
<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="false" Inherits="SvLuka.Schedules._default" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Schedules / Raspored</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD vAlign="top" width="20" height="10" rowSpan="2"><uc1:mainnavbar id="MainNavBar1" runat="server"></uc1:mainnavbar></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
					<TD vAlign="top" align="center" height="10"><uc1:header id="Header1" runat="server"></uc1:header></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
				</TR>
				<TR>
					<TD vAlign="top"></TD>
					<TD vAlign="top"><asp:Label id="lblSchedules" runat="server" Font-Bold="True">Please click on an event on the calendar to get more information.</asp:Label><br>
						<br>
							
							
						<%--<iframe src="http://www.google.com/calendar/embed?showTitle=0&amp;showTz=0&amp;height=600&amp;wkst=1&amp;bgcolor=%23ffecc6&amp;src=aea5db1h2ssolond3llcnpul7g%40group.calendar.google.com&amp;color=%23B1365F&amp;src=6lne9t4ljhv8srj9s7hnd55oqg%40group.calendar.google.com&amp;color=%236E6E41&amp;src=is16q4gom1ke09s9fqfchmffcg%40group.calendar.google.com&amp;color=%235229A3&amp;ctz=America%2FNew_York" style=" border-width:0 " width="800" height="600" frameborder="0" scrolling="no"></iframe>--%>
                        <asp:Label ID="lblCalendarEn" runat="server" Visible="False"><iframe src="https://www.google.com/calendar/embed?showTitle=0&amp;showTabs=0&amp;height=600&amp;wkst=1&amp;hl=en&amp;bgcolor=%23ffecc6&amp;src=aea5db1h2ssolond3llcnpul7g%40group.calendar.google.com&amp;color=%23B1365F&amp;src=6lne9t4ljhv8srj9s7hnd55oqg%40group.calendar.google.com&amp;color=%238D6F47&amp;src=lqdpci7b1t2rkoact8ar44jigs%40group.calendar.google.com&amp;color=%235229A3&amp;src=is16q4gom1ke09s9fqfchmffcg%40group.calendar.google.com&amp;color=%23AB8B00&amp;ctz=America%2FNew_York" style=" border-width:0 " width="800" height="600" frameborder="0" scrolling="no"></iframe></asp:Label>
                        <asp:Label ID="lblCalendarSr" runat="server" Visible="False"><iframe src="https://www.google.com/calendar/embed?showTitle=0&amp;showTabs=0&amp;height=600&amp;wkst=1&amp;hl=sr&amp;bgcolor=%23ffecc6&amp;src=aea5db1h2ssolond3llcnpul7g%40group.calendar.google.com&amp;color=%23B1365F&amp;src=6lne9t4ljhv8srj9s7hnd55oqg%40group.calendar.google.com&amp;color=%238D6F47&amp;src=is16q4gom1ke09s9fqfchmffcg%40group.calendar.google.com&amp;color=%23AB8B00&amp;src=l7isj43cj3k45foom4pl614fdc%40group.calendar.google.com&amp;color=%23333333&amp;ctz=America%2FNew_York" style=" border-width:0 " width="800" height="600" frameborder="0" scrolling="no"></iframe></asp:Label>
							
						<asp:Label id="lblFastDays" runat="server">
						<p>Fast Days are shown on the calendar <FONT style="BACKGROUND-COLOR: #8D6F47" color="white">
								&nbsp;&nbsp;<FONT size="2">highlighted</FONT>&nbsp;&nbsp;</FONT></p>
						<p>On fast days the faitful eat no meat, fish, eggs, dairy products, wine 
							(including alcholic beverages in general), or oil - this is indicated with <FONT style="BACKGROUND-COLOR: #888858" color="white">
								&nbsp;&nbsp;<FONT size="2">Water</FONT>&nbsp;&nbsp;</FONT>.
						</p>
						<p>On days indicated with <FONT style="BACKGROUND-COLOR: #888858" color="white">&nbsp;&nbsp;<FONT size="2">Oil</FONT>&nbsp;&nbsp;</FONT>
							the fast is relaxed to allow the use of wine and oil.</p>
						<p>On days indicated with <FONT style="BACKGROUND-COLOR: #888858" color="white">&nbsp;&nbsp;<FONT size="2">Fish</FONT>&nbsp;&nbsp;</FONT>, 
							in addition to wine and oil, the use of fish is permited.</p>
						<p>In case of doubt, the guidance of one's confessor or pastor should be sought.</p>
						</asp:Label>
						

					</TD>
					<TD vAlign="top"></TD>
					<TD vAlign="top"><uc1:right id="Right1" runat="server" Visible="false"></uc1:right></TD>
				</TR>
				<TR>
					<TD height="10">
						
					</TD>
					<TD align="center" height="10"></TD>
					<TD align="center" height="10"><uc1:footer id="Footer1" runat="server"></uc1:footer></TD>
					<TD align="center" height="10"></TD>
					<TD align="center" height="10"></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
