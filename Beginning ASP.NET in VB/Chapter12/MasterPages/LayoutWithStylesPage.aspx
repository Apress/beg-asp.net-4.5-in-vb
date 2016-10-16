<%@ Page Title="" Language="VB" MasterPageFile="~/LayoutWithStyles.master" AutoEventWireup="false" CodeFile="LayoutWithStylesPage.aspx.vb" Inherits="LayoutWithStylesPage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    Your content goes in this middle region, which automatically takes whatever 
    space is left over.</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="AdditionalContent" Runat="Server">
    <p>
    Additional page content goes here.</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        And down here.</p>
</asp:Content>

