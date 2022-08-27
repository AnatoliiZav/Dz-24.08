        
// Пользователь вводит M чисел. Посчитайте количество чисел больше 0.


int num(int M)
{
    int sum =0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Ввведите число:  ");
        int numer =  int.Parse(Console.ReadLine());
        if (numer > 0)
        {
            sum ++;
        }
    }
    return sum;
}


Console.WriteLine("Ввведите количество чисел:  ");
int M =  int.Parse(Console.ReadLine());
int myArray = num(M);   
Console.WriteLine($"Количество положительных чисел {myArray}");