using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_eliza.Classes
{
    public class Author
    {
        public int Id { get; set; }

        public string FIO { get; set; }
        public Author(int Id, string FIO)
        {
            this.Id = Id;
            this.FIO = FIO;
        }
        public static List<Author> AllAuthor()
        {
            // Создаём список
            List<Author> allAuthor = new List<Author>();
            // Заполняем список
            allAuthor.Add(new Author(1, "Виктор Пелевин"));
            allAuthor.Add(new Author(2, "Александра Маринина"));
            allAuthor.Add(new Author(3, "Ольга Герр"));
            // Возвращаем список
            return allAuthor;
        }
    }
}
