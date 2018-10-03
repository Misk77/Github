using Android.App;
using Android.Widget;
using Android.OS;

namespace TempConvert
{
    [Activity(Label = "TempConvert", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button cButton;
        Button fButton;
        TextView resultTextView;
        EditText temperatureTextEdit;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            cButton = FindViewById<Button>(TempConvert.Resource.Id.cButton);
            fButton = FindViewById<Button>(TempConvert.Resource.Id.fButton);
            resultTextView = FindViewById<TextView>(TempConvert.Resource.Id.resultTextView);
            temperatureTextEdit = FindViewById<EditText>(TempConvert.Resource.Id.temperatureTextEdit);


            cButton.Click+= CButton_Click;
            fButton.Click += FButton_Click;

        }

        private void FButton_Click(object sender, System.EventArgs e)
        {
            float temp = float.Parse(temperatureTextEdit.Text);
            float fresult = temp * 1.8f + 32f;
            resultTextView.Text = fresult.ToString() + "degrees Farenheit (° F)";
        }

        private void CButton_Click(object sender, System.EventArgs e)
        {
            float temp = float.Parse(temperatureTextEdit.Text);
            float cresult = (temp - 32f) / 1.8f;
            resultTextView.Text = cresult.ToString() + "degrees Celsius (° C)";
        }
    }
}

