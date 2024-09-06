using System;

class Program
{
    static void Main()
    {
        // قراءة قيمة L
        int L = int.Parse(Console.ReadLine());

        // قراءة عدد الصور N
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            // قراءة أبعاد الصورة W و H
            string[] dimensions = Console.ReadLine().Split(' ');
            int W = int.Parse(dimensions[0]);
            int H = int.Parse(dimensions[1]);

            // تطبيق الشروط
            if (W < L || H < L)
            {
                Console.WriteLine("UPLOAD ANOTHER");
            }
            else if (W == H)
            {
                Console.WriteLine("ACCEPTED");
            }
            else
            {
                Console.WriteLine("CROP IT");
            }
        }
    }
}

