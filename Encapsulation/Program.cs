using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character(100, 0, "Serdar");

            character.MoveTo(new Coordinate());
            character.RunTo(new Coordinate());
            character.Punch();
            character.Kick();

            Console.WriteLine("Character is running? : " + character.IsRunning);
            Console.WriteLine("Character is alive? : " + character.IsAlive);


            Console.ReadLine();
        }
    }
}
