namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities
{
    public class Knight: Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }
    } 
}