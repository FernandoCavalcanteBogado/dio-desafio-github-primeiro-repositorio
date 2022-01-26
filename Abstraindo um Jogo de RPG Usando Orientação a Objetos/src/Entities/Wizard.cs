namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }
            
        public override string Attack(){
        return this.Name + " Lançou Magia";
        }
        
        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou Magia Super efetiva com bonus de ataque de " + Bonus;
            }
            else{
                return this.Name + " Lançou Magia com força fraca com bonus de " + Bonus;
            }
        }
    } 
}