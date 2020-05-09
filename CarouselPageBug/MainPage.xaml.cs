using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselPageBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
            Page1.Appearing += Page1_Appearing;
            Page2.Appearing += Page2_Appearing;
            Page3.Appearing += Page3_Appearing;
        }
        private void Page1_Appearing(object sender, System.EventArgs e)
        {
            DisplayAlert("Appearing", "Page1 Appeared", "ok");
        }
        private void Page2_Appearing(object sender, System.EventArgs e)
		{
            DisplayAlert("Appearing", "Page2 Appeared","ok");
        }
        private void Page3_Appearing(object sender, System.EventArgs e)
        {
            DisplayAlert("Appearing", "Page3 Appeared", "ok");
        }
        private void OnNextClicked(object sender, System.EventArgs e)
        {
            var pageCount = this.Children.Count;
            if (pageCount < 2)
                return;

            var index = this.Children.IndexOf(this.CurrentPage);
            index++;
            if (index >= pageCount)
                index = 0;

            this.CurrentPage = this.Children[index];
        }
    }
}



