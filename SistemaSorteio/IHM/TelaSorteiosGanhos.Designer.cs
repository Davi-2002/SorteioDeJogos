namespace SistemaSorteio.IHM
{
    partial class TelaSorteiosGanhos
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
            this.dgv_ListaSorteios = new System.Windows.Forms.DataGridView();
            this.l_aviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaSorteios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaSorteios
            // 
            this.dgv_ListaSorteios.AllowUserToResizeColumns = false;
            this.dgv_ListaSorteios.AllowUserToResizeRows = false;
            this.dgv_ListaSorteios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListaSorteios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaSorteios.Location = new System.Drawing.Point(13, 12);
            this.dgv_ListaSorteios.Name = "dgv_ListaSorteios";
            this.dgv_ListaSorteios.ReadOnly = true;
            this.dgv_ListaSorteios.RowHeadersVisible = false;
            this.dgv_ListaSorteios.Size = new System.Drawing.Size(775, 363);
            this.dgv_ListaSorteios.TabIndex = 31;
            // 
            // l_aviso
            // 
            this.l_aviso.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.l_aviso.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_aviso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_aviso.Location = new System.Drawing.Point(14, 182);
            this.l_aviso.Name = "l_aviso";
            this.l_aviso.Size = new System.Drawing.Size(773, 22);
            this.l_aviso.TabIndex = 32;
            this.l_aviso.Text = "PLACEHOLDER";
            this.l_aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaSorteiosGanhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.l_aviso);
            this.Controls.Add(this.dgv_ListaSorteios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaSorteiosGanhos";
            this.Text = "SorteiosGanhos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaSorteios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaSorteios;
        private System.Windows.Forms.Label l_aviso;
    }
}