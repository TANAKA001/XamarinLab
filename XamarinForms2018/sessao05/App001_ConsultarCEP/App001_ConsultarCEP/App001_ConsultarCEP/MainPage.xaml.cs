using App001_ConsultarCEP.Servico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App001_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            consulta.Clicked += BuscarCep;
        }
        private void BuscarCep(object sender, EventArgs args)
        {
            string _cep = cep.Text.Trim();

            if (IsValidaCep(_cep))
            {
                try
                {
                    Endereco _endereco = ViaCEPServico.BuscarEnderecoViaCEP(_cep);
                    if (_endereco != null)
                    {

                        resultado.Text = String.Format("Endereço: {0} nº {1}, {2}, {3}", _endereco.logradouro, _endereco.complemento, _endereco.localidade, _endereco.uf);
                    }
                    else {
                        DisplayAlert("O endereço não foi encontrado para o cep informado:", _cep, "ok");
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRITICO", e.Message, "Ok");
                }

            }
        }

        private bool IsValidaCep(string _cep)
        {
            bool valid = true;
            
            int novoCep = 0;

            if (_cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP Invalido, informe os 8 digitos!", "Ok");

                valid = false;
            }

            //if (int.TryParse(_cep, out novoCep))
            //{
            //    DisplayAlert("ERRO", "CEP Invalido, deve conter apenas numeros!", "Ok");

            //    valid = false;
            //}
            
            return valid;
        }
    }
}
