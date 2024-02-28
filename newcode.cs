bool IsFileSource(LogEvent e)
{
    var source = e.GetSourceContext();
    return source != null && (source.Equals("File", StringComparison.OrdinalIgnoreCase) || source.StartsWith("File/", StringComparison.OrdinalIgnoreCase));
}

bool IsApiQueryWarning(LogEvent e)
{
    if (e.Level <= LogEventLevel.Warning
        && e.GetPropertyValue<string>("RequestPath").EmptyNull().StartsWithNoCase("/odata/")
        && e.GetSourceContext().EqualsNoCase("Microsoft.EntityFrameworkCore.Query"))
    {
        return true;
    }

    return false;
}
//england
 if (_seoSettings.CanonicalUrlsEnabled)
            {
                model.CanonicalUrl = Url.RouteUrl("Category", new { model.SeName }, Request.Scheme);
            }

            if (query.IsSubPage && !_catalogSettings.ShowDescriptionInSubPages)
            {
                model.Description.ChangeValue(string.Empty);
                model.BottomDescription.ChangeValue(string.Empty);
            }
//yes
