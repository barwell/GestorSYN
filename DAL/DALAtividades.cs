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
    public class DALAtividades
    {
        private DALConexao conexao;

        public DALAtividades(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloAtividades modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into atividade(ativ_nome, ativ_temp_dias, ativ_temp_horas, ativ_temp_minutos,"+
                " ativ_horas_dia, ativ_data, ativ_time, ativ_status) VALUES(@nome, @dias, @horas, @minutos, @horasdia,"+
                " @data, @time, @status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.AtivNome);
            cmd.Parameters.AddWithValue("@dias", modelo.AtivDias);
            cmd.Parameters.AddWithValue("@horas", modelo.AtivHoras);
            cmd.Parameters.AddWithValue("@minutos", modelo.AtivMinutos);
            cmd.Parameters.AddWithValue("@horasdia", modelo.AtivHorasDia);
            cmd.Parameters.AddWithValue("@data", modelo.AtivData);
            cmd.Parameters.AddWithValue("@time", modelo.AtivTime);
            cmd.Parameters.AddWithValue("@status", modelo.AtivStatus);
            conexao.Conectar();
            modelo.AtivCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloAtividades modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update atividade set ativ_nome = @nome, ativ_temp_dias = @dias, ativ_temp_horas = @horas, ativ_temp_minutos = @minutos,"+
                " ativ_horas_dia = @horasdia, ativ_data = @data, ativ_time = @time, ativ_status = @status where ativ_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.AtivNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.AtivCod);
            cmd.Parameters.AddWithValue("@dias", modelo.AtivDias);
            cmd.Parameters.AddWithValue("@horas", modelo.AtivHoras);
            cmd.Parameters.AddWithValue("@minutos", modelo.AtivMinutos);
            cmd.Parameters.AddWithValue("@horasdia", modelo.AtivHorasDia);
            cmd.Parameters.AddWithValue("@data", modelo.AtivData);
            cmd.Parameters.AddWithValue("@time", modelo.AtivTime);
            cmd.Parameters.AddWithValue("@status", modelo.AtivStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from atividade where ativ_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from atividade where ativ_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloAtividades CarregaModeloAtividades(int codigo)
        {
            ModeloAtividades modelo = new ModeloAtividades();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from atividade where ativ_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.AtivCod = Convert.ToInt32(registro["ativ_cod"]);
                modelo.AtivNome = Convert.ToString(registro["ativ_nome"]);
                modelo.AtivDias = Convert.ToInt32(registro["ativ_temp_dias"]);
                modelo.AtivHoras = Convert.ToInt32(registro["ativ_temp_horas"]);
                modelo.AtivMinutos = Convert.ToInt32(registro["ativ_temp_minutos"]);
                modelo.AtivHorasDia = Convert.ToInt32(registro["ativ_horas_dia"]);
                modelo.AtivData = Convert.ToString(registro["ativ_data"]);
            }
            conexao.Desconectar();
            return modelo;

        }

    }
}
