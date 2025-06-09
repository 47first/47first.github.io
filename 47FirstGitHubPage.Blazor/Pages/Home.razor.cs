using _47FirstGitHubPage.Blazor.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace _47FirstGitHubPage.Blazor.Pages;

public partial class Home : ComponentBase
{
    private readonly DateTime _cSharpStartTime = new(2021, 1, 1);
    private readonly DateTime _unityStartTime = new(2022, 3, 1);
    private readonly DateTime _itlStartTime = new(2023, 11, 1);

    [Inject]
    public required IStringLocalizer<HomePageLocalization> PageLocalizer { get; set; }

    [Inject]
    public required IStringLocalizer<DateOnlyLocalization> DateOnlyLocalizer { get; set; }

    private MarkupString AboutMeText
    {
        get
        {
            var dateNow = DateTime.Now;

            var cSharpRange = dateNow.Subtract(_cSharpStartTime);
            var unityRange = dateNow.Subtract(_unityStartTime);
            var itlRange = dateNow.Subtract(_itlStartTime);

            var result = PageLocalizer[
                "About Me Text",
                LocalizeDateOnly(cSharpRange),
                LocalizeDateOnly(unityRange),
                LocalizeDateOnly(itlRange)
            ];

            return new MarkupString(result);
        }
    }

    private string LocalizeDateOnly(TimeSpan timeSpan)
    {
        int years = (int)Math.Floor(timeSpan.Days / 365d);
        int months = (int)Math.Ceiling((timeSpan.Days - years * 365d) / 30);

        var localizedYears = DateOnlyLocalizer[years switch
        {
            >= 5 => "YearsFrom5",
            > 1 => "YearsTo4",
            _ => "Year"
        }];

        var localizedMonths = DateOnlyLocalizer[months switch
        {
            >= 5 => "MonthsFrom5",
            > 1 => "MonthsTo4",
            _ => "Month"
        }];

        return string.Join(' ', years, localizedYears, months, localizedMonths);
    }
}
