using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Test_Library;

namespace Hello_World
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            helloLabel.IsVisible = !helloLabel.IsVisible;
            Class1 testClass = new Class1();
            testClass.printHelloWorld();
        }
    }
}
