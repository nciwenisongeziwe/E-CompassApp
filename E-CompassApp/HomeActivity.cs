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

namespace E_CompassApp
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {
        private Button btnSpecials;
        private Button btnLocation;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Home);

            btnSpecials = FindViewById<Button>(Resource.Id.btnSpecials);
            btnLocation = FindViewById<Button>(Resource.Id.btnLocation);

            btnSpecials.Click += BtnSpecials_Click;
            btnLocation.Click += BtnLocation_Click;

        }


        private void BtnSpecials_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(FakeActivity));
        }


        private void BtnLocation_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(LocationActivity));
        }
    }
}