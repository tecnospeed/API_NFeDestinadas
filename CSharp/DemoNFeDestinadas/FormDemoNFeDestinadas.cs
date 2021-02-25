using Newtonsoft.Json;
using RestSharp;
using RetornoNotas;
using System;
using System.Windows.Forms;

namespace DemoNFeDestinadas
{
    public partial class FormNFeDestinadas : Form
    {
        public FormNFeDestinadas()
        {
            InitializeComponent();
        }

        private void btnConsultarNFeDestinadas_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://api.nfe.tecnospeed.com.br/destinadas/v1/protocolos/" + txtNrProtocolo.Text + "/notas");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("cpfcnpjsoftwarehouse", txtCpfCnpjSH.Text);
                request.AddHeader("cpfcnpjdestinatario", txtCpfCnpjDestinario.Text);
                request.AddHeader("token_sh", txtTokenSH.Text);
                IRestResponse response = client.Execute(request);
                txtJSON.Text = response.Content;

                var retorno = JsonConvert.DeserializeObject<Root>(txtJSON.Text);

                txtSituacao.Text = retorno.situacao;
                txtMensagem.Text = retorno.mensagem;
                txtNrNotas.Text = retorno.paginacao != null ? retorno.paginacao.numeroDeNotas.ToString() : "";
                txtNrPaginas.Text = retorno.paginacao != null ? retorno.paginacao.mumeroDePaginas.ToString() : "";

                dtgViewNotas.DataSource = retorno.notas;

                ////Para percorrer as notas
                //for (int i = 0; i < retorno.notas.Count; i++)
                //{
                //    Console.WriteLine(retorno.notas[i].chave);
                //}    
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao consultar NFe Destinadas. " + ex.Message);
            }

        }
    }
}
