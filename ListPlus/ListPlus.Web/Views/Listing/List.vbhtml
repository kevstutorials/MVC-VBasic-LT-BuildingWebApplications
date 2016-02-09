@ModelType List(Of ListPlus.Web.ListingModel)

@Code
    ViewBag.Title = "ListPlus Listings"
End Code

<div> 
    My Lists
    <ul>
        @For Each item In Model
            @<li>@item.Title</li>
        Next
    </ul>
</div>

