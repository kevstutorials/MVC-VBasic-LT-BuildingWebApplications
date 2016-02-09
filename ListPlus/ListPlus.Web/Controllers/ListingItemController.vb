Imports System.Web.Mvc

Namespace Controllers
    Public Class ListingItemController
        Inherits Controller

        ' GET: ListingItem
        Function ItemList(id As Integer) As ActionResult
            Dim items = New List(Of ListingItemModel)() From
                {
                    New ListingItemModel() With {.Id = 1, .ListingId = 1, .Title = "Bananas"},
                    New ListingItemModel() With {.Id = 2, .ListingId = 1, .Title = "Pears"},
                    New ListingItemModel() With {.Id = 3, .ListingId = 1, .Title = "Pancakes"},
                    New ListingItemModel() With {.Id = 4, .ListingId = 2, .Title = "Hammer"},
                    New ListingItemModel() With {.Id = 5, .ListingId = 2, .Title = "Nails"},
                    New ListingItemModel() With {.Id = 6, .ListingId = 3, .Title = "Eat"},
                    New ListingItemModel() With {.Id = 7, .ListingId = 3, .Title = "Swim in sea"},
                    New ListingItemModel() With {.Id = 8, .ListingId = 3, .Title = "Sun bathe"}
                }.Where(Function(li) li.ListingId = id).ToList()

            Dim list = New ListingItemListModel(items)
            Return View(list)
        End Function
    End Class
End Namespace