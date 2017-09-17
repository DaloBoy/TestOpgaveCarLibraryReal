using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpgaveCarLibrary
{
    public class Car
    {
        //properties
        public enum Color { Black, White, Gray, Red, Green, Blue }
        public int Doors { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public string Owner { get; set; }

        //Private Enum for at kunne identificere i Ctor
        Color _color;

        //Overloaded Constructor
        public Car(Color color, int doors, string model, string regno, string owner)
        {
            this._color = color;
            this.Doors = doors;
            this.Model = model;
            this.RegNo = regno;
            this.Owner = owner;

            if (color == Color.Green || color == Color.Black || color == Color.Blue || color == Color.Gray ||
                color == Color.Red || color == Color.White)
            {
                color = _color;
            }

            else
            {
                throw new ArgumentException("Farven er ikke en godkendt farve");
            }

            if (doors < 2 || doors > 5)
            {
                throw new ArgumentException("Din bil har enten for få, eller for mange døre");
            }

            if (model == null)
            {
                throw new ArgumentException("Bilen er ikke angivet en Model, som er nødvendigt");
            }

            if (regno.Length <= 6 || regno.Length >= 8)
            {
                throw new ArgumentException("Bilens registrerings-Nummer er enten for langt eller for kort.");
            }
        }
    }
}
