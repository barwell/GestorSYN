/*
 *WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 03/01/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de centro de custos do banco de dados.
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
    public class ModeloCentroCustos
    {

         //Construtor de variáveis
        public ModeloCentroCustos()
        {
            this.CentroCustCod = 0;
            this.CentroCustData = "";
            this.CentroCustNome = "";
            this.CentroCustStatus = "";
            this.CentroCustTime = "";
        }

        public ModeloCentroCustos(int centrocustcod, string centrocustnome, string centrocustdata, string centrocusttime, string centrocuststatus)
        {
            this.CentroCustCod = centrocustcod;
            this.CentroCustData = centrocustdata;
            this.CentroCustNome = centrocustnome;
            this.CentroCustStatus = centrocuststatus;
            this.CentroCustTime = centrocusttime;
        }

        //*******************************
        //Variáveis
        private int centrocust_cod;
        public int CentroCustCod
        {
            get { return this.centrocust_cod; }
            set { this.centrocust_cod = value; }
        }
        private String centrocust_nome;
        public String CentroCustNome
        {
            get { return this.centrocust_nome; }
            set { this.centrocust_nome = value; }
        }
        private String centrocust_data;
        public String CentroCustData
        {
            get { return this.centrocust_data; }
            set { this.centrocust_data = value; }
        }
        private String centrocust_time;

        public String CentroCustTime
        {
            get { return this.centrocust_time; }
            set { this.centrocust_time = value; }
        }
        private String centrocust_status;

        public string CentroCustStatus
        {
            get { return this.centrocust_status; }
            set { this.centrocust_status = value; }
        }
        //****************************


    }
}
