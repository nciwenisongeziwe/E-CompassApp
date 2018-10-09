
using Android.App;
using Android.OS;
using System.ServiceModel;
using EcompassServiceProxy;
using System;
using System.Collections.Generic;
using Android.Widget;
using Android.Support.V7.App;

namespace E_CompassApp
{
    [Activity(Label = "SpecialsActivity")]
    public class SpecialsActivity : AppCompatActivity// Activity Android.Support.V7.App.AppCompatActivity
    {
        private static readonly EndpointAddress Endpoint = new EndpointAddress("http://localhost:50874/EcompassService.svc");
        private EcompassServiceClient _client;
        private TextView txtSpecials;
       // private string str;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            try
            {
                SetContentView(Resource.Layout.Specials);
                //SetContentView(Resource.Layout.Specials);
                //txtSpecials = FindViewById<TextView>(Resource.Id.txtSpecials);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Java.Lang.IllegalStateException: < Timeout exceeded getting exception details>
                // throw;
            }
            
           
            InitializeEcompassServiceClient();
            //ListSpecials();
        }

        //private void ListSpecials()
        //{
        //    txtSpecials.Text = "Waiting for WCF...";
        //    try
        //    {
        //        new Thread(async () =>
        //        {
        //            await BuildStr();
        //        }).Start();

        //        txtSpecials.Text = "SPECIALS";
        //        txtSpecials.Text = str;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}


        //async Task BuildStr()
        //{
        //    //str = ecompassService.SayHelloTo();
        //     str = await _client.SayHelloToAsync(); /// after this step it jumps out of method

        //}

        void InitializeEcompassServiceClient()
        {
            BasicHttpBinding binding = CreateBasicHttpBinding();
            _client = new EcompassServiceClient(binding, Endpoint);
        }


        static BasicHttpBinding CreateBasicHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "basicHttpBinding",
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647
            };

            TimeSpan timeout = new TimeSpan(0, 0, 30);
            binding.SendTimeout = timeout;
            binding.OpenTimeout = timeout;
            binding.ReceiveTimeout = timeout;
            return binding;
        }





        //async void GetHelloWorldDataButtonOnClick(object sender, EventArgs e)
        //{
        //    var data = new List<PnpProducts>
        //    {
        //        //Name = "Mr. Chad",
        //        //SayHello = true
        //    };

        //    //_getHelloWorldDataTextView.Text = "Waiting for WCF...";
        //    IObservable<PnpProducts> result;
        //    try
        //    {

        //        //listProducts. = await _client.GetProductsDataAsync();
        //        //listProducts = result;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}


        async void SayHelloWorldButtonOnClick(object sender, EventArgs e)
        {
            txtSpecials.Text = "Waiting for WCF...";
            try
            {
                var result = await _client.SayHelloToAsync();
                txtSpecials.Text = result;
            }
            catch (Exception ex)
            {
                txtSpecials.Text = ex.Message;
                //Console.WriteLine(ex.Message);
            }
        }


    }

    //public async Task<List<PnpProducts>> GetPnpProductsAsync()
    //{
    //    EcompassServiceClient client;

        //List<PnpProducts> result;
        //try
        //{

        //    result =((List<PnpProducts>) await _client.GetProductsDataAsync());
        //    listProduct = result;
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //var todoItems = await Task.Factory.FromAsync<ObservableCollection<client.GetProductsData>>(
        //    ecomass.BeginGetTodoItems,
        //    todoService.EndGetTodoItems,
        //    null,
        //    TaskCreationOptions.None);


        //foreach (var item in todoItems)
        //{
        //    Items.Add(FromWCFServiceTodoItem(item));
        //}
        //...
   // }
}