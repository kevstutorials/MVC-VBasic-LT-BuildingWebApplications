<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
</head>
<body>
    <div>
        This is the layout page
        @RenderBody()
    </div>
    @RenderSection("footer", False)
    @If Not IsSectionDefined("footer") Then
        @: This is the manual footer
    End If

</body>
</html>
