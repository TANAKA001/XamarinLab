using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace App001_ConsultarCEP.Servico.Modelo
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = @"http://viacep.com.br/ws/{0}/json";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL,cep);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco _endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);
            if (_endereco.Cep == null)
            {
                return null;
            }
            return _endereco;
        }
    }
}
