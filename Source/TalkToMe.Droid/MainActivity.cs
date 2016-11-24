using Android.App;
using Android.Content.PM;
using Android.OS;
using TalkToMe.Core;
using TalkToMe.Droid.Services.IoC;

namespace TalkToMe.Droid
{
    [Activity(Label = "TalkToMe", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            IoC.Initialize(IoCHelperDroid.RegisterDroidDependencies);
            LoadApplication(new App());
        }
    }
}

