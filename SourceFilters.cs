using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAS_D5
{
    // Class to filtration by multiple parameters.
    public class SourceFilters
    {
        private Dictionary<string, string> filters = new Dictionary<string, string>();

        // Adds new filter.
        public void Add(string filterType, string newFilter)
        {
            filters[filterType] = newFilter;
        }

        // Removes filter if exists.
        public void Remove(string filterType)
        {
            if (filters.ContainsKey(filterType))
                filters.Remove(filterType);
        }

        // Creates filter string in Expression language. Can be used to setup binding source filter.
        public string Compose()
        {
            if (filters.Count == 0)
                return "";

            var combined_filter = "";
            var last = filters.Last();
            var first = filters.First();
            foreach (var entry in filters)
                if (entry.Equals(last))
                    if (entry.Equals(first))
                        combined_filter += entry.Value;
                    else
                        combined_filter += String.Format("({0})", entry.Value);
                else
                    combined_filter += String.Format("({0}) AND ", entry.Value);

            return combined_filter;
        }
    }
}
