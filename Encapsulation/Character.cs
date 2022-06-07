using System;

namespace Encapsulation
{
    public class Character
    {
        private int _health;
        private int _speed;
        private readonly Engine _engine;

        public int Speed
        {
            get { return _speed; }
            set {
                if(value < 0 || value > 25)
                {
                    throw new ArgumentException("Speed must be >=0 and <=25");
                }
                _speed = value;
            }
        }

        public int Health
        {
            get { return _health; }
            set
            {
                if(value > 100)
                {
                    throw new ArgumentException("Health must be <= 100");
                }
                if(value <= 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public string Name { get; }

        public Character(int health, int speed, string name)
        {
            _health = health;
            _speed = speed;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name can't be null or white space.");
            Name = name;
            _engine = new Engine();
        }


        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public bool IsRunning
        {
            get { return Speed > 5; }
        }

        public void MoveTo(Coordinate coord)
        {
            Speed = 5;
            _engine.Move(this, coord);
            Console.WriteLine("character started moving!");
        }

        public void RunTo(Coordinate coord)
        {
            Speed = 25;
            _engine.Move(this,coord);
            Console.WriteLine("character started running!");
        }

        public void Punch()
        {
            Health -= 10;
            Console.WriteLine("character punched!");
        }

        public void Kick()
        {
            Health -= 15;
            Console.WriteLine("character kicked!");
        }
    }
}
