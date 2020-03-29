using System;

namespace PropertyPlayground
{
    class Creature
    {
        private string _Animal;
        private string name;
        private string _Movement;
        private string _Foodtype;
        private int _IdNumber;

        public string Animal
        {
            get { return this._Animal; }
            set { this._Animal = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Movement
        {
            get { return this._Movement; }
            set { this._Movement = value; }
        }
        public string Food
        {
            get { return this._Foodtype; }
            set { this._Foodtype = value; }
        }
        public int IdNumber
        {
            get { return this._IdNumber; }
        }
        // For the sake of time, stopping here. Will continue at some point playing with get and sets. 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Creature myObj = new Creature();
            myObj.Name = "Jonesy";
            Console.WriteLine(myObj.Name);
            myObj.Animal = "Marine";
            Console.WriteLine(myObj.Animal);
            myObj.Movement = "Pull-ups";
            Console.WriteLine(myObj.Movement);
            myObj.Food = "Doom";
            Console.WriteLine(myObj.Food);
        }
    }
}
