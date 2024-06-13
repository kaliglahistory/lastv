namespace WinFormsApp1
{
    partial class Server
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            id_ = new DataGridViewTextBoxColumn();
            ip = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            tabel = new DataGridViewTextBoxColumn();
            floder = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            sqlBulkCopyColumnMappingCollectionBindingSource = new BindingSource(components);
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlBulkCopyColumnMappingCollectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(695, 366);
            button1.Name = "button1";
            button1.Size = new Size(93, 49);
            button1.TabIndex = 0;
            button1.Text = "Дать доступ пользователю";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            button2.Location = new Point(12, 363);
            button2.Name = "button2";
            button2.Size = new Size(130, 52);
            button2.TabIndex = 1;
            button2.Text = "Для запуска сервера укажити порт";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            textBox1.Location = new Point(12, 333);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(577, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_, ip, date, tabel, floder });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MinimumSize = new Size(130, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 24;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(800, 260);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id_
            // 
            id_.HeaderText = "Номер действия ";
            id_.Name = "id_";
            id_.ReadOnly = true;
            // 
            // ip
            // 
            ip.HeaderText = "IP отправитель";
            ip.Name = "ip";
            ip.ReadOnly = true;
            // 
            // date
            // 
            date.HeaderText = "Дата бекапа";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // tabel
            // 
            tabel.HeaderText = "Табельный номер сесси";
            tabel.Name = "tabel";
            tabel.ReadOnly = true;
            // 
            // floder
            // 
            floder.HeaderText = "Размер бекапа";
            floder.Name = "floder";
            floder.ReadOnly = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 266);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 6;
            button3.Text = "Назад в меню";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.Location = new Point(353, 266);
            button4.Name = "button4";
            button4.Size = new Size(131, 25);
            button4.TabIndex = 7;
            button4.Text = " Выгрузить даных за ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlText;
            checkBox1.Location = new Point(25, 421);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Сервер запущен";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(577, 415);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(625, 345);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 12;
            label1.Text = "ip";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 400);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 13;
            label2.Text = "Табель";
            // 
            // sqlBulkCopyColumnMappingCollectionBindingSource
            // 
            sqlBulkCopyColumnMappingCollectionBindingSource.DataSource = typeof(Microsoft.Data.SqlClient.SqlBulkCopyColumnMappingCollection);
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            textBox4.Location = new Point(353, 313);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(130, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            textBox5.Location = new Point(353, 363);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(130, 23);
            textBox5.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 345);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 16;
            label3.Text = "заканчивая по ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 294);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 17;
            label4.Text = "Начаная с ";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            Click += Server_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlBulkCopyColumnMappingCollectionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_;
        private DataGridViewTextBoxColumn ip;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn tabel;
        private DataGridViewTextBoxColumn floder;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private BindingSource sqlBulkCopyColumnMappingCollectionBindingSource;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
    }
}