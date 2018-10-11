
using Android.App;
using Android.OS;
using System.ServiceModel;
using EcompassServiceProxy;
using System;
using System.Collections.Generic;
using Android.Widget;
using Android.Support.V7.App;
using System.Threading;
using System.Threading.Tasks;
using static Android.Content.ClipData;

namespace E_CompassApp
{
    [Activity(Label = "SpecialsActivity")]
    public class SpecialsActivity : Activity// Activity Android.Support.V7.App.AppCompatActivity
    {
        private static readonly EndpointAddress Endpoint =
            new EndpointAddress("http://localhost:50874/EcompassService.svc");
        private EcompassServiceClient _client;
        private TextView txtSpecials;
        private string str;
        private ListView listSpecials;
        public PnpProducts[] Products { get; set; }

        public ArrayAdapter<string> ListAdapter { get; private set; }
        public string [] items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            try
            {
                SetContentView(Resource.Layout.Specials);

                txtSpecials = FindViewById<TextView>(Resource.Id.txtSpecials);
                listSpecials = FindViewById<ListView>(Resource.Id.listSpecials);
                InitializeEcompassServiceClient();

                ListSpecials();
                //ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, products.Length);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
         
        }

        private void ListSpecials()
        {
            txtSpecials.Text = "Waiting for WCF...";
            try
            {
                new Thread(async () =>
                {
                    await BuildStr();
                }).Start();

                txtSpecials.Text = "SPECIALS";
                txtSpecials.Text = str;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        async Task BuildStr()
        {
            //str = ecompassService.SayHelloTo();
            str = await _client.SayHelloToAsync(); /// after this step it jumps out of method
            Products = await _client.GetProductsDataAsync();

        }

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

    //            < ImageView
    //   android: src = "@drawable/yogurt"
    //   android: layout_width = "82.5dp"
    //   android: layout_height = "60.5dp"
    //   android: id = "@+id/imageView2"
    //   android: layout_marginRight = "0.0dp"
    //   android: layout_marginBottom = "14.0dp"
    //   android: layout_marginTop = "0.0dp"
    //   android: layout_marginLeft = "0.0dp" />

    //< TextView
    //   android: id = "@+id/myImageViewText"
    //   android: layout_width = "wrap_content"
    //   android: layout_height = "wrap_content"
    //   android: layout_margin = "1dp"
    //   android: gravity = "left"
    //   android: layout_gravity = "center_vertical"
    //   android: text = "Yogurt R29.90 2% discount"
    //   android: textColor = "#000000" />

    //< ImageView
    //   android: src = "@drawable/fries"
    //   android: layout_width = "74.5dp"
    //   android: layout_height = "56.5dp"
    //   android: id = "@+id/imageView2"
    //   android: layout_marginRight = "0.0dp"
    //   android: layout_marginBottom = "14.0dp"
    //   android: layout_marginTop = "0.0dp"
    //   android: layout_marginLeft = "0.0dp" />

    //< TextView
    //   android: id = "@+id/myImageViewText"
    //   android: layout_margin = "1dp"
    //   android: layout_width = "wrap_content"
    //   android: layout_height = "wrap_content"
    //   android: gravity = "left"
    //   android: layout_gravity = "center_vertical"
    //   android: text = "Fries R40.00 2% discount"
    //   android: textColor = "#000000" />
}