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
 * tabela Contato do banco de dados.
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
    public class DALContato
    {

        private DALConexao conexao;

        public DALContato(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloContato modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into contato(contato_nome, contato_data, contato_cep, contato_endereco, contato_telefone , contato_email, contato_celular1, contato_celular1oper, contato_celular2, contato_celular2oper,"+
                " for_cod, cli_cod, city_cod, estado_cod, pais_cod, contato_time, contato_status) VALUES(@nome, @data, @cep, @endereco, @telefone, @email, @cel1, @cel1oper, @cel2, @cel2oper, @forcod, @clicod,"+
                " @citycod, @estadocod, @paiscod, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.ContatoNome);
            cmd.Parameters.AddWithValue("@data", modelo.ContatoData);
            cmd.Parameters.AddWithValue("@cep", modelo.ContatoCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ContatoEndereco);
            cmd.Parameters.AddWithValue("@telefone", modelo.ContatoTelefone);
            cmd.Parameters.AddWithValue("@email", modelo.ContatoEmail);
            
            cmd.Parameters.AddWithValue("@cel1", modelo.ContatoCel1);
            cmd.Parameters.AddWithValue("@cel1oper", modelo.ContatoCel1Oper);
            cmd.Parameters.AddWithValue("@cel2", modelo.ContatoCel2);
            
            cmd.Parameters.AddWithValue("@cel2oper", modelo.ContatoCel2Oper);
            cmd.Parameters.AddWithValue("@forcod", modelo.ContatoForCod);
            cmd.Parameters.AddWithValue("@clicod", modelo.ContatoCliCod);
            cmd.Parameters.AddWithValue("@citycod", modelo.ContatoCityCod);
            cmd.Parameters.AddWithValue("@estadocod", modelo.ContatoEstadoCod);
            cmd.Parameters.AddWithValue("@paiscod", modelo.ContatoPaisCod);
            cmd.Parameters.AddWithValue("@time", modelo.ContatoTime);
            cmd.Parameters.AddWithValue("@status", modelo.ContatoStatus);
            conexao.Conectar();
            modelo.ContatoCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloContato modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update contato set contato_nome = @nome, contato_data = @data, contato_cep = @cep, contato_endereco = @endereco, contato_email = @email, contato_telefone = @telefone," +
                " contato_celular1 = @cel1, contato_celular1oper = @cel1oper, contato_celular2 = @cel2, contato_celular2oper = @cel2oper, for_cod = @forcod, cli_cod = @clicod, city_cod = @citycod,"+
                " estado_cod = @estadocod, pais_cod = @paiscod, contato_time = @time, contato_status = @status where contato_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.ContatoNome);
            cmd.Parameters.AddWithValue("@data", modelo.ContatoData);
            cmd.Parameters.AddWithValue("@cep", modelo.ContatoCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ContatoEndereco);
            cmd.Parameters.AddWithValue("@email", modelo.ContatoEmail);
            cmd.Parameters.AddWithValue("@telefone", modelo.ContatoTelefone);
            cmd.Parameters.AddWithValue("@cel1", modelo.ContatoCel1);
            cmd.Parameters.AddWithValue("@cel1oper", modelo.ContatoCel1Oper);
            cmd.Parameters.AddWithValue("@cel2", modelo.ContatoCel2);
            cmd.Parameters.AddWithValue("@cel2oper", modelo.ContatoCel2Oper);
            cmd.Parameters.AddWithValue("@forcod", modelo.ContatoForCod);
            cmd.Parameters.AddWithValue("@clicod", modelo.ContatoCliCod);
            cmd.Parameters.AddWithValue("@citycod", modelo.ContatoCityCod);
            cmd.Parameters.AddWithValue("@estadocod", modelo.ContatoEstadoCod);
            cmd.Parameters.AddWithValue("@paiscod", modelo.ContatoPaisCod);
            cmd.Parameters.AddWithValue("@time", modelo.ContatoTime);
            cmd.Parameters.AddWithValue("@status", modelo.ContatoStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from contato where contato_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from contato where contato_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarItens(int valor, string tabbanco, string coluna)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from "+ tabbanco +" where "+ coluna +" like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }


        public int VerificaContato(String valor) // se retornar 0 - não existe o Contato no banco || se retornar numero > 0 - encontrou valor no banco
        {
            int r = 0; // 0 - não existe valor no banco
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from contato where contato_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["contato_cod"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloContato CarregaModeloContato(int codigo)
        {
            ModeloContato modelo = new ModeloContato();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from contato where contato_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ContatoCod = Convert.ToInt32(registro["contato_cod"]);
                modelo.ContatoNome = Convert.ToString(registro["contato_nome"]);
                //modelo.ContatoForCod = Convert.ToInt32(registro["for_cod"]);
               // modelo.ContatoCliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.ContatoCityCod = Convert.ToInt32(registro["city_cod"]);
                modelo.ContatoCityCod = Convert.ToInt32(registro["estado_cod"]);
                modelo.ContatoCityCod = Convert.ToInt32(registro["pais_cod"]);
                modelo.ContatoTelefone = Convert.ToString(registro["contato_telefone"]);
                modelo.ContatoCel1 = Convert.ToString(registro["contato_celular1"]);
                modelo.ContatoCel1Oper = Convert.ToInt32(registro["contato_celular1oper"]);
                modelo.ContatoCel2 = Convert.ToString(registro["contato_celular2"]);
                modelo.ContatoCel2Oper = Convert.ToInt32(registro["contato_celular2oper"]);
                modelo.ContatoEndereco = Convert.ToString(registro["contato_cep"]);
                modelo.ContatoEndereco = Convert.ToString(registro["contato_endereco"]);
                modelo.ContatoData = Convert.ToString(registro["contato_data"]);

            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
