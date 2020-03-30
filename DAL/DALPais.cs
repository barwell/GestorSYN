/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 18/12/2015
 *Data da Ultima Revisão: 18/12/2015
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela país do banco de dados.
 *
 * Modificações da Revisão: Nenhuma
 */


using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPais
    {

        private DALConexao conexao;

        public DALPais(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPais modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into pais(pais_nome, pais_data, pais_time, pais_status) VALUES(@nome, @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.PaisNome);
            cmd.Parameters.AddWithValue("@data", modelo.PaisData);
            cmd.Parameters.AddWithValue("@time", modelo.PaisTime);
            cmd.Parameters.AddWithValue("@status", modelo.PaisStatus);
            conexao.Conectar();
            modelo.PaisCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloPais modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update pais set pais_nome = @nome, pais_data = @data, pais_time = @time, pais_status = @status where pais_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.PaisNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.PaisCod);
            cmd.Parameters.AddWithValue("@data", modelo.PaisData);
            cmd.Parameters.AddWithValue("@time", modelo.PaisTime);
            cmd.Parameters.AddWithValue("@status", modelo.PaisStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from pais where pais_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from pais where pais_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloPais CarregaModeloPais(int codigo)
        {
            ModeloPais modelo = new ModeloPais();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Pais where pais_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PaisCod = Convert.ToInt32(registro["pais_cod"]);
                modelo.PaisNome = Convert.ToString(registro["pais_nome"]);
                modelo.PaisData = Convert.ToString(registro["pais_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
