using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практика_14_Фильмотека
{
    public abstract class Filmoteka
    {
        string name;
        string production;
        TimeSpan time;
        string genre;
        
        public Filmoteka(string name, string production, TimeSpan time, string genre)
        {
            this.name = name;
            this.production = production;
            this.time = time;
            this.genre = genre;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Production { get; set; }
        public string Time { get; set; }
        public string Genre { get; set; }

        public abstract string info();
    }
    public  class TVshow : Filmoteka
    {
        int count;
        public TVshow(string name, string production, TimeSpan time, string genre, int count) : base (name, production, time,  genre)
        {
            this.count = count;
        }
        public override string info()
        {
            return $"название:  {Name}, производство: {Production}, время: {Time}, жанр: {Genre}, количество серий:{count}";
        }

    }
    class FeatureFilm : Filmoteka
    {
        DateTime yearOfIssue;
        bool color;
        public FeatureFilm(string name, string production, TimeSpan time, string genre, DateTime yearOfIssue, bool color) : base (name, production, time, genre)
        {

        }
        public override string info()
        {
            return "";
        }
    }
}
