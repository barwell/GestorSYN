/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 24/11/2015
 *Data da Ultima Revisão: 24/11/2015
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela categoria do banco de dados.
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
    public class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into categoria(cat_nome, cat_data, cat_time, cat_status) VALUES(@nome, @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@data", modelo.CatData);
            cmd.Parameters.AddWithValue("@time", modelo.CatTime);
            cmd.Parameters.AddWithValue("@status", modelo.CatStatus);
            conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome, cat_data = @data, cat_time = @time, cat_status = @status where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            cmd.Parameters.AddWithValue("@data", modelo.CatData);
            cmd.Parameters.AddWithValue("@time", modelo.CatTime);
            cmd.Parameters.AddWithValue("@status", modelo.CatStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from categoria where cat_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.CatNome = Convert.ToString(registro["cat_nome"]);
                modelo.CatData = Convert.ToString(registro["cat_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
