using System;
using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Support.V7.App;



namespace E_CompassApp
{
    [Activity(Label = "LocationActivity")]
    public class LocationActivity : AppCompatActivity, IOnMapReadyCallback
    {
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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //txtMessage=FindViewById<TextView>(Resource.Id.txtMessage);
                //txtMessage.Text= ex.Message;
            }
           

            
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            //throw new NotImplementedException();
            googleMap.MapType = GoogleMap.MapTypeNormal;
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;

            //
            MarkerOptions markerOpt1 = new MarkerOptions();
            markerOpt1.SetPosition(new LatLng(-33.986843, 25.6660153));
            markerOpt1.SetTitle("Pick n Pay Summerstrand");

            var bmDescriptor = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueCyan);
#pragma warning disable CS0618 // Type or member is obsolete
            markerOpt1.InvokeIcon(bmDescriptor);
#pragma warning restore CS0618 // Type or member is obsolete

            googleMap.AddMarker(markerOpt1);
        }


    }
}