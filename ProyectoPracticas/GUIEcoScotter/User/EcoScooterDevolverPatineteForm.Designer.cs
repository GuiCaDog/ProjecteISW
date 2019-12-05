namespace GUIEcoScotter
{
    partial class EcoScooterDevolverPatineteForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.Si = new System.Windows.Forms.Button();
            this.estaciones = new System.Windows.Forms.TableLayoutPanel();
            this.listViewEstaciones = new System.Windows.Forms.ListView();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.estaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Devolver Patinete";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.97938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02062F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Si, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(298, 361);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 103);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 75);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿Se ha producido algun incidente durante el alquiler? ";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Si
            // 
            this.Si.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Si.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Si.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Si.FlatAppearance.BorderSize = 4;
            this.Si.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Si.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Si.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Si.Location = new System.Drawing.Point(286, 6);
            this.Si.Name = "Si";
            this.Si.Size = new System.Drawing.Size(138, 91);
            this.Si.TabIndex = 9;
            this.Si.Text = "Sí";
            this.Si.UseVisualStyleBackColor = false;
            this.Si.Click += new System.EventHandler(this.Si_Click);
            // 
            // estaciones
            // 
            this.estaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estaciones.ColumnCount = 1;
            this.estaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.estaciones.Controls.Add(this.listViewEstaciones, 0, 0);
            this.estaciones.Location = new System.Drawing.Point(225, 128);
            this.estaciones.Name = "estaciones";
            this.estaciones.RowCount = 1;
            this.estaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.estaciones.Size = new System.Drawing.Size(578, 186);
            this.estaciones.TabIndex = 6;
            // 
            // listViewEstaciones
            // 
            this.listViewEstaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEstaciones.HideSelection = false;
            this.listViewEstaciones.Location = new System.Drawing.Point(3, 3);
            this.listViewEstaciones.Name = "listViewEstaciones";
            this.listViewEstaciones.Size = new System.Drawing.Size(572, 180);
            this.listViewEstaciones.TabIndex = 0;
            this.listViewEstaciones.UseCompatibleStateImageBehavior = false;
            this.listViewEstaciones.View = System.Windows.Forms.View.List;
            this.listViewEstaciones.SelectedIndexChanged += new System.EventHandler(this.listViewEstaciones_SelectedIndexChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(259, 493);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 9;
            // 
            // EcoScooterDevolverPatineteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 596);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.estaciones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "EcoScooterDevolverPatineteForm";
            this.Text = "EcoScooter ";
            this.Load += new System.EventHandler(this.EcoScooterDevolverPatineteForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.estaciones, 0);
            this.Controls.SetChildIndex(this.labelError, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.estaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Si;
        private System.Windows.Forms.TableLayoutPanel estaciones;
        private System.Windows.Forms.ListView listViewEstaciones;
        private System.Windows.Forms.Label labelError;
    }
}

