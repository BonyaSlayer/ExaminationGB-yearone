using Animals.Model.Base;

namespace Animals.Service
{
    internal interface IAnimal
    {
        /// <summary>
        /// Метод создает конкретного животного
        /// </summary>
        /// <param name="name">Имя животного</param>
        /// <param name="date">Дата рождения животного</param>
        /// <param name="animal">Вид животного</param>
        /// <returns></returns>
        public Animal CreateAnimal(string name, DateTime date, int animal);
        public void AddCommandAnimal(Animal animal, string command, string aboutCommand);
    }
}
