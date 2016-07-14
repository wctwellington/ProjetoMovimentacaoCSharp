using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProjetoMovimentacao
{
    public partial class formMovimentacao : Form
    {

        OleDbConnection conn;
        String sql;
        
        private bool validarCampos()
        {
            bool erro = false;

            lblSolicitante.ForeColor = Color.Black;
            lblNumPatrimonio.ForeColor = Color.Black;
            lblDescricao.ForeColor = Color.Black;
            lblLocalOrigem.ForeColor = Color.Black;
            lblLocalDestino.ForeColor = Color.Black;
            lblData.ForeColor = Color.Black;

            if (txtSolicitante.Text == "")
            {
                lblSolicitante.ForeColor = Color.Red;
                erro = true;
            }

            if (txtPatrimonio.Text == "")
            {
                lblNumPatrimonio.ForeColor = Color.Red;
                erro = true;
            }

            if (txtDescricao.Text == "")
            {
                lblDescricao.ForeColor = Color.Red;
                erro = true;
            }

            if (txtOrigem.Text == "")
            {
                lblLocalOrigem.ForeColor = Color.Red;
                erro = true;
            }

            if (txtDestino.Text == "")
            {
                lblLocalDestino.ForeColor = Color.Red;
                erro = true;
            }

            if (maskData.Text == "  /  /")
            {
                lblData.ForeColor = Color.Red;
                erro = true;
            }

            if (erro == true)
            {
                MessageBox.Show("Há campos inválidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return erro;
        }

        private void limparCampos()
        {
            txtSolicitante.Text = "";
            txtPatrimonio.Text = "";
            txtDescricao.Text = "";
            txtOrigem.Text = "";
            txtDestino.Text = "";
            maskData.Text = "";
        }

        private void carregarDataGrid(String sql)
        {

            
            OledbDAO dao = new OledbDAO();

            OleDbDataReader reader = dao.read(sql);
            BindingSource bsMovimentacao = new BindingSource();
            if (reader.HasRows == true)
            {
                bsMovimentacao.DataSource = reader;
            }
            else
            {
                bsMovimentacao = null;
            }

            dgvPesquisa.DataSource = bsMovimentacao;
        }
        

        public formMovimentacao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == false)
            {
                int codigo;

                Movimentacao mv = new Movimentacao();
                mv.Solicitante = txtSolicitante.Text;
                mv.Patrimonio = txtPatrimonio.Text;
                mv.Descricao = txtDescricao.Text;
                mv.Origem = txtOrigem.Text;
                mv.Destino = txtDestino.Text;
                mv.Data = maskData.Text;

                OledbDAO dao = new OledbDAO();
                codigo = dao.salvar(mv);

                MessageBox.Show("Movimentação Registrada com Sucesso!\n\nCódigo da Movimentação: " + codigo + "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
                sql = "select * from movimentacao";
                carregarDataGrid(sql);
            }
        }

        private void formMovimentacao_Load(object sender, EventArgs e)
        {
            conn = Conexao.obterConexao();
            sql = "select * from movimentacao";
            carregarDataGrid(sql);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();        
        }

        private void filtrarDados(object sender, EventArgs e)
        {
            sql = "select * from movimentacao where " + cbFiltrarPor.Text + " like '" + txtFiltrar.Text + "%' order by " + cbOrdenarPor.Text;

            carregarDataGrid(sql);
        }
    }
}
