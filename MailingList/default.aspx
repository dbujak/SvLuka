<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="True" Inherits="SvLuka.MailingList._default" %>
<%@ Register TagPrefix="uc1" TagName="Header" Src="../controls/Header.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Right" Src="../controls/Right.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Footer" Src="../controls/Footer.ascx" %>
<%@ Register TagPrefix="uc1" TagName="MainNavBar" Src="../controls/MainNavBar.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Join St Luke's mailing list / Upisite se na email listu crkve Sv Luke</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table3" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD vAlign="top" width="20" height="10" rowSpan="2">
						<uc1:MainNavBar id="MainNavBar2" runat="server"></uc1:MainNavBar></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
					<TD vAlign="top" align="center" height="10">
						<uc1:Header id="Header1" runat="server"></uc1:Header></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
					<TD vAlign="top" align="center" width="10" height="10"></TD>
				</TR>
				<TR>
					<TD vAlign="top"></TD>
					<TD vAlign="top">
						<P align="left">
							<asp:Label id="lblMailingList" runat="server">Mailing List</asp:Label></P>
						<P>
							<TABLE id="Table1" cellSpacing="1" cellPadding="1" border="0">
								<TR>
									<TD>
										<asp:Label id="lblEmail" runat="server">E-mail</asp:Label></TD>
									<TD></TD>
									<TD>
										<asp:TextBox id="txtEmail" runat="server" Width="277px"></asp:TextBox>
										<asp:RegularExpressionValidator id="valEmail" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
											ControlToValidate="txtEmail">*</asp:RegularExpressionValidator>
										<asp:RequiredFieldValidator id="valEmailReq" runat="server" ControlToValidate="txtEmail">*</asp:RequiredFieldValidator><FONT color="#ff6666"></FONT></TD>
								</TR>
								<TR>
									<TD height="5"></TD>
									<TD height="5"></TD>
									<TD height="5"></TD>
								</TR>
								<TR>
									<TD>
										<asp:Label id="lblFName" runat="server">F Name</asp:Label></TD>
									<TD></TD>
									<TD>
										<asp:TextBox id="txtFName" runat="server" Width="277px"></asp:TextBox></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 20px">
										<asp:Label id="lblLName" runat="server">L Name</asp:Label></TD>
									<TD style="HEIGHT: 20px"></TD>
									<TD style="HEIGHT: 20px">
										<asp:TextBox id="txtLName" runat="server" Width="277px"></asp:TextBox></TD>
								</TR>
								<TR>
									<TD>
										<asp:Label id="lblAddress" runat="server">Address</asp:Label></TD>
									<TD></TD>
									<TD>
										<asp:TextBox id="txtAddress" runat="server" Width="277px"></asp:TextBox></TD>
								</TR>
								<TR>
									<TD>
										<asp:Label id="lblCityEtc" runat="server">City, State, ZIP</asp:Label></TD>
									<TD></TD>
									<TD>
										<asp:TextBox id="txtCity" runat="server" Width="159px"></asp:TextBox>,
										<asp:TextBox id="txtState" runat="server" Width="27px"></asp:TextBox>,
										<asp:TextBox id="txtZip" runat="server" Width="73px"></asp:TextBox></TD>
								</TR>
								<TR>
									<TD></TD>
									<TD></TD>
									<TD>
										<asp:ValidationSummary id="ValidationSummary1" runat="server"></asp:ValidationSummary></TD>
								</TR>
								<TR>
									<TD height="5"></TD>
									<TD height="5"></TD>
									<TD align="right" height="5"></TD>
								</TR>
								<TR>
									<TD></TD>
									<TD></TD>
									<TD align="right">
										<asp:LinkButton id="cmdSubscribe" runat="server">Subscribe</asp:LinkButton></TD>
								</TR>
							</TABLE>
						</P>
						<P>&nbsp;</P>
						<P>&nbsp;</P>
						<P>&nbsp;</P>
						<P>&nbsp;</P>
						<P>&nbsp;</P>
						<P>&nbsp;</P>
					</TD>
					<TD vAlign="top"></TD>
					<TD vAlign="top">
						<uc1:Right id="Right2" runat="server"></uc1:Right></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 25px" height="25"></TD>
					<TD style="HEIGHT: 25px" align="center" height="25"></TD>
					<TD style="HEIGHT: 25px" align="center" height="25">
						<uc1:Footer id="Footer2" runat="server"></uc1:Footer></TD>
					<TD style="HEIGHT: 25px" align="center" height="25"></TD>
					<TD style="HEIGHT: 25px" align="center" height="24"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
