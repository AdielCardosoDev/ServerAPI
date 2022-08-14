using System.ComponentModel.DataAnnotations;

namespace ServerAPI.Model
{
    public class Server
    {
        [Key]
        public int id { get; set; }

        [Required][MaxLength(120)]
        public string name { get; set; }

        [MaxLength(120)]
        public string suport { get; set; }

        [MaxLength(120)]
        public string password { get; set; }

        [MaxLength(500)]
        public string Warning { get; set; }
        public DateTime registration { get; set; }
    }
}
