
/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 15/12/2015
 *Data da Ultima Revisão: 15/12/2015
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de subcategorias do banco de dados.
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
    public class ModeloSubCategoria
    {
        //Construtor de variáveis
        public ModeloSubCategoria()
        {
            this.CatCod = 0;
            this.ScatCod = 0;
            this.ScatData = "";
            this.ScatNome = "";
            this.ScatStatus = "";
            this.ScatTime = "";
        }

        public ModeloSubCategoria(int scatcod, int catcod, string snome, string scatdata, string scattime, string scatstatus)
        {
            this.CatCod = catcod;
            this.ScatCod = scatcod;
            this.ScatData = scatdata;
            this.ScatNome = snome;
            this.ScatStatus = scatstatus;
            this.ScatTime = scattime;
        }

        //*******************************
        //Variáveis
        private int scat_cod;
        public int ScatCod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }
        private int cat_cod;
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
        private String scat_nome;
        public String ScatNome
        {
            get { return this.scat_nome; }
            set { this.scat_nome = value; }
        }
        private String scat_data;
        public String ScatData
        {
            get { return this.scat_data; }
            set { this.scat_data = value; }
        }
        private String scat_time;

        public String ScatTime
        {
            get { return this.scat_time; }
            set { this.scat_time = value; }
        }
        private String scat_status;

        public string ScatStatus
        {
            get { return this.scat_status; }
            set { this.scat_status = value; }
        }
        //****************************
    }
}
