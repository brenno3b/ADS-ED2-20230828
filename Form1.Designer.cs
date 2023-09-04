namespace ADS_ED2_20230828
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            emailTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nomeTxtBox = new TextBox();
            label3 = new Label();
            diaTxtBox = new TextBox();
            mesTxtBox = new TextBox();
            anoTxtBox = new TextBox();
            telefoneDGV = new DataGridView();
            tipo = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            principal = new DataGridViewTextBoxColumn();
            tipoDropDown = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            principalCB = new CheckBox();
            button5 = new Button();
            numeroTxtBox = new TextBox();
            contatoDGV = new DataGridView();
            email = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataNasc = new DataGridViewTextBoxColumn();
            idade = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)telefoneDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contatoDGV).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(114, 36);
            button1.TabIndex = 0;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(600, 12);
            button2.Name = "button2";
            button2.Size = new Size(114, 36);
            button2.TabIndex = 1;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 12);
            button3.Name = "button3";
            button3.Size = new Size(114, 36);
            button3.TabIndex = 2;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(208, 12);
            button4.Name = "button4";
            button4.Size = new Size(114, 36);
            button4.TabIndex = 3;
            button4.Text = "Salvar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(59, 69);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(208, 23);
            emailTxtBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // nomeTxtBox
            // 
            nomeTxtBox.Location = new Point(59, 160);
            nomeTxtBox.Name = "nomeTxtBox";
            nomeTxtBox.Size = new Size(208, 23);
            nomeTxtBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 223);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 9;
            label3.Text = "Data de nascimento";
            // 
            // diaTxtBox
            // 
            diaTxtBox.Location = new Point(13, 241);
            diaTxtBox.Name = "diaTxtBox";
            diaTxtBox.Size = new Size(40, 23);
            diaTxtBox.TabIndex = 8;
            diaTxtBox.TextChanged += textBox3_TextChanged;
            // 
            // mesTxtBox
            // 
            mesTxtBox.Location = new Point(59, 241);
            mesTxtBox.Name = "mesTxtBox";
            mesTxtBox.Size = new Size(40, 23);
            mesTxtBox.TabIndex = 10;
            // 
            // anoTxtBox
            // 
            anoTxtBox.Location = new Point(105, 241);
            anoTxtBox.Name = "anoTxtBox";
            anoTxtBox.Size = new Size(59, 23);
            anoTxtBox.TabIndex = 11;
            // 
            // telefoneDGV
            // 
            telefoneDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            telefoneDGV.Columns.AddRange(new DataGridViewColumn[] { tipo, numero, principal });
            telefoneDGV.Location = new Point(294, 69);
            telefoneDGV.Name = "telefoneDGV";
            telefoneDGV.RowTemplate.Height = 25;
            telefoneDGV.Size = new Size(421, 150);
            telefoneDGV.TabIndex = 12;
            telefoneDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            // 
            // numero
            // 
            numero.HeaderText = " Número";
            numero.Name = "numero";
            // 
            // principal
            // 
            principal.HeaderText = "Principal";
            principal.Name = "principal";
            // 
            // tipoDropDown
            // 
            tipoDropDown.FormattingEnabled = true;
            tipoDropDown.Location = new Point(330, 235);
            tipoDropDown.Name = "tipoDropDown";
            tipoDropDown.Size = new Size(73, 23);
            tipoDropDown.TabIndex = 13;
            tipoDropDown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 239);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 14;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 239);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 16;
            label5.Text = "Número";
            // 
            // principalCB
            // 
            principalCB.AutoSize = true;
            principalCB.Location = new Point(554, 237);
            principalCB.Name = "principalCB";
            principalCB.Size = new Size(72, 19);
            principalCB.TabIndex = 17;
            principalCB.Text = "Principal";
            principalCB.UseVisualStyleBackColor = true;
            principalCB.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button5
            // 
            button5.Location = new Point(632, 229);
            button5.Name = "button5";
            button5.Size = new Size(83, 35);
            button5.TabIndex = 18;
            button5.Text = "Adicionar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numeroTxtBox
            // 
            numeroTxtBox.Location = new Point(468, 235);
            numeroTxtBox.Name = "numeroTxtBox";
            numeroTxtBox.Size = new Size(80, 23);
            numeroTxtBox.TabIndex = 19;
            // 
            // contatoDGV
            // 
            contatoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contatoDGV.Columns.AddRange(new DataGridViewColumn[] { email, nome, dataNasc, idade, telefone });
            contatoDGV.Location = new Point(12, 288);
            contatoDGV.Name = "contatoDGV";
            contatoDGV.RowTemplate.Height = 25;
            contatoDGV.Size = new Size(702, 150);
            contatoDGV.TabIndex = 20;
            contatoDGV.CellContentClick += contatoDGV_CellContentClick;
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // dataNasc
            // 
            dataNasc.HeaderText = "Data Nasc";
            dataNasc.Name = "dataNasc";
            // 
            // idade
            // 
            idade.HeaderText = "Idade";
            idade.Name = "idade";
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            // 
            // button6
            // 
            button6.Location = new Point(278, 452);
            button6.Name = "button6";
            button6.Size = new Size(169, 35);
            button6.TabIndex = 21;
            button6.Text = "Listar contatos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 499);
            Controls.Add(button6);
            Controls.Add(contatoDGV);
            Controls.Add(numeroTxtBox);
            Controls.Add(button5);
            Controls.Add(principalCB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tipoDropDown);
            Controls.Add(telefoneDGV);
            Controls.Add(anoTxtBox);
            Controls.Add(mesTxtBox);
            Controls.Add(label3);
            Controls.Add(diaTxtBox);
            Controls.Add(label2);
            Controls.Add(nomeTxtBox);
            Controls.Add(label1);
            Controls.Add(emailTxtBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)telefoneDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)contatoDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox emailTxtBox;
        private Label label1;
        private Label label2;
        private TextBox nomeTxtBox;
        private Label label3;
        private TextBox diaTxtBox;
        private TextBox mesTxtBox;
        private TextBox anoTxtBox;
        private DataGridView telefoneDGV;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn principal;
        private ComboBox tipoDropDown;
        private Label label4;
        private Label label5;
        private CheckBox principalCB;
        private Button button5;
        private TextBox numeroTxtBox;
        private DataGridView contatoDGV;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNasc;
        private DataGridViewTextBoxColumn idade;
        private DataGridViewTextBoxColumn telefone;
        private Button button6;
    }
}