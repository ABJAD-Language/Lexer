using ABJAD.LexEngine.Tokens;

namespace ABJAD.LexEngine.Scanning;

public class ScanDotStrategy : ScanningStrategy
{
    public Token Scan(string code, int current, int line, int lineIndex)
    {
        return new Token
        {
            StartIndex = current, EndIndex = current, StartLine = line, StartLineIndex = lineIndex,
            EndLineIndex = lineIndex, Type = TokenType.DOT, Label = "."
        };
    }
}