using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Maps;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;

using Android.Gms.Common;
using Android.Gms.Location;
using System.Threading.Tasks;
using Android.Support.V7.App;
using Android.Util;

namespace E_CompassApp
{
    [Activity(Label = "LocationActivity")]
    public class LocationActivity : AppCompatActivity, IOnMapReadyCallback
    {
       


        //private bool isRequestingLocationUpdates;
        //  private TextView txtMessage;

        // FusedLocationProviderClient fusedLocationProviderClient;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
          

            //   fusedLocationProviderClient = LocationServices.GetFusedLocationProviderClient(this);


            //LocationManager locationManager = (LocationManager)GetSystemService(Context.LocationService);

            try
            {
                LocationManager locationManager = (LocationManager)GetSystemService(Context.LocationService);
                StartRequestingLocationUpdates();
                //isRequestingLocationUpdates = true;

                SetContentView(Resource.Layout.Location);
                // For this example, this method is part of a class that implements ILocationListener, described below
                //locationManager.RequestLocationUpdates(LocationManager.GpsProvider, 2000, 1, this);
                var mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
                mapFragment.GetMapAsync(this);


                //var mapFrag = MapFragment.NewInstance();
                //activity.FragmentManager.BeginTransaction()
                //                        .Add(Resource.Id.map_container, mapFrag, "map_fragment")
                //                        .Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //txtMessage=FindViewById<TextView>(Resource.Id.txtMessage);
                //txtMessage.Text= ex.Message;
            }
           

            
        }


        bool IsGooglePlayServicesInstalled()
        {
            var queryResult = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (queryResult == ConnectionResult.Success)
            {
                Log.Info("MainActivity", "Google Play Services is installed on this device.");
                return true;
            }

            if (GoogleApiAvailability.Instance.IsUserResolvableError(queryResult))
            {
                // Check if there is a way the user can resolve the issue
                var errorString = GoogleApiAvailability.Instance.GetErrorString(queryResult);
                Log.Error("MainActivity", "There is a problem with Google Play Services on this device: {0} - {1}",
                          queryResult, errorString);

                // Alternately, display the error to the user.
            }

            return false;
        }



       


        public void OnMapReady(GoogleMap googleMap)
        {
            //throw new NotImplementedException();
            googleMap.MapType = GoogleMap.MapTypeNormal;
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
        }



        private void StartRequestingLocationUpdates()
        {
            //throw new NotImplementedException();
        }
    }
}