using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Models
{
    public class BreadcrumbGenerator
    {
        private static readonly HashSet<string> WordsToIgnore = new HashSet<string>
        {
            "the",
            "of",
            "in",
            "from",
            "by",
            "with",
            "and",
            "or",
            "for",
            "to",
            "at",
            "a",
        };

        public static string GenerateBC(string url, string separator)
        {
            const string homeActive = "<span class=\"active\">HOME</span>";
            const string homeLink = "<a href=\"/\">HOME</a>";

            var cleanUrl = url.Split(new[] { '?', '#' }, StringSplitOptions.RemoveEmptyEntries)[0];

            var urlParts = cleanUrl
                .Split('/')
                .Where(part => !string.IsNullOrEmpty(part) && !part.Contains(':'))
                .Select(part => part.Split('.')[0]) // Remove extensões
                .ToList();

            if (urlParts.LastOrDefault()?.ToLower() == "index")
            {
                urlParts.RemoveAt(urlParts.Count - 1);
            }

            if (urlParts.Count <= 1)
            {
                return homeActive;
            }

            var result = new List<string> { homeLink };
            string path = string.Empty;

            for (int i = 1; i < urlParts.Count; i++)
            {
                string part = urlParts[i];
                path += "/" + part;

                string displayName = FormatName(part);

                if (i == urlParts.Count - 1)
                {
                    result.Add($"<span class=\"active\">{displayName}</span>");
                }
                else
                {
                    result.Add($"<a href=\"{path}/\">{displayName}</a>");
                }
            }

            return string.Join(separator, result);
        }

        private static string FormatName(string name)
        {
            if (name.Length > 30)
            {
                return string.Join(
                        "",
                        name.Split('-')
                            .Where(word => !WordsToIgnore.Contains(word))
                            .Select(word => word[0])
                    )
                    .ToUpper();
            }

            return name.Replace("-", " ").ToUpper();
        }
    }
}
