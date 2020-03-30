/*
 *WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1
 *Data da Criação: 03/01/2016
 *Data da Ultima Revisão: nunca
 *
 * Descrição: Classe utilizada para preencher a tabela
 * tipos de cobrança de medidas do banco de dados.
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
    public class ModeloTipoCobranca
    {
        
        //Construtor de variáveis
        public ModeloTipoCobranca()
        {
            this.TipoCobCod = 0;
            this.TipoCobData = "";
            this.TipoCobNome = "";
            this.TipoCobStatus = "";
            this.TipoCobTime = "";
        }

        public ModeloTipoCobranca(int tipocobcod, string tipocobnome, string tipocobdata, string tipocobtime, string tipocobstatus)
        {
            this.TipoCobCod = tipocobcod;
            this.TipoCobData = tipocobdata;
            this.TipoCobNome = tipocobnome;
            this.TipoCobStatus = tipocobstatus;
            this.TipoCobTime = tipocobtime;
        }

        //*******************************
        //Variáveis
        private int tipocob_cod;
        public int TipoCobCod
        {
            get { return this.tipocob_cod; }
            set { this.tipocob_cod = value; }
        }
        private String tipocob_nome;
        public String TipoCobNome
        {
            get { return this.tipocob_nome; }
            set { this.tipocob_nome = value; }
        }
        private String tipocob_data;
        public String TipoCobData
        {
            get { return this.tipocob_data; }
            set { this.tipocob_data = value; }
        }
        private String tipocob_time;

        public String TipoCobTime
        {
            get { return this.tipocob_time; }
            set { this.tipocob_time = value; }
        }
        private String tipocob_status;

        public string TipoCobStatus
        {
            get { return this.tipocob_status; }
            set { this.tipocob_status = value; }
        }
        //****************************

    }
}
