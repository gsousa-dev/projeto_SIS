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
        private List<Exercicio> exercicios;

        public Dashboard(string access_token)
        {
            this.access_token = access_token;
            InitializeComponent();
            ListarSecretarias();
            //ListarExercicios();
        }

        //SECRETARIAS
        public void ListarSecretarias()
        {
            listBoxSecretarias.DataSource = null;

            RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/filter-by-type-of-user");
            RestRequest request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("ACCESS-TOKEN", access_token);
            request.AddHeader("USER-TYPE", (2).ToString());

            IRestResponse response = client.Execute(request);
            string json = response.Content;

            secretarias = JsonConvert.DeserializeObject<List<User>>(json);
            listBoxSecretarias.DataSource = secretarias;
            listBoxSecretarias.SelectedIndex = -1;
        }

        private void buttonAddSecretaria_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/");
            RestRequest request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("ACCESS-TOKEN", access_token);

            
            string birthday = dateTimePickerAddSecretaria.Value.ToString("yyyy-MM-dd");
            string gender = null;
            if (comboBoxAddGeneroSecretaria.Text == "Masculino")
                gender = "M";
            else if (comboBoxAddGeneroSecretaria.Text == "Feminino")
                gender = "F";

            request.AddJsonBody(
                     new
                     {
                         user_type = 2,
                         username = textBoxAddUsernameSecretaria.Text,
                         password = textBoxAddPasswordSecretaria.Text,
                         email = textBoxAddEmailSecretaria.Text,
                         name = textBoxAddNameSecretaria.Text,
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
     
            User secretariaSelecionada = ((User)listBoxSecretarias.SelectedItem);

            if (secretariaSelecionada == null)
            {
                textBoxPasswordSecretaria.Text = "";
                textBoxUsernameSecretaria.Text = "";
                textBoxEmailSecretaria.Text = "";
                textBoxNomeSecretaria.Text = "";
                comboBoxGeneroSecretaria.SelectedIndex = -1;

                return;
            }
            else {
                textBoxPasswordSecretaria.Text = "";
                textBoxUsernameSecretaria.Text = secretariaSelecionada.Username;
                textBoxEmailSecretaria.Text = secretariaSelecionada.Email;
                textBoxNomeSecretaria.Text = secretariaSelecionada.Name;
                if (secretariaSelecionada.Gender == "M")
                    comboBoxGeneroSecretaria.SelectedIndex = 0;
                if (secretariaSelecionada.Gender == "F")
                    comboBoxGeneroSecretaria.SelectedIndex = 1;
            }
                

            

            comboBoxGeneroSecretaria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddGeneroSecretaria.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        //---------------- EXERCICIOS-----------------------------
        /*public void ListarExercicios()
        {
            listBoxExercicios.DataSource = null;

            RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/exercicios");
            RestRequest request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("ACCESS-TOKEN", access_token);

            IRestResponse response = client.Execute(request);
            string json = response.Content;

            exercicios = JsonConvert.DeserializeObject<List<Exercicio>>(json);
            listBoxExercicios.DataSource = exercicios;
        }

    */

    }
}
