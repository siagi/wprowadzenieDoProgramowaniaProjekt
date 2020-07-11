using System;
using System.Collections.Generic;
using System.Text;

namespace VentilationLib
{
    public class Block
    {
        public string blockNr { get; private set; }
        public string BLOCKNR
        {
            get => blockNr;
            set
            {
                blockNr = value;
            }
        }
        public int stairCaseQuantity { get; private set; }
        public int STAIRCASE
        {
            get => stairCaseQuantity;
            set
            {
                stairCaseQuantity = value;
            }
        }
        public int floorQuantity { get; private set; }
        public int FLOOR
        {
            get => floorQuantity;
            set
            {
                floorQuantity = value;
            }
        }
        public int numberOfApartmentsOnTheFloor { get; private set; }
        public int NUMBEROFAPARTMENTSONTHEFLOOR
        {
            get => numberOfApartmentsOnTheFloor;
            set
            {
                numberOfApartmentsOnTheFloor = value;
            }
        }
        public int numberOfFlats { get; private set; }
        public int NUMBEROFFLATS
        {
            get => numberOfFlats;
            set
            {
                numberOfFlats = value;
            }
        }
        int flatQuantity { get; set; }
        public int FLATQIANTITY
        {
            get => flatQuantity;
            set
            {
                flatQuantity = value;
            }

        }
        int maxVentQuantity { get; set; }
        public int MAXVENTQUANTITY
        {
            get => maxVentQuantity;
            set
            {
                maxVentQuantity = value;
            }
        }
        int avarageFlow { get; set; }
        public int AVARAGEFLOW
            {
            get => avarageFlow;
            set
            {
                avarageFlow = value;
            }
            }


        public Block()
        {
            Console.WriteLine("Podaj nr bloku");
            this.blockNr = Console.ReadLine();
            Console.WriteLine("Podaj maksymalną ilość wentylatorów jaka może występować w mieszkaniu");
            this.maxVentQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilośc pięter w bloku");
            this.floorQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilośc mieszkań na piętrze");
            this.numberOfApartmentsOnTheFloor = int.Parse(Console.ReadLine());
            this.flatQuantity = this.numberOfApartmentsOnTheFloor * this.floorQuantity;
            Console.WriteLine("Podaj projektową wartość przepływu powietrza w wentylacji");
            this.avarageFlow = int.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return $"Nr Bloku: {BLOCKNR} || Ilość mieszkań: {FLATQIANTITY} || Projektowa wartość przepływu powietrza: {AVARAGEFLOW}\n --------------------------------";
        }
    }
}
