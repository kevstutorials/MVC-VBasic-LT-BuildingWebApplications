Public Class ListingItemListModel
    Public Sub New(ListingItems As List(Of ListingItemModel))
        Me.ListingItems = ListingItems
    End Sub

    Property ListingItems As List(Of ListingItemModel)
End Class

