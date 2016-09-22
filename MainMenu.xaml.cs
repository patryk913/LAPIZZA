using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LAPIZZA
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

         // <Image>
        //  <Image.Source>
            
           // <OnPlatform x:TypeArguments="ImageSource">
              
          //    <OnPlatform.iOS>logo.png</OnPlatform.iOS>
        //      <OnPlatform.Android>logo.png</OnPlatform.Android>
              
       //     </OnPlatform>
            
        //  </Image.Source>
       // </Image>

       // var logoImage = new Image { Aspect = Aspect.AspectFit };
        //logoImage.Source = ImageSource.FromFile("logo.png");

        private async void NavigateButtonOrder(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new OrderPage().GetSampleContentPage());
            await Navigation.PushAsync(new OrderPage());
        }

        private async void NavigateButtonAboutUs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUsPage());
        }

        private async void NavigateButtonContactUs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactUsPage());
        }

        private async void NavigateButtonOrderHist(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderHistoryPage().GetHistoryContentPage());
        }
    }
}
