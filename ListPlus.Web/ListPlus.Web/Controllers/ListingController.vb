Imports System.Web.Mvc

Namespace Controllers
    Public Class ListingController
        Inherits Controller

        ' GET: Listing
        Function List() As ActionResult
            Dim theList = New List(Of ListingModel) From
            {
                New ListingModel With {.Id = 1, .Title = "Food"},
                New ListingModel With {.Id = 2, .Title = "Hardware"},
                New ListingModel With {.Id = 3, .Title = "Vacation"}
            }
            Return View(theList)
        End Function
    End Class
End Namespace