using LexEngine.Tokens;

namespace LexEngine.Scanning;

public class ScanCloseBraceStrategy : ScanningStrategy
{
    public Token Scan(string code, int current, int line, int lineIndex)
    {
        return new Token
        {
            StartIndex = current, EndIndex = current, StartLine = line, StartLineIndex = lineIndex,
            EndLineIndex = lineIndex, Type = TokenType.CLOSE_BRACE, Label = "}"
        };
    }
}