namespace Minx.Razor.Models
{
    public class LabelledIntItem
    {
        public LabelledIntItem()
        {
                
        }

        public LabelledIntItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public int Id { get; set; }

        public string Name { get; set; }
    }
}