using Newtonsoft.Json;
using Questao2.Model;
using System;
using System.Net;

public class Program
{
    public static void Main()
    {
        string teamName = "Paris Saint-Germain";
        int year = 2013;
        int totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team "+ teamName +" scored "+ totalGoals.ToString() + " goals in "+ year);

        teamName = "Chelsea";
        year = 2014;
        totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
    }

    public static int getTotalScoredGoals(string team, int year)
    {
        string url = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team1={team}";
        WebClient webClient = new System.Net.WebClient();
        var json = webClient.DownloadString(url);
        
        TeamInfo teamInfo = JsonConvert.DeserializeObject<TeamInfo>(json);
        int gols = teamInfo.Data.Sum(x => x.Team1Goals);
        
        return gols;
    }

}