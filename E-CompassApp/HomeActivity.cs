
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

using Android.Support.V4.App;
using TaskStackBuilder = Android.Support.V4.App.TaskStackBuilder;

namespace E_CompassApp
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {
        private Button btnSpecials;
        private Button btnLocation;
        //private int count;
        static readonly int NOTIFICATION_ID = 1000;
        static readonly string CHANNEL_ID = "location_notification";
        internal static readonly string COUNT_KEY = "count";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Create your application here
            SetContentView(Resource.Layout.Home);

            //CreateNotificationChannel();

            btnSpecials = FindViewById<Button>(Resource.Id.btnSpecials);
            btnLocation = FindViewById<Button>(Resource.Id.btnLocation);

            btnSpecials.Click += BtnSpecials_Click;
            btnLocation.Click += BtnLocation_Click;

        }

        void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            // Pass the current button press count value to the next activity:
            //var valuesForActivity = new Bundle();
            //valuesForActivity.PutInt(COUNT_KEY, count);

            // When the user clicks the notification, SecondActivity will start up.
            var resultIntent = new Intent(this, typeof(SpecialsActivity));

            // Pass some values to SecondActivity:
            //resultIntent.PutExtras(valuesForActivity);

            // Construct a back stack for cross-task navigation:
            var stackBuilder = TaskStackBuilder.Create(this);
            //stackBuilder.AddParentStack(Class.FromType(typeof(SpecialsActivity)));
            //stackBuilder.AddNextIntent(resultIntent);

            // Create the PendingIntent with the back stack:
            var resultPendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            // Build the notification:
            var builder = new NotificationCompat.Builder(this, CHANNEL_ID)
                          .SetAutoCancel(true) // Dismiss the notification from the notification area when the user clicks on it
                          .SetContentIntent(resultPendingIntent) // Start up this activity when the user clicks the intent.
                          .SetContentTitle("Special on nearby") // Set the title
                          //.SetNumber(count) // Display the count in the Content Info
                          .SetSmallIcon(Resource.Drawable.oreos1) // This is the icon to display
                          .SetContentText($"Oroes special in your location."); // the message to display.

            // Finally, publish the notification:
            var notificationManager = NotificationManagerCompat.From(this);
            notificationManager.Notify(NOTIFICATION_ID, builder.Build());

            // Increment the button press count:
            //count++;
        }

        private void BtnSpecials_Click(object sender, System.EventArgs e)
        {
           // ButtonOnClick(sender, e);
            StartActivity(typeof(SpecialsActivity));
        }


        private void BtnLocation_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(LocationActivity));
            //try
            //{
            //    var geoUri = Android.Net.Uri.Parse("geo:-33.986843,25.6660153");
            //    var mapIntent = new Intent(Intent.ActionView, geoUri);
            //    StartActivity(mapIntent);
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }

        void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            var name = Resources.GetString(Resource.String.channel_name);
            var description = GetString(Resource.String.channel_description);
            var channel = new NotificationChannel(CHANNEL_ID, name, NotificationImportance.Default)
            {
                Description = description
            };

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }
    }
}