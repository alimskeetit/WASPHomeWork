using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public class Audio: Disk
    {
        public string artist;
        string recordingStudio;
        int songsNumber;

        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre): base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }

        public override int DiskSize { get => songsNumber*8; set => base.DiskSize = value; }

        public override void Burn(params string[] values)
        {
            Name = values[0];
            Genre = values[1];
            artist = values[2];
            recordingStudio = values[3];
            songsNumber = Convert.ToInt32(values[4]);

            base.BurnCount++;
        }

        public override string ToString()
        {
            return $"{Name} {Genre} {artist} {recordingStudio} Количество песен: {songsNumber} Количество прожигов: {BurnCount}";
        }

    }
}
