using LexEngine.Tokens;

namespace LexEngine.Scanning;

public class ScanModuloStrategy : ScanningStrategy
{
    public Token Scan(string code, int current, int line, int lineIndex)
    {
        return new Token
        {
            StartIndex = current, EndIndex = current, StartLine = line, StartLineIndex = lineIndex,
            EndLineIndex = lineIndex, Type = TokenType.MODULO, Label = "%"
        };
    }
}