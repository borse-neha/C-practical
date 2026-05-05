using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 288. Program to demonstrate recommendation systems simulation
// Generated as a standalone sample file.
public class RecommendationSystem
{
    private Dictionary<string, List<string>> userPreferences = new Dictionary<string, List<string>>
    {
        { "user1", new List<string> { "book1", "book2" } }
    };

    public List<string> Recommend(string user)
    {
        if (userPreferences.ContainsKey(user))
        {
            return userPreferences[user];
        }
        return new List<string> { "default recommendation" };
    }
}

public class Problem288
{
    public static async Task Main()
    {
        RecommendationSystem rs = new RecommendationSystem();
        List<string> recs = rs.Recommend("user1");
        Console.WriteLine("Recommendations: " + string.Join(", ", recs));

        await Task.CompletedTask;
    }
}