using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viusal
{
    public enum TriggerType
    {
        J,
        K,
        D
    }

    public static class ExcitationTable
    {
        public static Dictionary<TriggerType, Dictionary<Key, char>> Table;

        public struct Key
        {
            public bool IN, TO;

            public Key(bool In, bool To)
            {
                IN = In;
                TO = To;
            }

            public override bool Equals(object obj)
            {
                if (obj is Key)
                    return ((Key)obj).IN == IN && ((Key)obj).TO == TO;
                else
                    return base.Equals(obj);
            }
        }

        static ExcitationTable()
        {
            Table = new Dictionary<TriggerType, Dictionary<Key, char>>();

            var d = new Dictionary<Key, char>();
            d.Add(new Key(false,    false), '0');
            d.Add(new Key(false,    true),  '1');
            d.Add(new Key(true,     false), '0');
            d.Add(new Key(true,     true),  '1');
            Table.Add(TriggerType.D, d);

            var j = new Dictionary<Key, char>();
            j.Add(new Key(false,    false), '0');
            j.Add(new Key(false,    true),  '1');
            j.Add(new Key(true,     false), 'X');
            j.Add(new Key(true,     true),  'X');
            Table.Add(TriggerType.J, j);

            var k = new Dictionary<Key, char>();
            k.Add(new Key(false,    false), 'X');
            k.Add(new Key(false,    true),  'X');
            k.Add(new Key(true,     false), '1');
            k.Add(new Key(true,     true),  '0');
            Table.Add(TriggerType.K, k);
        }
    }
}
