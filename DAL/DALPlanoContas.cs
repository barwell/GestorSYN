/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 31/12/2015
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela plano de contas do banco de dados.
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
    public class DALPlanoContas
    {
        private DALConexao conexao;

        public DALPlanoContas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPlanoContas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into planodeconta(planconta_nome, planconta_data, planconta_time, planconta_status)"+
                " VALUES(@nome, @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.PlanContaNome);
            cmd.Parameters.AddWithValue("@data", modelo.PlanContaData);
            cmd.Parameters.AddWithValue("@time", modelo.PlanContaTime);
            cmd.Parameters.AddWithValue("@status", modelo.PlanContaStatus);
            conexao.Conectar();
            modelo.PlanContaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloPlanoContas modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update planodeconta set planconta_nome = @nome, planconta_data = @data, planconta_time = @time, planconta_status = @status where planconta_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.PlanContaNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.PlanContaCod);
            cmd.Parameters.AddWithValue("@data", modelo.PlanContaData);
            cmd.Parameters.AddWithValue("@time", modelo.PlanContaTime);
            cmd.Parameters.AddWithValue("@status", modelo.PlanContaStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from planodeconta where planconta_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from planodeconta where planconta_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloPlanoContas CarregaModeloPlanoContas(int codigo)
        {
            ModeloPlanoContas modelo = new ModeloPlanoContas();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from planodeconta where planconta_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PlanContaCod = Convert.ToInt32(registro["planconta_cod"]);
                modelo.PlanContaNome = Convert.ToString(registro["planconta_nome"]);
                modelo.PlanContaData = Convert.ToString(registro["planconta_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
