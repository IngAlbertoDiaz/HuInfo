namespace HuInfo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.txtHU = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIPaddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbCMES = new System.Windows.Forms.RadioButton();
            this.rbINFOR = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDurango = new System.Windows.Forms.RadioButton();
            this.rbLeon = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hu,
            this.lote,
            this.item,
            this.qt});
            this.dgvInfo.Location = new System.Drawing.Point(12, 135);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.Size = new System.Drawing.Size(595, 296);
            this.dgvInfo.TabIndex = 3;
            this.dgvInfo.TabStop = false;
            // 
            // txtHU
            // 
            this.txtHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHU.Location = new System.Drawing.Point(126, 98);
            this.txtHU.Name = "txtHU";
            this.txtHU.Size = new System.Drawing.Size(233, 31);
            this.txtHU.TabIndex = 0;
            this.txtHU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHU_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarExcelToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // generarExcelToolStripMenuItem
            // 
            this.generarExcelToolStripMenuItem.Name = "generarExcelToolStripMenuItem";
            this.generarExcelToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.generarExcelToolStripMenuItem.Text = "Generar excel";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recargarIPToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // recargarIPToolStripMenuItem
            // 
            this.recargarIPToolStripMenuItem.Name = "recargarIPToolStripMenuItem";
            this.recargarIPToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.recargarIPToolStripMenuItem.Text = "Recargar IP";
            this.recargarIPToolStripMenuItem.Click += new System.EventHandler(this.recargarIPToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(501, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblIPaddress
            // 
            this.lblIPaddress.AutoSize = true;
            this.lblIPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPaddress.Location = new System.Drawing.Point(8, 24);
            this.lblIPaddress.Name = "lblIPaddress";
            this.lblIPaddress.Size = new System.Drawing.Size(59, 20);
            this.lblIPaddress.TabIndex = 4;
            this.lblIPaddress.Text = "Server:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Handling Unit:";
            // 
            // hu
            // 
            this.hu.HeaderText = "HU";
            this.hu.Name = "hu";
            this.hu.ReadOnly = true;
            this.hu.Width = 48;
            // 
            // lote
            // 
            this.lote.HeaderText = "LOTE";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            this.lote.Width = 60;
            // 
            // item
            // 
            this.item.HeaderText = "ITEM";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 58;
            // 
            // qt
            // 
            this.qt.HeaderText = "CANTIDAD";
            this.qt.Name = "qt";
            this.qt.ReadOnly = true;
            this.qt.Width = 87;
            // 
            // rbCMES
            // 
            this.rbCMES.AutoSize = true;
            this.rbCMES.Checked = true;
            this.rbCMES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCMES.Location = new System.Drawing.Point(158, 68);
            this.rbCMES.Name = "rbCMES";
            this.rbCMES.Size = new System.Drawing.Size(73, 24);
            this.rbCMES.TabIndex = 6;
            this.rbCMES.Text = "CMES";
            this.rbCMES.UseVisualStyleBackColor = true;
            // 
            // rbINFOR
            // 
            this.rbINFOR.AutoSize = true;
            this.rbINFOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbINFOR.Location = new System.Drawing.Point(258, 68);
            this.rbINFOR.Name = "rbINFOR";
            this.rbINFOR.Size = new System.Drawing.Size(77, 24);
            this.rbINFOR.TabIndex = 7;
            this.rbINFOR.Text = "INFOR";
            this.rbINFOR.UseVisualStyleBackColor = true;
            this.rbINFOR.CheckedChanged += new System.EventHandler(this.rbINFOR_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLeon);
            this.groupBox1.Controls.Add(this.rbDurango);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(365, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compañia";
            // 
            // rbDurango
            // 
            this.rbDurango.AutoSize = true;
            this.rbDurango.Checked = true;
            this.rbDurango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDurango.Location = new System.Drawing.Point(6, 25);
            this.rbDurango.Name = "rbDurango";
            this.rbDurango.Size = new System.Drawing.Size(89, 24);
            this.rbDurango.TabIndex = 8;
            this.rbDurango.Text = "Durango";
            this.rbDurango.UseVisualStyleBackColor = true;
            // 
            // rbLeon
            // 
            this.rbLeon.AutoSize = true;
            this.rbLeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeon.Location = new System.Drawing.Point(6, 52);
            this.rbLeon.Name = "rbLeon";
            this.rbLeon.Size = new System.Drawing.Size(63, 24);
            this.rbLeon.TabIndex = 9;
            this.rbLeon.Text = "Leon";
            this.rbLeon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbINFOR);
            this.Controls.Add(this.rbCMES);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIPaddress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHU);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handling Unit Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.TextBox txtHU;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarExcelToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIPaddress;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarIPToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hu;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt;
        private System.Windows.Forms.RadioButton rbCMES;
        private System.Windows.Forms.RadioButton rbINFOR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLeon;
        private System.Windows.Forms.RadioButton rbDurango;
    }
}

