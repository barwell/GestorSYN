using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPais
    {

        //Construtor de Variáveis
        public ModeloPais()
        {
            this.PaisCod = 0;
            this.PaisData = "";
            this.PaisNome = "";
            this.PaisStatus = "";
            this.PaisTime = "";
        }

       public ModeloPais(int paiscod, string paisnome, string paisdata, string paistime, string paisstatus)
        {
            this.PaisCod = paiscod;
            this.PaisData = paisdata;
            this.PaisNome = paisnome;
            this.PaisStatus = paisstatus;
            this.PaisTime = paistime;
        }

        //********************************
        //Chamadas das Variáveis
        private int pais_cod;
        public int PaisCod
        {
            get { return this.pais_cod; }
            set { this.pais_cod = value; }
        }
        private String pais_nome;
        public String PaisNome
        {
            get { return this.pais_nome; }
            set { this.pais_nome = value; }
        }
        private String pais_data;
        public String PaisData
        {
            get { return this.pais_data; }
            set { this.pais_data = value; }
        }
        private String pais_time;

        public String PaisTime
        {
            get{return this.pais_time;}
            set{this.pais_time = value;}
        }
        private String pais_status;

        public string PaisStatus
        {
            get{return this.pais_status;}
            set{this.pais_status = value;}
        }
        //**********************************
    }
}
