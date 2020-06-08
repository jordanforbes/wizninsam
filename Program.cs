using System;

namespace wizardninjasamurai.Models {
    class Program {
        static void Main (string[] args) {
            Samurai S1 = new Samurai ("Jack");
            Wizard W1 = new Wizard ("Gandalf");
            Ninja N1 = new Ninja ("Naruto");
            Console.WriteLine (S1.Name);
            Console.WriteLine ("Health: " + S1.Health);
            Console.WriteLine (W1.Name);
            Console.WriteLine ("Health: " + W1.Health);
            Console.WriteLine ("Intelligence: " + W1.Intelligence);
            Console.WriteLine (N1.Name);
            Console.WriteLine ("Dexterity: " + N1.Dexterity);
            Console.WriteLine ("Health of Ninja: " + N1.Health);

            N1.Attack (W1);
            W1.Attack (N1);
            Console.WriteLine ("Health of Ninja: " + N1.Health);
            S1.Attack (N1);
            S1.Attack (N1);
            Console.WriteLine ("Health of Ninja: " + N1.Health);
            S1.Attack (N1);
            S1.Attack (N1);
            S1.Attack(N1);
            W1.Heal(N1);
            S1.Meditate();
            N1.Steal(S1);

        }
    }
}