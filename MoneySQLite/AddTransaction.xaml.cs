using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneySQLite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTransaction : ContentPage
	{
        public AddTransaction()
        {
            InitializeComponent();
            String myDate = DateTime.Now.ToString();
            txtDate.Text = myDate;
        }
        public void OnSaveClicked(object sender, EventArgs args)
        {

            var vEmployee = new Transaction()
            {
                TransName = txtTransName.Text,
                Amount = txtAmount.Text,
                Date = txtDate.Text,
                Desc = txtDesc.Text
            };
            App.DBUtils.SaveTransaction(vEmployee);
            Navigation.PushAsync(new ManageTransasction());
        }
    }
}
