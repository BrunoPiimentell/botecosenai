
namespace boteco
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxClientes = new System.Windows.Forms.PictureBox();
            this.pbxProdutos = new System.Windows.Forms.PictureBox();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.pbxFuncionarios = new System.Windows.Forms.PictureBox();
            this.pbxVendas = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // pbxClientes
            // 
            this.pbxClientes.Image = global::boteco.Properties.Resources.cliente;
            this.pbxClientes.Location = new System.Drawing.Point(12, 38);
            this.pbxClientes.Name = "pbxClientes";
            this.pbxClientes.Size = new System.Drawing.Size(153, 193);
            this.pbxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClientes.TabIndex = 2;
            this.pbxClientes.TabStop = false;
            this.pbxClientes.Click += new System.EventHandler(this.pbxClientes_Click);
            // 
            // pbxProdutos
            // 
            this.pbxProdutos.Image = global::boteco.Properties.Resources.produto;
            this.pbxProdutos.Location = new System.Drawing.Point(189, 38);
            this.pbxProdutos.Name = "pbxProdutos";
            this.pbxProdutos.Size = new System.Drawing.Size(159, 193);
            this.pbxProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProdutos.TabIndex = 3;
            this.pbxProdutos.TabStop = false;
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::boteco.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(761, 38);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(151, 193);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 4;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // pbxFuncionarios
            // 
            this.pbxFuncionarios.Image = global::boteco.Properties.Resources.funcionario;
            this.pbxFuncionarios.Location = new System.Drawing.Point(376, 38);
            this.pbxFuncionarios.Name = "pbxFuncionarios";
            this.pbxFuncionarios.Size = new System.Drawing.Size(169, 193);
            this.pbxFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFuncionarios.TabIndex = 4;
            this.pbxFuncionarios.TabStop = false;
            // 
            // pbxVendas
            // 
            this.pbxVendas.Image = global::boteco.Properties.Resources.venda;
            this.pbxVendas.Location = new System.Drawing.Point(573, 38);
            this.pbxVendas.Name = "pbxVendas";
            this.pbxVendas.Size = new System.Drawing.Size(156, 193);
            this.pbxVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVendas.TabIndex = 5;
            this.pbxVendas.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produtos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Funcionários";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vendas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sair";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxVendas);
            this.Controls.Add(this.pbxFuncionarios);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxProdutos);
            this.Controls.Add(this.pbxClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxClientes;
        private System.Windows.Forms.PictureBox pbxProdutos;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.PictureBox pbxFuncionarios;
        private System.Windows.Forms.PictureBox pbxVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

