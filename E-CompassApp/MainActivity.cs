using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace E_CompassApp
{
    [Activity(Label = "E_CompassApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button btnLogin;

        private EditText txtUsername;
        private EditText txtPassword;
        public object ToastLenght { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            btnLogin.Click += btnLogin_Click;

        }

        private void btnLogin_Click(object sender,System. EventArgs e)
        {
            if (txtUsername.Text == "software" && txtPassword.Text == "dev")
            {
                StartActivity(typeof(LoginActivity));

            }
            else
            {
                Toast.MakeText(this, "Username or password is incorrect", ToastLength.Long).Show();
            }
        }
    }
}

