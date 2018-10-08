using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;

namespace E_CompassApp
{
    [Activity(Label = "LocationActivity")]
    public class LocationActivity : Activity
    {
        private bool isRequestingLocationUpdates;
        private TextView txtMessage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            try
            {
                LocationManager locationManager = (LocationManager)GetSystemService(Context.LocationService);

                // For this example, this method is part of a class that implements ILocationListener, described below
                //locationManager.RequestLocationUpdates(LocationManager.GpsProvider, 2000, 1, this);
            }
            catch (Exception ex)
            {

                txtMessage=FindViewById<TextView>(Resource.Id.txtMessage);
                txtMessage.Text= ex.Message;
            }
            // Create your application here
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.AccessFineLocation) == Permission.Granted)
            {
                StartRequestingLocationUpdates();
                isRequestingLocationUpdates = true;

                SetContentView(Resource.Layout.Location);

            }
            else
            {
                Toast toast = new Toast(this);
                toast.SetText("Please make use location services are on");
               
                toast.Show();

                // The app does not have permission ACCESS_FINE_LOCATION 
            }
            
        }

        private void StartRequestingLocationUpdates()
        {
            throw new NotImplementedException();
        }
    }
}