using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public class Store
    {
        string storeName;
        string address;

        Audio[] audios;
        DVD[] dvds;

        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;
        }

        public static Store operator +(Store store, Disk disk)
        {
            //массив, которым заместим старый
            Disk[] toReturn;
            int newLength = 1;

            //если тип диска Audio
            if (disk.GetType() == typeof(Audio))
            {
                //новый массив будет иметь длину на единицу больше
                if (store.audios != null) 
                    newLength = store.audios.Length + 1;
                
                toReturn = new Audio[newLength];

                //копируем старый массив в новый
                if (store.audios != null)
                    store.audios.CopyTo(toReturn, 0);

                //добавляем новый диск
                toReturn[toReturn.Length - 1] = disk;
                
                //замещаем старый массив на новый
                store.audios = (Audio[])toReturn;
            }
            //если тип диска DVD
            else if (disk.GetType() == typeof(DVD))
            {
                //новый массив будет иметь длину на единицу больше
                if (store.dvds != null)
                    newLength = store.dvds.Length + 1;
                toReturn = new DVD[newLength];

                //копируем старый массив в новый
                if (store.dvds != null)
                    store.dvds.CopyTo(toReturn, 0);

                //добавляем новый диск
                toReturn[toReturn.Length - 1] = disk;

                //замещаем старый массив на новый
                store.dvds = (DVD[])toReturn;
            }
            //если диск не Audio и не DVD
            else throw new Exception();

            return store;
        }

        public static Store operator -(Store store, Disk disk)
        {
            Disk[] toReturn;

            //если тип диска Audio
            if (disk.GetType() == typeof(Audio))
            {
                //копируем в массив все кроме disk
                store.audios = (Audio[])store.audios.Except(new [] { (Audio)disk }).ToArray();
            }
            //если тип диска DVD
            else if (disk.GetType() == typeof(DVD))
            {
                //копируем в массив все кроме disk
                store.dvds = (DVD[])store.dvds.Except(new[] { (Disk)disk }).ToArray();
            }
            //если диск не Audio и не DVD
            else throw new Exception();

            return store;
        }

        public override string ToString()
        {
            StringBuilder @string = new StringBuilder();
            
            foreach (Audio audio in audios)
            {
                @string.Append(audio.ToString() + '\n');
            }

            foreach(DVD dvd in dvds)
            {
                @string.Append(dvd.ToString() + '\n');
            }

            return @string.ToString();
        }
    }
}


