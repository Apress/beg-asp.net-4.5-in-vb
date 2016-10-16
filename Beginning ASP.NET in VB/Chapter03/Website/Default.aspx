<%@ Page Language="VB" %>

<!DOCTYPE html>

<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim saleProduct As New Product("Kitchen Garbage", 49.99, "garbage.jpg")
        Response.Write(saleProduct.GetHtml())
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Product Test</title>    
</head>
<body>
</body>
</html>
