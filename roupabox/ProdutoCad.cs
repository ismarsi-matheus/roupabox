using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupaboxx
{
    internal class ProdutoCad
    {
        public ProdutoCad(string pro)
        {
            descPro = pro;
        }
        public string descPro { get; set; }
        public string marcaPro { get; set; }
        public string tamPro { get; set; }
        public string tamDesc { get; set; }
        public string corPro { get; set; }
        public string catPro { get; set; }
        public double valPro { get; set; }
        public double pesoPro { get; set; }
    }
}
/*
 

 Cadastro de Produtos
Marca    --- String   -- marcaPro
Tamanho  --- string -- tamPro
Cor    --- string -- corPro --   somente textos
categoria   --- string -- catPro
Descrição    --- string --  descPro
Valor   --  double -- valPro -- ser duas casas decimais
peso   -- double   --  pesoPro -- ser duas casas decimais


*/