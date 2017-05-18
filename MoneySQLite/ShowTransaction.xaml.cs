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
	public partial class ShowTransaction : ContentPage
	{
        Transaction mSelTransaction;
        public ShowTransaction(Transaction aSelectedTrans)
        {

            InitializeComponent();
            mSelTransaction = aSelectedTrans;
            BindingContext = mSelTransaction;
        }
        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditTransaction(mSelTransaction));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            bool accepted = await DisplayAlert("Konfirmasi", "Apakah anda yakin hapus data ?", "Yes", "No");
            if (accepted)
            {
                App.DBUtils.DeleteTransaction(mSelTransaction);
            }
            await Navigation.PushAsync(new ManageTransasction());
        }
    }
}
