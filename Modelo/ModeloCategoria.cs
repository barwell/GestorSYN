/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 *Versão:1.1
 *Data da Criação: 24/11/2015
 *Data da Ultima Revisão: 15/12/2015
 *
 * Descrição: Classe utilizada para preencher a tabela
 * de categorias do banco de dados.
 *
 * Modificações da Revisão: Inserção de construtor de variáveis
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        //Construtor de Variáveis
        public ModeloCategoria()
        {
            this.CatCod = 0;
            this.CatData = "";
            this.CatNome = "";
            this.CatStatus = "";
            this.CatTime = "";
        }
        
        public ModeloCategoria(int cat_cod, string cat_nome, string cat_data, string cat_time, string cat_status)
        {
            this.CatCod = cat_cod;
            this.CatData = cat_data;
            this.CatNome = cat_nome;
            this.CatStatus = cat_status;
            this.CatTime = cat_time;
        }

        //********************************
        //Chamadas das Variáveis
        private int cat_cod;
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
        private String cat_nome;
        public String CatNome
        {
            get { return this.cat_nome; }
            set { this.cat_nome = value; }
        }
        private String cat_data;
        public String CatData
        {
            get { return this.cat_data; }
            set { this.cat_data = value; }
        }
        private String cat_time;

        public String CatTime
        {
            get{return this.cat_time;}
            set{this.cat_time = value;}
        }
        private String cat_status;

        public string CatStatus
        {
            get{return this.cat_status;}
            set{this.cat_status = value;}
        }
        //**********************************

    }
}
