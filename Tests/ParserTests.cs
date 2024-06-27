using Infrastructure.Suits;
using FluentAssertions;

namespace Tests;

public class ParserTests
{
    [Fact]
    public void Parse_Should_Return_Four_Suits()
    {
        var sut = SuitParser.Parse();

        sut.Count().Should().Be(4);

    }
}