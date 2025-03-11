namespace Bing_Bong_Factory.Presentacion.Ventas
{
    partial class FrmBuscarP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarP));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductosB = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.btnCancelarB = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.ID_cln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto_cln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosB
            // 
            this.dgvProductosB.AllowCustomTheming = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvProductosB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosB.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductosB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosB.ColumnHeadersHeight = 40;
            this.dgvProductosB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_cln,
            this.Nombre_producto,
            this.Columna_Precio,
            this.Impuesto_cln});
            this.dgvProductosB.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProductosB.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductosB.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductosB.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvProductosB.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductosB.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvProductosB.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvProductosB.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.dgvProductosB.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductosB.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductosB.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.dgvProductosB.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.dgvProductosB.CurrentTheme.Name = null;
            this.dgvProductosB.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductosB.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductosB.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductosB.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.dgvProductosB.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosB.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductosB.EnableHeadersVisualStyles = false;
            this.dgvProductosB.GridColor = System.Drawing.Color.White;
            this.dgvProductosB.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.dgvProductosB.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvProductosB.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProductosB.Location = new System.Drawing.Point(2, 66);
            this.dgvProductosB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosB.Name = "dgvProductosB";
            this.dgvProductosB.RowHeadersVisible = false;
            this.dgvProductosB.RowHeadersWidth = 51;
            this.dgvProductosB.RowTemplate.Height = 40;
            this.dgvProductosB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosB.Size = new System.Drawing.Size(856, 437);
            this.dgvProductosB.TabIndex = 1;
            this.dgvProductosB.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconLeft")));
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(2, 12);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.PlaceholderText = "Enter text";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(260, 38);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 2;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 8;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "Enter text";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.dgvProductosB;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // btnCancelarB
            // 
            this.btnCancelarB.AllowAnimations = true;
            this.btnCancelarB.AllowMouseEffects = true;
            this.btnCancelarB.AllowToggling = false;
            this.btnCancelarB.AnimationSpeed = 200;
            this.btnCancelarB.AutoGenerateColors = false;
            this.btnCancelarB.AutoRoundBorders = true;
            this.btnCancelarB.AutoSizeLeftIcon = true;
            this.btnCancelarB.AutoSizeRightIcon = true;
            this.btnCancelarB.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarB.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnCancelarB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarB.BackgroundImage")));
            this.btnCancelarB.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancelarB.ButtonText = "Cancelar";
            this.btnCancelarB.ButtonTextMarginLeft = 0;
            this.btnCancelarB.ColorContrastOnClick = 45;
            this.btnCancelarB.ColorContrastOnHover = 45;
            this.btnCancelarB.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancelarB.CustomizableEdges = borderEdges1;
            this.btnCancelarB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelarB.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelarB.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelarB.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelarB.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCancelarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarB.ForeColor = System.Drawing.Color.White;
            this.btnCancelarB.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarB.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelarB.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelarB.IconMarginLeft = 11;
            this.btnCancelarB.IconPadding = 10;
            this.btnCancelarB.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarB.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelarB.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelarB.IconSize = 25;
            this.btnCancelarB.IdleBorderColor = System.Drawing.Color.Red;
            this.btnCancelarB.IdleBorderRadius = 36;
            this.btnCancelarB.IdleBorderThickness = 1;
            this.btnCancelarB.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnCancelarB.IdleIconLeftImage = null;
            this.btnCancelarB.IdleIconRightImage = null;
            this.btnCancelarB.IndicateFocus = false;
            this.btnCancelarB.Location = new System.Drawing.Point(707, 556);
            this.btnCancelarB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCancelarB.Name = "btnCancelarB";
            this.btnCancelarB.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelarB.OnDisabledState.BorderRadius = 30;
            this.btnCancelarB.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancelarB.OnDisabledState.BorderThickness = 1;
            this.btnCancelarB.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelarB.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelarB.OnDisabledState.IconLeftImage = null;
            this.btnCancelarB.OnDisabledState.IconRightImage = null;
            this.btnCancelarB.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnCancelarB.onHoverState.BorderRadius = 30;
            this.btnCancelarB.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancelarB.onHoverState.BorderThickness = 1;
            this.btnCancelarB.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnCancelarB.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnCancelarB.onHoverState.IconLeftImage = null;
            this.btnCancelarB.onHoverState.IconRightImage = null;
            this.btnCancelarB.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnCancelarB.OnIdleState.BorderRadius = 30;
            this.btnCancelarB.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancelarB.OnIdleState.BorderThickness = 1;
            this.btnCancelarB.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnCancelarB.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancelarB.OnIdleState.IconLeftImage = null;
            this.btnCancelarB.OnIdleState.IconRightImage = null;
            this.btnCancelarB.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarB.OnPressedState.BorderRadius = 30;
            this.btnCancelarB.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancelarB.OnPressedState.BorderThickness = 1;
            this.btnCancelarB.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnCancelarB.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancelarB.OnPressedState.IconLeftImage = null;
            this.btnCancelarB.OnPressedState.IconRightImage = null;
            this.btnCancelarB.Size = new System.Drawing.Size(139, 38);
            this.btnCancelarB.TabIndex = 24;
            this.btnCancelarB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelarB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelarB.TextMarginLeft = 0;
            this.btnCancelarB.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelarB.UseDefaultRadiusAndThickness = true;
            this.btnCancelarB.Click += new System.EventHandler(this.btnCancelarB_Click);
            // 
            // ID_cln
            // 
            this.ID_cln.HeaderText = "ID";
            this.ID_cln.Name = "ID_cln";
            this.ID_cln.Visible = false;
            // 
            // Nombre_producto
            // 
            this.Nombre_producto.HeaderText = "Nombre";
            this.Nombre_producto.MinimumWidth = 6;
            this.Nombre_producto.Name = "Nombre_producto";
            // 
            // Columna_Precio
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Columna_Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Columna_Precio.HeaderText = "Precio";
            this.Columna_Precio.MinimumWidth = 6;
            this.Columna_Precio.Name = "Columna_Precio";
            // 
            // Impuesto_cln
            // 
            this.Impuesto_cln.HeaderText = "Cantidad";
            this.Impuesto_cln.MinimumWidth = 6;
            this.Impuesto_cln.Name = "Impuesto_cln";
            // 
            // FrmBuscarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(862, 609);
            this.Controls.Add(this.btnCancelarB);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.dgvProductosB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarP";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvProductosB;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCancelarB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_cln;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto_cln;
    }
}