using Formul.BLL.Abstarct;
using Formul.DAL;
using Formul.DTOs.FormulaDTOs;
using Formul.DTOs.ParametrDTOs;
using Formul.Entities;

namespace Formul.Mehtods
{
    public static  class Calculate2
    {
     public static  string FormulaString(List<String> list,List<ParametrToListDTO> parametrs)
        {

            
            string formula2 = "";
            int x = 0;
            int parametr=0;

            foreach (var i in list)
            {
                 if (i.Contains("P"))
                  {
                    parametr = int.Parse(i.Remove(0, 1));
                    var data= parametrs.Single(m=>m.ParametrId==parametr);
                    formula2 += data.ParametrValue;
                    continue;
                  }
                   formula2 += i;
            }
            return formula2;
        }

    
    }
}
