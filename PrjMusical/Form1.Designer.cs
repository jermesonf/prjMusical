namespace PrjMusical
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetrocederFim = new System.Windows.Forms.Button();
            this.btnAvancarFim = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(137, 86);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(100, 20);
            this.txtLoc.TabIndex = 1;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(24, 126);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(75, 23);
            this.btnRetroceder.TabIndex = 2;
            this.btnRetroceder.Text = "<";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(166, 126);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 3;
            this.btnAvancar.Text = ">";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localizacao do album";
            // 
            // btnRetrocederFim
            // 
            this.btnRetrocederFim.Location = new System.Drawing.Point(24, 169);
            this.btnRetrocederFim.Name = "btnRetrocederFim";
            this.btnRetrocederFim.Size = new System.Drawing.Size(75, 23);
            this.btnRetrocederFim.TabIndex = 6;
            this.btnRetrocederFim.Text = "<<";
            this.btnRetrocederFim.UseVisualStyleBackColor = true;
            this.btnRetrocederFim.Click += new System.EventHandler(this.btnRetrocederFim_Click);
            // 
            // btnAvancarFim
            // 
            this.btnAvancarFim.Location = new System.Drawing.Point(166, 169);
            this.btnAvancarFim.Name = "btnAvancarFim";
            this.btnAvancarFim.Size = new System.Drawing.Size(75, 23);
            this.btnAvancarFim.TabIndex = 7;
            this.btnAvancarFim.Text = ">>";
            this.btnAvancarFim.UseVisualStyleBackColor = true;
            this.btnAvancarFim.Click += new System.EventHandler(this.btnAvancarFim_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(24, 214);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(162, 214);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(24, 253);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnAvancarFim);
            this.Controls.Add(this.btnRetrocederFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Musica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetrocederFim;
        private System.Windows.Forms.Button btnAvancarFim;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
    }
}

