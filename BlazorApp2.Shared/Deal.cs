namespace BlazorApp2.Shared
{
    public class Deal
    {
        public Deal(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
