
namespace boteco
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnAtualizarPedido = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvVendas, "dgvVendas");
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnNovoPedido, "btnNovoPedido");
            this.btnNovoPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // txtValor
            // 
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.Name = "txtValor";
            // 
            // txtIdProduto
            // 
            resources.ApplyResources(this.txtIdProduto, "txtIdProduto");
            this.txtIdProduto.Name = "txtIdProduto";
            // 
            // txtQuantidade
            // 
            resources.ApplyResources(this.txtQuantidade, "txtQuantidade");
            this.txtQuantidade.Name = "txtQuantidade";
            // 
            // lblEstoque
            // 
            resources.ApplyResources(this.lblEstoque, "lblEstoque");
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAtualizarPedido
            // 
            this.btnAtualizarPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnAtualizarPedido, "btnAtualizarPedido");
            this.btnAtualizarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualizarPedido.Name = "btnAtualizarPedido";
            this.btnAtualizarPedido.UseVisualStyleBackColor = false;
            this.btnAtualizarPedido.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxCliente.FormattingEnabled = true;
            resources.ApplyResources(this.cbxCliente, "cbxCliente");
            this.cbxCliente.Name = "cbxCliente";
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            resources.ApplyResources(this.cbxProduto, "cbxProduto");
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnNovoItem, "btnNovoItem");
            this.btnNovoItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnExcluirItem, "btnExcluirItem");
            this.btnExcluirItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnEditarItem, "btnEditarItem");
            this.btnEditarItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // txtIdVenda
            // 
            resources.ApplyResources(this.txtIdVenda, "txtIdVenda");
            this.txtIdVenda.Name = "txtIdVenda";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnLocalizar, "btnLocalizar");
            this.btnLocalizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnFinalizarPedido, "btnFinalizarPedido");
            this.btnFinalizarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnFinalizarVenda, "btnFinalizarVenda");
            this.btnFinalizarVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            // 
            // FrmVendas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnAtualizarPedido);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnAtualizarPedido;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
    }
}