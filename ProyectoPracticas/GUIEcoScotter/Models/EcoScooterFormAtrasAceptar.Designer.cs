namespace GUIEcoScotter
{
    partial class EcoScooterFormAtrasAceptar
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Image = global::GUIEcoScotter.Properties.Resources.comprobado;
            this.buttonAceptar.Location = new System.Drawing.Point(924, 494);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 75);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.buttonAtras.BackgroundImage = global::GUIEcoScotter.Properties.Resources.responder__4_;
            this.buttonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAtras.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAtras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.Location = new System.Drawing.Point(41, 494);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 75);
            this.buttonAtras.TabIndex = 0;
            this.buttonAtras.Text = "\r\n";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EcoScooterFormAtrasAceptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1039, 596);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonAtras);
            this.Name = "EcoScooterFormAtrasAceptar";
            this.Load += new System.EventHandler(this.EcoScooterFormBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonAceptar;
    }
}