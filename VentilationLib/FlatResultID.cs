using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VentilationLib
{
    public class FlatResultID
    {
        Random id = new Random();
        string[] idTable = { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","1","2","3","4","5","6","7","8","9","0" };
        int length = 8;
        string idText { get; set; }
        public string IDTEXT
        {
            get => idText;
            set { idText = value; }
        }
        
        public FlatResultID()
        {
            idText = "";
            for (int i = 0;i<length;i++)
            {
                int a = id.Next(36);
                idText = idText + idTable.ElementAt(a);
            }
        }

        public override string ToString()
        {
            return idText;
        }
    }
}
