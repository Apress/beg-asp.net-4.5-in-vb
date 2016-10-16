Imports System.Collections.Generic

Partial Class ManageUsers
    Inherits System.Web.UI.Page

    Protected Sub cmdCreateTestUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreateTestUsers.Click
        Dim createStatus As MembershipCreateStatus
        Membership.CreateUser("joes", "ignreto12__", "joes@domains.com", "How many menus are in tibet?", "16", True, createStatus)
        Membership.CreateUser("sallyr", "ignreto12__", "sally@domains.com", "How many menus are in tibet?", "16", True, createStatus)
        Membership.CreateUser("user014", "ignreto12__", "user014@home.ca", "How many menus are in tibet?", "16", True, createStatus)
        Membership.CreateUser("hmac_r", "ignreto12__", "", "How many menus are in tibet?", "16", True, createStatus)
        Membership.CreateUser("liu_liu", "ignreto12__", "liu@company.com", "How many menus are in tibet?", "16", True, createStatus)

        ' Rebind.
        gridUsers.DataSource = Membership.GetAllUsers()
        gridUsers.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gridUsers.DataSource = Membership.GetAllUsers()
        gridUsers.DataBind()
    End Sub

    Protected Sub gridUsers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridUsers.SelectedIndexChanged
        Dim list As New List(Of MembershipUser)()
        list.Add(Membership.GetUser(gridUsers.SelectedValue.ToString()))
        detailsUser.DataSource = list
        detailsUser.DataBind()
    End Sub
End Class
