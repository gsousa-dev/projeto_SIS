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
            ListarExercicios();
        }

        //SECRETARIAS
        public void ListarSecretarias()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar listar as secretárias. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void buttonAddSecretaria_Click(object sender, EventArgs e)
        {
            if (textBoxAddUsernameSecretaria.Text.Length == 0)
            {
                MessageBox.Show("Introduza dados em todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxAddPasswordSecretaria.Text.Length == 0)
            {
                MessageBox.Show("Introduza dados em todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxAddEmailSecretaria.Text.Length == 0)
            {
                MessageBox.Show("Introduza dados em todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxAddNameSecretaria.Text.Length == 0)
            {
                MessageBox.Show("Introduza dados em todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboBoxAddGeneroSecretaria.SelectedIndex == -1)
            {
                MessageBox.Show("Introduza dados em todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user");
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

                listBoxSecretarias.DataSource = null;

                ListarSecretarias();

                textBoxAddUsernameSecretaria.Text = "";
                textBoxAddPasswordSecretaria.Text = "";
                textBoxAddEmailSecretaria.Text = "";
                textBoxAddNameSecretaria.Text = "";
                comboBoxAddGeneroSecretaria.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar adicionar uma secretária. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                                          
        }

        private void buttonApagarSecretaria_Click(object sender, EventArgs e)
        {

            try
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


                    listBoxSecretarias.DataSource = null;

                    ListarSecretarias();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar alterar uma secretária. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }




        private void buttonAlterarSecretaria_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameSecretaria.Text.Length == 0)
            {
                MessageBox.Show("Introduza dados em todos os campos (menos password, é apenas usada se quiser alterar a password)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxEmailSecretaria.Text.Length == 0)
            {
                MessageBox.Show("Introduza dados em todos os campos (menos password, é apenas usada se quiser alterar a password)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxNameSecretaria.Text.Length == 0)
            {
                MessageBox.Show("Introduza dados em todos os campos (menos password, é apenas usada se quiser alterar a password)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboBoxGeneroSecretaria.SelectedIndex == -1)
            {
                MessageBox.Show("Introduza dados em todos os campos (menos password, é apenas usada se quiser alterar a password)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (listBoxSecretarias.SelectedIndex != -1)
                {
                    int id = ((User)listBoxSecretarias.SelectedItem).ID;
                    RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/" + id);
                    RestRequest request = new RestRequest();
                    request.Method = Method.PUT;
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("ACCESS-TOKEN", access_token);

                    string gender = null;
                    if (comboBoxGeneroSecretaria.Text == "Masculino")
                        gender = "M";
                    else if (comboBoxGeneroSecretaria.Text == "Feminino")
                        gender = "F";

                    if (textBoxPasswordSecretaria.Text.Length == 0)
                    {
                        request.AddJsonBody(
                             new
                             {
                                 user_type = 2,
                                 username = textBoxUsernameSecretaria.Text,
                                 email = textBoxEmailSecretaria.Text,
                                 name = textBoxNameSecretaria.Text,
                                 gender = gender
                             }
                            );
                    }
                    else if (textBoxPasswordSecretaria.Text.Length > 0)
                    {
                        request.AddJsonBody(
                             new
                             {
                                 user_type = 2,
                                 username = textBoxUsernameSecretaria.Text,
                                 password = textBoxPasswordSecretaria.Text,
                                 email = textBoxEmailSecretaria.Text,
                                 name = textBoxNameSecretaria.Text,
                                 gender = gender
                             }
                            );
                    }

                    IRestResponse response = client.Execute(request);

                    listBoxSecretarias.DataSource = null;
                    ListarSecretarias();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar apagar uma secretária. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

   

        private void buttonRefreshSecretariaList_Click(object sender, EventArgs e)
        {
            ListarSecretarias();
        }



        private void listBoxSecretarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            User secretariaSelecionada = ((User)listBoxSecretarias.SelectedItem);

            if (secretariaSelecionada == null)
            {
                textBoxPasswordSecretaria.Text = "";
                textBoxUsernameSecretaria.Text = "";
                textBoxEmailSecretaria.Text = "";
                textBoxNameSecretaria.Text = "";
                comboBoxGeneroSecretaria.SelectedIndex = -1;
            }
            else
            {
                textBoxPasswordSecretaria.Text = "";
                textBoxUsernameSecretaria.Text = secretariaSelecionada.Username;
                textBoxEmailSecretaria.Text = secretariaSelecionada.Email;
                textBoxNameSecretaria.Text = secretariaSelecionada.Name;
                if (secretariaSelecionada.Gender == "M")
                    comboBoxGeneroSecretaria.SelectedIndex = 0;
                if (secretariaSelecionada.Gender == "F")
                    comboBoxGeneroSecretaria.SelectedIndex = 1;
            }

            comboBoxGeneroSecretaria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddGeneroSecretaria.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        //---------------- EXERCICIOS-----------------------------
        public void ListarExercicios()
        {
            try
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

                listBoxExercicios.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar listar os exercícios. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void buttonAdicionarExercicio_Click(object sender, EventArgs e)
        {
            if (textBoxAddDescricaoExercicio.Text.Length == 0)
            {
                MessageBox.Show("Introduza a descrição do exercício", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/exercicio");
                RestRequest request = new RestRequest();
                request.Method = Method.POST;
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("ACCESS-TOKEN", access_token);

                request.AddJsonBody(
                         new
                         {
                             descricao = textBoxAddDescricaoExercicio.Text,
                         }
                        );

                IRestResponse response = client.Execute(request);

                listBoxExercicios.DataSource = null;

                ListarExercicios();

                textBoxAddDescricaoExercicio.Text = "";
                

            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar adicionar um exercício. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonApagarExercicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxExercicios.SelectedIndex != -1)
                {
                    int id = ((Exercicio)listBoxExercicios.SelectedItem).ID;
                    RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/exercicio/" + id);
                    RestRequest request = new RestRequest();
                    request.Method = Method.DELETE;
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("ACCESS-TOKEN", access_token);

                    IRestResponse response = client.Execute(request);


                    listBoxExercicios.DataSource = null;

                    ListarExercicios();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar apagar um exercicio. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonRefreshExercícios_Click(object sender, EventArgs e)
        {
            ListarExercicios();
        }

        private void listBoxExercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Exercicio exercicioSelecionado = ((Exercicio)listBoxExercicios.SelectedItem);

            if (exercicioSelecionado == null)
            {
                textBoxDescricaoExercicio.Text = "";
            }
            else
            {
                textBoxDescricaoExercicio.Text = exercicioSelecionado.Descricao;
            }
        }

        private void buttonAlterarExercicio_Click(object sender, EventArgs e)
        {
            if (textBoxDescricaoExercicio.Text.Length == 0)
            {
                MessageBox.Show("Introduza a decrição do exercicio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (listBoxExercicios.SelectedIndex != -1)
                {
                    int id = ((Exercicio)listBoxExercicios.SelectedItem).ID;
                    RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/exercicio/" + id);
                    RestRequest request = new RestRequest();
                    request.Method = Method.PUT;
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("ACCESS-TOKEN", access_token);

                    request.AddJsonBody(
                        new
                             {
                                 descricao = textBoxDescricaoExercicio.Text
                             }
                    );
                    

                    IRestResponse response = client.Execute(request);


                    listBoxExercicios.DataSource = null;

                    ListarExercicios();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar alterar um exercicio. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
