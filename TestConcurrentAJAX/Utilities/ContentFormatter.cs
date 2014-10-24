using System.Globalization;

namespace TestConcurrentAJAX.Utilities
{
    public class ContentFormatter
    {
        public static string FormatContent(int id, int delay)
        {
            return string.Format(
                "{0} ({1}ms)",
                id.ToString(CultureInfo.InvariantCulture).PadLeft(3),
                delay);
        }
    }
}