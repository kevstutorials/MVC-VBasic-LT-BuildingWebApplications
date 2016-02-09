@ModelType List(Of ListPlus.Web.ListingModel)

@Code
    ViewBag.Title = "ListPlus Listings"
End Code

<div> 
    <h2>My Lists</h2>
    <p>
        <div class="list-group">
            @For Each item In Model
                @DisplayListing(item)
            Next
        </div>
    </p>
</div>

@Helper DisplayListing(item As ListPlus.Web.ListingModel)
    'Going to Item List Based on Id Parameter
    @<a href="/ListingItem/ItemList/@item.Id" class="list-group-item">
        @If item.Type = 1 Then
            @<img src="~/Content/Images/shopping_cart.png" />
        Else
            @<img src="~/Content/Images/todo.png" />
        End If
        @item.Title
    </a>
End Helper