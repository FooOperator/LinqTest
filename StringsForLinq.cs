namespace a
{
    public class StringsForLinq
    {
        public static void FindEntriesStartingWith(string[] entries, char target)
        {
            var results = from entry in entries
                          where entry[0] == target
                          select entry;
            if (results.Count() <= 0)
            {
                Console.WriteLine($"No matching entries for {target}");
                return;
            }
            foreach (var item in results)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void FindEntryOrDefault(string[] entries, string target)
        {
            var result = entries.FirstOrDefault(entry => entry == target);
            Console.WriteLine($"{(result != null ? $"{target} in entries" : $"{target} not in entries")}");
        }
        public static void FindEntriesWithWhitespace(string[] entries)
        {
            var results = from entry in entries
                          where entry.Contains(" ")
                          select entry;

            if (results.Count() <= 0)
            {
                Console.WriteLine("No entries with whitespace");
                return;
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }

}
