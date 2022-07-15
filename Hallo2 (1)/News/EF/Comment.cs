using System;

namespace News.EF
{
    public class Comment
    {
        public int Id;
        public Publication Publication;
        public DateTime DateTime;
        public string Nick;
        public string Text;
    }
}
