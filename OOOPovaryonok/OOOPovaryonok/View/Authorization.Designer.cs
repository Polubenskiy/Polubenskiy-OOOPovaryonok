namespace OOOPovaryonok
{
    partial class Authorization
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSecret = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonAutorization = new System.Windows.Forms.Button();
            this.buttonWithoutAutorization = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.textBoxLogin, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxSecret, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelLogin, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelPassword, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonAutorization, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonWithoutAutorization, 1, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.66783F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39543F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.70399F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56183F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.67092F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(432, 405);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(216, 127);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(196, 40);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSecret.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecret.Location = new System.Drawing.Point(216, 171);
            this.textBoxSecret.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.PasswordChar = '*';
            this.textBoxSecret.Size = new System.Drawing.Size(196, 40);
            this.textBoxSecret.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogin.Location = new System.Drawing.Point(23, 124);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(190, 46);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Логин";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.Location = new System.Drawing.Point(20, 170);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(196, 43);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAutorization
            // 
            this.buttonAutorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAutorization.FlatAppearance.BorderSize = 0;
            this.buttonAutorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutorization.Location = new System.Drawing.Point(219, 216);
            this.buttonAutorization.Name = "buttonAutorization";
            this.buttonAutorization.Size = new System.Drawing.Size(190, 61);
            this.buttonAutorization.TabIndex = 3;
            this.buttonAutorization.Text = "Войти";
            this.buttonAutorization.UseVisualStyleBackColor = true;
            this.buttonAutorization.Click += new System.EventHandler(this.buttonAutorization_Click);
            // 
            // buttonWithoutAutorization
            // 
            this.buttonWithoutAutorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWithoutAutorization.FlatAppearance.BorderSize = 0;
            this.buttonWithoutAutorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithoutAutorization.Location = new System.Drawing.Point(23, 216);
            this.buttonWithoutAutorization.Name = "buttonWithoutAutorization";
            this.buttonWithoutAutorization.Size = new System.Drawing.Size(190, 61);
            this.buttonWithoutAutorization.TabIndex = 2;
            this.buttonWithoutAutorization.Text = "Войти без авторизации";
            this.buttonWithoutAutorization.UseVisualStyleBackColor = true;
            this.buttonWithoutAutorization.Click += new System.EventHandler(this.buttonWithoutAutorization_Click);
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(432, 48);
            this.tableLayoutPanelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация пользователя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 407);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 46);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО Поваренок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonWithoutAutorization;
        private System.Windows.Forms.Button buttonAutorization;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

