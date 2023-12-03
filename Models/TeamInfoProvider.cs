namespace _4Ballers.Models
{
    public class TeamInfoProvider
    {
        private List<TeamInfo> _teams;

        public TeamInfoProvider()
        {
            _teams = new List<TeamInfo>
        {
            new TeamInfo
            {
                TeamId = 1,
                Name = "Team 1",
                Nickname = "Nickname 1",
                Mascot = "Mascot 1",
                Founded = DateTime.Parse("2000-01-01"),
                Arena = "Arena 1",
                Coach = "Coach 1",
                Championships = 5
            },
            new TeamInfo
            {
                TeamId = 2,
                Name = "Team 2",
                Nickname = "Nickname 2",
                Mascot = "Mascot 2",
                Founded = DateTime.Parse("2005-01-01"),
                Arena = "Arena 2",
                Coach = "Coach 2",
                Championships = 3
            },
            // Dodaj informacje dla pozostałych drużyn
        };
            // Ustaw ścieżki do obrazów dla każdej drużyny
            _teams[0].TeamImageUrl = "/images/76court.jpg";
            _teams[1].TeamImageUrl = "/images/Team2Logo.jpg";
            // Ustaw ścieżki dla pozostałych drużyn
        }

        public TeamInfo GetTeamInfo(int teamId)
        {
            return _teams.FirstOrDefault(t => t.TeamId == teamId);
        }
    }

}
