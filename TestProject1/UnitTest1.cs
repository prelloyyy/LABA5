namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int dota2 = 5;
        int b = 10;
        int c = dota2 + b - 1;
        Assert.Equal(14, c);
        int leagueoflegends = c * 2;
        Assert.Equal(28, leagueoflegends);
    }
}
