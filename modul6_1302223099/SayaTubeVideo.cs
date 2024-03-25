﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223099
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            var rand = new Random();
            Debug.Assert(title.Length < 200 && title != null, "Judul terlalu panjang atau kosong");
            this.title = title;
            id = rand.Next(10000, 99999);
            playCount = 0;
        }
        public void IncreasePlayCount(int play)
        {
            Debug.Assert(play < 25000000 && play > 0, "PlayCount terlalu banyak atau negatif");
            try
            {
                checked
                {
                    playCount += play;

                }
            } catch (OverflowException e) 
            {
                Console.WriteLine("Terjadi oveflow " + e.Message);
            }
        }
        public string GetTitle()
        {
            return title;
        }
        public int GetPlayCount()
        {
            return playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
        }
    }
}
