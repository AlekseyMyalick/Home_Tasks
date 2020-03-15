using System;

namespace DEV_1
{
    public class Lines 
    {
        private string line;

        /// <summary>
        /// constructor initializes class elements
        /// </summary>
        public Lines(string line)
        {
            Line = line;
        }

        /// <summary>
        /// method Line accepts and returns values
        /// </summary>
        public string Line
        {
            get
            {
                return line;
            }

            set
            {
                CheckValue(value);
                line = value.ToLower();
            }
        }

        /// <summary>
        /// method LineLength returns line length
        /// </summary>
        public int LineLength
        {
            get
            {
                return Line.Length;
            }

        }

        /// <summary>
        /// method ComparisonOfLetter compares letters and counts the number of non-repeating
        /// </summary>
        public int ComparisonOfLetter(int count, int i)
        {
            for (int j = i + 1; j < LineLength; j++)
            {
                if (Equals(Line[i], Line[j]) == false)
                {
                    count++;
                    i++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        /// <summary>
        /// methode Country counts the final amount
        /// </summary>
        public int Counting()
        {
            int count = 0;

            for(int i = 0; i < LineLength; i++)
            {
                int finalAmount = 1;
                finalAmount = ComparisonOfLetter(finalAmount, i);
                count = Math.Max(finalAmount, count);
            }

            return count;
        }

        /// <summary>
        /// the method CheckValue checks the value and throws an error if it is Null
        /// </summary>
        void CheckValue(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

        }

    }
}
