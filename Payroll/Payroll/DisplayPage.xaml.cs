using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Payroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            page1GrossIncome.Text = $"{Application.Current.Properties["GrossIncome"]}";
            page1Deduction.Text = $"{Application.Current.Properties["Deduction"]}";
            page1NetIncome.Text = $"{Application.Current.Properties["NetIncome"]}";
        }

        public void back_Home(object sender, EventArgs e)
        {
            Application.Current.Properties["BackHome"] = new MainPage();
            Navigation.PushAsync(new MainPage());
        }
    }
}