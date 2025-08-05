namespace ProjectUI2
{
    partial class AddOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducts = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnPlaceOrder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnViewDetails = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtCustomerName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(35)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(101, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Order";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "Discount Percentage";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Company,
            this.Quantity,
            this.Price,
            this.Select,
            this.OrderQuantity,
            this.Ram,
            this.Storage});
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dgvProducts.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvProducts.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dgvProducts.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dgvProducts.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.Name = null;
            this.dgvProducts.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvProducts.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvProducts.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvProducts.HeaderBackColor = System.Drawing.Color.Navy;
            this.dgvProducts.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvProducts.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(20, 279);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1140, 329);
            this.dgvProducts.TabIndex = 36;
            this.dgvProducts.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // Name
            // 
            this.Name.FillWeight = 113.5829F;
            this.Name.HeaderText = " Name ";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Company
            // 
            this.Company.FillWeight = 113.5829F;
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 113.5829F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.FillWeight = 113.5829F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Select
            // 
            this.Select.HeaderText = "         Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.HeaderText = "Order Quantity";
            this.OrderQuantity.MinimumWidth = 6;
            this.OrderQuantity.Name = "OrderQuantity";
            // 
            // Ram
            // 
            this.Ram.HeaderText = "Ram";
            this.Ram.MinimumWidth = 6;
            this.Ram.Name = "Ram";
            this.Ram.Visible = false;
            // 
            // Storage
            // 
            this.Storage.HeaderText = "Storage";
            this.Storage.MinimumWidth = 6;
            this.Storage.Name = "Storage";
            this.Storage.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(35)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(13, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 49);
            this.label4.TabIndex = 37;
            this.label4.Text = "Select Products";
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.AcceptsReturn = false;
            this.txtDiscountPercent.AcceptsTab = false;
            this.txtDiscountPercent.AnimationSpeed = 200;
            this.txtDiscountPercent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDiscountPercent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDiscountPercent.BackColor = System.Drawing.Color.Transparent;
            this.txtDiscountPercent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDiscountPercent.BackgroundImage")));
            this.txtDiscountPercent.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDiscountPercent.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDiscountPercent.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDiscountPercent.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDiscountPercent.BorderRadius = 1;
            this.txtDiscountPercent.BorderThickness = 1;
            this.txtDiscountPercent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiscountPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountPercent.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDiscountPercent.DefaultText = "";
            this.txtDiscountPercent.FillColor = System.Drawing.Color.White;
            this.txtDiscountPercent.HideSelection = true;
            this.txtDiscountPercent.IconLeft = null;
            this.txtDiscountPercent.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountPercent.IconPadding = 10;
            this.txtDiscountPercent.IconRight = null;
            this.txtDiscountPercent.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountPercent.Lines = new string[0];
            this.txtDiscountPercent.Location = new System.Drawing.Point(833, 130);
            this.txtDiscountPercent.MaxLength = 32767;
            this.txtDiscountPercent.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDiscountPercent.Modified = false;
            this.txtDiscountPercent.Multiline = false;
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiscountPercent.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDiscountPercent.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiscountPercent.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiscountPercent.OnIdleState = stateProperties4;
            this.txtDiscountPercent.Padding = new System.Windows.Forms.Padding(3);
            this.txtDiscountPercent.PasswordChar = '\0';
            this.txtDiscountPercent.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiscountPercent.PlaceholderText = "Enter Discount percentage";
            this.txtDiscountPercent.ReadOnly = false;
            this.txtDiscountPercent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscountPercent.SelectedText = "";
            this.txtDiscountPercent.SelectionLength = 0;
            this.txtDiscountPercent.SelectionStart = 0;
            this.txtDiscountPercent.ShortcutsEnabled = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(230, 34);
            this.txtDiscountPercent.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDiscountPercent.TabIndex = 27;
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscountPercent.TextMarginBottom = 0;
            this.txtDiscountPercent.TextMarginLeft = 3;
            this.txtDiscountPercent.TextMarginTop = 0;
            this.txtDiscountPercent.TextPlaceholder = "Enter Discount percentage";
            this.txtDiscountPercent.UseSystemPasswordChar = false;
            this.txtDiscountPercent.WordWrap = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AllowAnimations = true;
            this.btnPlaceOrder.AllowMouseEffects = true;
            this.btnPlaceOrder.AllowToggling = false;
            this.btnPlaceOrder.AnimationSpeed = 200;
            this.btnPlaceOrder.AutoGenerateColors = false;
            this.btnPlaceOrder.AutoRoundBorders = false;
            this.btnPlaceOrder.AutoSizeLeftIcon = true;
            this.btnPlaceOrder.AutoSizeRightIcon = true;
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaceOrder.BackColor1 = System.Drawing.Color.LightSkyBlue;
            this.btnPlaceOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaceOrder.BackgroundImage")));
            this.btnPlaceOrder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaceOrder.ButtonText = "Add";
            this.btnPlaceOrder.ButtonTextMarginLeft = 0;
            this.btnPlaceOrder.ColorContrastOnClick = 45;
            this.btnPlaceOrder.ColorContrastOnHover = 45;
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPlaceOrder.CustomizableEdges = borderEdges1;
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaceOrder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaceOrder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaceOrder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaceOrder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaceOrder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaceOrder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlaceOrder.IconMarginLeft = 11;
            this.btnPlaceOrder.IconPadding = 10;
            this.btnPlaceOrder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaceOrder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaceOrder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlaceOrder.IconSize = 25;
            this.btnPlaceOrder.IdleBorderColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.IdleBorderRadius = 5;
            this.btnPlaceOrder.IdleBorderThickness = 2;
            this.btnPlaceOrder.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlaceOrder.IdleIconLeftImage = global::ProjectUI2.Properties.Resources.icons8_check_mark_50;
            this.btnPlaceOrder.IdleIconRightImage = null;
            this.btnPlaceOrder.IndicateFocus = false;
            this.btnPlaceOrder.Location = new System.Drawing.Point(952, 614);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaceOrder.OnDisabledState.BorderRadius = 5;
            this.btnPlaceOrder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaceOrder.OnDisabledState.BorderThickness = 2;
            this.btnPlaceOrder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaceOrder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaceOrder.OnDisabledState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_check_mark_50;
            this.btnPlaceOrder.OnDisabledState.IconRightImage = null;
            this.btnPlaceOrder.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.onHoverState.BorderRadius = 5;
            this.btnPlaceOrder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaceOrder.onHoverState.BorderThickness = 2;
            this.btnPlaceOrder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPlaceOrder.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlaceOrder.onHoverState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_check_mark_50;
            this.btnPlaceOrder.onHoverState.IconRightImage = null;
            this.btnPlaceOrder.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.OnIdleState.BorderRadius = 5;
            this.btnPlaceOrder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaceOrder.OnIdleState.BorderThickness = 2;
            this.btnPlaceOrder.OnIdleState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlaceOrder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.OnIdleState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_check_mark_50;
            this.btnPlaceOrder.OnIdleState.IconRightImage = null;
            this.btnPlaceOrder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPlaceOrder.OnPressedState.BorderRadius = 5;
            this.btnPlaceOrder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaceOrder.OnPressedState.BorderThickness = 2;
            this.btnPlaceOrder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPlaceOrder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.OnPressedState.IconLeftImage = global::ProjectUI2.Properties.Resources.icons8_check_mark_50;
            this.btnPlaceOrder.OnPressedState.IconRightImage = null;
            this.btnPlaceOrder.Size = new System.Drawing.Size(208, 58);
            this.btnPlaceOrder.TabIndex = 41;
            this.btnPlaceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaceOrder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaceOrder.TextMarginLeft = 0;
            this.btnPlaceOrder.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPlaceOrder.UseDefaultRadiusAndThickness = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnViewDetails.CustomizableEdges = borderEdges2;
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
            this.btnViewDetails.Location = new System.Drawing.Point(725, 614);
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
            this.btnViewDetails.TabIndex = 40;
            this.btnViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewDetails.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewDetails.TextMarginLeft = 0;
            this.btnViewDetails.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnViewDetails.UseDefaultRadiusAndThickness = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AcceptsReturn = false;
            this.txtCustomerName.AcceptsTab = false;
            this.txtCustomerName.AnimationSpeed = 200;
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCustomerName.BackgroundImage")));
            this.txtCustomerName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCustomerName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCustomerName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCustomerName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCustomerName.BorderRadius = 1;
            this.txtCustomerName.BorderThickness = 1;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.FillColor = System.Drawing.Color.White;
            this.txtCustomerName.HideSelection = true;
            this.txtCustomerName.IconLeft = null;
            this.txtCustomerName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.IconPadding = 10;
            this.txtCustomerName.IconRight = null;
            this.txtCustomerName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(223, 130);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCustomerName.Modified = false;
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCustomerName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCustomerName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCustomerName.OnIdleState = stateProperties8;
            this.txtCustomerName.Padding = new System.Windows.Forms.Padding(3);
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCustomerName.PlaceholderText = "Enter Customer Name";
            this.txtCustomerName.ReadOnly = false;
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(221, 34);
            this.txtCustomerName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCustomerName.TabIndex = 25;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerName.TextMarginBottom = 0;
            this.txtCustomerName.TextMarginLeft = 3;
            this.txtCustomerName.TextMarginTop = 0;
            this.txtCustomerName.TextPlaceholder = "Enter Customer Name";
            this.txtCustomerName.UseSystemPasswordChar = false;
            this.txtCustomerName.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUI2.Properties.Resources.icons8_clipboard_50;
            this.pictureBox1.Location = new System.Drawing.Point(20, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1187, 739);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "AddOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txtDiscountPercent;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvProducts;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnViewDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaceOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storage;
    }
}