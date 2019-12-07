namespace GUIEcoScotter
{
    partial class EcoScooterRegistrarPatineteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstaciones = new System.Windows.Forms.Label();
            this.textoError1 = new System.Windows.Forms.Label();
            this.textoError2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewEstaciones = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dirección = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordenadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registrar Patinete";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxEstado, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 77);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estado:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Disponible",
            "Mantenimiento"});
            this.comboBoxEstado.Location = new System.Drawing.Point(311, 43);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(296, 28);
            this.comboBoxEstado.TabIndex = 6;
            this.comboBoxEstado.Text = "Mantenimiento";
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // labelEstaciones
            // 
            this.labelEstaciones.AutoSize = true;
            this.labelEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEstaciones.Location = new System.Drawing.Point(175, 278);
            this.labelEstaciones.Name = "labelEstaciones";
            this.labelEstaciones.Size = new System.Drawing.Size(107, 24);
            this.labelEstaciones.TabIndex = 12;
            this.labelEstaciones.Text = "Estaciones:";
            this.labelEstaciones.Click += new System.EventHandler(this.Label4_Click);
            // 
            // textoError1
            // 
            this.textoError1.AutoSize = true;
            this.textoError1.BackColor = System.Drawing.SystemColors.Control;
            this.textoError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoError1.ForeColor = System.Drawing.Color.Red;
            this.textoError1.Location = new System.Drawing.Point(207, 229);
            this.textoError1.Name = "textoError1";
            this.textoError1.Size = new System.Drawing.Size(0, 16);
            this.textoError1.TabIndex = 13;
            // 
            // textoError2
            // 
            this.textoError2.AutoSize = true;
            this.textoError2.BackColor = System.Drawing.SystemColors.Control;
            this.textoError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoError2.ForeColor = System.Drawing.Color.Red;
            this.textoError2.Location = new System.Drawing.Point(173, 482);
            this.textoError2.Name = "textoError2";
            this.textoError2.Size = new System.Drawing.Size(0, 16);
            this.textoError2.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listViewEstaciones, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(176, 305);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 169);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // listViewEstaciones
            // 
            this.listViewEstaciones.AutoArrange = false;
            this.listViewEstaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Dirección,
            this.Coordenadas});
            this.listViewEstaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEstaciones.FullRowSelect = true;
            this.listViewEstaciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEstaciones.HideSelection = false;
            this.listViewEstaciones.Location = new System.Drawing.Point(3, 3);
            this.listViewEstaciones.MultiSelect = false;
            this.listViewEstaciones.Name = "listViewEstaciones";
            this.listViewEstaciones.Size = new System.Drawing.Size(664, 163);
            this.listViewEstaciones.TabIndex = 0;
            this.listViewEstaciones.UseCompatibleStateImageBehavior = false;
            this.listViewEstaciones.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Dirección
            // 
            this.Dirección.Text = "Dirección";
            this.Dirección.Width = 400;
            // 
            // Coordenadas
            // 
            this.Coordenadas.Text = "Coordenadas";
            this.Coordenadas.Width = 200;
            // 
            // EcoScooterRegistrarPatineteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 596);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textoError2);
            this.Controls.Add(this.textoError1);
            this.Controls.Add(this.labelEstaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EcoScooterRegistrarPatineteForm";
            this.Text = "EcoScooter ";
            this.Controls.SetChildIndex(this.personLoginLabel, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelEstaciones, 0);
            this.Controls.SetChildIndex(this.textoError1, 0);
            this.Controls.SetChildIndex(this.textoError2, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelEstaciones;
        private System.Windows.Forms.Label textoError1;
        private System.Windows.Forms.Label textoError2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listViewEstaciones;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Dirección;
        private System.Windows.Forms.ColumnHeader Coordenadas;
    }
}

