<%@ Page language="c#" Codebehind="edit.aspx.cs" AutoEventWireup="True" Inherits="SvLuka.Schedules.edit" validateRequest="false" %>
<%@ Register TagPrefix="uc1" TagName="Right" Src="../controls/Right.ascx" %>
<%@ Register TagPrefix="uc1" TagName="MainNavBar" Src="../controls/MainNavBar.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="../controls/Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="../controls/Footer.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" src="script.js"></script>
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
					<TD vAlign="top">
						<TABLE id="Table2" cellSpacing="0" cellPadding="3" border="0">
							<TR>
								<TD>Date / Time:</TD>
								<TD></TD>
								<TD><asp:textbox id="txtDate" runat="server" Width="118px"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="You're missing date" ControlToValidate="txtDate">*</asp:requiredfieldvalidator><asp:rangevalidator id="RangeValidator1" runat="server" ErrorMessage="Date is not a valid date" ControlToValidate="txtDate"
										Type="Date" MaximumValue="1/1/5000" MinimumValue="1/1/2000">*</asp:rangevalidator>&nbsp;
									<asp:dropdownlist id="cboHour" runat="server">
										<asp:ListItem Value="1">1</asp:ListItem>
										<asp:ListItem Value="2">2</asp:ListItem>
										<asp:ListItem Value="3">3</asp:ListItem>
										<asp:ListItem Value="4">4</asp:ListItem>
										<asp:ListItem Value="5">5</asp:ListItem>
										<asp:ListItem Value="6">6</asp:ListItem>
										<asp:ListItem Value="7">7</asp:ListItem>
										<asp:ListItem Value="8">8</asp:ListItem>
										<asp:ListItem Value="9">9</asp:ListItem>
										<asp:ListItem Value="10" Selected="True">10</asp:ListItem>
										<asp:ListItem Value="11">11</asp:ListItem>
										<asp:ListItem Value="12">12</asp:ListItem>
									</asp:dropdownlist><asp:dropdownlist id="cboMin" runat="server">
										<asp:ListItem Value="0" Selected="True">00</asp:ListItem>
										<asp:ListItem Value="15">15</asp:ListItem>
										<asp:ListItem Value="30">30</asp:ListItem>
										<asp:ListItem Value="45">45</asp:ListItem>
									</asp:dropdownlist><asp:dropdownlist id="cboAM" runat="server">
										<asp:ListItem Value="AM" Selected="True">AM</asp:ListItem>
										<asp:ListItem Value="PM">PM</asp:ListItem>
									</asp:dropdownlist>&nbsp;
									<asp:checkbox id="chkNoTime" runat="server" Text="No Time"></asp:checkbox></TD>
							</TR>
							<TR>
								<TD vAlign="top">English:</TD>
								<TD></TD>
								<TD><asp:textbox id="txtEnglish" runat="server" Width="462px" TextMode="MultiLine" Height="40px"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ErrorMessage="Missing schedule in English"
										ControlToValidate="txtEnglish">*</asp:requiredfieldvalidator></TD>
							</TR>
							<TR>
								<TD vAlign="top" colSpan="1" rowSpan="1">Cirilica:</TD>
								<TD></TD>
								<TD><asp:textbox id="txtCirilica" runat="server" Width="462px" TextMode="MultiLine" Height="40px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD vAlign="top" colSpan="1" rowSpan="1">Latinica:</TD>
								<TD></TD>
								<TD><asp:textbox id="txtLatinica" runat="server" Width="462px" TextMode="MultiLine" Height="40px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD vAlign="top">Location:</TD>
								<TD></TD>
								<TD align="left"><asp:dropdownlist id="cboLocations" runat="server" Width="234px"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD vAlign="top"><asp:label id="lblID" runat="server" Visible="False">Label</asp:label></TD>
								<TD></TD>
								<TD align="left"><asp:validationsummary id="ValidationSummary1" runat="server"></asp:validationsummary></TD>
							</TR>
							<TR>
								<TD vAlign="top"></TD>
								<TD></TD>
								<TD align="right"><asp:button id="cmdCancel" runat="server" Text="Cancel" CausesValidation="False" onclick="cmdCancel_Click"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:button id="cmdSave" runat="server" Text="Save" onclick="cmdSave_Click"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
					<TD vAlign="top"></TD>
					<TD vAlign="top"><uc1:right id="Right1" runat="server"></uc1:right></TD>
				</TR>
				<TR>
					<TD height="10"></TD>
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
