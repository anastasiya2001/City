using System;
namespace News.EF
{
    public class Publication
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Announce { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public Reblicator Rubricator { get; set; }
    }
}
