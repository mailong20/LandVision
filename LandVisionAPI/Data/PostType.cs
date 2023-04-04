namespace LandVisionAPI.Data
{
    public class PostType

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> PostsOfPostType { get; set;}
    }
}
