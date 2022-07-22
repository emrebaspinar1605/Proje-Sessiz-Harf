using System;

namespace ProjeSessizHarf
{
    public struct Boolean
    {
        public void IsBool()
        {
            Console.Write("Bir Cümle giriniz...: ");
            string text= Console.ReadLine();

            foreach (var word in text.Split(' '))
            {
                bool control= false;
                for (int i = 1; i < word.Length ; i++)
                {
                    if (consonant(word[i]) == consonant(word[i-1]))
                    {
                        control= true;
                    }
                }
                Console.Write(control+ " ");
            }
            bool consonant(char x)
            {
                return !"aeıioöuü".ToCharArray().Contains(x);
            }
        }
    }
}