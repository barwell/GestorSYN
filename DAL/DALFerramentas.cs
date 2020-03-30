/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 21/12/2015
 *Data da Ultima Revisão: nunca
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela ferramenta do banco de dados.
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
    public class DALFerramentas
    {

        private DALConexao conexao;

        public DALFerramentas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFerramentas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into ferramenta(ferr_nome, ferr_valor, ferr_data, ferr_time, ferr_status) VALUES(@nome, @valor, @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.FerrNome);
            cmd.Parameters.AddWithValue("@valor", modelo.FerrValor);
            cmd.Parameters.AddWithValue("@data", modelo.FerrData);
            cmd.Parameters.AddWithValue("@time", modelo.FerrTime);
            cmd.Parameters.AddWithValue("@status", modelo.FerrStatus);
            conexao.Conectar();
            modelo.FerrCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFerramentas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update ferramenta set ferr_nome = @nome, ferr_valor = @valor, ferr_data = @data, ferr_time = @time, ferr_status = @status where ferr_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.FerrNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.FerrCod);
            cmd.Parameters.AddWithValue("@valor", modelo.FerrValor);
            cmd.Parameters.AddWithValue("@data", modelo.FerrData);
            cmd.Parameters.AddWithValue("@time", modelo.FerrTime);
            cmd.Parameters.AddWithValue("@status", modelo.FerrStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ferramenta where ferr_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ferramenta where ferr_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFerramentas CarregaModeloFerramentas(int codigo)
        {
            ModeloFerramentas modelo = new ModeloFerramentas();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ferramenta where ferr_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FerrCod = Convert.ToInt32(registro["ferr_cod"]);
                modelo.FerrNome = Convert.ToString(registro["ferr_nome"]);
                modelo.FerrValor = Convert.ToDouble(registro["ferr_valor"]);
                modelo.FerrData = Convert.ToString(registro["ferr_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
