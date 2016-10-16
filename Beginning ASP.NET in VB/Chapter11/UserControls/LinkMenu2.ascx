<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LinkMenu2.ascx.vb" Inherits="LinkMenu2" %>
<div style="border-right: 2px groove; padding-right: 5px; border-top: 2px groove;
    padding-left: 5px; font-weight: bold; font-size: small; padding-bottom: 5px;
    border-left: 2px groove; width: 100px; padding-top: 5px; border-bottom: 2px groove;
    font-family: Verdana; height: 120px; background-color: #FFFFD9">
    Products:
    <asp:LinkButton ID="lnkBooks" runat="server" CommandArgument="Menu2Host.aspx?product=Books" >Books
  </asp:LinkButton><br />
    <asp:LinkButton ID="lnkToys" runat="server" CommandArgument="Menu2Host.aspx?product=Toys">Toys
  </asp:LinkButton><br />
    <asp:LinkButton ID="lnkSports" runat="server" CommandArgument="Menu2Host.aspx?product=Sports">Sports
  </asp:LinkButton><br />
    <asp:LinkButton ID="lnkFurniture" runat="server" CommandArgument="Menu2Host.aspx?product=Furniture">Furniture
  </asp:LinkButton>
</div>