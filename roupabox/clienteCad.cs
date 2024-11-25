using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupaboxx
{
    internal class ClienteCad
    {
        public string nomeCli { get; set; }// Nome   --  string   --  nomeCli  - Somente Textos
        public long cpfCli { get; set; }// CPF   --  long  --  cpfCli    --   11 dígitos
        public long telCli { get; set; }// Telefone   --  long -- telCli   -- 11 dígitos
        public int idadeCli { get; set; }// Idade   --  int  --  idadeCli   Somente Numeros
        public string mailCli { get; set; }// E-mail  --  string   --  mailCli   -- @
        public string sexoCli { get; set; }// Sexo  --  string   --  sexoCli  - Somente Textos
        public string ruaCli { get; set; }// Rua  --  string   --  ruaCli 
        public string compCli { get; set; }// complemento --  string   --  compCli
        public int numCli { get; set; }// Numero  --  int  --  numCli
        public string bairroCli { get; set; }// Bairro  --  string   -- bairroCli
        public string cidCli { get; set; }// Cidade --  string   -- cidCli
        public string estCli { get; set; }// Estado --  string   -- estCli  -- ser somente 2 dígitos
        public int cepCli { get; set; }// CEP --  int  -- cepCli -- 8 dígitos 





    }
}