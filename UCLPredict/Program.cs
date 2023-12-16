var teams1 = new List<int>
{
    11,12,13,14,15,16,17,18
};

var teams2 = new List<int>
{
    21,22,23,24,25,26,27,28
};

var total = Compute(teams1, teams2);

Console.WriteLine(total);
Console.ReadKey();

static int Compute(List<int> teams1, List<int> teams2)
{
    var total = 0;

    if (teams1.Count == 0 && teams2.Count == 0) return 1;

    var team1 = teams1.First();
    var tmpTeams1 = teams1.Where(t => t != team1).ToList();

    foreach (var team2 in teams2)
    {
        if (team2 - team1 == 10) continue;
        if (team2 == 27 && (team1 == 11 || team1 == 16)) continue;

        var tmpTeams2 = teams2.Where(t => t != team2).ToList();
        total += Compute(tmpTeams1, tmpTeams2);
    }
    return total;
}