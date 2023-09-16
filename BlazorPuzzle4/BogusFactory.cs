using BigAssembly;

namespace BlazorPuzzle4;

public class BogusFactory
{
    public BogusClass CreateInstance()
    {
        return new BogusClass();
    }
}