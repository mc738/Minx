namespace Minx.Razor.Models
{
    public class KeyValueItem
    {
        public KeyValueItem()
        {
                
        }

        public KeyValueItem(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        
        public string Value { get; set; }
    }
}