namespace Bing_Bong_Factory.Presentacion
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.dgvProductos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_in_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbInventario = new Bunifu.UI.WinForms.BunifuLabel();
            this.Home_lbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnInsertar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnEliminar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lbProductos = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnActualizar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeight = 40;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_name,
            this.Unit_Price,
            this.Unit_in_stock});
            this.dgvProductos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvProductos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProductos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvProductos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvProductos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvProductos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvProductos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvProductos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvProductos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.CurrentTheme.Name = null;
            this.dgvProductos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProductos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvProductos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvProductos.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvProductos.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvProductos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProductos.Location = new System.Drawing.Point(304, 275);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 40;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(990, 460);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Nombre";
            this.Product_name.MinimumWidth = 8;
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            this.Product_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = " Precio Unitario";
            this.Unit_Price.MinimumWidth = 8;
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            this.Unit_Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Unit_in_stock
            // 
            this.Unit_in_stock.HeaderText = "Cantidad";
            this.Unit_in_stock.MinimumWidth = 8;
            this.Unit_in_stock.Name = "Unit_in_stock";
            this.Unit_in_stock.ReadOnly = true;
            this.Unit_in_stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbInventario);
            this.bunifuPanel1.Controls.Add(this.Home_lbl);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(18, 18);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(279, 968);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // lbInventario
            // 
            this.lbInventario.AllowParentOverrides = false;
            this.lbInventario.AutoEllipsis = false;
            this.lbInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbInventario.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventario.ForeColor = System.Drawing.Color.Black;
            this.lbInventario.Location = new System.Drawing.Point(33, 323);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInventario.Size = new System.Drawing.Size(114, 29);
            this.lbInventario.TabIndex = 16;
            this.lbInventario.Text = "Inventario";
            this.lbInventario.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInventario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Home_lbl
            // 
            this.Home_lbl.AllowParentOverrides = false;
            this.Home_lbl.AutoEllipsis = false;
            this.Home_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home_lbl.CursorType = System.Windows.Forms.Cursors.Default;
            this.Home_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_lbl.ForeColor = System.Drawing.Color.Black;
            this.Home_lbl.Location = new System.Drawing.Point(33, 257);
            this.Home_lbl.Name = "Home_lbl";
            this.Home_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Home_lbl.Size = new System.Drawing.Size(63, 29);
            this.Home_lbl.TabIndex = 15;
            this.Home_lbl.Text = "Inicio";
            this.Home_lbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Home_lbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 38;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(15, 18);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(76, 76);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnInsertar
            // 
            this.btnInsertar.AllowAnimations = true;
            this.btnInsertar.AllowMouseEffects = true;
            this.btnInsertar.AllowToggling = false;
            this.btnInsertar.AnimationSpeed = 200;
            this.btnInsertar.AutoGenerateColors = false;
            this.btnInsertar.AutoRoundBorders = true;
            this.btnInsertar.AutoSizeLeftIcon = true;
            this.btnInsertar.AutoSizeRightIcon = true;
            this.btnInsertar.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertar.BackgroundImage")));
            this.btnInsertar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsertar.ButtonText = "Insertar";
            this.btnInsertar.ButtonTextMarginLeft = 0;
            this.btnInsertar.ColorContrastOnClick = 45;
            this.btnInsertar.ColorContrastOnHover = 45;
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnInsertar.CustomizableEdges = borderEdges1;
            this.btnInsertar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInsertar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInsertar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInsertar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInsertar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInsertar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInsertar.IconMarginLeft = 11;
            this.btnInsertar.IconPadding = 10;
            this.btnInsertar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInsertar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInsertar.IconSize = 25;
            this.btnInsertar.IdleBorderColor = System.Drawing.Color.Red;
            this.btnInsertar.IdleBorderRadius = 48;
            this.btnInsertar.IdleBorderThickness = 1;
            this.btnInsertar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnInsertar.IdleIconLeftImage = null;
            this.btnInsertar.IdleIconRightImage = null;
            this.btnInsertar.IndicateFocus = false;
            this.btnInsertar.Location = new System.Drawing.Point(311, 212);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(10);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInsertar.OnDisabledState.BorderRadius = 30;
            this.btnInsertar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsertar.OnDisabledState.BorderThickness = 1;
            this.btnInsertar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInsertar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInsertar.OnDisabledState.IconLeftImage = null;
            this.btnInsertar.OnDisabledState.IconRightImage = null;
            this.btnInsertar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnInsertar.onHoverState.BorderRadius = 30;
            this.btnInsertar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsertar.onHoverState.BorderThickness = 1;
            this.btnInsertar.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnInsertar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnInsertar.onHoverState.IconLeftImage = null;
            this.btnInsertar.onHoverState.IconRightImage = null;
            this.btnInsertar.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnInsertar.OnIdleState.BorderRadius = 30;
            this.btnInsertar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsertar.OnIdleState.BorderThickness = 1;
            this.btnInsertar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnInsertar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.OnIdleState.IconLeftImage = null;
            this.btnInsertar.OnIdleState.IconRightImage = null;
            this.btnInsertar.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnInsertar.OnPressedState.BorderRadius = 30;
            this.btnInsertar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsertar.OnPressedState.BorderThickness = 1;
            this.btnInsertar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnInsertar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.OnPressedState.IconLeftImage = null;
            this.btnInsertar.OnPressedState.IconRightImage = null;
            this.btnInsertar.Size = new System.Drawing.Size(250, 50);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsertar.TextMarginLeft = 0;
            this.btnInsertar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInsertar.UseDefaultRadiusAndThickness = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AllowAnimations = true;
            this.btnEliminar.AllowMouseEffects = true;
            this.btnEliminar.AllowToggling = false;
            this.btnEliminar.AnimationSpeed = 200;
            this.btnEliminar.AutoGenerateColors = false;
            this.btnEliminar.AutoRoundBorders = true;
            this.btnEliminar.AutoSizeLeftIcon = true;
            this.btnEliminar.AutoSizeRightIcon = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.ButtonTextMarginLeft = 0;
            this.btnEliminar.ColorContrastOnClick = 45;
            this.btnEliminar.ColorContrastOnHover = 45;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEliminar.CustomizableEdges = borderEdges2;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEliminar.IconMarginLeft = 11;
            this.btnEliminar.IconPadding = 10;
            this.btnEliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.IdleBorderColor = System.Drawing.Color.Red;
            this.btnEliminar.IdleBorderRadius = 48;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnEliminar.IdleIconLeftImage = null;
            this.btnEliminar.IdleIconRightImage = null;
            this.btnEliminar.IndicateFocus = false;
            this.btnEliminar.Location = new System.Drawing.Point(851, 212);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.OnDisabledState.BorderRadius = 30;
            this.btnEliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.OnDisabledState.BorderThickness = 1;
            this.btnEliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.OnDisabledState.IconLeftImage = null;
            this.btnEliminar.OnDisabledState.IconRightImage = null;
            this.btnEliminar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnEliminar.onHoverState.BorderRadius = 30;
            this.btnEliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.onHoverState.BorderThickness = 1;
            this.btnEliminar.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnEliminar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnEliminar.onHoverState.IconLeftImage = null;
            this.btnEliminar.onHoverState.IconRightImage = null;
            this.btnEliminar.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.OnIdleState.BorderRadius = 30;
            this.btnEliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.OnIdleState.BorderThickness = 1;
            this.btnEliminar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnEliminar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnIdleState.IconLeftImage = null;
            this.btnEliminar.OnIdleState.IconRightImage = null;
            this.btnEliminar.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnPressedState.BorderRadius = 30;
            this.btnEliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.OnPressedState.BorderThickness = 1;
            this.btnEliminar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnEliminar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnPressedState.IconLeftImage = null;
            this.btnEliminar.OnPressedState.IconRightImage = null;
            this.btnEliminar.Size = new System.Drawing.Size(250, 50);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.TextMarginLeft = 0;
            this.btnEliminar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEliminar.UseDefaultRadiusAndThickness = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbProductos
            // 
            this.lbProductos.AllowParentOverrides = false;
            this.lbProductos.AutoEllipsis = false;
            this.lbProductos.AutoSize = false;
            this.lbProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbProductos.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductos.ForeColor = System.Drawing.Color.Red;
            this.lbProductos.Location = new System.Drawing.Point(304, 36);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbProductos.Size = new System.Drawing.Size(990, 103);
            this.lbProductos.TabIndex = 16;
            this.lbProductos.Text = "Productos";
            this.lbProductos.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbProductos.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AllowAnimations = true;
            this.btnActualizar.AllowMouseEffects = true;
            this.btnActualizar.AllowToggling = false;
            this.btnActualizar.AnimationSpeed = 200;
            this.btnActualizar.AutoGenerateColors = false;
            this.btnActualizar.AutoRoundBorders = true;
            this.btnActualizar.AutoSizeLeftIcon = true;
            this.btnActualizar.AutoSizeRightIcon = true;
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnActualizar.ButtonText = "Actualizar";
            this.btnActualizar.ButtonTextMarginLeft = 0;
            this.btnActualizar.ColorContrastOnClick = 45;
            this.btnActualizar.ColorContrastOnHover = 45;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnActualizar.CustomizableEdges = borderEdges3;
            this.btnActualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActualizar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActualizar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActualizar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnActualizar.IconMarginLeft = 11;
            this.btnActualizar.IconPadding = 10;
            this.btnActualizar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnActualizar.IconSize = 25;
            this.btnActualizar.IdleBorderColor = System.Drawing.Color.Red;
            this.btnActualizar.IdleBorderRadius = 48;
            this.btnActualizar.IdleBorderThickness = 1;
            this.btnActualizar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnActualizar.IdleIconLeftImage = null;
            this.btnActualizar.IdleIconRightImage = null;
            this.btnActualizar.IndicateFocus = false;
            this.btnActualizar.Location = new System.Drawing.Point(581, 212);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(10);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActualizar.OnDisabledState.BorderRadius = 30;
            this.btnActualizar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnActualizar.OnDisabledState.BorderThickness = 1;
            this.btnActualizar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActualizar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActualizar.OnDisabledState.IconLeftImage = null;
            this.btnActualizar.OnDisabledState.IconRightImage = null;
            this.btnActualizar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnActualizar.onHoverState.BorderRadius = 30;
            this.btnActualizar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnActualizar.onHoverState.BorderThickness = 1;
            this.btnActualizar.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnActualizar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnActualizar.onHoverState.IconLeftImage = null;
            this.btnActualizar.onHoverState.IconRightImage = null;
            this.btnActualizar.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnActualizar.OnIdleState.BorderRadius = 30;
            this.btnActualizar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnActualizar.OnIdleState.BorderThickness = 1;
            this.btnActualizar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnActualizar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.OnIdleState.IconLeftImage = null;
            this.btnActualizar.OnIdleState.IconRightImage = null;
            this.btnActualizar.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.OnPressedState.BorderRadius = 30;
            this.btnActualizar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnActualizar.OnPressedState.BorderThickness = 1;
            this.btnActualizar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnActualizar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.OnPressedState.IconLeftImage = null;
            this.btnActualizar.OnPressedState.IconRightImage = null;
            this.btnActualizar.Size = new System.Drawing.Size(250, 50);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActualizar.TextMarginLeft = 0;
            this.btnActualizar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnActualizar.UseDefaultRadiusAndThickness = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1608, 949);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvProductos;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lbInventario;
        private Bunifu.UI.WinForms.BunifuLabel Home_lbl;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnInsertar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_in_stock;
        private Bunifu.UI.WinForms.BunifuLabel lbProductos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnActualizar;
    }
}