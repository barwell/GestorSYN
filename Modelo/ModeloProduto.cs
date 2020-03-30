/*
 *WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 21/02/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de produtos do banco de dados.
 *
 * Modificações da Revisão: Nenhuma
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {

        //Construtor de variáveis
        public ModeloProduto()
        {
            this.ProdutoCod = 0;
            this.ProdutoData = "";
            this.ProdutoCodBarra = "";
            this.ProdutoNome = "";
            this.ProdutoDescricao = "";
            this.ProdutoFabricante = "";
            this.ProdutoFoto = "";
            this.ProdutoValorPago = 0;
            this.ProdutoValorVenda = 0;
            this.ProdutoLucro = 0;
            this.ProdutoOutros = 0;
            this.ProdutoQuantidade = 0;
            this.ProdutoDimensoes = "";
            this.ProdutoPeso = 0;
            this.ProdutoAtivo = 0;
            this.ProdutoRevenda = 0;
            this.ProdutoInsumo = 0;
            this.ProdutoMateriaPrima = 0;
            this.ProdutoProducao = 0;
            this.ProdutoSerial = "";
            this.ProdutoUniMedida= 0;
            this.ProdutoCatCod = 0;
            this.ProdutoSCatCod = 0;
            this.ProdutoForCod = 0;
            this.ProdutoImpostoCod = 0;
            this.ProdutoTime = "";
            this.ProdutoStatus = "";
        }

        public ModeloProduto(int produtocod, string produtodata, string produtocodbarra, string produtonome, string produtodescricao, string produtofabricante, string produtofoto,
            double produtovalorpago, int produtoquantidade, string produtodimensoes, float produtopeso, int produtoativo, int produtorevenda, int produtoinsumo, 
            int produtomateriaprima, int produtoproducao, string produtoserial, int produtounidademedida, int produtocatcod, int produtoscatcod, int produtoforcod, int produtoimpostocod, 
            string produtotime, string produtostatus)
        {
            this.ProdutoCod = produtocod;
            this.ProdutoData = produtodata;
            this.ProdutoCodBarra = produtocodbarra;
            this.ProdutoNome = produtonome;
            this.ProdutoDescricao = produtodescricao;
            this.ProdutoFabricante = produtofabricante;
            this.ProdutoFoto = produtofoto;
            this.ProdutoValorPago = produtovalorpago;
            this.ProdutoValorVenda = produtovalorvenda;
            this.ProdutoLucro = produtolucro;
            this.ProdutoOutros = produtooutros;
            this.ProdutoQuantidade = produtoquantidade;
            this.ProdutoDimensoes = produtodimensoes;
            this.ProdutoPeso = produtopeso;
            this.ProdutoAtivo = produtoativo;
            this.ProdutoRevenda = produtorevenda;
            this.ProdutoInsumo = produtoinsumo;
            this.ProdutoMateriaPrima = produtomateriaprima;
            this.ProdutoProducao = produtoproducao;
            this.ProdutoSerial = produtoserial;
            this.ProdutoUniMedida= produtounidademedida;
            this.ProdutoCatCod = produtocatcod;
            this.ProdutoSCatCod = produtoscatcod;
            this.ProdutoForCod = produtoforcod;
            this.ProdutoImpostoCod = produtoimpostocod;
            this.ProdutoTime = produtotime;
            this.ProdutoStatus = produtostatus;
            
        }

        //*******************************
        //Variáveis
        private int produto_cod;
        public int ProdutoCod
        {
            get { return this.produto_cod; }
            set { this.produto_cod = value; }
        }
        private string produto_data;
        public string ProdutoData
        {
            get { return this.produto_data; }
            set { this.produto_data = value; }
        }
        private string produto_codbarra;
        public string ProdutoCodBarra
        {
            get { return this.produto_codbarra; }
            set { this.produto_codbarra = value; }
        }
        private String produto_nome;
        public String ProdutoNome
        {
            get { return this.produto_nome; }
            set { this.produto_nome = value; }
        }
        private string produto_descricao;
        public string ProdutoDescricao
        {
            get { return this.produto_descricao; }
            set { this.produto_descricao = value; }
        }
        private string produto_fabricante;
        public string ProdutoFabricante
        {
            get { return this.produto_fabricante; }
            set { this.produto_fabricante = value; }
        }
        private string produto_foto;
        public string ProdutoFoto
        {
            get { return this.produto_foto; }
            set { this.produto_foto = value; }
        }
        private double produto_valorpago;
        public double ProdutoValorPago
        {
            get { return this.produto_valorpago; }
            set { this.produto_valorpago = value; }
        }
        private float produto_quantidade;
        public float ProdutoQuantidade
        {
            get { return this.produto_quantidade; }
            set { this.produto_quantidade = value; }
        }
        private string produto_dimensoes;
        public string ProdutoDimensoes
        {
            get { return this.produto_dimensoes; }
            set { this.produto_dimensoes = value; }
        }
        private float produto_peso;
        public float ProdutoPeso
        {
            get { return this.produto_peso; }
            set { this.produto_peso = value; }
        }
        private int produto_ativo;
        public int ProdutoAtivo
        {
            get { return this.produto_ativo; }
            set { this.produto_ativo = value; }
        }
        private int produto_revenda;
        public int ProdutoRevenda
        {
            get { return this.produto_revenda; }
            set { this.produto_revenda = value; }
        }
        private int produto_insumo;
        public int ProdutoInsumo
        {
            get { return this.produto_insumo; }
            set { this.produto_insumo = value; }
        }
        private int produto_materiaprima;
        public int ProdutoMateriaPrima
        {
            get { return this.produto_materiaprima; }
            set { this.produto_materiaprima = value; }
        }
        private int produto_producao;
        public int ProdutoProducao
        {
            get { return this.produto_producao; }
            set { this.produto_producao = value; }
        }
        private string produto_serial;
        public string ProdutoSerial
        {
            get { return this.produto_serial; }
            set { this.produto_serial = value; }
        }
        private int produto_unidademedida;
        public int ProdutoUniMedida
        {
            get { return this.produto_unidademedida; }
            set { this.produto_unidademedida = value; }
        }
        private int produto_catcod;

        public int ProdutoCatCod
        {
            get { return this.produto_catcod; }
            set { this.produto_catcod = value; }
        }
        private int produto_scatcod;

        public int ProdutoSCatCod
        {
            get { return this.produto_scatcod; }
            set { this.produto_scatcod = value; }
        }
        private int produto_forcod;

        public int ProdutoForCod
        {
            get { return this.produto_forcod; }
            set { this.produto_forcod = value; }
        }
        private int produto_impostocod;

        public int ProdutoImpostoCod
        {
            get { return this.produto_impostocod; }
            set { this.produto_impostocod = value; }
        }
        private string produto_time;

        public string ProdutoTime
        {
            get { return this.produto_time; }
            set { this.produto_time = value; }
        }
        private string produto_status;

        public string ProdutoStatus
        {
            get { return this.produto_status; }
            set { this.produto_status = value; }
        }
        //****************************

    }
}
