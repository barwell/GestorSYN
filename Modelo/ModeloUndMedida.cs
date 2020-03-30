
/*
 *WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 16/12/2015
 *Data da Ultima Revisão: 16/12/2015
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de unidades de medidas do banco de dados.
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
    public class ModeloUndMedida
    {

        //Construtor de variáveis
        public ModeloUndMedida()
        {
            this.UmedCod = 0;
            this.UmedData = "";
            this.UmedNome = "";
            this.UmedStatus = "";
            this.UmedTime = "";
        }

        public ModeloUndMedida(int umedcod, string umednome, string umeddata, string umedtime, string umedstatus)
        {
            this.UmedCod = umedcod;
            this.UmedData = umeddata;
            this.UmedNome = umednome;
            this.UmedStatus = umedstatus;
            this.UmedTime = umedtime;
        }

        //*******************************
        //Variáveis
        private int umed_cod;
        public int UmedCod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }
        private String umed_nome;
        public String UmedNome
        {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }
        private String umed_data;
        public String UmedData
        {
            get { return this.umed_data; }
            set { this.umed_data = value; }
        }
        private String umed_time;

        public String UmedTime
        {
            get { return this.umed_time; }
            set { this.umed_time = value; }
        }
        private String umed_status;

        public string UmedStatus
        {
            get { return this.umed_status; }
            set { this.umed_status = value; }
        }
        //****************************

    }
}
