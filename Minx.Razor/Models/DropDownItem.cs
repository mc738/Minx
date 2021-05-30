using System;

namespace Minx.Razor.Models
{
    public class DropDownItem
    {
        public DropDownItem()
        {
                
        }

        public DropDownItem(Guid reference, string name)
        {
            Reference = reference;
            Name = name;
        }
        
        public Guid Reference { get; set; }

        public string Name { get; set; }
    }
}