namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public string Name;
        public int Level;
        public string HeroType;
        public  int HP;
        public int MP;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Attack(){
            return this.Name + " Atacou com sua espara";
        }


    }
}