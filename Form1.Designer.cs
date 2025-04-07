namespace diplom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.con1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.btnOpenTokenSite = new System.Windows.Forms.Button();
            this.btnSaveToken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // con1
            // 
            this.con1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.con1.Location = new System.Drawing.Point(530, 52);
            this.con1.Name = "con1";
            this.con1.Size = new System.Drawing.Size(126, 34);
            this.con1.TabIndex = 0;
            this.con1.Text = "connection";
            this.con1.UseVisualStyleBackColor = true;
            this.con1.Click += new System.EventHandler(this.con1_Click);
            // 
            // exit
            // 
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Location = new System.Drawing.Point(662, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 36);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 296);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(662, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Токен доступа:";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToken.Location = new System.Drawing.Point(176, 12);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(348, 34);
            this.textBoxToken.TabIndex = 6;
            this.textBoxToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpenTokenSite
            // 
            this.btnOpenTokenSite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenTokenSite.Location = new System.Drawing.Point(12, 47);
            this.btnOpenTokenSite.Name = "btnOpenTokenSite";
            this.btnOpenTokenSite.Size = new System.Drawing.Size(160, 34);
            this.btnOpenTokenSite.TabIndex = 7;
            this.btnOpenTokenSite.Text = "Как получить токен?";
            this.btnOpenTokenSite.UseVisualStyleBackColor = true;
            this.btnOpenTokenSite.Click += new System.EventHandler(this.btnOpenTokenSite_Click);
            // 
            // btnSaveToken
            // 
            this.btnSaveToken.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveToken.Location = new System.Drawing.Point(530, 10);
            this.btnSaveToken.Name = "btnSaveToken";
            this.btnSaveToken.Size = new System.Drawing.Size(126, 36);
            this.btnSaveToken.TabIndex = 8;
            this.btnSaveToken.Text = "Сохранить токен";
            this.btnSaveToken.UseVisualStyleBackColor = true;
            this.btnSaveToken.Click += new System.EventHandler(this.btnSaveToken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveToken);
            this.Controls.Add(this.btnOpenTokenSite);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.con1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button con1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Button btnOpenTokenSite;
        private System.Windows.Forms.Button btnSaveToken;
    }
}

