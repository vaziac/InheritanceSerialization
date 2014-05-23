using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Project.CHaracterClasses
{
    public class Player: Entity
    {
        Random rand = new Random();
        public Player()
            : base()
        {
        }
        public Player(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
        }
        public Player(string name, EntityGender eGender, EntityClass eClass, int estr, int edex, int ewis, int eint)
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            Strength = estr;
            Dexterity = edex;
            Wisdom = ewis;
            Intelligence = eint;
        }
    }
}
