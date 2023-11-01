// See https://aka.ms/new-console-template for more information
                int a = 0, b = 1, c;
                Console.WriteLine(" enter your number");
                int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{a}\t{b}\t");
for (int i = 2; i <= n; i++) 
{
    c = a + b;
    Console.WriteLine($"{c}\t");
    a = b;
    b = c;
}
  // amirhossein azarakhsh.tamrine4