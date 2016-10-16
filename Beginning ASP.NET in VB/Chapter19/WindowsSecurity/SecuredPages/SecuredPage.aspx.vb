Imports System.Security.Principal

Partial Class SecuredPages_SecuredPage
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim displayText As New StringBuilder()
        displayText.Append("You have reached the secured page, ")
        displayText.Append(User.Identity.Name)

        Dim winIdentity As WindowsIdentity
        winIdentity = CType(User.Identity, WindowsIdentity)

        displayText.Append(".<br /><br />Authentication Type: ")
        displayText.Append(winIdentity.AuthenticationType)
        displayText.Append("<br />Anonymous: ")
        displayText.Append(winIdentity.IsAnonymous)
        displayText.Append("<br />Authenticated: ")
        displayText.Append(winIdentity.IsAuthenticated)
        displayText.Append("<br />Guest: ")
        displayText.Append(winIdentity.IsGuest)
        displayText.Append("<br />System: ")
        displayText.Append(winIdentity.IsSystem)
        displayText.Append("<br />Administrator: ")
        displayText.Append(User.IsInRole("BUILTIN\Administrators"))

        lblMessage.Text = displayText.ToString()

    End Sub
End Class
