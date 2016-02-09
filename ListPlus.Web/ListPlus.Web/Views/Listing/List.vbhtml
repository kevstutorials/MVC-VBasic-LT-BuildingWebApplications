@ModelType List(Of ListPlus.Web.ListingModel)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>List</title>
</head>
<body>
    <div> 
        List
        <ul>
            @For Each item In Model
                @<li>@item.Title</li>
            Next

        </ul>
    </div>
</body>
</html>
