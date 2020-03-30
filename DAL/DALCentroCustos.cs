/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 03/01/2015
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela centro de custo do banco de dados.
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
    public class DALCentroCustos
    {
        private DALConexao conexao;

        public DALCentroCustos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCentroCustos modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into centrodecustos(centcusto_nome, centcusto_data, centcusto_time, centcusto_status) "+
                "VALUES(@nome, @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CentroCustNome);
            cmd.Parameters.AddWithValue("@data", modelo.CentroCustData);
            cmd.Parameters.AddWithValue("@time", modelo.CentroCustTime);
            cmd.Parameters.AddWithValue("@status", modelo.CentroCustStatus);
            conexao.Conectar();
            modelo.CentroCustCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCentroCustos modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update centrodecustos set centcusto_nome = @nome, centcusto_data = @data,"+
                " centcusto_time = @time, centcusto_status = @status where centcusto_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.CentroCustNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CentroCustCod);
            cmd.Parameters.AddWithValue("@data", modelo.CentroCustData);
            cmd.Parameters.AddWithValue("@time", modelo.CentroCustTime);
            cmd.Parameters.AddWithValue("@status", modelo.CentroCustStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from centrodecustos where centcusto_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from centrodecustos where centcusto_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaCentroCustos(String valor) // se retornar 0 - não existe a unidade no banco || se retornar numero > 0 - encontrou valor no banco
        {
            int r = 0; // 0 - não existe valor no banco
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from centrodecustos where centcusto_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["centcusto_cod"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloCentroCustos CarregaModeloCentroCustos(int codigo)
        {
            ModeloCentroCustos modelo = new ModeloCentroCustos();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from centrodecustos where centcusto_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CentroCustCod = Convert.ToInt32(registro["centcusto_cod"]);
                modelo.CentroCustNome = Convert.ToString(registro["centcusto_nome"]);
                modelo.CentroCustData = Convert.ToString(registro["centcusto_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
