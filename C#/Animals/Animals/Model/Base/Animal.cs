using System.Text;

namespace Animals.Model.Base
{/// <summary>
/// Родительский класс животных
/// </summary>
    public abstract class Animal
    {
        private static int _counter; //счетчик
        private int _id; //id животного
        private string _name; //название животного
        private DateTime _birthday; //дата рождения
        private Dictionary<string, string> animalCommands = new(); //создание новой коллекции команд
        private TypeAnimal _typeAnimal; //тип животного
        private ViewAnimal _viewAnimal; //вид животного

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя животного</param>
        /// <param name="birthday">Дата рождения</param>
        /// <param name="typeAnimal">Тип</param>
        /// <param name="viewAnimal">Вид</param>
        public Animal(string name, DateTime birthday, TypeAnimal typeAnimal, ViewAnimal viewAnimal)
        {
            _id = ++_counter;
            _name = name;
            _birthday = birthday;
            _typeAnimal = typeAnimal;
            _viewAnimal = viewAnimal;
        } 

        /// <summary>
        /// Возвращение колекции команд животного
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string>GetCommands() => animalCommands;

        /// <summary>
        /// Добавление новой команды животному
        /// </summary>
        /// <param name="command"></param>
        /// <param name="aboutCommand"></param>
        public void AddCommand(string command, string aboutCommand)
        {
            animalCommands.Add(command, aboutCommand);
        } 

        /// <summary>
        /// Вывод команд животного
        /// </summary>
        /// <returns></returns>
        public StringBuilder PrintCommand()
        {
            var sb = new StringBuilder();
            int counter = 0;
            foreach (var command in GetCommands())
            {
                sb.Append($"{++counter}. Команда: \"{command.Key}\" ==> {command.Value}\n");
            }
            return sb;
        }

        public int GetId() => _id;

        public override string ToString() => $"Id:{_id} | Имя:{_name} | Тип животного:{_typeAnimal} | Вид животного:{_viewAnimal} | Дата рождения:{_birthday.ToShortDateString()}.\n{PrintCommand()}";
    }
}
