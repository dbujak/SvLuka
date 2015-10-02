<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serbfestdc2015.aspx.cs" Inherits="SvLuka.Misc.serbfestdc2015" %>

<%@ Register Src="../controls/Prevod.ascx" TagName="Prevod" TagPrefix="uc1" %>
<%@ Register Src="../controls/Footer.ascx" TagName="Footer" TagPrefix="uc1" %>
<%@ Register Src="../controls/Right.ascx" TagName="Right" TagPrefix="uc1" %>
<%@ Register Src="../controls/Header.ascx" TagName="Header" TagPrefix="uc1" %>
<%@ Register Src="../controls/MainNavBar.ascx" TagName="MainNavBar" TagPrefix="uc1" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SerbFest DC 2015</title>

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
                        <h1>SerbFest DC 2015</h1>
                        
                        <h1 style="background-color:yellow">We will be open rain or shine!</h1>

<h2 style="background-color:yellow">All festival activities will take place inside at our next-door neighbor:<br />
Saints Peter & Paul Antiochian Orthodox Church<br />
10620 River Road, Potomac, MD, 20854
</h2>
                        <h2>Don’t stay home in the rain - come experience traditional
	Serbian food, music & culture at DC’s	
1st Annual Serbian Food & Cultural Festival!
</h2>
                        <br />
                        <h2>Friday, October 2nd     5 – 8 pm</h2>
                        <h2>Saturday, October 3rd     11 am – 9 pm</h2>


                        <h2>Free Admission & Parking!</h2>
                        <h2><a href="http://goo.gl/forms/kAFmAJ8TQs" target="_blank">You can pre-order food here</a>.</h2>
                        <p style="font-size: large">
                            <b>Delicious Serbian Food!</b><br />
                            •	Spit-roasted Pig & Lamb<br />
                            •	Authentic Serbian Grilled Foods & Side Dishes<br />
                            •	Serbian Desserts & Pastries
                        </p>

                        <p style="font-size: large">
                            <b>Traditional Entertainment!</b><br />
                            •	Live Music & Dancing on Saturday, Oct. 3rd<br />
                            •	‘Bezimeni’ Tamburitza Orchestra from Pittsburgh, PA: 12-4 pm<br />
                            •	‘Stevan Sindjelić’ Folklore Dance Group from Holy Trinity Serbian Orthodox Church (Kitchener, Ontario, Canada): 4-5 pm<br />
                            •	DJ Spaz from Chicago, IL: 5-9 pm<br />

                        </p>

                        <p style="font-size: large">
                            <b>Something For Everyone!</b><br />
                        •	Children’s activities<br />
                        •	Bookstore & boutique<br />
                        •	Crafts and more<br />
                        </p>

                        <p style="font-size: large">
                            <b>Come enjoy our Serbian heritage & culture!<br />
Dobro nam došli!  Welcome!
<br />
                                <br />

                                Please follow our Facebook page for updates: <br /><a href="https://www.facebook.com/events/689198151211855/" target="_blank"><img src="/SvLuka/imgs/facebook/facebook-button.png" height="100px"/></a>
                                <br />
                                <br />
                                Questions: <a href="mailto:serbfestdc2015@svluka.org">serbfestdc2015@svluka.org</a>
                        </p>
                        <p style="font-size:large">
                            Please purchase tickets for all food & beverages; cash, check & credit cards accepted.<br /><br />
All proceeds will be used entirely for in support of our parish.  <br />
                            Thank you and may God bless you!

                        </p>
                        
                         
                        <br /><br /><br />
                        <table border="0" cellpadding="3">
                            <tr>
                                <td colspan="2" align="center">
                                    <h1>Traditional Serbian Cuisine</h1>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <b>À la Carte</b>
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Burek (baked meat pie in phyllo dough)
                                </td>
                                <td>$14
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="burek2.jpg" width="250px" />
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
                                <td><div class="dots"><span class="field">Sarma (meat & rice mixture wrapped in a pickled cabbage leaf)
                                </td>
                                <td>$5
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="sarma.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Kupus salata (cabbage salad)
                                </td>
                                <td>$4
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
                                <td>$4
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
                                <td>$4
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
                                <td><div class="dots"><span class="field">Ćevapčići (half portion – 4 pieces)
                                </td>
                                <td>$5
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="cevapi.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Ražnjići (pork or chicken – 2 skewers)
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
                                <td>$19
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Svinjetina (spit-roasted pig, by the pound)
                                </td>
                                <td>$16
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
                                <td>$3
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
                                <td>$2
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="palacinke.jpg" width="250px"  />
                                </td>
                            </tr>
                            <tr>
                                <td><div class="dots"><span class="field">Serbian nut rolls, poppy seed rolls & kolači (cookies)
                                </td>
                                <td>Priced Individually 
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <img src="strudla2.jpg" width="250px"  />
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
<%--                        <h2>Map</h2>
                        <img src="Picnic%20Map.svg" height="600px" /><br />--%>
                        
                        <br />
                        <img src="Giant_LogoH-color.JPG" width="200px" />
                        <h2>Thank you to our sponsor - Giant Food</h2>
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
