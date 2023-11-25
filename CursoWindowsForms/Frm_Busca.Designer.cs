namespace CursoWindowsForms
{
    partial class Frm_Busca
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
            this.Lst_Busca = new System.Windows.Forms.ListBox();
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.salvarStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.apagatoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lst_Busca
            // 
            this.Lst_Busca.FormattingEnabled = true;
            this.Lst_Busca.ItemHeight = 16;
            this.Lst_Busca.Location = new System.Drawing.Point(12, 66);
            this.Lst_Busca.Name = "Lst_Busca";
            this.Lst_Busca.Size = new System.Drawing.Size(426, 356);
            this.Lst_Busca.TabIndex = 0;
            this.Lst_Busca.SelectedIndexChanged += new System.EventHandler(this.Lst_Busca_SelectedIndexChanged);
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarStripButton1,
            this.apagatoolStripButton2});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(460, 31);
            this.Tls_Principal.TabIndex = 1;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // salvarStripButton1
            // 
            this.salvarStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarStripButton1.Image = global::CursoWindowsForms.Properties.Resources.salvar;
            this.salvarStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarStripButton1.Name = "salvarStripButton1";
            this.salvarStripButton1.Size = new System.Drawing.Size(29, 28);
            this.salvarStripButton1.Text = "&Salvar";
            this.salvarStripButton1.Click += new System.EventHandler(this.salvarStripButton1_Click);
            // 
            // apagatoolStripButton2
            // 
            this.apagatoolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apagatoolStripButton2.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.apagatoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apagatoolStripButton2.Name = "apagatoolStripButton2";
            this.apagatoolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.apagatoolStripButton2.Text = "&apaga";
            this.apagatoolStripButton2.Click += new System.EventHandler(this.apagatoolStripButton2_Click);
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 434);
            this.Controls.Add(this.Tls_Principal);
            this.Controls.Add(this.Lst_Busca);
            this.Name = "Frm_Busca";
            this.Text = "Frm_Busca";
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_Busca;
        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton salvarStripButton1;
        private System.Windows.Forms.ToolStripButton apagatoolStripButton2;
    }
}