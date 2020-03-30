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
    public class DALProduto
    {

        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into produto(pro_coddebarras, pro_nome, pro_descricao, pro_marcafabricante, pro_foto, pro_valorpago," +
                "pro_qtde, pro_dimensoes, pro_peso, pro_ativo, pro_revenda, pro_insumo, pro_materiaprima, pro_producao, pro_serial, umed_cod, cat_cod, "+
                "scat_cod, for_cod, impos_cod, pro_data, pro_time, pro_status) VALUES(@codbarra, @nome, @descricao, @fabricante, @foto, @valorpago, @quantidade," +
                "@quantidade, @dimensoes, @peso, @ativo, @revenda, @insumo, @materiaprima, @producao, @serial, @unidade, @catcod, @scatcod, @forcod, @impostocod, " +
                "@data, @time, @status); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@data", modelo.ProdutoData);
                cmd.Parameters.AddWithValue("@codbarra", modelo.ProdutoCodBarra);
                cmd.Parameters.AddWithValue("@nome", modelo.ProdutoNome);
                cmd.Parameters.AddWithValue("@descricao", modelo.ProdutoDescricao);
                cmd.Parameters.AddWithValue("@fabricante", modelo.ProdutoFabricante);
                cmd.Parameters.AddWithValue("@foto", modelo.ProdutoFoto);
                cmd.Parameters.AddWithValue("@valorpago", modelo.ProdutoValorPago);
                cmd.Parameters.AddWithValue("@quantidade", modelo.ProdutoQuantidade);
                cmd.Parameters.AddWithValue("@dimensoes", modelo.ProdutoDimensoes);
                cmd.Parameters.AddWithValue("@peso", modelo.ProdutoPeso);
                cmd.Parameters.AddWithValue("@ativo", modelo.ProdutoAtivo);
                cmd.Parameters.AddWithValue("@revenda", modelo.ProdutoRevenda);
                cmd.Parameters.AddWithValue("@insumo", modelo.ProdutoInsumo);
                cmd.Parameters.AddWithValue("@materiaprima", modelo.ProdutoMateriaPrima);
                cmd.Parameters.AddWithValue("@producao", modelo.ProdutoProducao);
                cmd.Parameters.AddWithValue("@serial", modelo.ProdutoSerial);
                cmd.Parameters.AddWithValue("@unidade", modelo.ProdutoUniMedida);
                cmd.Parameters.AddWithValue("@catcod", modelo.ProdutoCatCod);
                cmd.Parameters.AddWithValue("@scatcod", modelo.ProdutoSCatCod);
                cmd.Parameters.AddWithValue("@forcod", modelo.ProdutoForCod);
                cmd.Parameters.AddWithValue("@impostocod", modelo.ProdutoImpostoCod);
                cmd.Parameters.AddWithValue("@time", modelo.ProdutoTime);
                cmd.Parameters.AddWithValue("@status", modelo.ProdutoStatus); 

                conexao.Conectar();
                modelo.ProdutoSCatCod = Convert.ToInt32(cmd.ExecuteScalar());

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

        public void Alterar(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update produto set pro_cod = @prodcod, pro_coddebarras = @codbarra, pro_nome = @nome, pro_descricao = @descricao, pro_marcafabricante = @fabricante, pro_foto = @foto, pro_valorpago = @valorpago," +
                "pro_qtde = @quantidade, pro_dimensoes = @dimensoes, pro_peso = @peso, pro_ativo = @ativo, pro_revenda = @revenda, pro_insumo = @insumo, pro_materiaprima = @materiaprima, pro_producao = @producao, pro_serial = @serial, umed_cod = @unidade, cat_cod = @catcod, " +
                "scat_cod = @scatcod, for_cod = @forcod, impos_cod = @impostocod, pro_data = @data, pro_time = @time, pro_status = @status";
                cmd.Parameters.AddWithValue("@prodcod", modelo.ProdutoCod);
                cmd.Parameters.AddWithValue("@data", modelo.ProdutoData);
                cmd.Parameters.AddWithValue("@codbarra", modelo.ProdutoCodBarra);
                cmd.Parameters.AddWithValue("@nome", modelo.ProdutoNome);
                cmd.Parameters.AddWithValue("@descricao", modelo.ProdutoDescricao);
                cmd.Parameters.AddWithValue("@fabricante", modelo.ProdutoFabricante);
                cmd.Parameters.AddWithValue("@foto", modelo.ProdutoFoto);
                cmd.Parameters.AddWithValue("@valorpago", modelo.ProdutoValorPago);
                cmd.Parameters.AddWithValue("@quantidade", modelo.ProdutoQuantidade);
                cmd.Parameters.AddWithValue("@dimensoes", modelo.ProdutoDimensoes);
                cmd.Parameters.AddWithValue("@peso", modelo.ProdutoPeso);
                cmd.Parameters.AddWithValue("@ativo", modelo.ProdutoAtivo);
                cmd.Parameters.AddWithValue("@revenda", modelo.ProdutoRevenda);
                cmd.Parameters.AddWithValue("@insumo", modelo.ProdutoInsumo);
                cmd.Parameters.AddWithValue("@materiaprima", modelo.ProdutoMateriaPrima);
                cmd.Parameters.AddWithValue("@producao", modelo.ProdutoProducao);
                cmd.Parameters.AddWithValue("@serial", modelo.ProdutoSerial);
                cmd.Parameters.AddWithValue("@unidade", modelo.ProdutoUniMedida);
                cmd.Parameters.AddWithValue("@catcod", modelo.ProdutoCatCod);
                cmd.Parameters.AddWithValue("@scatcod", modelo.ProdutoSCatCod);
                cmd.Parameters.AddWithValue("@forcod", modelo.ProdutoForCod);
                cmd.Parameters.AddWithValue("@impostocod", modelo.ProdutoImpostoCod);
                cmd.Parameters.AddWithValue("@time", modelo.ProdutoTime);
                cmd.Parameters.AddWithValue("@status", modelo.ProdutoStatus); 
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
                cmd.CommandText = "delete from produto where pro_cod = @codigo;";
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
            SqlDataAdapter da = new SqlDataAdapter("Select sc.pro_cod, sc.pro_nome, sc.cat_cod, sc.scat_cod, sc.for_cod, "+
                "sc.pro_marcafabricante, sc.pro_serial, sc.pro_coddebarras, sc.pro_descricao, c.pro_nome, sc.pro_data" + 
                " from produto sc inner join categoria c on sc.cat_cod = c.cat_cod where pro_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where pro_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProdutoCod = Convert.ToInt32(registro["pro_cod"]); 
                modelo.ProdutoData = Convert.ToString(registro["pro_data"]);
                modelo.ProdutoCodBarra = Convert.ToString(registro["pro_coddebarras"]);
                modelo.ProdutoNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProdutoDescricao = Convert.ToString(registro["pro_descricao"]);
                modelo.ProdutoFabricante = Convert.ToString(registro["pro_marcafabricante"]);
                modelo.ProdutoFoto = Convert.ToString(registro["pro_foto"]);
                modelo.ProdutoValorPago = Convert.ToInt32(registro["pro_valorpago"]);
                modelo.ProdutoQuantidade = Convert.ToInt32(registro["pro_qtde"]);
                modelo.ProdutoDimensoes = Convert.ToString(registro["pro_dimensoes"]); ;
                modelo.ProdutoPeso = Convert.ToInt32(registro["pro_peso"]);
                modelo.ProdutoAtivo = Convert.ToInt32(registro["pro_ativo"]);
                modelo.ProdutoRevenda = Convert.ToInt32(registro["pro_revenda"]);
                modelo.ProdutoInsumo = Convert.ToInt32(registro["pro_insumo"]);
                modelo.ProdutoMateriaPrima = Convert.ToInt32(registro["pro_materiaprima"]);
                modelo.ProdutoProducao = Convert.ToInt32(registro["pro_producao"]);
                modelo.ProdutoSerial = Convert.ToString(registro["pro_serial"]);
                modelo.ProdutoUniMedida = Convert.ToInt32(registro["umed_cod"]);
                modelo.ProdutoCatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ProdutoSCatCod = Convert.ToInt32(registro["scat_cod"]);
                modelo.ProdutoForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ProdutoImpostoCod = Convert.ToInt32(registro["impos_cod"]);
                modelo.ProdutoTime = Convert.ToString(registro["pro_time"]);
                modelo.ProdutoStatus = Convert.ToString(registro["pro_status"]); 
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
