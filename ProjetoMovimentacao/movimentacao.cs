using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoMovimentacao
{
    class Movimentacao
    {

        public string solicitante, patrimonio, descricao, origem, destino, data;
        private int codigo;

        public int Codigo
        {
            get { return codigo;}
            set {this.codigo = value;}
        }

        public string Solicitante
        {
            get { return solicitante; }
            set { this.solicitante = value; }
        }

        public string Patrimonio
        {
            get { return patrimonio; }
            set { this.patrimonio = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
        }

        public string Origem
        {
            get { return origem; }
            set { this.origem = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { this.destino = value; }
        }

        public string Data
        {
            get { return data; }
            set { this.data = value; }
        }

    }
}
