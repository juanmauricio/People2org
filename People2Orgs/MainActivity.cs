using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace People2Orgs
{
    [Activity(Label = "People2Orgs", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Button retroalimentacionButton = FindViewById<Button>(Resource.Id.btnRetroalimentacion);
            retroalimentacionButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(RetroalimentacionActivity));
                //intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };


        }
    }
}

