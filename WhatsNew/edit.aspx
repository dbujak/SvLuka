<%@ Page language="c#" Codebehind="edit.aspx.cs" AutoEventWireup="True" Inherits="SvLuka.WhatsNew.edit" validateRequest="false" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="../controls/Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="../controls/Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Right" Src="../controls/Right.ascx" %>
<%@ Register TagPrefix="uc1" TagName="MainNavBar" Src="../controls/MainNavBar.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
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
						<TABLE id="Table2" cellSpacing="0" cellPadding="3" border="0">
							<TR>
								<TD>Date:</TD>
								<TD></TD>
								<TD>
									<asp:TextBox id="txtDate" runat="server" Width="118px"></asp:TextBox>
									<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="You're missing date" ControlToValidate="txtDate">*</asp:RequiredFieldValidator>
									<asp:RangeValidator id="RangeValidator1" runat="server" ErrorMessage="Date is not a valid date" ControlToValidate="txtDate"
										Type="Date" MaximumValue="1/1/5000" MinimumValue="1/1/2000">*</asp:RangeValidator>&nbsp;
								</TD>
							</TR>
							<TR>
								<TD>Start:</TD>
								<TD></TD>
								<TD>
									<asp:TextBox id="txtSDate" runat="server" Width="118px"></asp:TextBox>
									<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ErrorMessage="You're missing start date"
										ControlToValidate="txtSDate">*</asp:RequiredFieldValidator>
									<asp:RangeValidator id="RangeValidator2" runat="server" ErrorMessage="Start date is not a valid date"
										ControlToValidate="txtSDate" Type="Date" MaximumValue="1/1/5000" MinimumValue="1/1/2000">*</asp:RangeValidator></TD>
							</TR>
							<TR>
								<TD>End:</TD>
								<TD></TD>
								<TD>
									<asp:TextBox id="txtEDate" runat="server" Width="118px"></asp:TextBox>
									<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ErrorMessage="You're missing end date"
										ControlToValidate="txtEDate">*</asp:RequiredFieldValidator>
									<asp:RangeValidator id="RangeValidator3" runat="server" ErrorMessage="End date is not a valid date"
										ControlToValidate="txtEDate" Type="Date" MaximumValue="1/1/5000" MinimumValue="1/1/2000">*</asp:RangeValidator></TD>
							</TR>
							<TR>
								<TD>Visible:</TD>
								<TD></TD>
								<TD>
									<asp:CheckBox id="chkVisible" runat="server" Text="Active"></asp:CheckBox></TD>
							</TR>
							<TR>
								<TD>Order:</TD>
								<TD></TD>
								<TD>
									<asp:TextBox id="txtOrder" runat="server" Width="116px"></asp:TextBox>
									<asp:RangeValidator id="RangeValidator4" runat="server" ErrorMessage="Order not valid number" ControlToValidate="txtOrder"
										Type="Integer" MaximumValue="9999999" MinimumValue="0">*</asp:RangeValidator></TD>
							</TR>
							<TR>
								<TD vAlign="top">English:</TD>
								<TD></TD>
								<TD>
									<asp:TextBox id="txtEnglish" runat="server" Width="660px" Height="84px" TextMode="MultiLine"></asp:TextBox>
									<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="Missing schedule in English"
										ControlToValidate="txtEnglish">*</asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD vAlign="top" colSpan="1" rowSpan="1">Cirilica:</TD>
								<TD></TD>
								<TD>
									<asp:TextBox id="txtCirilica" runat="server" Width="660px" Height="84px" TextMode="MultiLine"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD vAlign="top" colSpan="1" rowSpan="1">Latinica</TD>
								<TD></TD>
								<TD>
									<asp:TextBox id="txtLatinica" runat="server" Width="660px" Height="84px" TextMode="MultiLine"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD vAlign="top">
									<asp:Label id="lblID" runat="server" Visible="False">Label</asp:Label></TD>
								<TD></TD>
								<TD align="left">
									<asp:ValidationSummary id="ValidationSummary1" runat="server"></asp:ValidationSummary></TD>
							</TR>
							<TR>
								<TD vAlign="top"></TD>
								<TD></TD>
								<TD align="right">
									<asp:Button id="cmdCancel" runat="server" Text="Cancel" CausesValidation="False" onclick="cmdCancel_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:Button id="cmdSave" runat="server" Text="Save" onclick="cmdSave_Click"></asp:Button></TD>
							</TR>
						</TABLE>
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
			&nbsp;
		</form>
	</body>
</HTML>
