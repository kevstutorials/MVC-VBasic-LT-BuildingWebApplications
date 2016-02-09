@ModelType ListPlus.Web.ListingItemListModel
@Code
    ViewData("Title") = "ItemList"
End Code

<h2>ItemList</h2>

<ul class="list-group">
    @For Each item In Model.ListingItems
        @<li class="list-group-item">
            @item.Title
        </li>
    Next

</ul>
