using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_19_ArrayHelper
{
    class ArrayHelper<T> where T : IEquatable<T>, IComparable<T>
    {
        public delegate int[] AdunareSiruriEgale(int[] SirUnu, int[] SirDoi);

        public T FoundItem;
        public bool ValidOrNot;
        public List<T> Collection;
        int i = 0;

        public ArrayHelper(params T[] args)
        {
            this.Collection = new List<T>();
            if (args.Length == 0)
            {
                args = new T[0];
            }
            this.Collection.AddRange(args);
        }

        //Metoda de adunare care va fi folosita prin delgatul din Program
        public int[] AdunareDouaSiruri(int[] SirUnu, int[] SirDoi)
        {
            int[] Rezultat = new int[SirUnu.Length];
            foreach ( int no in SirUnu ) {
                Rezultat[i] = no + SirDoi[i];
                i++;
            }
            return Rezultat;
        }

        public bool Finder(T element)
        {
            //localizare si intoarcere un element intr-un sir
            foreach (T item in this.Collection)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public dynamic Finder(T element, string decider = null)
        {
            bool IsValid = Finder(element);
          
            if (IsValid)
            {
                if ( decider == "element" )
                {
                    return element;
                } else if ( decider == "index" )
                    return this.Collection.IndexOf(element);
            }

            return -1;
        }

        public bool deleteOnCondition(int i)
        {
            if ( i < 30 )
            {
                return true;
            }
            return false;
        }
    }
}
