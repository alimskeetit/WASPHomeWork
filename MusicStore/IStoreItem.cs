using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        
        public virtual void DicountPrice (int percent)
        {
            Price *= 1.0 - percent / 100.0;
        }
    }
}
