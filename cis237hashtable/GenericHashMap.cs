using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class GenericHashMap<TKey, TValue>
    {
        private const int PRIME_VALUE = 97;
        TValue[] theValues;

        public GenericHashMap()
        {
            theValues = new TValue[PRIME_VALUE];
        }

        public TValue Get(TKey key)
        {
            int indexForValues = HashFunction(key);
            return theValues[indexForValues];
        }

        public void Put(TKey key, TValue value)
        {
            int indexForValues = HashFunction(key);
            theValues[indexForValues] = value;
        }

        public override string ToString()
        {
            string returnString = "Key     => Value\n";
            returnString += "------------------------------\n";
            for (int i = 0; i < theValues.Length; i++)
            {
                if(theValues[i] != null)
                {
                    returnString += i + " => " + theValues[i] + Environment.NewLine;
                }
            }
            return returnString;
        }

        public  string ShowArray()
        {
            string returnString = "Key     => Value\n";
            returnString += "------------------------------\n";
            for (int i = 0; i < theValues.Length; i++)
            {

                returnString += "[" + i + "] =>" + theValues[i] + Environment.NewLine;
                
            }
            return returnString;
        }

        private int HashFunction(TKey key)
        {
            return key.GetHashCode() % PRIME_VALUE;
        }
    }
}
