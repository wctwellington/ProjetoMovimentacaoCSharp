using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ProjetoMovimentacao
{
    class OledbDAO
    {

        private OleDbConnection conn = Conexao.obterConexao();

        public int salvar(Movimentacao m)
        {

            String _sql;

            _sql = "insert into movimentacao (solicitante, patrimonio, descricao, origem, destino, data) values ";
            _sql += "('" + m.Solicitante + "','"
                + m.Patrimonio + "','"
                + m.Descricao + "','"
                + m.Origem + "','"
                + m.Destino + "','"
                + m.Data + "')";

            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_sql, conn);
                _dataCommand.ExecuteNonQuery();

                OleDbDataReader reader = read("select MAX(codigo) from movimentacao");
                if (reader.HasRows)
                {
                    reader.Read();
                    return (int) reader.GetValue(0);
                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }

            return 0;
        }

        public OleDbDataReader read(String sql)
        {

            OleDbCommand _dataCommand = new OleDbCommand(sql, conn);
            OleDbDataReader reader = _dataCommand.ExecuteReader();

            return reader;

        }
    }
}

