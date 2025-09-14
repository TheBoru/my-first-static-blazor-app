using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlazorApp.Shared
{
    public class Player
    {
        public string Name { get; set; }

        public int TotalPointScored 
        { 
            get
            {
                return ((GoalsScored * 3) + PointsScored);
            }
        }
        public int GoalsScored { get; set; }
        public int PointsScored { get; set; }
        public string ScoreString
        {
            get
            {
                string goals, points;

                if (GoalsScored <= 9)
                {
                    goals = $"0{GoalsScored}";
                }
                else
                {
                    goals = GoalsScored.ToString();
                }

                if (PointsScored <= 9)
                {
                    points = $"0{PointsScored}";
                }
                else
                {
                    points = PointsScored.ToString();
                }

                return $"{goals}:{points}";
            }
        }


    }
}
