namespace dotNetSouthDev.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
    public static IEnumerable<ReadOnlyMemory<char>> Lines(this string text)
    {
        var textMemory = text.AsMemory();
        var lineStartIndex = 0;
        var currentIndex = 0;

        while (currentIndex < text.Length)
        {
            if (text[currentIndex] == '\n')
            {
                yield return textMemory.Slice(lineStartIndex, currentIndex - lineStartIndex);

                lineStartIndex = currentIndex + 1;

                currentIndex++;

                continue;
            }

            if (text[currentIndex] == '\r')
            {
                if (currentIndex + 1 < text.Length && text[currentIndex + 1] == '\n')
                {
                    yield return textMemory.Slice(lineStartIndex, currentIndex - lineStartIndex);

                    lineStartIndex = currentIndex + 2;

                    currentIndex += 2;

                    continue;
                }
            }

            if (currentIndex == text.Length - 1)
                yield return textMemory.Slice(lineStartIndex);

            currentIndex++;
        }
    }
}