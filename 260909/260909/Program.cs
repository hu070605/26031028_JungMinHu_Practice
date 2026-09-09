using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //    Console.WriteLine(sizeof(int));
        //    Console.WriteLine(sizeof(float));

        //    string message1 = "안녕하세요. 방갑습니다";
        //    string message2 = "abcde. fghij.";

        //    Console.WriteLine(message1[0]);
        //    Console.WriteLine(message1[1]);
        //    Console.WriteLine(message1[2]);
        //    Console.WriteLine(message1[3]);
        //    Console.WriteLine(message1[4]);

        //    Console.WriteLine(message1.Length);
        //    Console.WriteLine(message2.Length);



        //    System.Int32 val;
        //    System.Single val2;

        //    string m1 = "Hello";
        //    m1 += " world";


        //    string resDir = "resource/";

        //    string textureFile = "m1.png";

        //    string texPath = resDir;
        //    texPath += textureFile;

        //    //texture load;

        //    Console.WriteLine(m1);


        //// 단항 연산자
        //int value = 100;
        //int result = 0;

        //result = ++value; Console.WriteLine($"result: {result} value: {value}");  // value += 1;
        //result = --value; Console.WriteLine($"result: {result} value: {value}");  // value -= 1;  



        //var vall1 = 0; Console.WriteLine();
        //var vall2 = 0; 

        //var inputString = Console.ReadLine();
        //Console.WriteLine(inputString);

        var val1 = 1000L;
        var val2 = 2000L;

        long valc = val1 + val2;
        float valf = valc;
        double vald = valf;

        valf = (float)vald;
        valc = (long)valf;
        val1 = (int)valc;

        var str = "20000";
        val1 = int.Parse(str);
        valc = long.Parse(str);

        //val1.ToString();
        //valc.ToString();
        //valf.ToString();
        //vald.ToString();

        //var b1 = bool.Parse("TRUE"); Console.WriteLine($"b1: type {b1.GetType()}: b1");
        //var b2 = bool.Parse("FALSE"); Console.WriteLine($"b2: type {b2.GetType()}: b2");
        int valMin = int.MinValue; Console.WriteLine(valMin);
        valMin = -2147483648;
        Console.WriteLine(-valMin);
        //int valMax - int.MaxValue; Console.WriteLine(valMax);

    }
}