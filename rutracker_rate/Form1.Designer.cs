namespace rutracker_rate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxStartPage = new System.Windows.Forms.TextBox();
            this.textBoxEndPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ссылкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарубежные2019ГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарубежные20162018ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нашеКиноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сериалыЗпрубежныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сериалыНашиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxOpacity = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(513, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxStartPage
            // 
            this.textBoxStartPage.AccessibleDescription = "";
            this.textBoxStartPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStartPage.Location = new System.Drawing.Point(113, 24);
            this.textBoxStartPage.Name = "textBoxStartPage";
            this.textBoxStartPage.Size = new System.Drawing.Size(394, 20);
            this.textBoxStartPage.TabIndex = 5;
            this.textBoxStartPage.Text = "https://rutracker.org/forum/viewforum.php?f=2200";
            // 
            // textBoxEndPage
            // 
            this.textBoxEndPage.Location = new System.Drawing.Point(113, 48);
            this.textBoxEndPage.Name = "textBoxEndPage";
            this.textBoxEndPage.Size = new System.Drawing.Size(48, 20);
            this.textBoxEndPage.TabIndex = 6;
            this.textBoxEndPage.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "URL страницы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кол-во страниц";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(577, 264);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(402, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Вставить из буфера и выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ссылкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ссылкиToolStripMenuItem
            // 
            this.ссылкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зарубежные2019ГодToolStripMenuItem,
            this.зарубежные20162018ToolStripMenuItem,
            this.нашеКиноToolStripMenuItem,
            this.сериалыЗпрубежныеToolStripMenuItem,
            this.сериалыНашиToolStripMenuItem});
            this.ссылкиToolStripMenuItem.Name = "ссылкиToolStripMenuItem";
            this.ссылкиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ссылкиToolStripMenuItem.Text = "Ссылки";
            // 
            // зарубежные2019ГодToolStripMenuItem
            // 
            this.зарубежные2019ГодToolStripMenuItem.Name = "зарубежные2019ГодToolStripMenuItem";
            this.зарубежные2019ГодToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.зарубежные2019ГодToolStripMenuItem.Text = "Зарубежные  фильмы 2019 год";
            this.зарубежные2019ГодToolStripMenuItem.Click += new System.EventHandler(this.зарубежные2019ГодToolStripMenuItem_Click);
            // 
            // зарубежные20162018ToolStripMenuItem
            // 
            this.зарубежные20162018ToolStripMenuItem.Name = "зарубежные20162018ToolStripMenuItem";
            this.зарубежные20162018ToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.зарубежные20162018ToolStripMenuItem.Text = "Зарубежные фильмы 2016-2018";
            this.зарубежные20162018ToolStripMenuItem.Click += new System.EventHandler(this.зарубежные20162018ToolStripMenuItem_Click);
            // 
            // нашеКиноToolStripMenuItem
            // 
            this.нашеКиноToolStripMenuItem.Name = "нашеКиноToolStripMenuItem";
            this.нашеКиноToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.нашеКиноToolStripMenuItem.Text = "Наше кино";
            this.нашеКиноToolStripMenuItem.Click += new System.EventHandler(this.нашеКиноToolStripMenuItem_Click);
            // 
            // сериалыЗпрубежныеToolStripMenuItem
            // 
            this.сериалыЗпрубежныеToolStripMenuItem.Name = "сериалыЗпрубежныеToolStripMenuItem";
            this.сериалыЗпрубежныеToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сериалыЗпрубежныеToolStripMenuItem.Text = "Сериалы зарубежные";
            this.сериалыЗпрубежныеToolStripMenuItem.Click += new System.EventHandler(this.сериалыЗпрубежныеToolStripMenuItem_Click);
            // 
            // сериалыНашиToolStripMenuItem
            // 
            this.сериалыНашиToolStripMenuItem.Name = "сериалыНашиToolStripMenuItem";
            this.сериалыНашиToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сериалыНашиToolStripMenuItem.Text = "Сериалы наши";
            this.сериалыНашиToolStripMenuItem.Click += new System.EventHandler(this.сериалыНашиToolStripMenuItem_Click);
            // 
            // checkBoxOpacity
            // 
            this.checkBoxOpacity.AutoSize = true;
            this.checkBoxOpacity.Location = new System.Drawing.Point(168, 51);
            this.checkBoxOpacity.Name = "checkBoxOpacity";
            this.checkBoxOpacity.Size = new System.Drawing.Size(217, 17);
            this.checkBoxOpacity.TabIndex = 12;
            this.checkBoxOpacity.Text = "Прозрачность в не активном режиме";
            this.checkBoxOpacity.UseVisualStyleBackColor = true;
            this.checkBoxOpacity.CheckedChanged += new System.EventHandler(this.checkBoxOpacity_CheckedChanged);
            this.checkBoxOpacity.Click += new System.EventHandler(this.checkBoxOpacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBoxOpacity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndPage);
            this.Controls.Add(this.textBoxStartPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Сортировка сидов";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxStartPage;
        private System.Windows.Forms.TextBox textBoxEndPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ссылкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарубежные2019ГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарубежные20162018ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нашеКиноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сериалыЗпрубежныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сериалыНашиToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxOpacity;
    }
}

