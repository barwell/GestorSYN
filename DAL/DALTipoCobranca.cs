/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 03/01/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para controle dos dados da
 * tabela tipo de cobrança do banco de dados.
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
    public class DALTipoCobranca
    {

        private DALConexao conexao;

        public DALTipoCobranca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoCobranca modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into tipodecobranca(tipocobranca_nome, tipocobranca_data, tipocobranca_time, tipocobranca_status) "+
                "VALUES(@nome, @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.TipoCobNome);
            cmd.Parameters.AddWithValue("@data", modelo.TipoCobData);
            cmd.Parameters.AddWithValue("@time", modelo.TipoCobTime);
            cmd.Parameters.AddWithValue("@status", modelo.TipoCobStatus);
            conexao.Conectar();
            modelo.TipoCobCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloTipoCobranca modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update tipodecobranca set tipocobranca_nome = @nome, tipocobranca_data = @data, tipocobranca_time = @time, tipocobranca_status = @status where tipocobranca_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.TipoCobNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.TipoCobCod);
            cmd.Parameters.AddWithValue("@data", modelo.TipoCobData);
            cmd.Parameters.AddWithValue("@time", modelo.TipoCobTime);
            cmd.Parameters.AddWithValue("@status", modelo.TipoCobStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from tipodecobranca where tipocobranca_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tipodecobranca where tipocobranca_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaTipoCobranca(String valor) // se retornar 0 - não existe a unidade no banco || se retornar numero > 0 - encontrou valor no banco
        {
            int r = 0; // 0 - não existe valor no banco
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tipodecobranca where tipocobranca_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["tipocobranca_cod"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloTipoCobranca CarregaModeloTipoCobranca(int codigo)
        {
            ModeloTipoCobranca modelo = new ModeloTipoCobranca();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tipodecobranca where tipocobranca_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.TipoCobCod = Convert.ToInt32(registro["tipocobranca_cod"]);
                modelo.TipoCobNome = Convert.ToString(registro["tipocobranca_nome"]);
                modelo.TipoCobData = Convert.ToString(registro["tipocobranca_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
