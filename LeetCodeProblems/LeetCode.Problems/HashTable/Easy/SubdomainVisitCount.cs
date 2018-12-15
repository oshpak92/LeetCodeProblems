using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problems.HashTable.Easy
{
    public class SubdomainVisitCount
    {
        private char point = '.';
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var result = new Dictionary<string, int>();

            foreach (var domain in cpdomains)
            {
                var parts = domain.Split(' ');
                if (parts.Length != 2) throw new FormatException(domain);
                ProcessDomain(result, parts[1], int.Parse(parts[0]));
            }

            return result.Select(item => $"{item.Value} {item.Key}").ToList();
        }

        private void ProcessDomain(IDictionary<string, int> domains, string domain, int visits)
        {
            if (string.IsNullOrWhiteSpace(domain)) return;

            var i = domain.Length - 1;

            if (!domains.ContainsKey(domain))
            {
                domains.Add(domain, visits);
            }
            else
            {
                domains[domain] += visits;
            }

            while (i != 0)
            {
                if (domain[i] == point)
                {
                    var subdomain = domain.Substring(i + 1, domain.Length - (i + 1));
                    if (domains.ContainsKey(subdomain))
                        domains[subdomain] += visits;
                    else
                        domains[subdomain] = visits;
                }
                i--;
            }
        }
    }
}
