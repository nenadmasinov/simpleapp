using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SimplePage : ContentPage
	{
        public int PageNumber = 0;
        public SimplePage()
        {
            InitializeComponent();
        }

		public SimplePage (int pageNumber)
		{
            InitializeComponent();
            PageNumber = pageNumber;
            txtPageNumber.Text = PageNumber.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var pgNumber = PageNumber + 1;
            Navigation.PushAsync(new SimplePage(pgNumber));
        }
    }
}