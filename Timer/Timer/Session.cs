using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    public class Session
    {
        private List<Solve> solves;
        float worstTime; 
        float bestTime; 

        public Session()
        {
            solves = new List<Solve>();
            worstTime = float.MinValue;
            bestTime = float.MaxValue;
        }

        public List<Solve> Solves => solves;

        public float BestTime => bestTime;
        public float WorstTime => worstTime;

        public Solve this[int index]
        {
            get
            {
                return solves[index];
            }
        }

        /// <summary>
        /// Returns the number of solves in this session
        /// </summary>
        public int Count => solves.Count;

        /// <summary>
        /// Adds a solve to the session. Remember: the solve object must have an initialized Time property!
        /// </summary>
        /// <param name="solve"></param>
        public void Add(Solve solve)
        {
            solves.Add(solve);
            if (solve.Time < bestTime)
                bestTime = solve.Time;
            if (solve.Time > worstTime)
                worstTime = solve.Time;

            solve.bestTime = bestTime;
            solve.worstTime = worstTime;
        }

        /// <summary>
        /// Removes a solve at the specified index
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            //Before removing, check if the solve to be removes might be best or worst time
            if(solves[index].Time == bestTime)
            {
                solves.RemoveAt(index);

                bestTime = float.MaxValue;
                foreach(Solve solve in solves)
                    if (solve.Time < bestTime && solve.penalty != "DNF")
                        bestTime = solve.Time;
            }
            else if(solves[index].Time == worstTime)
            {
                solves.RemoveAt(index);

                worstTime = float.MinValue;
                foreach (Solve solve in solves)
                    if (solve.Time > worstTime && solve.penalty != "DNF")
                        worstTime = solve.Time;
            }       
        }

        public void RemoveLast()
        {
            Remove(Count-1);
        }

        /// <summary>
        /// Deletes all saves solves
        /// </summary>
        public void Clear()
        {
            solves.Clear();
            bestTime = float.MaxValue;
            worstTime = float.MinValue;
        }

        /// <summary>
        /// Returns a sequence of solves from index to (index + count)
        /// </summary>
        /// <param name="index">The index at which to start the sequence</param>
        /// <param name="count">The number of solves in the sequence</param>
        /// <returns></returns>
        public List<Solve> GetRange(int index, int count)
        {
            return solves.GetRange(index, count);
        }

        /// <summary>
        /// Returns the last solve that was made
        /// </summary>
        /// <returns></returns>
        public Solve getLastSolve()
        {
            return solves.Last();
        }
        
        public bool hasSolves()
        {
            return Count > 0;
        }

        /// <summary>
        /// Clear best and worst times and recalculate them
        /// </summary>
        public void RecalculateBestAndWorstTimes()
        {
            worstTime = float.MinValue;
            bestTime = float.MaxValue;
            foreach(Solve solve in solves)
            {
                if(solve.Time > worstTime && solve.penalty != "DNF")
                    worstTime = solve.Time;
                if (solve.Time < bestTime && solve.penalty != "DNF")
                    bestTime = solve.Time;
            }
            getLastSolve().bestTime = bestTime;
            getLastSolve().worstTime = worstTime;
        }

        /// <summary>
        /// Recalculate the best and worst time, but disregard the very last solve. 
        /// This function is helpful when the last solve has been marked as DNF.
        /// </summary>
        public void RecalculateBestAndWorstTimesWithoutLastSolve()
        {
            if (Count > 1)
            {
                bestTime = solves[Count - 2].bestTime;
                worstTime = solves[Count - 2].worstTime;
                getLastSolve().bestFive = bestTime;
                getLastSolve().worstTime = worstTime;
            }
            else
            {
                worstTime = float.MinValue;
                bestTime = float.MaxValue;
            }
        }
    }
}
