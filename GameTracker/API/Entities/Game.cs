using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracker.API.Entities
{

    public class Game
    {
        public enum RatingCategory
        {
            Unrated,
            OverwhelminglyPostitive,
            VeryPostitive,
            Positive,
            MostlyPositive,
            Mixed,
            MostlyNegative,
            Negative,
            VeryNegative,
            OverwhelminglyNegative
        }
        public int Id { get; set; }
        public string Name { get; set; } = "Unnamed";
        public string ExePath { get; set; } = "No Exe Path";
        public bool Downloaded { get; set; }
        public float PlayTime { get; set; }
        public bool Multiplayer { get; set; }
        public bool Singleplayer { get; set; }
        public DateTime? LastPlayed { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public DateOnly? LatestUpdate { get; set; }
        public DateOnly BoughtDate { get; set; }
        public float DownloadSizeMB { get; set; }
        public int? Achievements { get; set; }
        public int? CompletedAchievement { get; set; }
        public RatingCategory Rating { get; set; }
        public bool VR { get; set; }
        public bool Controller { get; set; }
        public bool MK { get; set; }
    }
}
