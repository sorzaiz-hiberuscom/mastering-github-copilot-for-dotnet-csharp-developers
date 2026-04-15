namespace Skills
{
    public class Comments
    {

        // create a method that generates a comment for a given skill
        public static Comments GenerateComment(string skill, string author)
        {
            return new Comments
            {
                Content = $"This is a comment about the skill: {skill}",
                Author = author
            };
        }

        public int Id { get; set; }
        public string? Content { get; set; }
        public string? Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? MemberId { get; set; }

        public Comments()
        {
            CreatedDate = DateTime.Now;
        }

        public Comments(int id, string content, string author, int memberId)
        {
            Id = id;
            Content = content;
            Author = author;
            MemberId = memberId;
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Author: {Author}, Content: {Content}, Created: {CreatedDate:yyyy-MM-dd HH:mm:ss}, Member ID: {MemberId}";
        }
    }
}
