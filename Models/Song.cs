using System.Collections.Generic;

namespace zhtv.Models
{
    public class Song
    {
        public int SongId { set; get; }
        public string Name { set; get; }
        public string Singer { set; get; }
        public List<string> UserOrders { set; get; } = new List<string>();

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song song = (Song)obj;
            return this.SongId == song.SongId;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
