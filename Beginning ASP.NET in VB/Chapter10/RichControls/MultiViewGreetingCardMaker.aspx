<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MultiViewGreetingCardMaker.aspx.vb" Inherits="MultiViewGreetingCardMaker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" cellpadding="5">
            <tr valign="top">
                <td style="width: 281px">
                    <asp:MultiView id="MultiView1" runat="server" ActiveViewIndex="0">
                        <asp:View ID="View1" runat="server">
                            Choose a foreground (text) color:<br  />
                            <asp:DropDownList ID="lstForeColor" runat="server" AutoPostBack="True" Height="22px"
                                Width="194px">
                            </asp:DropDownList><br  />
                            <br  />
                            Choose a background color:<br  />
                            <asp:DropDownList ID="lstBackColor" runat="server" AutoPostBack="True" Height="22px"
                                 Width="194px">
                            </asp:DropDownList>
                            
                            <br />
                            
                            <asp:Button ID="cmdNext" runat="server" Text="Next >" CommandName="NextView" />
                            
                            </asp:View>
                            
                        <asp:View ID="View2" runat="server">
                            Choose a border style:<br  />
                            <asp:RadioButtonList ID="lstBorder" runat="server" AutoPostBack="True"
                                Height="59px"  RepeatColumns="2" Width="177px">
                            </asp:RadioButtonList><br  />
                            <br  />
                            <asp:CheckBox ID="chkPicture" runat="server" AutoPostBack="True" 
                                Text="Add the Default Picture"  />
                                
                            <br />
                            <asp:Button ID="Button3" runat="server" Text="< Prev" CommandName="PrevView" />
                            <asp:Button ID="Button4" runat="server" Text="Next >" CommandName="NextView" />
                            
                                </asp:View>
                        <asp:View ID="View3" runat="server">
                            Choose a font name:<br  />
                            <asp:DropDownList ID="lstFontName" runat="server" AutoPostBack="True" Height="22px"
                                Width="194px">
                            </asp:DropDownList><br  />
                            <br  />
                            Specify a font size:<br  />
                            <asp:TextBox ID="txtFontSize" runat="server" AutoPostBack="True" ></asp:TextBox><br  />
                            <br  />
                            Enter the greeting text below:<br  />
                            <asp:TextBox ID="txtGreeting" runat="server" Height="85px" 
                                TextMode="MultiLine" Width="240px" AutoPostBack="True"></asp:TextBox>                            
                            <br />                            
                            <asp:Button ID="Button1" runat="server" Text="< Prev" CommandName="PrevView" />
                            <asp:Button ID="Button2" runat="server" Text="Apply" />
                                            
                          </asp:View>
                    </asp:MultiView>
                </td>
                <td >
                    <asp:Panel ID="pnlCard" runat="server" Height="445px" HorizontalAlign="Center" Style="z-index: 101;
                        " Width="339px">
                        <br />
                        &nbsp;
                        <asp:Label ID="lblGreeting" runat="server" Height="150px" Width="272px"></asp:Label>
                        <asp:Image ID="imgDefault" runat="server" Height="160px" Visible="False" Width="212px" />
                    </asp:Panel>
                </td>
            </tr>
        </table>
        </div>
        
    </form>
</body>
</html>
