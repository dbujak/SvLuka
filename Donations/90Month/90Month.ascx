<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="90Month.ascx.cs" Inherits="SvLuka.Donations._90Month._90Month" %>
<style type="text/css">
        .newspaper {
            -webkit-column-count: <%=this.columnsCount%>; /* Chrome, Safari, Opera */
            -moz-column-count: <%=this.columnsCount%>; /* Firefox */
            column-count: <%=this.columnsCount%>;
        }
    </style>
<style type="text/css">
    .donation-meter {
        margin-left: 30px;
        width: 100px;
        color: black;
        text-decoration: none;
    }

    .glass {
        background: #e5e5e5;
        border-radius: 100px 100px 0 0;
        display: block;
        height: 300px;
        margin: 0 35px 10px;
        padding: 5px;
        position: relative;
        width: 20px;
    }


    .amount {
        background: #f34e54;
        border-radius: 100px;
        display: block;
        width: 20px;
        position: absolute;
        bottom: 5px;
    }

    strong {
        display: block;
        text-align: center;
    }

    .goal {
        font-size: 30px;
    }

    .total {
        font-size: 16px;
        position: absolute;
        right: 35px;
    }


    .bulb {
        background: #e5e5e5;
        border-radius: 100px;
        display: block;
        height: 50px;
        margin: 0 35px 10px;
        padding: 5px;
        position: relative;
        top: -20px;
        right: 15px;
        width: 50px;
    }

    .red-circle {
        background: #f34e54;
        border-radius: 100px;
        display: block;
        height: 50px;
        width: 50px;
    }

    .filler {
        background: #f34e54;
        border-radius: 100px 100px 0 0;
        display: block;
        height: 30px;
        width: 20px;
        position: relative;
        top: -65px;
        right: -15px;
        z-index: 30;
    }
</style>



<div align="left" style="display: <%=this.headerDisplay%>">
    <asp:Label ID="lblHeader" runat="server">header</asp:Label>
</div>

<div align="left" style="display: <%=this.whatIsBeingAskedDisplay%>">
    <asp:Label ID="lblWhatIsBeingAsked" runat="server">header</asp:Label>
    <br />
</div>


<div style="width: 100%">
</div>

<table border="0" width="100%">
    <tr>
        <td valign="top">
            <div style="float: left; width: 200px; display: <%=this.thermometerDisplay%>">
                <asp:Label ID="lblProgress" runat="server" Text=""></asp:Label>
            </div>
        </td>
        <td valign="top">

            <div style="display: <%=this.listDisplay%>">
                <h3>
                    <asp:Label ID="lblListHeader" runat="server" Text="<%$ Resources:Strings, 18_donation_list_header %>"></asp:Label></h3>
                <asp:Label ID="lblList" runat="server" Text="List of Families"></asp:Label>
            </div>
        </td>
    </tr>
</table>


<div style="display: <%=this.backgroundDisplay%>">
    <asp:Label ID="lblBackground" runat="server" Text=""></asp:Label>
</div>

<div style="display: <%=this.goalDisplay%>">
    <asp:Label ID="lblGoal" runat="server" Text=""></asp:Label>
</div>

<div style="display: <%=this.whereIsYourHeartDisplay%>">
    <asp:Label ID="lblWhereIsYourHeart" runat="server" Text=""></asp:Label>
</div>
