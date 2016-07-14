using System;
using System.Windows.Forms;

namespace ProjetoMovimentacao
{
    partial class formMovimentacao
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
            this.components = new System.ComponentModel.Container();
            this.tooltipe = new System.Windows.Forms.ToolTip(this.components);
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblRotulo = new System.Windows.Forms.Label();
            this.lblAtencao = new System.Windows.Forms.Label();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.lblNumPatrimonio = new System.Windows.Forms.Label();
            this.lblLocalOrigem = new System.Windows.Forms.Label();
            this.lblLocalDestino = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblVisualizacaoDados = new System.Windows.Forms.Label();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.gbFiltragemDados = new System.Windows.Forms.GroupBox();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.cbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.lblOrdenarPor = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.maskData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gbFiltragemDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitante.Location = new System.Drawing.Point(37, 148);
            this.txtSolicitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolicitante.MaxLength = 60;
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(223, 22);
            this.txtSolicitante.TabIndex = 6;
            this.tooltipe.SetToolTip(this.txtSolicitante, "Máximo de caracteres: 60");
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatrimonio.Location = new System.Drawing.Point(289, 148);
            this.txtPatrimonio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatrimonio.MaxLength = 30;
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(233, 22);
            this.txtPatrimonio.TabIndex = 7;
            this.tooltipe.SetToolTip(this.txtPatrimonio, "Máximo de caracteres: 30");
            // 
            // txtOrigem
            // 
            this.txtOrigem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.Location = new System.Drawing.Point(37, 240);
            this.txtOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrigem.MaxLength = 35;
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(223, 22);
            this.txtOrigem.TabIndex = 9;
            this.tooltipe.SetToolTip(this.txtOrigem, "Máximo de caracteres: 35");
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(289, 240);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.MaxLength = 35;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(233, 22);
            this.txtDestino.TabIndex = 10;
            this.tooltipe.SetToolTip(this.txtDestino, "Máximo de caracteres: 35");
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(37, 194);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.MaxLength = 70;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(352, 22);
            this.txtDescricao.TabIndex = 14;
            this.tooltipe.SetToolTip(this.txtDescricao, "Máximo de caracteres: 70");
            // 
            // lblRotulo
            // 
            this.lblRotulo.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo.Location = new System.Drawing.Point(13, 26);
            this.lblRotulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotulo.Name = "lblRotulo";
            this.lblRotulo.Size = new System.Drawing.Size(674, 28);
            this.lblRotulo.TabIndex = 0;
            this.lblRotulo.Text = "REGISTRAR MOVEMENTAÇÃO DE BENS";
            this.lblRotulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtencao
            // 
            this.lblAtencao.AutoSize = true;
            this.lblAtencao.Location = new System.Drawing.Point(34, 85);
            this.lblAtencao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtencao.Name = "lblAtencao";
            this.lblAtencao.Size = new System.Drawing.Size(396, 16);
            this.lblAtencao.TabIndex = 1;
            this.lblAtencao.Text = "Atenção: Todos os campos são de preenchimento obrigatório";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.Location = new System.Drawing.Point(34, 127);
            this.lblSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(76, 16);
            this.lblSolicitante.TabIndex = 2;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // lblNumPatrimonio
            // 
            this.lblNumPatrimonio.AutoSize = true;
            this.lblNumPatrimonio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPatrimonio.Location = new System.Drawing.Point(286, 127);
            this.lblNumPatrimonio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPatrimonio.Name = "lblNumPatrimonio";
            this.lblNumPatrimonio.Size = new System.Drawing.Size(96, 16);
            this.lblNumPatrimonio.TabIndex = 3;
            this.lblNumPatrimonio.Text = "Nº Patrimônio";
            // 
            // lblLocalOrigem
            // 
            this.lblLocalOrigem.AutoSize = true;
            this.lblLocalOrigem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalOrigem.Location = new System.Drawing.Point(34, 220);
            this.lblLocalOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalOrigem.Name = "lblLocalOrigem";
            this.lblLocalOrigem.Size = new System.Drawing.Size(114, 16);
            this.lblLocalOrigem.TabIndex = 4;
            this.lblLocalOrigem.Text = "Local de Origem";
            // 
            // lblLocalDestino
            // 
            this.lblLocalDestino.AutoSize = true;
            this.lblLocalDestino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDestino.Location = new System.Drawing.Point(286, 220);
            this.lblLocalDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalDestino.Name = "lblLocalDestino";
            this.lblLocalDestino.Size = new System.Drawing.Size(114, 16);
            this.lblLocalDestino.TabIndex = 5;
            this.lblLocalDestino.Text = "Local de Destino";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(414, 174);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(70, 16);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data Mov.";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(34, 174);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(67, 16);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Destrição";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(555, 148);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 36);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(555, 190);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 36);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblVisualizacaoDados
            // 
            this.lblVisualizacaoDados.AutoSize = true;
            this.lblVisualizacaoDados.Location = new System.Drawing.Point(34, 276);
            this.lblVisualizacaoDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisualizacaoDados.Name = "lblVisualizacaoDados";
            this.lblVisualizacaoDados.Size = new System.Drawing.Size(152, 16);
            this.lblVisualizacaoDados.TabIndex = 17;
            this.lblVisualizacaoDados.Text = "Visualização de Dados";
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(37, 295);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(623, 206);
            this.dgvPesquisa.TabIndex = 18;
            // 
            // gbFiltragemDados
            // 
            this.gbFiltragemDados.Controls.Add(this.txtFiltrar);
            this.gbFiltragemDados.Controls.Add(this.cbOrdenarPor);
            this.gbFiltragemDados.Controls.Add(this.cbFiltrarPor);
            this.gbFiltragemDados.Controls.Add(this.lblOrdenarPor);
            this.gbFiltragemDados.Controls.Add(this.lblFiltrarPor);
            this.gbFiltragemDados.Location = new System.Drawing.Point(37, 520);
            this.gbFiltragemDados.Name = "gbFiltragemDados";
            this.gbFiltragemDados.Size = new System.Drawing.Size(620, 124);
            this.gbFiltragemDados.TabIndex = 19;
            this.gbFiltragemDados.TabStop = false;
            this.gbFiltragemDados.Text = "Filtragem de Dados";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(12, 87);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(209, 22);
            this.txtFiltrar.TabIndex = 23;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.filtrarDados);
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "codigo",
            "solicitante",
            "patrimonio",
            "descricao",
            "origem",
            "destino"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(280, 48);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(209, 24);
            this.cbOrdenarPor.TabIndex = 22;
            this.cbOrdenarPor.Text = "codigo";
            this.cbOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.filtrarDados);
            // 
            // cbFiltrarPor
            // 
            this.cbFiltrarPor.FormattingEnabled = true;
            this.cbFiltrarPor.Items.AddRange(new object[] {
            "codigo",
            "solicitante",
            "patrimonio",
            "descricao",
            "origem",
            "destino",
            "data"});
            this.cbFiltrarPor.Location = new System.Drawing.Point(12, 48);
            this.cbFiltrarPor.Name = "cbFiltrarPor";
            this.cbFiltrarPor.Size = new System.Drawing.Size(209, 24);
            this.cbFiltrarPor.TabIndex = 21;
            this.cbFiltrarPor.Text = "patrimonio";
            this.cbFiltrarPor.SelectedIndexChanged += new System.EventHandler(this.filtrarDados);
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPor.Location = new System.Drawing.Point(277, 29);
            this.lblOrdenarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(86, 16);
            this.lblOrdenarPor.TabIndex = 20;
            this.lblOrdenarPor.Text = "Ordenar Por";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(9, 29);
            this.lblFiltrarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(71, 16);
            this.lblFiltrarPor.TabIndex = 20;
            this.lblFiltrarPor.Text = "Filtrar por";
            // 
            // maskData
            // 
            this.maskData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.maskData.Location = new System.Drawing.Point(417, 194);
            this.maskData.Name = "maskData";
            this.maskData.Size = new System.Drawing.Size(105, 22);
            this.maskData.TabIndex = 20;
            // 
            // formMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 666);
            this.Controls.Add(this.maskData);
            this.Controls.Add(this.gbFiltragemDados);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.lblVisualizacaoDados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtPatrimonio);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.lblLocalDestino);
            this.Controls.Add(this.lblLocalOrigem);
            this.Controls.Add(this.lblNumPatrimonio);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.lblAtencao);
            this.Controls.Add(this.lblRotulo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMovimentacao";
            this.Text = "Movementação de Bens";
            this.Load += new System.EventHandler(this.formMovimentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gbFiltragemDados.ResumeLayout(false);
            this.gbFiltragemDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRotulo;
        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.Label lblNumPatrimonio;
        private System.Windows.Forms.Label lblLocalOrigem;
        private System.Windows.Forms.Label lblLocalDestino;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblVisualizacaoDados;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.GroupBox gbFiltragemDados;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.ComboBox cbFiltrarPor;
        private System.Windows.Forms.Label lblOrdenarPor;
        private System.Windows.Forms.Label lblFiltrarPor;
        private ToolTip tooltipe;
        private DateTimePicker maskData;
    }
}

