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
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        private Button btnLocation;
        private Button btnSpecials;
        public object ToastLenght { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Home);
            btnLocation = FindViewById<Button>(Resource.Id.btnLocation);
            btnSpecials = FindViewById<Button>(Resource.Id.btnSpecials);
            btnSpecials.Click += btnSpecials_Click;
            btnLocation.Click += btnLocation_Click;



        }

        private void btnSpecials_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(SpecialsActivity));
        }

        private void btnLocation_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(LocationActivity));
        }
    }
}