namespace GameAchievementTracker.WebAPI.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string GameName { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public double HoursPlayed { get; set; }

        public int AchievementsEarned { get; set; }

        public int TotalAchievements { get; set; }

        public bool IsCompleted { get; set; }
    }
}