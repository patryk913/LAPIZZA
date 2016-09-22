using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LAPIZZA
{
    public partial class AboutUsPage : ContentPage
    {
        public AboutUsPage()
        {
            var browser = new WebView();
            browser.Source = "http://www.deakin.edu.au/~kchandr/Mobile%20Computing/aboutus.html";
            Content = browser;
        }
    }
}
