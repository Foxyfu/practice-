namespace task4
{
    using System;
    using System.Collections;

    class MusicCatalog
    {
        Hashtable disks = new Hashtable();

        public void AddDisk(string diskName)
        {
            disks[diskName] = new ArrayList();
        }

        public void RemoveDisk(string diskName)
        {
            disks.Remove(diskName);
        }

        public void AddSong(string diskName, string songName)
        {
            ArrayList songs = (ArrayList)disks[diskName];
            if (songs == null)
            {
                songs = new ArrayList();
                disks[diskName] = songs;
            }
            songs.Add(songName);
        }

        public void RemoveSong(string diskName, string songName)
        {
            ArrayList songs = (ArrayList)disks[diskName];
            if (songs != null)
            {
                songs.Remove(songName);
            }
        }

        public void PrintCatalog()
        {
            Console.WriteLine("Music Catalog:");
            foreach (string diskName in disks.Keys)
            {
                Console.WriteLine($"- {diskName}:");
                ArrayList songs = (ArrayList)disks[diskName];
                foreach (string songName in songs)
                {
                    Console.WriteLine($"  - {songName}");
                }
            }
        }

        public void PrintDisk(string diskName)
        {
            Console.WriteLine($"Disk {diskName}:");
            ArrayList songs = (ArrayList)disks[diskName];
            if (songs != null)
            {
                foreach (string songName in songs)
                {
                    Console.WriteLine($"- {songName}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MusicCatalog catalog = new MusicCatalog();

            // Добавление дисков и песен
            catalog.AddDisk("Rock Hits");
            catalog.AddSong("Rock Hits", "Stairway to Heaven");
            catalog.AddSong("Rock Hits", "Bohemian Rhapsody");
            catalog.AddSong("Rock Hits", "Hotel California");

            catalog.AddDisk("Pop Favorites");
            catalog.AddSong("Pop Favorites", "Shape of You");
            catalog.AddSong("Pop Favorites", "Believer");
            catalog.AddSong("Pop Favorites", "Love Yourself");

            // Вывод каталога на экран
            catalog.PrintCatalog();

            // Вывод содержимого диска на экран
            catalog.PrintDisk("Rock Hits");

            // Удаление песни и диска
            catalog.RemoveSong("Rock Hits", "Bohemian Rhapsody");
            catalog.RemoveDisk("Pop Favorites");

            // Вывод каталога на экран после удаления
            catalog.PrintCatalog();
        }
    }

}