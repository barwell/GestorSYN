/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 16/12/2015
 *Data da Ultima Revisão: 16/12/2015
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela Unidade de Medida do banco de dados.
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
    public class DALUndMedida
    {

        private DALConexao conexao;

        public DALUndMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUndMedida modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into undmedida(umed_nome, umed_data, umed_time, umed_status) VALUES(@nome, @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);
            cmd.Parameters.AddWithValue("@data", modelo.UmedData);
            cmd.Parameters.AddWithValue("@time", modelo.UmedTime);
            cmd.Parameters.AddWithValue("@status", modelo.UmedStatus);
            conexao.Conectar();
            modelo.UmedCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloUndMedida modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update undmedida set umed_nome = @nome, umed_data = @data, umed_time = @time, umed_status = @status where umed_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.UmedCod);
            cmd.Parameters.AddWithValue("@data", modelo.UmedData);
            cmd.Parameters.AddWithValue("@time", modelo.UmedTime);
            cmd.Parameters.AddWithValue("@status", modelo.UmedStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from undmedida where umed_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from undmedida where umed_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaUndDeMedida(String valor) // se retornar 0 - não existe a unidade no banco || se retornar numero > 0 - encontrou valor no banco
        {
            int r = 0; // 0 - não existe valor no banco
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from undmedida where umed_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["umed_cod"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloUndMedida CarregaModeloUndMedida(int codigo)
        {
            ModeloUndMedida modelo = new ModeloUndMedida();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from undmedida where umed_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.UmedNome = Convert.ToString(registro["umed_nome"]);
                modelo.UmedData = Convert.ToString(registro["umed_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
