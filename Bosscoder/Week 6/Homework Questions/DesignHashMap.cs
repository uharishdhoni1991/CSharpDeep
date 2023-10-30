using System.Collections;

namespace Bosscoder.Week_6.Homework_Questions
{
    public class DesignHashMap
    {
        Hashtable hashtable;

        public DesignHashMap()
        {
            hashtable = new Hashtable();
        }

        public void Put(int key, int value)
        {
            hashtable[key] = value;
        }

        public int Get(int key)
        {
            return hashtable.ContainsKey(key) ? (int)hashtable[key] : -1;
        }

        public void Remove(int key)
        {
            hashtable.Remove(key);
        }
    }
}
