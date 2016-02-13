namespace DefectFinder.Model
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string State { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Description: " + Description;
        }
    }

}
