using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> Database = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                try
                {
                    List<string> line = Console.ReadLine().Split(';').ToList();
                    var len = line[2].Split(':').Select(int.Parse).ToArray();
                    Database.Add(new Song(line[0], line[1], len[0], len[1]));
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Songs added: " + Database.Count);
            int summins=0;
            int sumsecs = 0;
            Database.ForEach(p => { summins += p.Minutes; sumsecs += p.Seconds; });
            summins += sumsecs / 60;
            Console.WriteLine("Playlist length: {0}h {1}m {2}s", summins/60, summins%60, sumsecs%60);
        }
    }
}
