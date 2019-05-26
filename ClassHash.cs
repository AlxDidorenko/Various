using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class ClassHash<T>
    {
        List<HashNode<string>>[] cont = new List<HashNode<string>>[100];
        private int count = 0;
        public int HashFunc(int key)
        {
            return key % cont.Length;
        }

        public void Addition(int key, HashNode<string> value)
        {
            int index = HashFunc(key);
            if (cont[index] == null)
            {
                cont[index].Add(value);
            }
            count++;
        }

        public string Find(int key)
        {
            int index = HashFunc(key);
            if (cont[index] != null)
            {
                foreach (HashNode<string> hn in cont[index])
                {
                    if (hn.key == key)
                    {
                        return hn.ToString();
                    }
                }
            }
            return null;
        }

        public void Deletion(int key)
        {
            int index = HashFunc(key);
                foreach (HashNode<string> hn in cont[index])
                {
                    if (hn.key == key)
                    {
                        cont[index].Remove(hn);
                    }
                }
            count--;
        }
    }
}
