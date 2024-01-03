using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Model.Base
{
    public abstract class PackAnimal : Animal
    {
        public PackAnimal(string name, DateTime birthday, ViewAnimal viewAnimal) : base(name, birthday, TypeAnimal.PACKANIMAL, viewAnimal)
        {
            base.AddCommand("Кушать", "Идет кушать.");
            base.AddCommand("Вперед", "Начинает движение.");
            base.AddCommand("Пить", "Начинает пить воду.");
        }
    }
}
