namespace projeto_SIS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonAddSecretaria = new System.Windows.Forms.Button();
            this.buttonRefreshSecretariaList = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxSecretarias = new System.Windows.Forms.ListBox();
            this.buttonApagarSecretaria = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditarPT = new System.Windows.Forms.Button();
            this.tbNomePT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmailPT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsernamePT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarPT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPT = new System.Windows.Forms.ListBox();
            this.btnApagarPT = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelAviso = new System.Windows.Forms.Label();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeUser
            // 
            this.labelNomeUser.AutoSize = true;
            this.labelNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUser.Location = new System.Drawing.Point(93, 9);
            this.labelNomeUser.Name = "labelNomeUser";
            this.labelNomeUser.Size = new System.Drawing.Size(0, 16);
            this.labelNomeUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seja bem-vindo, Admin.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 565);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.buttonRefreshSecretariaList);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.listBoxSecretarias);
            this.tabPage2.Controls.Add(this.buttonApagarSecretaria);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(883, 539);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Secretárias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxPassword);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePickerBirthday);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.comboBoxGender);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxName);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBoxEmail);
            this.groupBox4.Controls.Add(this.textBoxUsername);
            this.groupBox4.Controls.Add(this.buttonAddSecretaria);
            this.groupBox4.Location = new System.Drawing.Point(515, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 292);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adicionar Secretária";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(130, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(219, 23);
            this.textBoxPassword.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Password";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(130, 175);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(219, 20);
            this.dateTimePickerBirthday.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Data de nascimento";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBoxGender.Location = new System.Drawing.Point(130, 211);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(219, 21);
            this.comboBoxGender.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 138);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 20);
            this.textBoxName.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Genéro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Username";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(130, 102);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(219, 20);
            this.textBoxEmail.TabIndex = 22;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(130, 33);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(219, 20);
            this.textBoxUsername.TabIndex = 21;
            // 
            // buttonAddSecretaria
            // 
            this.buttonAddSecretaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSecretaria.Location = new System.Drawing.Point(260, 249);
            this.buttonAddSecretaria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSecretaria.Name = "buttonAddSecretaria";
            this.buttonAddSecretaria.Size = new System.Drawing.Size(89, 30);
            this.buttonAddSecretaria.TabIndex = 4;
            this.buttonAddSecretaria.Text = "Adicionar";
            this.buttonAddSecretaria.UseVisualStyleBackColor = true;
            this.buttonAddSecretaria.Click += new System.EventHandler(this.buttonAddSecretaria_Click);
            // 
            // buttonRefreshSecretariaList
            // 
            this.buttonRefreshSecretariaList.Location = new System.Drawing.Point(4, 246);
            this.buttonRefreshSecretariaList.Name = "buttonRefreshSecretariaList";
            this.buttonRefreshSecretariaList.Size = new System.Drawing.Size(93, 30);
            this.buttonRefreshSecretariaList.TabIndex = 21;
            this.buttonRefreshSecretariaList.Text = "Refresh List";
            this.buttonRefreshSecretariaList.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 510);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(391, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "NOTA: Para Editar ou Apagar uma Secretária tem que o selecionar la lista a cima.";
            // 
            // listBoxSecretarias
            // 
            this.listBoxSecretarias.FormattingEnabled = true;
            this.listBoxSecretarias.Location = new System.Drawing.Point(4, 3);
            this.listBoxSecretarias.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSecretarias.Name = "listBoxSecretarias";
            this.listBoxSecretarias.Size = new System.Drawing.Size(876, 238);
            this.listBoxSecretarias.TabIndex = 19;
            this.listBoxSecretarias.SelectedIndexChanged += new System.EventHandler(this.listBoxSecretarias_SelectedIndexChanged);
            // 
            // buttonApagarSecretaria
            // 
            this.buttonApagarSecretaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarSecretaria.Location = new System.Drawing.Point(102, 246);
            this.buttonApagarSecretaria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarSecretaria.Name = "buttonApagarSecretaria";
            this.buttonApagarSecretaria.Size = new System.Drawing.Size(93, 30);
            this.buttonApagarSecretaria.TabIndex = 18;
            this.buttonApagarSecretaria.Text = "Apagar";
            this.buttonApagarSecretaria.UseVisualStyleBackColor = true;
            this.buttonApagarSecretaria.Click += new System.EventHandler(this.buttonApagarSecretaria_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxPT);
            this.tabPage1.Controls.Add(this.btnApagarPT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(883, 539);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Personal Trainers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnEditarPT);
            this.groupBox2.Controls.Add(this.tbNomePT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbEmailPT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbUsernamePT);
            this.groupBox2.Location = new System.Drawing.Point(412, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 234);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar PT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // btnEditarPT
            // 
            this.btnEditarPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPT.Location = new System.Drawing.Point(59, 168);
            this.btnEditarPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPT.Name = "btnEditarPT";
            this.btnEditarPT.Size = new System.Drawing.Size(74, 30);
            this.btnEditarPT.TabIndex = 5;
            this.btnEditarPT.Text = "Editar";
            this.btnEditarPT.UseVisualStyleBackColor = true;
            // 
            // tbNomePT
            // 
            this.tbNomePT.Location = new System.Drawing.Point(71, 92);
            this.tbNomePT.Name = "tbNomePT";
            this.tbNomePT.Size = new System.Drawing.Size(100, 20);
            this.tbNomePT.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // tbEmailPT
            // 
            this.tbEmailPT.Location = new System.Drawing.Point(71, 64);
            this.tbEmailPT.Name = "tbEmailPT";
            this.tbEmailPT.Size = new System.Drawing.Size(100, 20);
            this.tbEmailPT.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome";
            // 
            // tbUsernamePT
            // 
            this.tbUsernamePT.Location = new System.Drawing.Point(71, 37);
            this.tbUsernamePT.Name = "tbUsernamePT";
            this.tbUsernamePT.Size = new System.Drawing.Size(100, 20);
            this.tbUsernamePT.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionarPT);
            this.groupBox1.Location = new System.Drawing.Point(618, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 234);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar PT";
            // 
            // btnAdicionarPT
            // 
            this.btnAdicionarPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPT.Location = new System.Drawing.Point(67, 168);
            this.btnAdicionarPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarPT.Name = "btnAdicionarPT";
            this.btnAdicionarPT.Size = new System.Drawing.Size(71, 30);
            this.btnAdicionarPT.TabIndex = 4;
            this.btnAdicionarPT.Text = "Adicionar";
            this.btnAdicionarPT.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOTA: Para Editar ou Apagar um PT tem que o selecionar la lista a cima.";
            // 
            // listBoxPT
            // 
            this.listBoxPT.FormattingEnabled = true;
            this.listBoxPT.Location = new System.Drawing.Point(2, 2);
            this.listBoxPT.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPT.Name = "listBoxPT";
            this.listBoxPT.Size = new System.Drawing.Size(405, 238);
            this.listBoxPT.TabIndex = 7;
            // 
            // btnApagarPT
            // 
            this.btnApagarPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarPT.Location = new System.Drawing.Point(251, 245);
            this.btnApagarPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarPT.Name = "btnApagarPT";
            this.btnApagarPT.Size = new System.Drawing.Size(70, 30);
            this.btnApagarPT.TabIndex = 6;
            this.btnApagarPT.Text = "Apagar";
            this.btnApagarPT.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelAviso);
            this.tabPage4.Controls.Add(this.listBoxClientes);
            this.tabPage4.Controls.Add(this.btnApagar);
            this.tabPage4.Controls.Add(this.btnEditar);
            this.tabPage4.Controls.Add(this.btnAdicionar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(883, 539);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Clientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Location = new System.Drawing.Point(73, 292);
            this.labelAviso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(369, 13);
            this.labelAviso.TabIndex = 4;
            this.labelAviso.Text = "NOTA: Para Editar ou Apagar um Cliente tem que o selecionar la lista a cima.";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(2, 2);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(500, 238);
            this.listBoxClientes.TabIndex = 3;
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(338, 252);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(68, 30);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(220, 252);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(68, 30);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(103, 252);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(73, 30);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 611);
            this.Controls.Add(this.labelNomeUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonAddSecretaria;
        private System.Windows.Forms.Button buttonRefreshSecretariaList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxSecretarias;
        private System.Windows.Forms.Button buttonApagarSecretaria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditarPT;
        private System.Windows.Forms.TextBox tbNomePT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmailPT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsernamePT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionarPT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPT;
        private System.Windows.Forms.Button btnApagarPT;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}