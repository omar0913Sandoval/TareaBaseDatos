namespace CapaVistas.Dialogos
{
    partial class DlgProducto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgProducto));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.Drag_PnlHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dgvProducto = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductoAgregado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemover = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoAgregado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1309, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // Drag_PnlHeader
            // 
            this.Drag_PnlHeader.Fixed = true;
            this.Drag_PnlHeader.Horizontal = true;
            this.Drag_PnlHeader.TargetControl = this.pnlHeader;
            this.Drag_PnlHeader.Vertical = true;
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 10;
            this.Elipse_Form.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(80, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRODUCTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(73, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 55);
            this.label1.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.txtBusqueda.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusqueda.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.txtBusqueda.BorderThickness = 3;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusqueda.isPassword = false;
            this.txtBusqueda.Location = new System.Drawing.Point(50, 89);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(350, 43);
            this.txtBusqueda.TabIndex = 6;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProducto.ColumnHeadersHeight = 48;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducto.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProducto.DoubleBuffered = true;
            this.dgvProducto.EnableHeadersVisualStyles = false;
            this.dgvProducto.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvProducto.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProducto.Location = new System.Drawing.Point(12, 180);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.RowHeadersWidth = 50;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(536, 377);
            this.dgvProducto.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dgvProductoAgregado
            // 
            this.dgvProductoAgregado.AllowUserToAddRows = false;
            this.dgvProductoAgregado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvProductoAgregado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductoAgregado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductoAgregado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductoAgregado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductoAgregado.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductoAgregado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductoAgregado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductoAgregado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoAgregado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductoAgregado.ColumnHeadersHeight = 48;
            this.dgvProductoAgregado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductoAgregado.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductoAgregado.DoubleBuffered = true;
            this.dgvProductoAgregado.EnableHeadersVisualStyles = false;
            this.dgvProductoAgregado.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvProductoAgregado.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProductoAgregado.Location = new System.Drawing.Point(745, 180);
            this.dgvProductoAgregado.Name = "dgvProductoAgregado";
            this.dgvProductoAgregado.ReadOnly = true;
            this.dgvProductoAgregado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductoAgregado.RowHeadersVisible = false;
            this.dgvProductoAgregado.RowHeadersWidth = 50;
            this.dgvProductoAgregado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoAgregado.Size = new System.Drawing.Size(538, 377);
            this.dgvProductoAgregado.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.White;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 60D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(1145, 627);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(138, 48);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaVistas.Properties.Resources.Busqueda;
            this.pictureBox6.Location = new System.Drawing.Point(9, 88);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1270, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 35);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 20;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.BorderRadius = 0;
            this.btnRemover.ButtonText = "REMOVER";
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.DisabledColor = System.Drawing.Color.White;
            this.btnRemover.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemover.Iconimage = null;
            this.btnRemover.Iconimage_right = null;
            this.btnRemover.Iconimage_right_Selected = null;
            this.btnRemover.Iconimage_Selected = null;
            this.btnRemover.IconMarginLeft = 0;
            this.btnRemover.IconMarginRight = 0;
            this.btnRemover.IconRightVisible = true;
            this.btnRemover.IconRightZoom = 0D;
            this.btnRemover.IconVisible = true;
            this.btnRemover.IconZoom = 60D;
            this.btnRemover.IsTab = false;
            this.btnRemover.Location = new System.Drawing.Point(584, 383);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnRemover.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRemover.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemover.selected = false;
            this.btnRemover.Size = new System.Drawing.Size(140, 48);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemover.Textcolor = System.Drawing.Color.White;
            this.btnRemover.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "AGREGAR";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.White;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = null;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 60D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(583, 286);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(140, 48);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DlgProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 687);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvProductoAgregado);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgProducto";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoAgregado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuDragControl Drag_PnlHeader;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBusqueda;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvProductoAgregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.PictureBox btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemover;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
    }
}