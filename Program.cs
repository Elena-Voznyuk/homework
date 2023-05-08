//Задача 19
void Palindrome(int n)
{
int a = n % 10;
int b = n / 10000;
int c = n % 100;
int d = c / 10;
int e = n % 10000;
int f = e / 1000;
    if (a == b && d == f)
        Console.WriteLine("This number is palindrome");
    else
        Console.WriteLine("This number is not palindrome");
}       
Console.WriteLine("Input your number");
int number = Convert.ToInt32(Console.ReadLine());
    if (number > 9999 && number < 100000)
        Palindrome(number);
    else
    Console.WriteLine("This is not a five-digit number");







//Задача 21
/*
void Coordinats(int x1, int y1, int z1, int x2, int y2, int z2)
{
 double distance = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
 Console.WriteLine($"Distance between A-B is {distance}");
}
Console.WriteLine("Input your x-coordinate of A");
int x_coordinate_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your y-coordinate of A");
int y_coordinate_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your z-coordinate of A");
int z_coordinate_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your x-coordinate of B");
int x_coordinate_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your y-coordinate of B");
int y_coordinate_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your z-coordinate of B");
int z_coordinate_b = Convert.ToInt32(Console.ReadLine());
Coordinats(x_coordinate_a,y_coordinate_a, z_coordinate_a, x_coordinate_b, y_coordinate_b, z_coordinate_b);  
*/

//Задача 23
/*void Cube(int n)
{
int current_i = 1;
while (current_i <= n)
       {
        double current_cube = Math.Pow(current_i, 3);
        current_i ++;
        Console.Write($"{current_cube}, ");
       }
Console.Write("\b\b.");      
}
Console.WriteLine("Input your number N:");
int number_N = Convert.ToInt32(Console.ReadLine());
Cube(number_N);
*/ 