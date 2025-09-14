using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class Match
    {
        public DateTime MatchDate { get; set; }
        public Team  TeamOne { get; set; }
        public Team TeamTwo { get; set; }

        public  string ScoreLine 
        {
            get
            {
                return $"{TeamOne.ScoreString} to {TeamTwo.ScoreString}";
            }
        }
    }
}
