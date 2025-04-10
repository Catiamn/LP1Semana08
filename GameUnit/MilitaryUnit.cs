using System.ComponentModel.Design.Serialization;

namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        //Cost é igual ao Attack power e HP
        public override float Cost =>  AttackPower + XP;

        //Health é igual à Health base + XP
        public override int Health { get => base.Health + XP; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }


        //incrementa o XP da própria unidade e aplica um dano igual a AttackPower na Health da unidade atacada (u)
        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower; 
            
        }

        public override string ToString()
        {
            return $"SettlerUnit: HP={Health} COST={Cost:f2} XP={XP} ";
        }
    }
}
