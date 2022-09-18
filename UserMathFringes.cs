using System;
using System.Linq;

namespace Fringilla
{
    class UserMathFringes
    {
        // adapted version of library is need for Fringilla
        public static double[] FindMaxIndexes(double[] xdata, double[] ydata, int window)       //last name << double [,] FindExtremIndexes
        {
            double[] countMaxBuff = new double[10];             // input window parameter the same like SG filter or greater
            int countMax = 0;                                   // because start and end of the vector may contain
                                                                // unsmoothed extrema
            bool raiseFlag = false;
            bool slopeFlag = false;

            for (int i = 0; i < ydata.Length - 1; i++)          // step by step throught whole y vector
            {                                                   // there can be only two possibilities
                if(ydata[i] < ydata[i + 1])                     // next value can be bigger than first (line raise)
                {
                    if(raiseFlag == false)
                    { 
                        raiseFlag = true;
                        countMax++;
                    }
                    if (slopeFlag == true)
                    {
                        slopeFlag = false;
                    }
                }

                if (ydata[i] > ydata[i + 1])                    // next value is smaller than first (line slope)
                {
                    if (slopeFlag == false)
                    {
                        slopeFlag = true;
                    }
                    if (raiseFlag == true)
                    {
                        raiseFlag = false;
                        if (countMax > 0)
                        {
                            countMaxBuff[countMax - 1] = i;
                        }
                    }
                }
            }
            //preparing answer
            int ansIndex = 0;
            for(int i = 0; i < countMax;i++)        // including window dependencies
            { 
                if (countMaxBuff[i] > window && countMaxBuff[i] < (ydata.Length - window)) 
                { 
                    ansIndex++;                     // in this loop to determine the lenght of ans 
                } 
            }
            double[] ans = new double[ansIndex];
            
            ansIndex = 0;
            for (int i = 0; i < countMax; i++) 
            {
                if (countMaxBuff[i] > window && countMaxBuff[i] < (ydata.Length - window))
                {
                    ans[ansIndex] = countMaxBuff[i];
                    ansIndex++;                     // in this loop as index of ans values
                } 
            }

            return ans;
        }
        public static double[] SGFilter(double[] inVector, int window, int loops, int precission)
        {
            double[] ans = new double[inVector.Length];
            for(int i = 0; i < inVector.Length; i++) { ans[i] = inVector[i]; }

            double[] coeffs = new double[(window * 2) + 1]; // window <- middle -> window ; symmetric vector
            double coeffs_sum;
            double ys;
            // if window = 3 then symmetric coeffs 3 2 1 m 1 2 3
            //                                     0 1 2 3 4 5 6

            // first the coefficients vector
            for (int i = window; i < coeffs.Length; i++)
            {
                coeffs[i] = (-5 * Math.Pow(i - window,2)) + ((60 * (window + 1)) - 271);    // right side only
            }
            for(int i = 0; i < window; i++)
            {
                coeffs[i] = coeffs[coeffs.Length - 1-i];
            }
            coeffs_sum = coeffs.Sum();
            // solution
            while(loops>0)
            {
                for (int i = window; i < (inVector.Length - window); i++)
                {
                    ys = 0;
                    for (int j = 0; j < coeffs.Length; j++)
                    {
                        ys += (ans[(i - window) + j] * coeffs[j]);
                    }
                    ans[i] = Math.Round((ys / coeffs_sum),precission);
                }
                loops--;
            }
            return ans;
        }
    }
}
