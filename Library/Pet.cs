using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Pet
    {
        public Player Player { get; set; }
        public typePet PetType { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public int Poop { get; set; }
        public DateTime Date { get; set; }

        public Pet()
        {
            this.Init();
        }

        public Pet(Player player, typePet petType, string name, int age, int food, int poop, DateTime date)
        {
            Player = player;
            PetType = petType;
            Name = name;
            Age = age;
            Food = food;
            Poop = poop;
            Date = date;
        }

        private void Init()
        {
            Player = new Player();
            PetType = typePet.data;
            Name = string.Empty;
            Age = 0;
            Food = 0;
            Poop = 0;
            Date = new DateTime(1990,01,01);
        }

        public string tengoHambre()
        {
            string hambre = "";
            if (Food < 2)
            {
                hambre = " porfavor dame comida :c";
            }
            else
            {
                hambre = " guatita llena corazon contento :3";
            }
            return hambre;
        }

        // cuando esta a punto hacerse popo
        public string poopIncoming()
        {
            string poops = "";
            if (Poop <= 0)
            {
                poops = " necesito baño :c";
            }
            else
            {
                poops = "  estoy bien c:";
            }
            return poops;
        }
    }
}
