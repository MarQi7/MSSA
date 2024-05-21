using PyDungeon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace PyDungeon
{
    //abstract classes are used for heirarchy as a base template. Cannot be instantiated.
    internal abstract class Character
    {
        //init
        private string name; // set when called from list/input
        public string Name { get { return name; } }

        private int type; //set when called from list/input
        public string Type
        {
            get
            {
                switch (type)
                {

                    case 1:
                        return "Hero";
                    case 2:
                        return "Monster";
                    case 3:
                        return "Boss";
                    default:
                        return null;
                }
            }
        }

        private int charClass;
        public string CharClass
        {
            get
            {
                switch (charClass)
                {

                    case 1:
                        return "Elf";
                    case 2:
                        return "Knight";
                    case 3:
                        return "Assassin";
                    case 4:
                        return "Mage";
                    case 5:
                        return "Troll";
                    case 6:
                        return "Orc";
                    case 7:
                        return "WingBeast";
                    case 8:
                        return "Goblin";
                    case 9:
                        return "Demon";
                    case 10:
                        return "Vampire";
                    case 11:
                        return "Werewolf";
                    case 12:
                        return "Acolyte";
                    default:
                        return null;
                }
            }
        }
        
        private int maxHealth; //starting health decided in -> type -> class (base + modifier)
        public int MaxHealth {  get { return maxHealth; } }
        public int CurrentHealth { get; set; }
     
        private int attack;  //starting attack decided in -> type -> class (base + modifier)
        public int Attack { get { return attack; } }

        private int magicAttack;  //starting magic attack decided in -> type -> class (base + modifier)
        public int MagicMagicAttack { get {  return magicAttack; } }
        
        private int defense;
        public int Defense { get { return defense; } }
        
        public Random Roll = new Random();
        ///overload names attribute
        ///class overload option?
        ///health, atk, magAtk
        ///
        private bool created = false;

        public virtual void Update(string name, int type, int charClass, int maxHealth, int attack, int magAttack, int defense)
        {
            if (created == false)
                this.name = name;
                this.type = type;
                this.charClass = charClass;
                this.maxHealth = maxHealth;
                this.attack = attack;
                this.magicAttack = magAttack;
                this.defense = defense;
                created = true;
        }

    }
    abstract class Hero : Character
    {

        public object Elf()
        {

        }
        public object Knight()
        {

        }
        public object Assassin()
        {

        }
        public object Mage()
        {

        }
        //class attribute file to generate 
        //import names
        //status, weapon, armor, title
    }
    abstract class Monster : Character
    {
        public object Orc()
        {

        }
        public object Troll()
        {

        }
        public object Wingbeast()
        {

        }
        public object Goblin()
        {

        }
    }
    abstract class Boss : Character
    {
        public object Demon()
        {

        }
        public object Vampire()
        {

        }
        public object Werewolf()
        {

        }
        public object Acolyte()
        {

        }
    }


    /// <summary>
    /// create a method that calculates attack based on each classes attack style
    /// add in any other bonus calculations for defense when attacked... ex. 
    /// damage/hit = enemy.def() - char.atk() 
    /// enemy.health = enemy.health - damage/hit
    /// </summary>
    /*
    class Elf : Hero
    {
        public void Update()
        {
            
        }
    }
    class Knight : Hero
    {
        public void Update()
        {
            
        }
    }
    class Assassin : Hero
    {
        public void Update()
        {
                
        }
    }
    class Mage : Hero
    {
        public void Update()
        {
                
        }
    }
    class Orc : Monster
    {
        public void Update()
        {
                
        }
    }
    class Troll : Monster
    {
        public void Update()
        {
                
        }
    }
    class WingBeast : Monster
    {
        public void Update()
        {
                
        }
    }
    class Goblin : Monster
    {
        public void Update()
        {
                
        }
    }
    class Demon : Boss
    {
        public void Update()
        {
               
        }
    }
    class Vamipire : Boss
    {
        public void Update()
        {
               
        }
    }
    class Werewolf : Boss
    {
        public void Update()
        {
                
        }
    }
    class Acolyte : Boss
    {
        public void Update()
        {
                
        }
    }
    */
}
