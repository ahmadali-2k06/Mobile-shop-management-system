namespace ProjectUI2
{
    partial class StockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStock = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.searchbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnViewDetails = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(35)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(99, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowCustomTheming = false;
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.ColumnHeadersHeight = 40;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Brand,
            this.Quantity,
            this.Price,
            this.Total_Price,
            this.Ram,
            this.Storage});
            this.dgvStock.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvStock.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvStock.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvStock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvStock.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvStock.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvStock.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvStock.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStock.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvStock.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.CurrentTheme.Name = null;
            this.dgvStock.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvStock.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvStock.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStock.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvStock.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvStock.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvStock.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvStock.HeaderForeColor = System.Drawing.Color.White;
            this.dgvStock.Location = new System.Drawing.Point(18, 192);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 40;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1157, 335);
            this.dgvStock.TabIndex = 35;
            this.dgvStock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 250.8737F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 160;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 160;
            // 
            // Name
            // 
            this.Name.FillWeight = 68.75307F;
            this.Name.HeaderText = " Name ";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.FillWeight = 68.75307F;
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 68.75307F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 68.75307F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total_Price
            // 
            this.Total_Price.FillWeight = 60.53119F;
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.MinimumWidth = 6;
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            // 
            // Ram
            // 
            this.Ram.HeaderText = "Ram";
            this.Ram.MinimumWidth = 6;
            this.Ram.Name = "Ram";
            this.Ram.ReadOnly = true;
            this.Ram.Visible = false;
            // 
            // Storage
            // 
            this.Storage.HeaderText = "Storage";
            this.Storage.MinimumWidth = 6;
            this.Storage.Name = "Storage";
            this.Storage.ReadOnly = true;
            this.Storage.Visible = false;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Delete Record";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges1;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.Black;
            this.bunifuButton2.IdleBorderRadius = 5;
            this.bunifuButton2.IdleBorderThickness = 2;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuButton2.IdleIconLeftImage = global::ProjectUI2.Properties.Resources.icons8_delete_30;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(733, 561);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 5;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 2;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_delete_30;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.bunifuButton2.onHoverState.BorderRadius = 5;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 2;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuButton2.onHoverState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_delete_30;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.bunifuButton2.OnIdleState.BorderRadius = 5;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 2;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_delete_30;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 5;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 2;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_delete_30;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(208, 58);
            this.bunifuButton2.TabIndex = 37;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.AllowAnimations = true;
            this.searchbtn.AllowMouseEffects = true;
            this.searchbtn.AllowToggling = false;
            this.searchbtn.AnimationSpeed = 200;
            this.searchbtn.AutoGenerateColors = false;
            this.searchbtn.AutoRoundBorders = false;
            this.searchbtn.AutoSizeLeftIcon = true;
            this.searchbtn.AutoSizeRightIcon = true;
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.BackgroundImage")));
            this.searchbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchbtn.ButtonText = "Search";
            this.searchbtn.ButtonTextMarginLeft = 0;
            this.searchbtn.ColorContrastOnClick = 45;
            this.searchbtn.ColorContrastOnHover = 45;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.searchbtn.CustomizableEdges = borderEdges2;
            this.searchbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.searchbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.searchbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.searchbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.searchbtn.IconMarginLeft = 11;
            this.searchbtn.IconPadding = 10;
            this.searchbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.searchbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.searchbtn.IconSize = 25;
            this.searchbtn.IdleBorderColor = System.Drawing.Color.Black;
            this.searchbtn.IdleBorderRadius = 5;
            this.searchbtn.IdleBorderThickness = 2;
            this.searchbtn.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.searchbtn.IdleIconLeftImage = null;
            this.searchbtn.IdleIconRightImage = null;
            this.searchbtn.IndicateFocus = false;
            this.searchbtn.Location = new System.Drawing.Point(387, 108);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.searchbtn.OnDisabledState.BorderRadius = 5;
            this.searchbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchbtn.OnDisabledState.BorderThickness = 2;
            this.searchbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.searchbtn.OnDisabledState.IconLeftImage = null;
            this.searchbtn.OnDisabledState.IconRightImage = null;
            this.searchbtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.searchbtn.onHoverState.BorderRadius = 5;
            this.searchbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchbtn.onHoverState.BorderThickness = 2;
            this.searchbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchbtn.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchbtn.onHoverState.IconLeftImage = null;
            this.searchbtn.onHoverState.IconRightImage = null;
            this.searchbtn.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.searchbtn.OnIdleState.BorderRadius = 5;
            this.searchbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchbtn.OnIdleState.BorderThickness = 2;
            this.searchbtn.OnIdleState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.searchbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.searchbtn.OnIdleState.IconLeftImage = null;
            this.searchbtn.OnIdleState.IconRightImage = null;
            this.searchbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.searchbtn.OnPressedState.BorderRadius = 5;
            this.searchbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.searchbtn.OnPressedState.BorderThickness = 2;
            this.searchbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.searchbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.searchbtn.OnPressedState.IconLeftImage = null;
            this.searchbtn.OnPressedState.IconRightImage = null;
            this.searchbtn.Size = new System.Drawing.Size(114, 42);
            this.searchbtn.TabIndex = 33;
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbtn.TextMarginLeft = 0;
            this.searchbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.searchbtn.UseDefaultRadiusAndThickness = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(18, 108);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search Products";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(352, 42);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Search Products";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUI2.Properties.Resources.icons8_mobiles_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.AllowAnimations = true;
            this.btnReset.AllowMouseEffects = true;
            this.btnReset.AllowToggling = false;
            this.btnReset.AnimationSpeed = 200;
            this.btnReset.AutoGenerateColors = false;
            this.btnReset.AutoRoundBorders = false;
            this.btnReset.AutoSizeLeftIcon = true;
            this.btnReset.AutoSizeRightIcon = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.ButtonTextMarginLeft = 0;
            this.btnReset.ColorContrastOnClick = 45;
            this.btnReset.ColorContrastOnHover = 45;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnReset.CustomizableEdges = borderEdges3;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReset.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReset.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReset.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReset.IconMarginLeft = 11;
            this.btnReset.IconPadding = 10;
            this.btnReset.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReset.IconSize = 25;
            this.btnReset.IdleBorderColor = System.Drawing.Color.Black;
            this.btnReset.IdleBorderRadius = 5;
            this.btnReset.IdleBorderThickness = 2;
            this.btnReset.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.IdleIconLeftImage = global::ProjectUI2.Properties.Resources.icons8_refresh_30;
            this.btnReset.IdleIconRightImage = null;
            this.btnReset.IndicateFocus = false;
            this.btnReset.Location = new System.Drawing.Point(967, 561);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReset.OnDisabledState.BorderRadius = 5;
            this.btnReset.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReset.OnDisabledState.BorderThickness = 2;
            this.btnReset.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReset.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReset.OnDisabledState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_refresh_30;
            this.btnReset.OnDisabledState.IconRightImage = null;
            this.btnReset.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnReset.onHoverState.BorderRadius = 5;
            this.btnReset.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReset.onHoverState.BorderThickness = 2;
            this.btnReset.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReset.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.onHoverState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_refresh_30;
            this.btnReset.onHoverState.IconRightImage = null;
            this.btnReset.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnReset.OnIdleState.BorderRadius = 5;
            this.btnReset.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReset.OnIdleState.BorderThickness = 2;
            this.btnReset.OnIdleState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReset.OnIdleState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_refresh_30;
            this.btnReset.OnIdleState.IconRightImage = null;
            this.btnReset.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReset.OnPressedState.BorderRadius = 5;
            this.btnReset.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReset.OnPressedState.BorderThickness = 2;
            this.btnReset.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReset.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReset.OnPressedState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_refresh_30;
            this.btnReset.OnPressedState.IconRightImage = null;
            this.btnReset.Size = new System.Drawing.Size(208, 58);
            this.btnReset.TabIndex = 38;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.TextMarginLeft = 0;
            this.btnReset.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReset.UseDefaultRadiusAndThickness = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.AllowAnimations = true;
            this.btnViewDetails.AllowMouseEffects = true;
            this.btnViewDetails.AllowToggling = false;
            this.btnViewDetails.AnimationSpeed = 200;
            this.btnViewDetails.AutoGenerateColors = false;
            this.btnViewDetails.AutoRoundBorders = false;
            this.btnViewDetails.AutoSizeLeftIcon = true;
            this.btnViewDetails.AutoSizeRightIcon = true;
            this.btnViewDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDetails.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnViewDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewDetails.BackgroundImage")));
            this.btnViewDetails.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewDetails.ButtonText = "VIew Details";
            this.btnViewDetails.ButtonTextMarginLeft = 0;
            this.btnViewDetails.ColorContrastOnClick = 45;
            this.btnViewDetails.ColorContrastOnHover = 45;
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnViewDetails.CustomizableEdges = borderEdges4;
            this.btnViewDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewDetails.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewDetails.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewDetails.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnViewDetails.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDetails.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewDetails.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnViewDetails.IconMarginLeft = 11;
            this.btnViewDetails.IconPadding = 10;
            this.btnViewDetails.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDetails.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewDetails.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnViewDetails.IconSize = 25;
            this.btnViewDetails.IdleBorderColor = System.Drawing.Color.Black;
            this.btnViewDetails.IdleBorderRadius = 5;
            this.btnViewDetails.IdleBorderThickness = 2;
            this.btnViewDetails.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewDetails.IdleIconLeftImage = global::ProjectUI2.Properties.Resources.icons8_detail_50;
            this.btnViewDetails.IdleIconRightImage = null;
            this.btnViewDetails.IndicateFocus = false;
            this.btnViewDetails.Location = new System.Drawing.Point(491, 561);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewDetails.OnDisabledState.BorderRadius = 5;
            this.btnViewDetails.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewDetails.OnDisabledState.BorderThickness = 2;
            this.btnViewDetails.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewDetails.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnViewDetails.OnDisabledState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_detail_50;
            this.btnViewDetails.OnDisabledState.IconRightImage = null;
            this.btnViewDetails.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetails.onHoverState.BorderRadius = 5;
            this.btnViewDetails.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewDetails.onHoverState.BorderThickness = 2;
            this.btnViewDetails.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnViewDetails.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewDetails.onHoverState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_detail_50;
            this.btnViewDetails.onHoverState.IconRightImage = null;
            this.btnViewDetails.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetails.OnIdleState.BorderRadius = 5;
            this.btnViewDetails.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewDetails.OnIdleState.BorderThickness = 2;
            this.btnViewDetails.OnIdleState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewDetails.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.OnIdleState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_detail_50;
            this.btnViewDetails.OnIdleState.IconRightImage = null;
            this.btnViewDetails.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnViewDetails.OnPressedState.BorderRadius = 5;
            this.btnViewDetails.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewDetails.OnPressedState.BorderThickness = 2;
            this.btnViewDetails.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnViewDetails.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.OnPressedState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_detail_50;
            this.btnViewDetails.OnPressedState.IconRightImage = null;
            this.btnViewDetails.Size = new System.Drawing.Size(208, 58);
            this.btnViewDetails.TabIndex = 41;
            this.btnViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewDetails.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewDetails.TextMarginLeft = 0;
            this.btnViewDetails.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnViewDetails.UseDefaultRadiusAndThickness = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // StockForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1187, 739);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton searchbtn;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvStock;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnViewDetails;
    }
}