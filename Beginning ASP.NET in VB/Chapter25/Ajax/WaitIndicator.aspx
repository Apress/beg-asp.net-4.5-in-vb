<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WaitIndicator.aspx.vb" Inherits="WaitIndicator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Test Page</title>
   
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>                
                <div style="background-color:#FFFFE0;padding: 20px">
                <asp:Label ID="lblTime" runat="server" Font-Bold="True"></asp:Label>
                <br />
                <br />
                <asp:Button ID="cmdRefreshTime" runat="server" Text="Start the Refresh Process" />
                </div>
            </ContentTemplate>
    </asp:UpdatePanel>
    <br />

    <asp:UpdateProgress runat="server" id="updateProgress1">
      <ProgressTemplate>
        <div style="font-size: xx-small">
            Contacting Server ... <img src="wait.gif" />        
            <input id="Button1" onclick="AbortPostBack()" type="button" value="Cancel" style="font-size: xx-small;" />
        </div>
      </ProgressTemplate>
    </asp:UpdateProgress>
    </div>
    </form>
    
     <script type="text/javascript">
    var prm = Sys.WebForms.PageRequestManager.getInstance();
    prm.add_initializeRequest(InitializeRequest);

    function InitializeRequest(sender, args) {
        if (prm.get_isInAsyncPostBack())
        {
            args.set_cancel(true);
        }
    }

    function AbortPostBack() {
        if (prm.get_isInAsyncPostBack()) {
         prm.abortPostBack();
        }        
    }
    </script>
    
</body>
</html>

