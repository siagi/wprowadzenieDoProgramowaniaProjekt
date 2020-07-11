using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
   public class MeasuringProcessList
    {
        public List<MeasuringProcess> measuringProcessListName { get; set; }


        public MeasuringProcessList()
        {
            measuringProcessListName = new List<MeasuringProcess>();
        }
        public void MeasuringProcessListAdd(MeasuringProcess flat)
        {
            measuringProcessListName.Add(flat);
        }
        public void MeasuringProcessListRead()
        {
            for(int i = 0;i< measuringProcessListName.Count;i++)
            {
                Console.WriteLine($"{measuringProcessListName[i]}");
            }
        }
        public void MeasuringProcessListReadUnique(int a)
        {
            Console.WriteLine($"{measuringProcessListName[a].ToString()}");
        }
        public void MeasuringProcessListReadUniqueEditBlock(int a)
        {
            measuringProcessListName[a].BLOK = new Block();
        }
        public void MeasuringProcessListReadUniqueEditAddress(int a)
        {
            measuringProcessListName[a].ADRES = new Addresses();
        }
        public void MeasuringProcessListReadUniqueEditFlat(int a)
        {
          measuringProcessListName[a].MIESZKANIE = new Flats(measuringProcessListName[a].BLOK.MAXVENTQUANTITY);
        }
    }
}
