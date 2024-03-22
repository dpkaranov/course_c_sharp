using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        int start, step, current;

        public ArithProgression(int str, int stp)
        {
            start = str;
            current = start;
            step = stp;
        }

        public int GetNext()
        {
            current = current + step;
            return current;
        }

        public void Reset()
        {
            current = start;
        }

        public void SetStart(int x)
        {
            start = x;
        }
    }

    class GeomProgression : ISeries
    {
        int start, step, current;

        public GeomProgression(int str, int stp)
        {
            start = str;
            current = start;
            step = stp;
        }

        public int GetNext()
        {
            current = current * step;
            return current;
        }

        public void Reset()
        {
            current = start;
        }

        public void SetStart(int x)
        {
            start = x;
        }
    }
}

