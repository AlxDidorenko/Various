using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class ClassHash
    {
        public List<HashNode>[] cont = new List<HashNode>[100];

        public void Load()
        {
            for (int i = 0; i < 100; i++)
                cont[i] = new List<HashNode>();
        }

        public void Addition(HashNode hn)
        {
            cont[hn.key % cont.Length].Add(hn);
        }

        public string Find(int key)
        {
            HashNode result = new HashNode();
            HashNode[] search = cont[key % cont.Length].Where(sf => sf.key == key).ToArray();
            foreach (var founded in search)
            {
                result.key = founded.key;
                result.value = founded.value;
            }
            return result.value;
        }

        public void Deletion(int key)
        {
            HashNode[] search = cont[key % cont.Length].Where(sf => sf.key == key).ToArray();
            foreach (var element in search)
            {
                cont[key % cont.Length].Remove(element);
            }            
        }

        public List<HashNode>[] Retarray()
        {
            return cont;
        }
    }
}
