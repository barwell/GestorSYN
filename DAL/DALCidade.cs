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
 * tabela Cidade do banco de dados.
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
    public class DALCidade
    {

        private DALConexao conexao;

        public DALCidade(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCidade modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into cidade(city_nome, city_data, city_codigofed, city_estado_cod, city_time, city_status) VALUES(@nome, @data, @codfed, @codestado, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CityNome);
            cmd.Parameters.AddWithValue("@data", modelo.CityData);
            cmd.Parameters.AddWithValue("@codfed", modelo.CityCodFed);
            cmd.Parameters.AddWithValue("@codestado", modelo.CityEstadoCod);
            cmd.Parameters.AddWithValue("@time", modelo.CityTime);
            cmd.Parameters.AddWithValue("@status", modelo.CityStatus);
            conexao.Conectar();
            modelo.CityCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCidade modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update cidade set city_nome = @nome, city_data = @data, city_time = @time, city_codigofed = @codfed, "+
                "city_estado_cod = @codestado, city_status = @status where city_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.CityNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CityCod);
            cmd.Parameters.AddWithValue("@data", modelo.CityData);
            cmd.Parameters.AddWithValue("@codfed", modelo.CityCodFed);
            cmd.Parameters.AddWithValue("@codestado", modelo.CityEstadoCod);
            cmd.Parameters.AddWithValue("@time", modelo.CityTime);
            cmd.Parameters.AddWithValue("@status", modelo.CityStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from cidade where city_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from cidade where city_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarItens(int valor, string tabbanco, string coluna)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + tabbanco + " where " + coluna + " like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaCity(String valor) // se retornar 0 - não existe a Cidade no banco || se retornar numero > 0 - encontrou valor no banco
        {
            int r = 0; // 0 - não existe valor no banco
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cidade where city_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["city_cod"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloCidade CarregaModeloCidade(int codigo)
        {
            ModeloCidade modelo = new ModeloCidade();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cidade where city_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CityCod = Convert.ToInt32(registro["city_cod"]);
                modelo.CityNome = Convert.ToString(registro["city_nome"]);
                modelo.CityData = Convert.ToString(registro["city_data"]);
                modelo.CityCodFed = Convert.ToInt32(registro["city_codigofed"]);
                modelo.CityEstadoCod = Convert.ToInt32(registro["city_estado_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
