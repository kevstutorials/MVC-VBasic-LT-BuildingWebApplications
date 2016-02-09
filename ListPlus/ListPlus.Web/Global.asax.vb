Imports System.Web.Mvc
Imports System.Web.Routing
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        RegisterGlobalFilters(GlobalFilters.Filters)
        RegisterRoutes(RouteTable.Routes)
        RegisterBundles(BundleTable.Bundles)
    End Sub
End Class
