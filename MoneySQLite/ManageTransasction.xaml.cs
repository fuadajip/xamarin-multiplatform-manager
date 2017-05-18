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
	public partial class ManageTransasction : ContentPage
	{
		public ManageTransasction ()
		{
			InitializeComponent ();
            var vList = App.DBUtils.GetAllTransaction();
            lstData.ItemsSource = vList;

            var totalTrans = App.DBUtils.GeTotalAmount();
            txtTotal.Text = totalTrans.ToString();
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var vSelUser = (Transaction)e.SelectedItem;
            Navigation.PushAsync(new ShowTransaction(vSelUser));
        }

        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddTransaction());
        }
    }
}
