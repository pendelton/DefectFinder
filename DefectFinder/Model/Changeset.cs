namespace DefectFinder.Model
{
    public class Changeset
    {
    }

    public class Author
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string UniqueName { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
    }

    public class CheckedInBy
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string UniqueName { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Self
    {
        public string Href { get; set; }
    }

    public class Changes
    {
        public string Href { get; set; }
    }

    public class WorkItems
    {
        public string Href { get; set; }
    }

    public class Web
    {
        public string Href { get; set; }
    }

    public class Author2
    {
        public string Href { get; set; }
    }

    public class CheckedInBy2
    {
        public string Href { get; set; }
    }

    public class Links
    {
        public Self Self { get; set; }
        public Changes Changes { get; set; }
        public WorkItems WorkItems { get; set; }
        public Web Web { get; set; }
        public Author2 Author { get; set; }
        public CheckedInBy2 CheckedInBy { get; set; }
    }

    public class RootObject
    {
        public int ChangesetId { get; set; }
        public string Url { get; set; }
        public Author Author { get; set; }
        public CheckedInBy CheckedInBy { get; set; }
        public string CreatedDate { get; set; }
        public string Comment { get; set; }
        public Links Links { get; set; }
    }
}
