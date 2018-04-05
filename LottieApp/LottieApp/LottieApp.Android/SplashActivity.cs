using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace LottieApp.Droid
{
    [Activity(Label = "LottieApp", MainLauncher = true, NoHistory = true, LaunchMode = LaunchMode.SingleTop, ScreenOrientation = ScreenOrientation.Unspecified, Theme = "@style/MyTheme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        Android.Content.Res.Configuration newConfig;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
               StartActivity(typeof(MainActivity));
                    Window.SetBackgroundDrawable(null);
                    base.OnConfigurationChanged(newConfig);
    
        }

    }
   
}