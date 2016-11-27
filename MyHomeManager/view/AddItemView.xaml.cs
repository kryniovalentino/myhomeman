using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyHomeManager
{

    public partial class AddItemView : ContentPage
    {
        Entry MyEntry = new Entry { Placeholder = "Username" };

        public AddItemView()
        {
            InitializeComponent();
        }
        public void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var secondPage = new TodoList();
            Navigation.PopModalAsync();
        }
    }
}
