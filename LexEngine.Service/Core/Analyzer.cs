namespace LexEngine.Service.Core;

public interface Analyzer
{
    List<LexicalToken> AnalyzeCode(string code);
}