using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> PlayerList { get; set; }
        public int TotalPointsScored
        {
            get
            {
                int totalpointsscored = 0;

                foreach (var player in PlayerList)
                {
                    totalpointsscored = totalpointsscored + player.TotalPointScored;
                }

                return totalpointsscored;
            }
        }

        public int GoalsScored
        {
            get
            {
                int goalsscored = 0;

                foreach (var player in PlayerList)
                {
                    goalsscored = goalsscored + player.GoalsScored;
                }

                return goalsscored;
            }
        }

        public int PointsScored
        {
            get
            {
                int pointsscored = 0;

                foreach (var player in PlayerList )
                {
                    pointsscored = pointsscored + player.GoalsScored;
                }

                return pointsscored;
            }
        }

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
