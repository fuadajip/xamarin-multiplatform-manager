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
	public partial class EditTransaction : ContentPage
	{
        Transaction mSelTransaction;
        public EditTransaction(Transaction aSelectedTrans)
        {
            InitializeComponent();
            mSelTransaction = aSelectedTrans;
            BindingContext = mSelTransaction;
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            String myDate = DateTime.Now.ToString();
            mSelTransaction.TransName = txtName.Text;
            mSelTransaction.Amount = txtAmount.Text;
            mSelTransaction.Date = myDate;
            mSelTransaction.Desc = txtDesc.Text;
            App.DBUtils.EditEmployee(mSelTransaction);
            Navigation.PushAsync(new ManageTransasction());
        }
    }
}
