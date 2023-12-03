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
                Name = "Philadelphia 76ers",
                Nickname = "Sixers",
                Mascot = "Franklin",
                Founded = DateTime.Parse("1946-06-06"),
                Arena = "Wells Fargo Center",
                Coach = "Nick Nurse",
                Championships = 3
            },
            new TeamInfo
            {
                TeamId = 2,
                Name = "Boston Celtics",
                Nickname = "Celtowie (Celts)",
                Mascot = "Lucky the Leprechaun",
                Founded = DateTime.Parse("1946-06-06"),
                Arena = "TD Garden",
                Coach = "Joe Mazzulla",
                Championships = 17
            },
            new TeamInfo
            {
                TeamId = 3,
                Name = "Brooklyn Nets",
                Nickname = "Siatki (Nets)",
                Mascot = "Sily the Silver Fox",
                Founded = DateTime.Parse("1967-04-01"),
                Arena = "Barclays Center",
                Coach = "Jacque Vaughn",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 4,
                Name = "New York Knicks",
                Nickname = "Knicks",
                Mascot = "The Blue Crew Chief",
                Founded = DateTime.Parse("1946-06-06"),
                Arena = "Madison Square Garden",
                Coach = "Tom Thibodeau",
                Championships = 2
            },
            new TeamInfo
            {
                TeamId = 5,
                Name = "Toronto Raptors",
                Nickname = "Dinozaury (Raptors)",
                Mascot = "Raptor",
                Founded = DateTime.Parse("1995-05-30"),
                Arena = "Scotiabank Arena",
                Coach = "Darko Rajaković",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 6,
                Name = "Chicago Bulls",
                Nickname = "Byki (Bulls)",
                Mascot = "Benny the Bull",
                Founded = DateTime.Parse("1966-01-16"),
                Arena = "United Center",
                Coach = "Michael Reinsdorf",
                Championships = 6
            },
            new TeamInfo
            {
                TeamId = 7,
                Name = "Cleavland Cavaliers",
                Nickname = "Kawalerzyści (Cavs)",
                Mascot = "Moondog, Mr Cavalier",
                Founded = DateTime.Parse("1970-06-04"),
                Arena = "Quicken Loans Arena",
                Coach = "J.B. Bickerstaff",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 8,
                Name = "Detroit Pistons",
                Nickname = "Tłoki ",
                Mascot = "Hooper",
                Founded = DateTime.Parse("1941-11-01"),
                Arena = "Little Caesars Arena",
                Coach = "Monty Williams",
                Championships = 3
            },
            new TeamInfo
            {
                TeamId = 9,
                Name = "Indiana Pacers",
                Nickname = "Pacers",
                Mascot = "Boomer, Bowser",
                Founded = DateTime.Parse("1967-01-27"),
                Arena = "Bankers Life Fieldhouse",
                Coach = "Rick Carlisle",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 10,
                Name = "Milwaukee Bucks",
                Nickname = "Jelenie (Bucks)",
                Mascot = "Bango",
                Founded = DateTime.Parse("1968-01-22"),
                Arena = "Fiserv Forum",
                Coach = "Adrian Griffin",
                Championships = 2
            },
            new TeamInfo
            {
                TeamId = 11,
                Name = "Atlanta Hawks",
                Nickname = "Jastrzębie (Hawks)",
                Mascot = "Skyhawk,Harry the Hawk",
                Founded = DateTime.Parse("1968-06-30"),
                Arena = "State Farm Arena",
                Coach = "Quin Snyder",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 12,
                Name = "Charlote Hornets",
                Nickname = "Szerszenie (Hornets)",
                Mascot = "Hugo",
                Founded = DateTime.Parse("1988-04-14"),
                Arena = "Spectrum Center",
                Coach = "Steve Clifford",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 13,
                Name = "Miami Heat",
                Nickname = " Żar (Heat)",
                Mascot = "Burnie",
                Founded = DateTime.Parse("1988-04-22"),
                Arena = "Centrum Kaseya",
                Coach = "Erik Spoelstra",
                Championships = 3
            },
            new TeamInfo
            {
                TeamId = 14,
                Name = "Orlando Magic",
                Nickname = "Magicy (Magics)",
                Mascot = "Stuff",
                Founded = DateTime.Parse("1987-05-22"),
                Arena = "Amway Center",
                Coach = "Steve Clifford",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 15,
                Name = "Washington Wizards",
                Nickname = "Czerodzieje (Wizards)",
                Mascot = "G-Wiz",
                Founded = DateTime.Parse("1961-06-02"),
                Arena = "Capital One Arena",
                Coach = "Scott Brooks",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 16,
                Name = "Denver Nuggets",
                Nickname = "Samorodki (Nuggets)",
                Mascot = "Rocky",
                Founded = DateTime.Parse("1967-12-27"),
                Arena = "Ball Arena",
                Coach = "Michael Malone",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 17,
                Name = "Minnesota Timberwolves",
                Nickname = "Timberwolves",
                Mascot = "Crunch",
                Founded = DateTime.Parse("1989-03-22"),
                Arena = "Target Center",
                Coach = "Chris Finch",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 18,
                Name = "Oklahoma City Thunder",
                Nickname = "Grzmoty (Thunders)",
                Mascot = "Bizon Rumble",
                Founded = DateTime.Parse("2008-07-02"),
                Arena = "Chesapeake Energy Arena",
                Coach = "Mark Daigneault",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 19,
                Name = "Portland Trail Blazers",
                Nickname = "Blazers",
                Mascot = "Blaze",
                Founded = DateTime.Parse("1970-02-11"),
                Arena = "Moda Center",
                Coach = "Terry Stotts",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 20,
                Name = "Utah Jazz",
                Nickname = "Nutki (Jazzmans)",
                Mascot = "Bear",
                Founded = DateTime.Parse("1974-06-07"),
                Arena = "Vivint Smart Home Arena",
                Coach = "Quin Snyder",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 21,
                Name = "Golden State Warriors",
                Nickname = "Wojownicy (Warriors)",
                Mascot = "Thunder",
                Founded = DateTime.Parse("1946-06-06"),
                Arena = "Chase Center",
                Coach = "Steve Kerr",
                Championships = 7
            },
            new TeamInfo
            {
                TeamId = 22,
                Name = "Los Angeles Clippers",
                Nickname = "Lob City",
                Mascot = "Brak",
                Founded = DateTime.Parse("1970-06-03"),
                Arena = "Crypto.com Arena",
                Coach = "Tyronn Lue",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 23,
                Name = "Los Angeles Lakers",
                Nickname = "Jeziorowcy (Lakers)",
                Mascot = "Brak",
                Founded = DateTime.Parse("1947-02-01"),
                Arena = "Staples Center",
                Coach = "Darvin Ham",
                Championships = 17
            },
            new TeamInfo
            {
                TeamId = 24,
                Name = "Pheonix Suns",
                Nickname = "Słońca (Suns)",
                Mascot = "Go the Gorilla",
                Founded = DateTime.Parse("1968-12-22"),
                Arena = "Footprint Center",
                Coach = "Frank Vogel",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 25,
                Name = "Sacramento Kings",
                Nickname = "Królowie (Kings)",
                Mascot = "Slamson",
                Founded = DateTime.Parse("1946-02-24"),
                Arena = "Golden 1 Center",
                Coach = "Mike Brown",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 26,
                Name = "Dallas Mavericks",
                Nickname = "Mavs",
                Mascot = "Champ",
                Founded = DateTime.Parse("1980-02-01"),
                Arena = "American Airlines Center",
                Coach = "Jason Kidd",
                Championships = 1
            },
            new TeamInfo
            {
                TeamId = 27,
                Name = "Houston Rockets",
                Nickname = "Rakiety (Rockets)",
                Mascot = "Clutch",
                Founded = DateTime.Parse("1967-06-30"),
                Arena = "Toyota Center",
                Coach = "Ime Udoka",
                Championships = 2
            },
            new TeamInfo
            {
                TeamId = 28,
                Name = "Memphis Grizzlies",
                Nickname = "Niedźwiadki (Grizzlies)",
                Mascot = "Grizz",
                Founded = DateTime.Parse("1995-04-04"),
                Arena = "FedEx Forum",
                Coach = "J.B. Bickerstaff",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 29,
                Name = "New Orleans Pelicans",
                Nickname = "Pelikany (Pelicans)",
                Mascot = "Pierre the Pelican",
                Founded = DateTime.Parse("2013-04-18"),
                Arena = "Smoothie King Center",
                Coach = "Stan Van Gundy",
                Championships = 0
            },
            new TeamInfo
            {
                TeamId = 30,
                Name = "San Antonio Spurs",
                Nickname = "Ostrogi (Spurs)",
                Mascot = "The Coyote",
                Founded = DateTime.Parse("1967-10-10"),
                Arena = "Frost Bank Center",
                Coach = "Gregg Popovich",
                Championships = 5
            },
            // Dodaj informacje dla pozostałych drużyn
        };
            // Ustaw ścieżki do obrazów dla każdej drużyny
            _teams[0].TeamImageUrl = "/images/76court.jpg";
            _teams[1].TeamImageUrl = "/images/BostonCourt.jpg";
            _teams[2].TeamImageUrl = "/images/BrooklynCourt.jpg";
            _teams[3].TeamImageUrl = "/images/Nykcourt.jpg";
            _teams[4].TeamImageUrl = "/images/Torontocourt.jpg";
            _teams[5].TeamImageUrl = "/images/BullsCourt.jpg";
            _teams[6].TeamImageUrl = "/images/CavsCourt.jpg";
            _teams[7].TeamImageUrl = "/images/DetroitCourt.jpg";
            _teams[8].TeamImageUrl = "/images/PacersCourt.jpg";
            _teams[9].TeamImageUrl = "/images/MillCourt.jpg";
            _teams[10].TeamImageUrl = "/images/AtlCourt.jpg";
            _teams[11].TeamImageUrl = "/images/HornetCourt.jpg";
            _teams[12].TeamImageUrl = "/images/HeatCourt.jpg";
            _teams[13].TeamImageUrl = "/images/MagicCourt.jpg";
            _teams[14].TeamImageUrl = "/images/WizCourt.jpg";
            _teams[15].TeamImageUrl = "/images/DenvCourt.jpg";
            _teams[16].TeamImageUrl = "/images/TimberCourt.jpg";
            _teams[17].TeamImageUrl = "/images/OKCCourt.jpg";
            _teams[18].TeamImageUrl = "/images/BlazersCourt.jpg";
            _teams[19].TeamImageUrl = "/images/JazzCourt.jpg";
            _teams[20].TeamImageUrl = "/images/GSWCourt.jpg";
            _teams[21].TeamImageUrl = "/images/LACCourt.jpg";
            _teams[22].TeamImageUrl = "/images/LALCourt.jpg";
            _teams[23].TeamImageUrl = "/images/SunsCourt.jpg";
            _teams[24].TeamImageUrl = "/images/KingsCourt.jpg";
            _teams[25].TeamImageUrl = "/images/MavsCourt.jpg";
            _teams[26].TeamImageUrl = "/images/HustonCourt.jpg";
            _teams[27].TeamImageUrl = "/images/GrizllyCourt.jpg";
            _teams[28].TeamImageUrl = "/images/PelicanCourt.jpg";
            _teams[29].TeamImageUrl = "/images/SpursCourt.jpg";
            // Ustaw ścieżki dla pozostałych drużyn
        }

        public TeamInfo GetTeamInfo(int teamId)
        {
            return _teams.FirstOrDefault(t => t.TeamId == teamId);
        }
    }

}
