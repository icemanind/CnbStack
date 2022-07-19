using System;

namespace ConsoleApp4
{
    public class MinStack
    {
        private int[] _data;
        private int _pointer;

        public MinStack()
        {
            // Start with a max stack of 10 items. It will automatically resize as it needs to
            _data = new int[10];
            _pointer = 0;
        }

        public void Push(int item)
        {
            if (_pointer >= _data.Length - 1)
            {
                IncreaseStack();
            }

            _data[_pointer] = item;
            _pointer++;
        }

        public int Pop()
        {
            if (_pointer <= 0)
            {
                throw new Exception("Stack is empty!");
            }

            _pointer--;
            return _data[_pointer];
        }

        public int Top()
        {
            if (_pointer <= 0)
            {
                throw new Exception("Stack is empty!");
            }

            return _data[_pointer - 1];
        }

        public int GetMin()
        {
            if (_pointer <= 0)
            {
                throw new Exception("Stack is empty!");
            }

            int smallest = _data[0];

            for (int x = 0; x < _pointer; x++)
            {
                if (_data[x] < smallest) smallest = _data[x];
            }

            return smallest;
        }

        private void IncreaseStack()
        {
            int[] tmp = new int[_data.Length];

            for (int i = 0; i < _data.Length; i++)
            {
                tmp[i] = _data[i];
            }

            _data = new int[_data.Length * 2];

            for (int i = 0; i < tmp.Length; i++)
            {
                _data[i] = tmp[i];
            }
        }
    }
}
