using System.Text;
using TestStack.BDDfy;

namespace GildedRose.Host.AcceptanceSpecs.Characterisation.UpdateQuality;

internal class ThirtyDays
{
    private StringBuilder _output;

    internal void GivenInputAndOutputAccess()
    {
        Console.SetIn(new StringReader($"a"));

        _output = new StringBuilder();
        Console.SetOut(new StringWriter(_output));
    }

    internal void WhenTheProgramIsRun()
    {
        Program.Main(["30"]);
    }

    internal Task ThenTheOutputIsAsExpected()
    {
        return Verify(_output.ToString());
    }

    [Test]
    public void RunTest()
    {
        this.BDDfy();
    }
}