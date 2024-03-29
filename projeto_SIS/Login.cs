﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace projeto_SIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {   
            if (textBoxUsername.TextLength > 0 && textBoxPassword.TextLength > 0)
            {
                try
                {
                    if (textBoxUsername.Text == "admin")
                    {
                        RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/authenticate");
                        RestRequest request = new RestRequest();

                        request.Method = Method.POST;
                        request.AddHeader("Accept", "application/json");
                        request.AddHeader("Content-Type", "application/json");

                        request.AddJsonBody(
                         new
                         {
                             username = textBoxUsername.Text,
                             password = textBoxPassword.Text
                         }
                        );

                        IRestResponse response = client.Execute(request);

                        Utils.escreverParaFicheiro("PEDIDO - LOGIN", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);

                        string content = response.Content;
                        string access_token = JObject.Parse(content).Property("access_token").Value.ToString();

                        Utils.escreverParaFicheiro2("RESPOSTA - LOGIN", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);

                        if (access_token != null)
                        {
                            this.Hide();
                            Dashboard dashboard = new Dashboard(access_token);
                            dashboard.ShowDialog();
                            Application.Exit();
                                               
                        }
                        else
                            MessageBox.Show("Algo de errado aconteceu.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Utilizador sem permissões para fazer autenticação.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo inesperado aconteceu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                                  
            }
            else
                MessageBox.Show("Os campos não foram preenchidos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
