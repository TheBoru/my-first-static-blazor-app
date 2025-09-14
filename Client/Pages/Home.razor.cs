using BlazorApp.Shared;

namespace BlazorApp.Client.Pages
{
    partial class Home
    {
        Team Team1 = new();
        Team Team2 = new();

        Match Match = new();

        string? team1name, team2name;
        
        private void SetTeamNames(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
        {
            Match.TeamOne = Team1;
            Match.TeamTwo = Team2;

            team1name = Match.TeamOne.Name;

            team2name = Match.TeamTwo.Name;

        }
    }
}
