<html>
<head></head>
<body>
<%
        Dim SiteNameURL 
	SiteNameURL = Request.ServerVariables("SERVER_NAME")
        Select Case UCase(SiteNameURL)
            Case "WWW.PROPERIT.COM", "PROPERIT.COM"
                Response.Redirect("Brinkster/properIT/default.aspx")
            Case "WWW.BUJAK.US", "BUJAK.US"
                Response.Redirect("Brinkster/Bujak/default.aspx")
            Case "WWW.HARMONYLEAF.COM", "HARMONYLEAF.COM"
                Response.Redirect("Brinkster/HarmonyLeaf/default.aspx")
            Case "WWW.WANCONTROL.COM", "WANCONTROL.COM"
                Response.Redirect("Brinkster/wanControl/default.aspx")
            Case "WWW.RENOVATIONSTUDIO.BIZ", "RENOVATIONSTUDIO.BIZ"
                Response.Redirect("Brinkster/RENOVATIONSTUDIO/default.aspx")
            Case "WWW.SVLUKA.ORG", "SVLUKA.ORG"
                Response.Redirect("SvLuka/default.aspx")
            Case Else
		Response.write ("We could not locate this domain:" & SiteNameURL)
        End Select

%>
</body>
</html>