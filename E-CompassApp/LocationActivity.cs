using System;
using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Gms.Location;
using Android.Locations;
using ILocationListener = Android.Gms.Location.ILocationListener;


namespace E_CompassApp
{
    [Activity(Label = "LocationActivity")]
    public class LocationActivity : Activity, IOnMapReadyCallback, ILocationListener
    {
        //FusedLocationProviderClient fusedLocationProviderClient;
        private double _latView;
        private double _longView;

        public double LatView { get => _latView; set => _latView = value; }
        public double LongView { get => _longView; set => _longView = value; }

        


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            try
            {
                SetContentView(Resource.Layout.Location);
                // For this example, this method is part of a class that implements ILocationListener, described below
                //locationManager.RequestLocationUpdates(LocationManager.GpsProvider, 2000, 1, this);
                var mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
                mapFragment.GetMapAsync(this);

                mapFragment = MapFragment.NewInstance();
                mapFragment.FragmentManager.BeginTransaction()
                                                .Add(Resource.Id.map, mapFragment, "map_fragment")
                                                .Commit();

                //fusedLocationProviderClient = LocationServices.GetFusedLocationProviderClient(this);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //txtMessage=FindViewById<TextView>(Resource.Id.txtMessage);
                //txtMessage.Text= ex.Message;
            }



        }

        private LocationManager GetSystemService(object locationService)
        {
            throw new NotImplementedException();
        }

        //private async void GetLastLocationFromDevice()
        //{
        //    // This method assumes that the necessary run-time permission checks have succeeded.
        //    //getLastLocationButton.SetText(Resource.String.getting_last_location);
        //    Android.Locations.Location location = await fusedLocationProviderClient.GetLastLocationAsync();

        //    if (location == null)
        //    {
        //        // Seldom happens, but should code that handles this scenario
        //    }
        //    else
        //    {
        //        // Do something with the location 
        //        //Log.Debug("Sample", "The latitude is " + location.Latitude);
        //        LatView = location.Latitude;
        //        LongView = location.Longitude;
        //    }
        //}


        public void OnMapReady(GoogleMap googleMap)
        {
            //GetLastLocationFromDevice();
            LatView = -33.986843;
            LongView = 25.6660153;

            googleMap.MapType = GoogleMap.MapTypeNormal;
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
            googleMap.MoveCamera(CameraUpdateFactory.ZoomIn());
            //
            LatLng location = new LatLng(LatView, LongView);

            CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
            builder.Target(location);
            builder.Zoom(18);
            //builder.Bearing(155);
            //builder.Tilt(65);

            CameraPosition cameraPosition = builder.Build();

            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);

            googleMap.MoveCamera(cameraUpdate);

           

            MarkerOptions markerOpt1 = new MarkerOptions();
            markerOpt1.SetPosition(new LatLng(LatView, LongView));// 
            markerOpt1.SetTitle("Pick n Pay Summerstrand");

            var bmDescriptor = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueCyan);
#pragma warning disable CS0618 // Type or member is obsolete
            markerOpt1.InvokeIcon(bmDescriptor);
#pragma warning restore CS0618 // Type or member is obsolete

            googleMap.AddMarker(markerOpt1);
        }

        public void OnLocationChanged(Location location)
        {
            throw new NotImplementedException();
        }
    }
}