/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 24/11/2015
 *Data da Ultima Revisão: 24/11/2015
 *
 * Descrição: Classe utilizada para conectar ao banco de dados.
 *
 * Modificações da Revisão: Nenhuma
 */
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;

        public DALConexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
