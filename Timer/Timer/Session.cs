using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    class Session
    {
        private List<Solve> solves;

        public Session()
        {
            solves = new List<Solve>();
        }

        public List<Solve> Solves => solves;

        public Solve this[int index]
        {
            get
            {
                return solves[index];
            }
        }

        public void Add(Solve solve)
        {
            solves.Add(solve);
        }

        public void Remove(int index)
        {
            solves.RemoveAt(index);
        }

        public void Clear()
        {
            solves.Clear();
        }


        public int Count => solves.Count;

        public List<Solve> GetRange(int index, int count)
        {
            return solves.GetRange(index, count);
        }
    }
}
