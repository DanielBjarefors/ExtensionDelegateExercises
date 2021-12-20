using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgifterFrånPresentationer
{
    public static class ExtensionIEnumT
    {

        public static float SumEnum(this IEnumerable<float> ie)
        {
            float sum = 0;            
                foreach (var e in ie)
                {
                    sum += e;
                }          
            return sum;
        }
        public static float AvgEnum(this IEnumerable<float> ie)
        {
            float sum = 0;
            foreach (var e in ie)
            {
                sum += e;
            }
            return sum/ie.Count();
        }
        public static float ProductEnum(this IEnumerable<float> ie)
        {
            float sum = 0;

            foreach (var e in ie)
            {
                sum *= e;
            }
            return sum;
        }
        public static float maxEnum(this IEnumerable<float> ie)
        {
            float sum = 0;
            foreach (var e in ie)
            {
                if (e>sum)
                {
                    sum = e;
                }
            }           
            return sum;
        }
        public static float minEnum(this IEnumerable<float> ie)
        {
            float sum = 0;
            foreach (var e in ie)
            {
                if (e > sum)
                {
                    sum = e;
                }
            }
            return sum;
        }
    }
}
