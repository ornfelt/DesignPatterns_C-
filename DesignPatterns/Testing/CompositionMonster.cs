using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Testing
{

    // From: https://www.codeproject.com/Articles/80045/Composition-VS-Inheritance
    // You can further develop the Fighter class by implementing a list with several moves...
    class CompositionMonster
    {
        public static void TestCompositionMonster()
        {
            Fighter fighter1 = new Fighter("Puncher", new PunchMove());
            Fighter fighter2 = new Fighter("Kicker", new KickMove());

            Attack(fighter1,fighter2);
            Attack(fighter2,fighter1);

            Console.Read();
        }
        static void Attack(Fighter attacker,Fighter defendant)
        {
            Console.WriteLine("Fighter {0} Attacks {1} with {2} Move resulting in {3} Damage"
                ,attacker.Name,defendant.Name,attacker.MoveName,attacker.MoveDamage);

            attacker.Attack(defendant);

            Console.WriteLine("Defendant {0} has {1} health remaining",
            defendant.Name,defendant.Health);
        }
    }

    abstract class Move
    {
        public int Damage { get; set; }
        public string Name { get; set; }

        protected Move(int damage,string name)
        {
            Damage = damage;
            Name = name;
        }

        public void Attack(Fighter defendant)
        {
            defendant.Health -= Damage;
        }
    }

    class PunchMove:Move
    {
        public PunchMove() : base(5, "Punch")
        {
        }
    }

    class KickMove:Move
    {
        public KickMove() : base(7, "Kick")
        {
        }
    }
}
