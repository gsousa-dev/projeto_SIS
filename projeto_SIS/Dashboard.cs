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
        private List<Secretaria> secretarias;
        private List<Cliente> clientes;
        private List<Exercicio> exercicios;

        public Dashboard(string access_token)
        {
            this.access_token = access_token;
            InitializeComponent();

            ListarSecretarias();
            ListarExercicios();
            ListarClientes();
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

                Utils.escreverParaFicheiro("PEDIDO - LISTA DE SECRETÁRIAS", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);


                IRestResponse response = client.Execute(request);
                string json = response.Content;

                Utils.escreverParaFicheiro2("RESPOSTA - LISTA DE SECRETÁRIAS", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);


                secretarias = JsonConvert.DeserializeObject<List<Secretaria>>(json);
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

                Utils.escreverParaFicheiro("PEDIDO - ADICIONAR SECRETÁRIA", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);


                IRestResponse response = client.Execute(request);

                Utils.escreverParaFicheiro2("RESPOSTA - ADICIONAR SECRETÁRIA", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);


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
                    int id = ((Secretaria)listBoxSecretarias.SelectedItem).ID;
                    RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/" + id);
                    RestRequest request = new RestRequest();
                    request.Method = Method.DELETE;
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("ACCESS-TOKEN", access_token);

                    Utils.escreverParaFicheiro("PEDIDO - APAGAR SECRETÁRIA", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);


                    IRestResponse response = client.Execute(request);

                    Utils.escreverParaFicheiro2("RESPOSTA - APAGAR SECRETÁRIA", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);


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
                    int id = ((Secretaria)listBoxSecretarias.SelectedItem).ID;
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

                    Utils.escreverParaFicheiro("PEDIDO - ALTERAR SECRETÁRIA", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);


                    IRestResponse response = client.Execute(request);

                    Utils.escreverParaFicheiro2("RESPOSTA - ALTERAR SECRETÁRIA", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);

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
            Secretaria secretariaSelecionada = ((Secretaria)listBoxSecretarias.SelectedItem);

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

                Utils.escreverParaFicheiro("PEDIDO - LISTAR EXERCÍCIOS", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);

                IRestResponse response = client.Execute(request);

                Utils.escreverParaFicheiro2("RESPOSTA - LISTAR EXERCÍCIOS", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);


                string json = response.Content;

                exercicios = JsonConvert.DeserializeObject<List<Exercicio>>(json);
                listBoxExercicios.DataSource = exercicios;

                listBoxExercicios.SelectedIndex = -1;

                comboBoxTipoExercicio.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxAddTipoExercicio.DropDownStyle = ComboBoxStyle.DropDownList;
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
                RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/exercicios");
                RestRequest request = new RestRequest();
                request.Method = Method.POST;
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("ACCESS-TOKEN", access_token);

                string tipo = null;
                if (comboBoxAddTipoExercicio.SelectedIndex == 0)
                    tipo = "1";
                else if (comboBoxAddTipoExercicio.SelectedIndex == 1)
                    tipo = "2";

                request.AddJsonBody(
                         new
                         {
                             descricao = textBoxAddDescricaoExercicio.Text,
                             tipo_exercicio = tipo
                         }
                        );

                Utils.escreverParaFicheiro("PEDIDO - ADICIONAR EXERCÍCIO", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);

                IRestResponse response = client.Execute(request);

                Utils.escreverParaFicheiro2("RESPOSTA - ADICIONAR EXERCÍCIO", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);

                listBoxExercicios.DataSource = null;

                ListarExercicios();

                textBoxAddDescricaoExercicio.Text = "";
                comboBoxAddTipoExercicio.SelectedIndex = -1;
                

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
                    RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/exercicios/" + id);
                    RestRequest request = new RestRequest();
                    request.Method = Method.DELETE;
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("ACCESS-TOKEN", access_token);

                    Utils.escreverParaFicheiro("PEDIDO - APAGAR EXERCÍCIO", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);

                    IRestResponse response = client.Execute(request);

                    Utils.escreverParaFicheiro2("RESPOSTA - APAGAR EXERCÍCIO", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);

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
                comboBoxTipoExercicio.SelectedIndex = -1;
            }
            else
            {
                textBoxDescricaoExercicio.Text = exercicioSelecionado.Descricao;
                if (exercicioSelecionado.Tipo_exercicio == 1)
                    comboBoxTipoExercicio.SelectedIndex = 0;
                if (exercicioSelecionado.Tipo_exercicio == 2)
                    comboBoxTipoExercicio.SelectedIndex = 1;
            }
        }

        private void buttonAlterarExercicio_Click(object sender, EventArgs e)
        {
            if (textBoxDescricaoExercicio.Text.Length == 0)
            {
                MessageBox.Show("Introduza a decrição do exercicio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxTipoExercicio.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha o tipo de exercício", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (listBoxExercicios.SelectedIndex != -1)
                {
                    int id = ((Exercicio)listBoxExercicios.SelectedItem).ID;
                    RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/exercicios/" + id);
                    RestRequest request = new RestRequest();
                    request.Method = Method.PUT;
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("ACCESS-TOKEN", access_token);

                    string tipo = null;
                    if (comboBoxTipoExercicio.SelectedIndex == 0)
                        tipo = "1";
                    else if (comboBoxTipoExercicio.SelectedIndex == 1)
                        tipo = "2";

                    request.AddJsonBody(
                        new
                             {
                                 descricao = textBoxDescricaoExercicio.Text,
                                 tipo_exercicio = tipo
                             }
                    );


                    Utils.escreverParaFicheiro("PEDIDO - ALTERAR EXERCÍCIO", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);

                    IRestResponse response = client.Execute(request);

                    Utils.escreverParaFicheiro2("RESPOSTA - ALTERAR EXERCÍCIO", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);


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

        // ---------------------------- CLIENTES ------------------------------------------

        public void ListarClientes()
        {
            try
            {
                listBoxClientes.DataSource = null;

                RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/filter-by-type-of-user");
                RestRequest request = new RestRequest();
                request.Method = Method.GET;
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("ACCESS-TOKEN", access_token);
                request.AddHeader("USER-TYPE", (4).ToString());

                Utils.escreverParaFicheiro("PEDIDO - LISTA DE CLIENTES", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);

                IRestResponse response = client.Execute(request);
                string json = response.Content;

                Utils.escreverParaFicheiro2("RESPOSTA - LISTA DE CLIENTES", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);

                clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
                listBoxClientes.DataSource = clientes;
                listBoxClientes.SelectedIndex = -1;

                comboBoxAddPTCliente.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxPTCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar listar os clientes. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = ((Cliente)listBoxClientes.SelectedItem);

            if (clienteSelecionado == null)
            {
                textBoxPasswordCliente.Text = "";
                textBoxUsernameCliente.Text = "";
                textBoxEmailCliente.Text = "";
                textBoxNomeCliente.Text = "";
                comboBoxGeneroCliente.SelectedIndex = -1;
                comboBoxPTCliente.SelectedIndex = -1;
            }
            else
            {
                textBoxPasswordCliente.Text = "";
                textBoxUsernameCliente.Text = clienteSelecionado.Username;
                textBoxEmailCliente.Text = clienteSelecionado.Email;
                textBoxNomeCliente.Text = clienteSelecionado.Name;
                if (clienteSelecionado.Gender == "M")
                    comboBoxGeneroCliente.SelectedIndex = 0;
                if (clienteSelecionado.Gender == "F")
                    comboBoxGeneroCliente.SelectedIndex = 1;
                //comboBoxPTCliente.SelectedIndex == clienteSelecionado.PersonalTrainer;
            }

            comboBoxGeneroSecretaria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddGeneroSecretaria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonRefreshListaClientes_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxClientes.SelectedIndex != -1)
                {
                    int id = ((Cliente)listBoxClientes.SelectedItem).ID;
                    RestClient client = new RestClient("http://localhost/projeto_platsi/api/web/v1/user/" + id);
                    RestRequest request = new RestRequest();
                    request.Method = Method.DELETE;
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("ACCESS-TOKEN", access_token);

                    Utils.escreverParaFicheiro("PEDIDO - APAGAR CLIENTE", client.BaseUrl.ToString(), request.Method.ToString(), request.Parameters);

                    IRestResponse response = client.Execute(request);

                    Utils.escreverParaFicheiro2("RESPOSTA - APAGAR CLIENTE", client.BaseUrl.ToString(), request.Method.ToString(), response.Content);

                    listBoxClientes.DataSource = null;

                    ListarClientes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado aconteceu ao tentar apagar um cliente. Verifique se está conectado com o servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
