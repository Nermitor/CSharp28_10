using System;
using System.IO;

namespace CSharp28_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test(@"C:\Users\dmaty\RiderProjects\CSharp28_10\test.txt");
        }

        public static void Test(string inputFile)
        {
            StreamReader reader = new StreamReader(inputFile);

            int n = Convert.ToInt32(reader.ReadLine());

            BaseClass[] objects = new BaseClass[n];

            for (int i = 0; i < n; i++)
            {
                string curLine = reader.ReadLine();

                switch (curLine[0])
                {
                    case 'S':
                        objects[i] = Singleton.Instance();
                        break;
                    case 'D':
                        if (curLine[1] == '1')
                            objects[i] = Doubleton.Instance1();
                        else if (curLine[1] == '2')
                            objects[i] = Doubleton.Instance2();
                        break;
                    case 'T':
                        objects[i] = TenTon.Instance(Convert.ToInt32(curLine[1].ToString()));
                        break;
                }
            }

            n = Convert.ToInt32(reader.ReadLine());
            string[] raw;
            int index, increment;
            for (int i = 0; i < n; i++)
            {
                raw = reader.ReadLine().Split();
                index = Convert.ToInt32(raw[0]);
                increment = Convert.ToInt32(raw[1]);
                objects[index].IncData(increment);
            }

            foreach (BaseClass o in objects)
            {
                Console.WriteLine(o.GetData());
            }
        }
    }
}