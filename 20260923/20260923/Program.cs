class Program
{
    static void Main(string[] args)
    {
        //16 - for문으로 1~100 사이의 짝수 출력
        for (int number16 = 2; number16 <= 100; number16 += 2)
        {
            Console.WriteLine(number16);
        }


        //17 - while문으로 0~10 출력
        int number17 = 0;

        while (number17 <= 10)
        {
            Console.WriteLine(number17);
            number17++;
        }


        //18 - do -while문으로 1~10 사이의 홀수 출력
        int number18 = 1;

        do
        {
            Console.WriteLine(number18);
            number18 += 2;
        }
        while (number18 <= 10);


        //19 - 이중 for문으로 피라미드 출력
        int height = 8;

        for (int row = 1; row <= height; row++)
        {
            for (int space = 0; space < height - row; space++)
            {
                Console.Write(" ");
            }

            for (int star = 0; star < row * 2 - 1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


        //20 - 숫자 5개의 최댓값과 최솟값 출력
        int maximum = 0;
        int minimum = 0;

        for (int count = 0; count < 5; count++)
        {
            Console.Write("숫자를 입력해주세요. : ");
            int inputNumber = int.Parse(Console.ReadLine());

            if (count == 0)
            {
                maximum = inputNumber;
                minimum = inputNumber;
            }
            else
            {
                if (inputNumber > maximum)
                {
                    maximum = inputNumber;
                }

                if (inputNumber < minimum)
                {
                    minimum = inputNumber;
                }
            }
        }

        Console.WriteLine($"최댓값 : {maximum}");
        Console.WriteLine($"최솟값 : {minimum}");
    }
}