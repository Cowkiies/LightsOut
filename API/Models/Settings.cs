using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        public int GridSizeX { get; set; }
        public int GridSizeY { get; set; }
        public string Difficulty { get; set; }
    }
}
