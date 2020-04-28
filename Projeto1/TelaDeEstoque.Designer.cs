namespace Projeto1
{
    partial class mPrincipal
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
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEspecificaToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.consultaEscpecificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.btncan = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProdutoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editarEstoqueToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.produtoToolStripMenuItem.Text = "Cadastro";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novoProdutoToolStripMenuItem.Text = "Novo Produto";
            this.novoProdutoToolStripMenuItem.Click += new System.EventHandler(this.novoProdutoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // editarEstoqueToolStripMenuItem
            // 
            this.editarEstoqueToolStripMenuItem.Name = "editarEstoqueToolStripMenuItem";
            this.editarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editarEstoqueToolStripMenuItem.Text = "Editar Estoque";
            this.editarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.editarEstoqueToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despacheToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // despacheToolStripMenuItem
            // 
            this.despacheToolStripMenuItem.Name = "despacheToolStripMenuItem";
            this.despacheToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.despacheToolStripMenuItem.Text = "Despache";
            this.despacheToolStripMenuItem.Click += new System.EventHandler(this.despacheToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaGeralToolStripMenuItem,
            this.consultaEspecificaToolStripMenuItem,
            this.consultaEscpecificaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultaToolStripMenuItem.Text = "Consultas";
            // 
            // consultaGeralToolStripMenuItem
            // 
            this.consultaGeralToolStripMenuItem.Name = "consultaGeralToolStripMenuItem";
            this.consultaGeralToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaGeralToolStripMenuItem.Text = "Consulta Geral";
            // 
            // consultaEspecificaToolStripMenuItem
            // 
            this.consultaEspecificaToolStripMenuItem.Name = "consultaEspecificaToolStripMenuItem";
            this.consultaEspecificaToolStripMenuItem.Size = new System.Drawing.Size(179, 6);
            // 
            // consultaEscpecificaToolStripMenuItem
            // 
            this.consultaEscpecificaToolStripMenuItem.Name = "consultaEscpecificaToolStripMenuItem";
            this.consultaEscpecificaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaEscpecificaToolStripMenuItem.Text = "Consulta Escpecifica";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(102, 6);
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Location = new System.Drawing.Point(205, 118);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(130, 33);
            this.btnsalvar.TabIndex = 1;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(84, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome do Produto: ";
            this.lblName.Visible = false;
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Visible = false;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcod.Location = new System.Drawing.Point(336, 53);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(43, 13);
            this.lblcod.TabIndex = 2;
            this.lblcod.Text = "Código:";
            this.lblcod.Visible = false;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(385, 50);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(55, 20);
            this.txtcod.TabIndex = 3;
            this.txtcod.Visible = false;
            // 
            // btncan
            // 
            this.btncan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btncan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncan.Location = new System.Drawing.Point(351, 118);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(62, 32);
            this.btncan.TabIndex = 1;
            this.btncan.Text = "Cancelar";
            this.btncan.UseVisualStyleBackColor = false;
            this.btncan.Visible = false;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(127, 118);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(62, 33);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btncan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 176);
            this.dataGridView1.TabIndex = 4;
            // 
            // mPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(533, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "mPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.mPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator consultaEspecificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEscpecificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem despacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

