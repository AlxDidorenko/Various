using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class ClassHash
    {
        List<HashNode>[] cont = new List<HashNode>[100];

        public int HashFunc(int key)
        {
            return key % cont.Length;
        }

        public void Addition(int key, HashNode value)
        {
            int index = HashFunc(key);
            if (cont[index] == null)
            {
                cont[index].Add(value);
            }
        }

        public HashNode Find(int key)
        {
            int index = HashFunc(key);
            if (cont[index] != null)
            {
                foreach (HashNode hn in cont[index])
                {
                    if (hn.key == key)
                    {
                        return hn;
                    }
                }
            }
            return null;
        }

        public void Deletion(int key)
        {
            int index = HashFunc(key);
                foreach (HashNode hn in cont[index])
                {
                    if (hn.key == key)
                    {
                        cont[index].Remove(hn);
                    }
                }
        }
    }
}
