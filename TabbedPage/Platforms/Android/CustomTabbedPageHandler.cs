using AndroidX.Fragment.App;
using Google.Android.Material.Tabs;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
using Platform = Microsoft.Maui.ApplicationModel.Platform;

namespace TabbedPageSample.Platforms.Android;

public class CustomTabbedPageHandler : TabbedViewHandler
{
    public override void UpdateValue(string property)
    {
        base.UpdateValue(property);

        var tabs = Platform.CurrentActivity?.FindViewById<FragmentContainerView>(Microsoft.Maui.Resource.Id
            .navigationlayout_toptabs);

        var tabLayout = tabs?.GetChildAt(0);

        if (tabLayout is TabLayout layout)
        {
            layout.TabMode = TabLayout.ModeScrollable;
            layout.SetSelectedTabIndicatorColor(Colors.White.ToAndroid());
        }
    }
}
