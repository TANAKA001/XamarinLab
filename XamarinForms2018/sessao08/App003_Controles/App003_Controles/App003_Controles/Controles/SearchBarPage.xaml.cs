using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App003_Controles.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        List<string> listaEmpresas;
        public SearchBarPage()
        {
            InitializeComponent();

            listaEmpresas = new List<string>(new string[] {
                "CallTech",
                "OCP - OMNI Cons. Products",
                "Deviant",
                "MAshurlE",
            });

            Preencher(listaEmpresas);
        }
        private void Preencher(List<string> lista)
        {
            listResult.Children.Clear();
            foreach (var items in lista)
            {
                listResult.Children.Add(new Label { Text = items });
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Preencher(listaEmpresas.Where(a => a.Contains(e.NewTextValue)).ToList<string>());
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            Preencher(listaEmpresas.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<string>());
        }
    }
}
