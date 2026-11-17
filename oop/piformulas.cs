using System;

class Program
{
    static void Main()
    {
        double accuratePi = 3.141592653589;
        double diff = 0.0001;

        // Leibnitz Pi convergence search
        int i = 1;
        while (Math.Abs(LeibnitzPi(i) - accuratePi) > diff)
        {
            i++;
        }
        Console.WriteLine(i);

        // Euler Pi calculation for n = 10
        Console.WriteLine(EulerPi(10));

        // Euler Pi convergence search
        diff = 0.0001;
        i = 1;
        while (Math.Abs(EulerPi(i) - accuratePi) > diff)
        {
            i++;
        }
        Console.WriteLine(i);
    }

    static double LeibnitzPi(int n)
    {
        double sign = 1;
        double pi = 0;
        for (int i = 0; i <= n; i++)
        {
            sign *= -1;
            pi += sign * 1.0 / (2 * i + 1);
        }
        return pi * 4;
    }

    static double EulerPi(int n)
    {
        double pi = 0;
        for (int i = 1; i <= n; i++)
        {
            pi += 1.0 / (i * i);
        }
        return Math.Sqrt(pi * 6);
    }
}