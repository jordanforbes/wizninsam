using System;

namespace wizardninjasamurai.Models {
    class Wizard : Human {
        public Wizard (string name) : base (name) {
            SetHealth (50);
            Intelligence = 25;
        }

        public override int Attack (Human target) {
            Random rand = new Random ();
            int dmg = Dexterity * 5;
            // Console.WriteLine (Intelligence);
            int currentHp = Health;
            int enemyHp = target.Health;
            SetHealth (currentHp + dmg);
            target.SetHealth (enemyHp -= dmg);
            Console.WriteLine ($"{Name} casts fireball at {target.Name} for {dmg} Damage\n{Name} heals himself for {dmg} HP");
            return target.Health;
        }

        public void Heal (Human target) {
            int targetHp = target.Health;
            int healFor = 10 * Intelligence;
            targetHp += healFor;
            target.SetHealth (targetHp);
            Console.WriteLine ($"{Name} heals {target.Name} for {healFor} HP!\n{target.Name} is now {target.Health}");

        }
    }
}