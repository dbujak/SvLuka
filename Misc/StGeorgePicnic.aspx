<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StGeorgePicnic.aspx.cs" Inherits="SvLuka.Misc.StGeorgePicnic" %>

<%@ Register Src="../controls/Prevod.ascx" TagName="Prevod" TagPrefix="uc1" %>
<%@ Register Src="../controls/Footer.ascx" TagName="Footer" TagPrefix="uc1" %>
<%@ Register Src="../controls/Right.ascx" TagName="Right" TagPrefix="uc1" %>
<%@ Register Src="../controls/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<%@ Register Src="../controls/MainNavBar.ascx" TagName="MainNavBar" TagPrefix="uc1" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        .dots {
            background: url('dot.gif') repeat-x bottom;
        }

        .field {
            background-color: #ffecc6;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <table id="Table1" height="100%" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td valign="top" width="20" height="10" rowspan="2">
                    <uc1:MainNavBar ID="MainNavBar1" runat="server"></uc1:MainNavBar>
                </td>
                <td valign="top" align="center" width="10" height="10"></td>
                <td valign="top" align="center" height="10">
                    <uc1:Header ID="Header1" runat="server"></uc1:Header>
                </td>
                <td valign="top" align="center" width="10" height="10"></td>
                <td valign="top" align="center" width="10" height="10"></td>
            </tr>
            <tr>
                <td valign="top"></td>
                <td valign="top">
                    <center>
                        <h1>St. George’s Day Picnic</h1>

                        <h2>Saturday, May 9th      11 am – 7 pm</h2>

                        <h2>St. Luke Serbian Orthodox Church<br />
                            10660 River Road<br />
                            Potomac MD 20854</h2>
                        <h2>Free Admission & Parking!</h2>
                        <h2>(Parking available next door at Sts. Peter & Paul Church)</h2>
                        <p style="font-size: large">
                            <b>Delicious Serbian Food!</b><br />
                            •	Spit-roasted Pig & Lamb<br />
                            •	Authentic Serbian Grilled Foods<br />
                            •	Serbian Pastries
                        </p>

                        <p style="font-size: large">
                            <b>Traditional Entertainment!</b><br />
                            •	Live Music & Dancing
                        </p>

                        <p style="font-size: large">
                            <b>Something For Everyone!</b><br />
                            •	Bounce houses & games for kids<br />
                            •	Bookstore & boutique<br />
                            •	Crafts and more
                        </p>

                        <p style="font-size: large">
                            <b>Come enjoy our Serbian heritage & culture!<br />
                                Dobro nam došli!  Welcome!<br />
                                <br />

                                Questions: <a href="mailto:stgeorgesdaypicnic@svluka.org">stgeorgesdaypicnic@svluka.org</a>
                        </p>
                         <p style="font-size: large">Please purchase tickets for all food & beverages; cash, check & credit cards accepted.</p>
                        <img src="Food.png" />
                        <br /><br /><br />
                        <table border="0" cellpadding="3">
                            <tr>
                                <td colspan="2" align="center">
                                    <h2>Traditional Serbian Cuisine</h2>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <b>À la Carte</b>
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Burek (baked phyllo dough pie filled with either cheese or spinach)
                                </td>
                                <td>$12
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="burek.jpg" width="250px" />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Zeljanica (baked spinach & cheese in phyllo dough)
                                </td>
                                <td>$4
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="zeljanica.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Gibanica (baked cheese in phyllo dough)
                                </td>
                                <td>$4
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="gibanica.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Kupus salata (cabbage salad)
                                </td>
                                <td>$3
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="kupusSalata.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Šopska salata (tomato, cucumber & onion salad with feta cheese)
                                </td>
                                <td>$3
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="sopskaSalata.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Krompir salata (potato salad)
                                </td>
                                <td>$3
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="krompirSalata.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <b>Grill – Roštilj</b>
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Ćevapčići (grilled skinless ground meat sausages – 8 pieces)
                                </td>
                                <td>$10
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="cevapi.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Ćevapčići (half portion – 4 pieces)
                                </td>
                                <td>$5
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Ražnjići (pork kebab – 2 skewers)
                                </td>
                                <td>$10
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="raznjici.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Ćevapčići & Ražnjići Combo (4 ćevapčići & 1 skewer)
                                </td>
                                <td>$10
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Jagnjetina (spit-roasted lamb, by the pound)
                                </td>
                                <td>$17
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Svinjetina (spit-roasted pig, by the pound)
                                </td>
                                <td>$15
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="svinjetina.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <b>Desserts</b>
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Krofna (deep-fried donut)</span></div>
                                </td>
                                <td>$2
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="krofne.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Palačinka (crepe)
                                </td>
                                <td>$1
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="palacinke.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Apple Strudel
                                </td>
                                <td>$4
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="strudla.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <h2>Drinks</h2>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <b>Bar</b>
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Rakija (Serbian Brandy)
                                </td>
                                <td>$5
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Beer (Serbian, Other Imports & Domestic)
                                </td>
                                <td>$5
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Wine (Red, White)
                                </td>
                                <td>$5 per glass/$20 per bottle
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Soft Drinks & Water
                                </td>
                                <td>$2
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <img src="jelen.png" width="100px" /><img src="niksicko.png" width="100px" /><img src="bip.png" width="100px" /><img src="lav.jpg" width="100px" /><img src="hainiken.gif" width="100px" />
                                </td>
                            </tr>
                        </table>




                        <h3>Please purchase tickets for all food & beverages; cash, check & credit cards accepted.</h3><br /><br />
                        <h2>Map</h2>
                        <img src="Picnic%20Map.svg" height="600px" /><br />
                        <br />
                        <br /><br /><br /><br /><br /><br />
                    </center>
                </td>
                <td valign="top"></td>
                <td valign="top">
                    <uc1:Right ID="Right1" runat="server"></uc1:Right>
                </td>
            </tr>
            <tr>
                <td height="10"></td>
                <td align="center" height="10"></td>
                <td align="center" height="10">
                    <uc1:Footer ID="Footer1" runat="server"></uc1:Footer>
                </td>
                <td align="center" height="10"></td>
                <td align="center" height="10"></td>
            </tr>
        </table>
    </form>
</body>
</html>
