<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
    @System.Web.Optimization.Styles.Render("~/Content/css")
    @System.Web.Optimization.Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("ListPlus", "Index", "Home", Nothing, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right"></ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
    </div>
    @System.Web.Optimization.Scripts.Render("~/bundles/jquery")
    @System.Web.Optimization.Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
