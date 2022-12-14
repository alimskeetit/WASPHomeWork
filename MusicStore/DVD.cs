using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public class DVD: Disk
    {
        string producer;
        string filmCompany;
        int minutesCount;

        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre): base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }

        public override int DiskSize { get => minutesCount/32; set => base.DiskSize = value; }

        public override void Burn(params string[] values)
        {
            Name = values[0];
            Genre = values[1];
            producer = values[2];
            filmCompany = values[3];
            minutesCount = Convert.ToInt32(values[4]);
            
            BurnCount++;
        }

        public override string ToString()
        {
            return $"{Name} {Genre} {producer} {filmCompany} Длительность: {minutesCount} Количество прожигов: {BurnCount}";
        }
    }
}
