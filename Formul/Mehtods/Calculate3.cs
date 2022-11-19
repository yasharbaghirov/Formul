using System.Data;

namespace Formul.Mehtods
{
    public static class Calculate3
    {

        public static int Cavab(string formula)
        {
            DataTable dt = new DataTable();
            int x = int.Parse(dt.Compute(formula, " ").ToString());
            return x;
        }
    }
}
