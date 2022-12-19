using System.Windows.Forms;

namespace OOOPovaryonok.View
{
    partial class ProductList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.coloredComboSort = new ColoredCombo();
            this.labelSort = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.coloredComboDiscount = new ColoredCombo();
            this.coloredComboCategoria = new ColoredCombo();
            this.labelListProduct = new System.Windows.Forms.Label();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDiscriptioin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCountProduct = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelNavigation, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelListProduct, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewProductList, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelCountProduct, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1525, 912);
            this.tableLayoutPanelMain.TabIndex = 0;
            this.tableLayoutPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelMain_Paint);
            // 
            // tableLayoutPanelNavigation
            // 
            this.tableLayoutPanelNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelNavigation.ColumnCount = 8;
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNavigation.Controls.Add(this.coloredComboSort, 1, 0);
            this.tableLayoutPanelNavigation.Controls.Add(this.labelSort, 0, 0);
            this.tableLayoutPanelNavigation.Controls.Add(this.labelDiscount, 2, 0);
            this.tableLayoutPanelNavigation.Controls.Add(this.labelCategoria, 4, 0);
            this.tableLayoutPanelNavigation.Controls.Add(this.labelSearch, 6, 0);
            this.tableLayoutPanelNavigation.Controls.Add(this.textBoxSearch, 7, 0);
            this.tableLayoutPanelNavigation.Controls.Add(this.coloredComboDiscount, 3, 0);
            this.tableLayoutPanelNavigation.Controls.Add(this.coloredComboCategoria, 5, 0);
            this.tableLayoutPanelNavigation.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelNavigation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelNavigation.Name = "tableLayoutPanelNavigation";
            this.tableLayoutPanelNavigation.RowCount = 1;
            this.tableLayoutPanelNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNavigation.Size = new System.Drawing.Size(1519, 74);
            this.tableLayoutPanelNavigation.TabIndex = 2;
            // 
            // coloredComboSort
            // 
            this.coloredComboSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coloredComboSort.BorderColor = System.Drawing.Color.Black;
            this.coloredComboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coloredComboSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coloredComboSort.FormattingEnabled = true;
            this.coloredComboSort.Location = new System.Drawing.Point(104, 25);
            this.coloredComboSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coloredComboSort.Name = "coloredComboSort";
            this.coloredComboSort.Size = new System.Drawing.Size(271, 24);
            this.coloredComboSort.TabIndex = 10;
            this.coloredComboSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSort.Location = new System.Drawing.Point(3, 0);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(94, 74);
            this.labelSort.TabIndex = 0;
            this.labelSort.Text = "Сортировка";
            this.labelSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscount.Location = new System.Drawing.Point(382, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(94, 74);
            this.labelDiscount.TabIndex = 1;
            this.labelDiscount.Text = "Скидка";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategoria.Location = new System.Drawing.Point(761, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(94, 74);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Категории";
            this.labelCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearch.Location = new System.Drawing.Point(1140, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(94, 74);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Поиск";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(1240, 26);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(276, 22);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // coloredComboDiscount
            // 
            this.coloredComboDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coloredComboDiscount.BorderColor = System.Drawing.Color.Black;
            this.coloredComboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coloredComboDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coloredComboDiscount.FormattingEnabled = true;
            this.coloredComboDiscount.Location = new System.Drawing.Point(483, 25);
            this.coloredComboDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coloredComboDiscount.Name = "coloredComboDiscount";
            this.coloredComboDiscount.Size = new System.Drawing.Size(271, 24);
            this.coloredComboDiscount.TabIndex = 8;
            this.coloredComboDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscount_SelectedIndexChanged);
            // 
            // coloredComboCategoria
            // 
            this.coloredComboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coloredComboCategoria.BorderColor = System.Drawing.Color.Black;
            this.coloredComboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coloredComboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coloredComboCategoria.FormattingEnabled = true;
            this.coloredComboCategoria.Location = new System.Drawing.Point(862, 25);
            this.coloredComboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coloredComboCategoria.Name = "coloredComboCategoria";
            this.coloredComboCategoria.Size = new System.Drawing.Size(271, 24);
            this.coloredComboCategoria.TabIndex = 9;
            this.coloredComboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelListProduct
            // 
            this.labelListProduct.AutoSize = true;
            this.labelListProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListProduct.Location = new System.Drawing.Point(4, 0);
            this.labelListProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListProduct.Name = "labelListProduct";
            this.labelListProduct.Size = new System.Drawing.Size(1517, 62);
            this.labelListProduct.TabIndex = 3;
            this.labelListProduct.Text = "Список продукции";
            this.labelListProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.AllowUserToAddRows = false;
            this.dataGridViewProductList.AllowUserToDeleteRows = false;
            this.dataGridViewProductList.AllowUserToResizeColumns = false;
            this.dataGridViewProductList.AllowUserToResizeRows = false;
            this.dataGridViewProductList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewProductList.ColumnHeadersHeight = 29;
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductList.ColumnHeadersVisible = false;
            this.dataGridViewProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.ColumnImage,
            this.ColumnDiscriptioin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductList.Location = new System.Drawing.Point(3, 142);
            this.dataGridViewProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProductList.MultiSelect = false;
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewProductList.RowHeadersVisible = false;
            this.dataGridViewProductList.RowHeadersWidth = 51;
            this.dataGridViewProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProductList.RowTemplate.DividerHeight = 10;
            this.dataGridViewProductList.RowTemplate.Height = 24;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(1519, 705);
            this.dataGridViewProductList.TabIndex = 1;
            this.dataGridViewProductList.SelectionChanged += new System.EventHandler(this.dataGridViewProductList_SelectionChanged);
            // 
            // Image
            // 
            this.Image.FillWeight = 160.4278F;
            this.Image.HeaderText = "Артикль";
            this.Image.MinimumWidth = 25;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Visible = false;
            this.Image.Width = 25;
            // 
            // ColumnImage
            // 
            this.ColumnImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.FillWeight = 106.2733F;
            this.ColumnImage.HeaderText = "Изображение";
            this.ColumnImage.MinimumWidth = 200;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnImage.Width = 200;
            // 
            // ColumnDiscriptioin
            // 
            this.ColumnDiscriptioin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDiscriptioin.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDiscriptioin.FillWeight = 33.29896F;
            this.ColumnDiscriptioin.HeaderText = "Описание";
            this.ColumnDiscriptioin.MinimumWidth = 837;
            this.ColumnDiscriptioin.Name = "ColumnDiscriptioin";
            this.ColumnDiscriptioin.ReadOnly = true;
            // 
            // labelCountProduct
            // 
            this.labelCountProduct.AutoSize = true;
            this.labelCountProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountProduct.Location = new System.Drawing.Point(3, 849);
            this.labelCountProduct.Name = "labelCountProduct";
            this.labelCountProduct.Size = new System.Drawing.Size(1519, 63);
            this.labelCountProduct.TabIndex = 4;
            this.labelCountProduct.Text = "0 из 0";
            this.labelCountProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 912);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1541, 949);
            this.Name = "ProductList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО Поваренок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductList_FormClosing);
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelNavigation.ResumeLayout(false);
            this.tableLayoutPanelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNavigation;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelListProduct;
        private System.Windows.Forms.Label labelCountProduct;
        private ColoredCombo coloredComboDiscount;
        private ColoredCombo coloredComboCategoria;
        private ColoredCombo coloredComboSort;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewImageColumn ColumnImage;
        private DataGridViewTextBoxColumn ColumnDiscriptioin;
    }
}