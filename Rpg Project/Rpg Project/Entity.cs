using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Project.CHaracterClasses
{
    public enum EntityGender { Male, Female, Unknown };
    public enum EntityClass { Warrior, Rogue, Cleric, Mage, Unknown };
    
    public abstract class Entity
    {
        #region Fields

        protected string _name;
        protected EntityGender _gender;
        protected EntityClass _characterClass;
        protected int _str;
        protected int _dex;
        protected int _wis;
        protected int _int;
        protected int _strMod;
        protected int _dexMod;
        protected int _wisMod;
        protected int _intMod;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public EntityGender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public EntityClass CharacterClass
        {
            get { return _characterClass; }
            set { _characterClass = value; }
        }
        public int Strength
        {
            get { return _str + _strMod; }
            set { _str = value; }
        }
        public int Dexterity
        {
            get { return _dex + _dexMod; }
            set { _dex = value; }
        }
        public int Wisdom
        {
            get { return _wis + _wisMod; }
            set { _wis = value; }
        }
        public int Intelligence
        {
            get { return _int + _intMod; }
            set { _int = value; }
        }

        #endregion

        #region Constructors

        public Entity()
        {
            //Set initial values
            Name = "";
            Gender = EntityGender.Unknown;
            CharacterClass = EntityClass.Unknown;
            _str = 0;
            _dex = 0;
            _wis = 0;
            _int = 0;
        }

        #endregion

        #region Methods

        #endregion
    }
}
