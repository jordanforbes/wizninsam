using System;

namespace wizardninjasamurai.Models {
    class Samurai : Human {
        public Samurai (string name) : base (name) {
            this.SetHealth (200);
        }

        public override int Attack (Human target) {
            if(target.Health > 50)
            {
                base.Attack(target);
                return target.Health;
            }else{
                target.SetHealth(0);
                Console.WriteLine($"{Name} skewered {target.Name}, reducing their HP to {target.Health}");
                return target.Health;
            }
            // int roll = rand.Next (0, 5);
            // int dmg = Strength * 5;
            // if (roll == 1) {
            //     dmg += 10;
            // }
            // // Console.WriteLine(Intelligence);
            // // int currentHp = Health;
            // int enemyHp = target.Health;
            // // SetHealth(currentHp + dmg);
            // target.SetHealth (enemyHp -= dmg);
            // Console.WriteLine ($"{Name} throws a shuriken at {target.Name} for {dmg} Damage");
            // return target.Health;
            // Random rand = new Random ();
        }
        public void Meditate()
        {
            SetHealth(200);
            Console.WriteLine($"{Name} Meditated, recovering their health to {Health}");

        }
    }
}