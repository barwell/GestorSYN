using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class DALSubCategoria
    {
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into subcategoria(cat_cod, scat_nome, scat_data, scat_time, scat_status) VALUES(@catcod, @nome, @data, @time, @status); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@data", modelo.ScatData);
                cmd.Parameters.AddWithValue("@time", modelo.ScatTime);
                cmd.Parameters.AddWithValue("@status", modelo.ScatStatus);
                conexao.Conectar();
                modelo.ScatCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @nome, cat_cod = @catcod, scat_data = @data, scat_time = @time, scat_status = @status where scat_cod = @scatcod";
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scatcod", modelo.ScatCod);
                cmd.Parameters.AddWithValue("@data", modelo.ScatData);
                cmd.Parameters.AddWithValue("@time", modelo.ScatTime);
                cmd.Parameters.AddWithValue("@status", modelo.ScatStatus);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }            
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }  
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome, sc.scat_data" + " from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where scat_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subcategoria where scat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatNome = Convert.ToString(registro["scat_nome"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
                modelo.ScatData = Convert.ToString(registro["scat_data"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
