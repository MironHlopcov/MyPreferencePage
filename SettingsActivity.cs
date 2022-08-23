using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Java.Lang;

namespace MyPreferencePage
{
    [Activity(Label = "SettingsActivity", Theme = "@style/AppTheme.NoActionBar")]
    public class SettingsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_settings);

            if (FindViewById(Resource.Id.idFrameLayout1) != null)
            {
                if (savedInstanceState != null)
                {
                    return;
                }
                // below line is to inflate our fragment.
                SupportFragmentManager.BeginTransaction().Add(Resource.Id.idFrameLayout1, new SettingsFragment()).Commit();

            }
        }
    }
}
