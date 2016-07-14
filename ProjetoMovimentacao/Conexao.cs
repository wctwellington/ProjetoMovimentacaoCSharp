using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProjetoMovimentacao
{
    class Conexao
    {

        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=movimentacao.accdb";

        private static OleDbConnection conn = null;

        public static OleDbConnection obterConexao()
        {
            conn = new OleDbConnection(connString);

            try
            {
                conn.Open();
            }
            catch
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
