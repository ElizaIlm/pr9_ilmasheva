using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_eliza.Classes
{
    public class Genre
    {
        /// <summary> Код жанра
        /// </summary>
        public int Id { get; set; }
 
        public string Name { get; set; }
        public Genre(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public static List<Genre> AllGenres()
        {
            // Создаём список
            List<Genre> allGenres = new List<Genre>();
            // Заполняем список
            allGenres.Add(new Genre(1, "Современная русская литература"));
            allGenres.Add(new Genre(2, "Современные детективы"));
            allGenres.Add(new Genre(3, "Любовные фэнтези"));
            allGenres.Add(new Genre(4, "Попаданцы"));
            allGenres.Add(new Genre(5, "Юмористическое фэнтези"));
            // Возвращаем список
            return allGenres;
        }
    }
}
