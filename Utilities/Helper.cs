using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Helper
    {
        public static bool IsNullOrEmpty(string strInput)
        {
            bool isNullorEmpty = false;
            if (strInput == null || strInput.Trim().Length == 0)
            {
                isNullorEmpty = true;
            }

            return isNullorEmpty;
        }

        public static StringBuilder PositiveDivisors(int inputNo)
        {
            StringBuilder sbOutPositiveDivisors = new StringBuilder();

            for (int count = 1; count <= inputNo; count++)
            {
                if (inputNo % count == 0)
                {
                    sbOutPositiveDivisors.Append(count + (inputNo.Equals(count) ? "" : ","));
                }
            }

            return sbOutPositiveDivisors;
        }

        public static double AreaOfTriangle(int sideA, int sideB, int sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new System.ArgumentException("InvalidTriangleException: Traingle sides cannot be less than or equal to 0.");
            }

            double triangleArea = 0;
            double perimeterHalf = (sideA + sideB + sideC) / 2;

            triangleArea = Math.Sqrt(perimeterHalf * (perimeterHalf - sideA) * (perimeterHalf - sideB) * (perimeterHalf - sideC));

            if (triangleArea == 0)
            {
                throw new System.ArgumentException("InvalidTriangleException: Cannot form a triangle with these sides.");
            }

            return triangleArea;
        }

        public static int[] MostCommonIntegers(int[] inputArr)
        {
            int[] outputArr = (from numbers in inputArr
                               group numbers by numbers into grouped
                               let maxCount = (from numberCount in inputArr
                                               group numberCount by numberCount into groupedCount
                                               orderby groupedCount.Count() descending
                                               select groupedCount.Count()).First()
                               let gCount = grouped.Count()
                               where gCount == maxCount
                               select grouped.Key).ToArray();

            return outputArr;
        }
    }
}
