using System;

namespace wizardninjasamurai.Models {
    class Ninja : Human {
        public Ninja (string name) : base (name) {
            Dexterity = 175;
        }

        public override int Attack (Human target)
        {
            Random rand = new Random();
            int roll = rand.Next(0,5);
            int dmg = Dexterity * 5;
            if(roll == 1){
                dmg +=10;
            }
            // Console.WriteLine(Intelligence);
            // int currentHp = Health;
            int enemyHp = target.Health;
            // SetHealth(currentHp + dmg);
            target.SetHealth(enemyHp -= dmg);
            Console.WriteLine($"{Name} throws a shuriken at {target.Name} for {dmg} Damage");
            return target.Health;
        }
        public void Steal(Human target)
        {
            int targetHp = target.Health;
            int currentHp = Health;
            targetHp -=5;
            currentHp +=5;
            target.SetHealth(targetHp);
            SetHealth(currentHp);
            Console.WriteLine($"{Name} stole 5 health from {target.Name}\n{Name} recovered 5 hp, their HP is now {Health}");
        }
    }
}