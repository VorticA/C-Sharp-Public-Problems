﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public string Artist
        {
            get
            {
                return this.artist;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20) throw new InvalidArtistNameException("Artist name should be betweem 3 and 20 symbols.");
                this.artist = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30) throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
                this.name = value;
            }
        }
        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
                if (value < 0 || value > 14) throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
                this.minutes=value;
            }
        }
        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value < 0 || value > 59) throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
                this.seconds = value;
            }
        }

        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}
