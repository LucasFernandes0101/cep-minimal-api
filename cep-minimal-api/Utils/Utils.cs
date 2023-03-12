using System.Text;

namespace cep_minimal_api.Utils
{
    public static class Utils
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
