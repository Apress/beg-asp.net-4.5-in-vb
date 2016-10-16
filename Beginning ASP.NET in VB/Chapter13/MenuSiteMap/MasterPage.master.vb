
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Function GetDescriptionFromTitle(ByVal title As String) _
      As String
        Dim startingNode As SiteMapNode = SiteMap.RootNode
        Dim matchNode As SiteMapNode = SearchNodes(startingNode, title)
        If matchNode Is Nothing Then
            ' No match.
            Return ""
        Else
            ' Get the description of the match.
            Return matchNode.Description
        End If
    End Function

    Private Function SearchNodes(ByVal node As SiteMapNode, ByVal title As String) _
      As SiteMapNode
        If node.Title = title Then
            Return node
        Else
            ' Perform recursive search.
            For Each child As SiteMapNode In node.ChildNodes
                ' Was a match found?
                ' If so, return it.
                Dim match As SiteMapNode = SearchNodes(child, title)
                If match IsNot Nothing Then Return match
            Next
            ' All the nodes were examined, but no match was found.
            Return Nothing
        End If
    End Function


End Class

