namespace V_1._0
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B_Enviar = new System.Windows.Forms.Button();
            this.ML_Região = new System.Windows.Forms.CheckedListBox();
            this.ML_Produto = new System.Windows.Forms.CheckedListBox();
            this.L_NovoOrçamento = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Enviar
            // 
            this.B_Enviar.Location = new System.Drawing.Point(100, 181);
            this.B_Enviar.Name = "B_Enviar";
            this.B_Enviar.Size = new System.Drawing.Size(75, 23);
            this.B_Enviar.TabIndex = 0;
            this.B_Enviar.Text = "Enviar";
            this.B_Enviar.UseVisualStyleBackColor = true;
            this.B_Enviar.Click += new System.EventHandler(this.B_Enviar_Click);
            // 
            // ML_Região
            // 
            this.ML_Região.CheckOnClick = true;
            this.ML_Região.FormattingEnabled = true;
            this.ML_Região.Items.AddRange(new object[] {
            "Tenente Portela - RS"});
            this.ML_Região.Location = new System.Drawing.Point(140, 81);
            this.ML_Região.Name = "ML_Região";
            this.ML_Região.Size = new System.Drawing.Size(130, 94);
            this.ML_Região.TabIndex = 1;
            this.ML_Região.SelectedIndexChanged += new System.EventHandler(this.ML_Região_SelectedIndexChanged);
            // 
            // ML_Produto
            // 
            this.ML_Produto.CheckOnClick = true;
            this.ML_Produto.FormattingEnabled = true;
            this.ML_Produto.Items.AddRange(new object[] {
            "Cama de Aves"});
            this.ML_Produto.Location = new System.Drawing.Point(14, 81);
            this.ML_Produto.Name = "ML_Produto";
            this.ML_Produto.Size = new System.Drawing.Size(120, 94);
            this.ML_Produto.TabIndex = 2;
            this.ML_Produto.SelectedIndexChanged += new System.EventHandler(this.ML_Produto_SelectedIndexChanged);
            // 
            // L_NovoOrçamento
            // 
            this.L_NovoOrçamento.AutoSize = true;
            this.L_NovoOrçamento.Location = new System.Drawing.Point(97, 53);
            this.L_NovoOrçamento.Name = "L_NovoOrçamento";
            this.L_NovoOrçamento.Size = new System.Drawing.Size(88, 13);
            this.L_NovoOrçamento.TabIndex = 3;
            this.L_NovoOrçamento.Text = "Novo Orçamento";
            this.L_NovoOrçamento.Click += new System.EventHandler(this.L_NovoOrçamento_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_NovoOrçamento);
            this.Controls.Add(this.ML_Produto);
            this.Controls.Add(this.ML_Região);
            this.Controls.Add(this.B_Enviar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Protótipo V-1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Enviar;
        private System.Windows.Forms.CheckedListBox ML_Região;
        private System.Windows.Forms.Label L_NovoOrçamento;
        private System.Windows.Forms.CheckedListBox ML_Produto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

