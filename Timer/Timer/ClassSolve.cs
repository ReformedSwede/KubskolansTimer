using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    class Solve
    {
        /// <summary>
        /// The time of the solve, i.e. how long time it took to solve the cube.
        /// </summary>
        public float time = 0;

        /// <summary>
        /// The scramble algorithm used in the solve.
        /// </summary>
        public string scramble = "";
        
        /// <summary>
        /// Information about any penalty. ("", "DNF" or "+2")
        /// </summary>
        public string penalty = "";



        //the following variables hold some statistics that were valid when the solve was just made

        /// <summary>
        /// The worst time in the session at the time of the solve.
        /// </summary>
        public float worstTime;

        /// <summary>
        /// The best time in the session at the time of the solve.
        /// </summary>
        public float bestTime;

        /// <summary>
        /// The best Average of five at the time of the solve. 
        /// </summary>
        public float bestFive;

        /// <summary>
        /// The best Average of twelve at the time of the solve. 
        /// </summary>
        public float bestTwelve;
    }
}
