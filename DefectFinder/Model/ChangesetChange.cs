using System.Collections.Generic;

namespace DefectFinder.Model
{
    public class ChangesetChange
    {
        public class Item
        {
            public int Version { get; set; }
            public int Size { get; set; }
            public string HashValue { get; set; }
            public string Path { get; set; }
            public string Url { get; set; }
        }

        public class Value
        {
            public Item Item { get; set; }
            public string ChangeType { get; set; }
        }

        public class RootObject
        {
            public int Count { get; set; }
            public List<Value> Value { get; set; }
        }

    }
}
