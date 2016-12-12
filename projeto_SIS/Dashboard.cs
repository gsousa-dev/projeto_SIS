using System;
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
    public partial class Dashboard : Form
    {
        public string access_token;
        private List<User> secretarias;
        public Dashboard(string access_token)
        {
            this.access_token = access_token;
            InitializeComponent();
            ListarSecretarias(access_token);
        }
        public void ListarSecretarias(string access_token)
        {
            RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user");
            RestRequest request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("ACCESS-TOKEN", access_token);

            IRestResponse response = client.Execute(request);
            string json = response.Content;

            secretarias = JsonConvert.DeserializeObject<List<User>>(json);
            listBoxSecretarias.DataSource = secretarias;
        }

        private void buttonAddSecretaria_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user");
            RestRequest request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("ACCESS-TOKEN", access_token);
            
            string birthday = dateTimePickerBirthday.Value.ToString("yyyy-MM-dd");
            string gender = null;
            if (comboBoxGender.Text == "Masculino")
                gender = "M";
            else if (comboBoxGender.Text == "Feminino")
                gender = "F";

            request.AddJsonBody(
                     new
                     {
                         user_type = 2,
                         username = textBoxUsername.Text,
                         password = textBoxPassword.Text,
                         email = textBoxEmail.Text,
                         name = textBoxName.Text,
                         birthday = birthday,
                         gender = gender
                     }
                    );

            IRestResponse response = client.Execute(request);                                   
        }

        private void buttonApagarSecretaria_Click(object sender, EventArgs e)
        {
            if (listBoxSecretarias.SelectedIndex != -1)
            {
                int id = ((User)listBoxSecretarias.SelectedItem).ID;
                RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/" + id);
                RestRequest request = new RestRequest();
                request.Method = Method.DELETE;
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("ACCESS-TOKEN", access_token);
                IRestResponse response = client.Execute(request);
            }
        }

        private void listBoxSecretarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
