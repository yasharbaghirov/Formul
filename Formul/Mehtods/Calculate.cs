namespace Formul.Methods
{
    public static class Calculate
    {
        public static List<string> FormulaQueue(string formula)
        {
            List<string> list = new List<string>();
            List<string> metods = new List<string>() { "+", "-", "*", "/", "(", ")" };
            string metod = null;

            foreach (var item in formula)
            {              
                if (!metods.Contains(item.ToString()))
                {
                    metod += item.ToString();
                 }              
                if (metods.Contains(item.ToString()))
                {
                    if (metod != null)
                    {
                        list.Add(metod);
                    }
                    metod = null;
                    list.Add(item.ToString());
                }
            }
            if (metod != null)
            {
                list.Add(metod);
            }
            return list;
        }
    }
}
