using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaASMRBackend.Models.Domain
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Url { get; set; }
        public double Length { get; set; }
        public List<string> keywords = new List<string>();
    }
}
