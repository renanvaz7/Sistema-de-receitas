namespace Sistema_de_Receitas
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
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.rbnCarne = new System.Windows.Forms.RadioButton();
            this.rbnAves = new System.Windows.Forms.RadioButton();
            this.rbnLanches = new System.Windows.Forms.RadioButton();
            this.lblModoPreparo = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.lvReceitasCadastradas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rbnBolos = new System.Windows.Forms.RadioButton();
            this.gpbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.rbnBolos);
            this.gpbCategoria.Controls.Add(this.rbnCarne);
            this.gpbCategoria.Controls.Add(this.rbnAves);
            this.gpbCategoria.Controls.Add(this.rbnLanches);
            this.gpbCategoria.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbCategoria.Location = new System.Drawing.Point(771, 137);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(200, 133);
            this.gpbCategoria.TabIndex = 8;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoria";
            // 
            // rbnCarne
            // 
            this.rbnCarne.AutoSize = true;
            this.rbnCarne.Location = new System.Drawing.Point(115, 30);
            this.rbnCarne.Name = "rbnCarne";
            this.rbnCarne.Size = new System.Drawing.Size(70, 22);
            this.rbnCarne.TabIndex = 2;
            this.rbnCarne.TabStop = true;
            this.rbnCarne.Text = "Carne";
            this.rbnCarne.UseVisualStyleBackColor = true;
            this.rbnCarne.CheckedChanged += new System.EventHandler(this.rbnBolos_CheckedChanged);
            // 
            // rbnAves
            // 
            this.rbnAves.AutoSize = true;
            this.rbnAves.Location = new System.Drawing.Point(25, 85);
            this.rbnAves.Name = "rbnAves";
            this.rbnAves.Size = new System.Drawing.Size(56, 22);
            this.rbnAves.TabIndex = 4;
            this.rbnAves.TabStop = true;
            this.rbnAves.Text = "Aves";
            this.rbnAves.UseVisualStyleBackColor = true;
            this.rbnAves.CheckedChanged += new System.EventHandler(this.rbnBolos_CheckedChanged);
            // 
            // rbnLanches
            // 
            this.rbnLanches.AutoSize = true;
            this.rbnLanches.Location = new System.Drawing.Point(112, 85);
            this.rbnLanches.Name = "rbnLanches";
            this.rbnLanches.Size = new System.Drawing.Size(82, 22);
            this.rbnLanches.TabIndex = 3;
            this.rbnLanches.TabStop = true;
            this.rbnLanches.Text = "Lanches";
            this.rbnLanches.UseVisualStyleBackColor = true;
            this.rbnLanches.CheckedChanged += new System.EventHandler(this.rbnBolos_CheckedChanged);
            // 
            // lblModoPreparo
            // 
            this.lblModoPreparo.AutoSize = true;
            this.lblModoPreparo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoPreparo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModoPreparo.Location = new System.Drawing.Point(28, 283);
            this.lblModoPreparo.Name = "lblModoPreparo";
            this.lblModoPreparo.Size = new System.Drawing.Size(129, 18);
            this.lblModoPreparo.TabIndex = 7;
            this.lblModoPreparo.Text = "Modo de Preparo";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIngredientes.Location = new System.Drawing.Point(28, 116);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(97, 18);
            this.lblIngredientes.TabIndex = 6;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(28, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 18);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(277, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(515, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Cadastro de Receitas";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(168, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(530, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(31, 137);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(667, 133);
            this.txtIngredientes.TabIndex = 10;
            // 
            // lvReceitasCadastradas
            // 
            this.lvReceitasCadastradas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvReceitasCadastradas.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReceitasCadastradas.HideSelection = false;
            this.lvReceitasCadastradas.Location = new System.Drawing.Point(31, 471);
            this.lvReceitasCadastradas.Name = "lvReceitasCadastradas";
            this.lvReceitasCadastradas.Size = new System.Drawing.Size(960, 146);
            this.lvReceitasCadastradas.TabIndex = 11;
            this.lvReceitasCadastradas.UseCompatibleStateImageBehavior = false;
            this.lvReceitasCadastradas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ingredientes";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Modo de Preparo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 240;
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.Location = new System.Drawing.Point(31, 304);
            this.txtModoPreparo.Multiline = true;
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.Size = new System.Drawing.Size(811, 152);
            this.txtModoPreparo.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Plum;
            this.btnSalvar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(886, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 39);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Plum;
            this.btnDeletar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeletar.Location = new System.Drawing.Point(886, 356);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(105, 39);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Plum;
            this.btnLimpar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(886, 417);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 39);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rbnBolos
            // 
            this.rbnBolos.AutoSize = true;
            this.rbnBolos.Location = new System.Drawing.Point(25, 31);
            this.rbnBolos.Name = "rbnBolos";
            this.rbnBolos.Size = new System.Drawing.Size(64, 22);
            this.rbnBolos.TabIndex = 5;
            this.rbnBolos.TabStop = true;
            this.rbnBolos.Text = "Bolos";
            this.rbnBolos.UseVisualStyleBackColor = true;
            this.rbnBolos.CheckedChanged += new System.EventHandler(this.rbnBolos_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1014, 641);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtModoPreparo);
            this.Controls.Add(this.lvReceitasCadastradas);
            this.Controls.Add(this.lblModoPreparo);
            this.Controls.Add(this.gpbCategoria);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.RadioButton rbnCarne;
        private System.Windows.Forms.RadioButton rbnAves;
        private System.Windows.Forms.RadioButton rbnLanches;
        private System.Windows.Forms.Label lblModoPreparo;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.ListView lvReceitasCadastradas;
        private System.Windows.Forms.TextBox txtModoPreparo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton rbnBolinho;
    }
}

