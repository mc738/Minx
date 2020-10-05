using System;

namespace Minx.Razor.Models
{
    public class MapMarker
    {
        public Guid Reference { get; set; }
        
        public string Name { get; set; }
        
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}