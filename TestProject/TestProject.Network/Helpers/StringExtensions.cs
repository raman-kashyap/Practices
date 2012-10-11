using System.Text.RegularExpressions;

namespace TestProject.Network.Helpers
{
    public static class StringExtensions
    {
        /// <summary>
        /// Replace special characters with "replaceWith" string value
        /// </summary>
        /// <param name="source">Actual string value to replace special characters from.</param>
        /// <param name="replaceWith">A string value to replace special characters with.</param>
        /// <returns>Returns string value</returns>
        public static string ReplaceSpecialCharacters(this string source, string replaceWith)
        {
            return Regex.Replace(source, "[^0-9a-zA-Z]+", replaceWith);
        }
    }
}
