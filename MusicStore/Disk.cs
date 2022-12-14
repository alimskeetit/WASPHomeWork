using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public class Disk: IStoreItem
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int BurnCount { get; set; }

        public Disk(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        public virtual int DiskSize { get; set; }

        public double Price { get; set; }

        public virtual void Burn(params string[] values) { }
    }
}
