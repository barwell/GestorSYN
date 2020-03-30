/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 04/01/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela Estados do banco de dados.
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
    public class DALEstado
    {

        private DALConexao conexao;

        public DALEstado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEstado modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into estado(estado_nome, estado_data, estado_codigofed, estado_pais_cod, estado_time, estado_status) VALUES(@nome, @data, @codfed, @codpais, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.EstadoNome);
            cmd.Parameters.AddWithValue("@data", modelo.EstadoData);
            cmd.Parameters.AddWithValue("@codfed", modelo.EstadoCodFed);
            cmd.Parameters.AddWithValue("@codpais", modelo.EstadoPaisCod);
            cmd.Parameters.AddWithValue("@time", modelo.EstadoTime);
            cmd.Parameters.AddWithValue("@status", modelo.EstadoStatus);
            conexao.Conectar();
            modelo.EstadoCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloEstado modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update estado set estado_nome = @nome, estado_data = @data, estado_time = @time, estado_codigofed = @codfed, "+
                "estado_pais_cod = @codpais, estado_status = @status where estado_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.EstadoNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.EstadoCod);
            cmd.Parameters.AddWithValue("@data", modelo.EstadoData);
            cmd.Parameters.AddWithValue("@codfed", modelo.EstadoCodFed);
            cmd.Parameters.AddWithValue("@codpais", modelo.EstadoPaisCod);
            cmd.Parameters.AddWithValue("@time", modelo.EstadoTime);
            cmd.Parameters.AddWithValue("@status", modelo.EstadoStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from estado where estado_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            tabela.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * from estado where estado_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarItens(int valor, string tabbanco, string coluna)
        {
            DataTable tabela = new DataTable();
            tabela.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + tabbanco.ToString() + " where " + coluna + " like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaEstado(String valor) // se retornar 0 - não existe o Estado no banco || se retornar numero > 0 - encontrou valor no banco
        {
            int r = 0; // 0 - não existe valor no banco
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from estado where estado_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["estado_cod"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloEstado CarregaModeloEstado(int codigo)
        {
            ModeloEstado modelo = new ModeloEstado();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from estado where estado_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.EstadoCod = Convert.ToInt32(registro["estado_cod"]);
                modelo.EstadoNome = Convert.ToString(registro["estado_nome"]);
                modelo.EstadoData = Convert.ToString(registro["estado_data"]);
                modelo.EstadoCodFed = Convert.ToInt32(registro["estado_codigofed"]);
                modelo.EstadoPaisCod = Convert.ToInt32(registro["estado_pais_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
