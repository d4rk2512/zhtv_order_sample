using System.ComponentModel.DataAnnotations;

namespace zhtv.Models
{
    public class OrderInfo
    {
        [Required]
        public string User { set; get; }
        [Required]
        public int SongId { set; get; }
    }
}
