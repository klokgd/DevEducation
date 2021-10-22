using System;

namespace Lists
{
    public class ArrayList
    {
        private int[] _array;
        public int RealLength { get; private set; }


        public ArrayList()
        {
            RealLength = 0;
            _array = new int[10];
        }
        public ArrayList(int number)
        {
           
            RealLength = 1;
            _array = new int[10];
            _array[0] = number;
        }
        public ArrayList(int[] array)
        {

            RealLength = array.Length;
            _array = array;


        }


        public void AddLast(int number)
        {
            int[] array = new int[RealLength + 1];
            array = _array;
            array[RealLength + 1] = number;
            _array = array;

            RealLength++;
        }

        public void UpSize()
        {
            int[] temp = _array;
            int newLength = RealLength * 3 / 2;
            _array = new int[newLength];

            for (int i = 0; i < RealLength; i++)
            {
                _array[i] = temp[i];
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[RealLength];

            for (int i = 0; i < RealLength; i++)
            {
                array[i] = _array[i];
            }

            return array;
        }

        public void AddFirst(int number)
        {
            for (int i = 0; i < RealLength; i++)
            {
                _array[i + 1] = _array[i]; 
            }
            _array[0] = number;
        }



    }
}
