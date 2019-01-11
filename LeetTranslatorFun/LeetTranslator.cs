// Leet Translator - L33t Tr4nsl4t0r.
//
// Just for the fun.
//
using System.Text;
using System.Linq;
namespace Translator
{
  public static class Leet
  {
    /// <summary>
    /// Translate text to Leet - Extension methods for string class
    /// </summary>
    /// <param name="text">Orginal text</param>
    /// <param name="degree">Degree of translation (0 - 100%)</param>
    /// <returns>Leet translated text</returns>
    public static string ToLeet(this string text, int degree = 30)
    {
      return Translate(text, degree);
    }

    /// <summary>
    /// Translate text to Leet
    /// </summary>
    /// <param name="text">Orginal text</param>
    /// <param name="degree">Degree of translation (0 - 100%)</param>
    /// <returns>Leet translated text</returns>
    public static string Translate(string text, int degree = 30)
    {
      // Adjust degree between 0 - 100
      degree = degree >= 100 ? 100 : degree <= 0 ? 0 : degree;

      // No Leet Translator
      if (degree == 0)
        return text;

      // StringBuilder to store result.
      StringBuilder sb = new StringBuilder(text.Length);
      foreach (char c in text)
      {
        if (degree > 99)
        {
          int index = FindingCharDegree100.IndexOf(c);
          if (index < 0)
            sb.Append(c);
          else
            sb.Append(ReplacingCharDegree100[index]);
        }
        else if (degree > 80)
        {
          int index = FindingCharDegree81And99.IndexOf(c);
          if (index < 0)
            sb.Append(c);
          else
            sb.Append(ReplacingCharDegree81And99[index]);
        }
        else if (degree > 64)
        {
          int index = FindingCharDegree65And80.IndexOf(c);
          if (index < 0)
            sb.Append(c);
          else
            sb.Append(ReplacingCharDegree65And80[index]);
        }
        else if (degree > 48)
        {
          int index = FindingCharDegree49And64.IndexOf(c);
          if (index < 0)
            sb.Append(c);
          else
            sb.Append(ReplacingCharDegree49And64[index]);
        }
        else if (degree > 32)
        {
          int index = FindingCharDegree33And48.IndexOf(c);
          if (index < 0)
            sb.Append(c);
          else
            sb.Append(ReplacingCharDegree33And48[index]);
        }
        else if (degree > 16)
        {
          int index = FindingCharDegree16And32.IndexOf(c);
          if (index < 0)
            sb.Append(c);
          else
            sb.Append(ReplacingCharDegree16And32[index]);
        }
        else //if (degree > 0)
        {
          if (c == 'e' || c == 'E')
            sb.Append("3");
          else
            sb.Append(c);
        }
      }
      return sb.ToString(); // Return result.
    }

    #region Static string for finding and replacing - Credit to CP member Luc Pattyn for this great idea
    private static string FindingCharDegree16And32   = "aeioAEIO";
    private static string[] ReplacingCharDegree16And32 = {"4", "3", "1", "0", "4", "3", "1", "0"};

    private static string FindingCharDegree33And48   = FindingCharDegree16And32 + "sSlLcCyYuUdD";
    private static string[] ReplacingCharDegree33And48 = ReplacingCharDegree16And32.Concat(new string[] { "$", "$", "£", "£", "(", "(", "¥", "¥", "µ", "µ", "Ð", "Ð" }).ToArray();

    private static string FindingCharDegree49And64 = FindingCharDegree33And48 + "kKgGtTzZfF";
    private static string[] ReplacingCharDegree49And64 = ReplacingCharDegree33And48.Concat(new string[] { "|{", "|{", "9", "9", "7", "7", "2", "2", "ƒ", "ƒ" }).ToArray();

    private static string FindingCharDegree65And80 = FindingCharDegree49And64 + "yYnNwWhHvVmM";
    private static string[] ReplacingCharDegree65And80 = ReplacingCharDegree49And64.Concat(new string[] { "¥", "¥", "|\\|", "|\\|", "\\/\\/", "\\/\\/", "|-|", "|-|", "\\/", "\\/", "|\\/|", "|\\/|" }).ToArray();

    private static string FindingCharDegree81And99 = FindingCharDegree65And80 + "rRbBqQxX";
    private static string[] ReplacingCharDegree81And99 = ReplacingCharDegree65And80.Concat(new string[] { "®", "®", "ß", "ß", "Q", "Q¸", ")(", ")(" }).ToArray();

    private static string FindingCharDegree100 = FindingCharDegree81And99 + "jJ";
    private static string[] ReplacingCharDegree100 = ReplacingCharDegree81And99.Concat(new string[] { "_|", "_|" }).ToArray();
    #endregion
  }
}
