///////        VAZIFA - 1      ///////


//// begin 1
//Console.Write("Kvadrat tomonini kiriting: ");
//int a = int.Parse(Console.ReadLine());
//int P;
//P = 4 * a;
//Console.WriteLine("Peremetri = " + P);


//// begin 2
//Console.Write("Kvadrat tomonini kiriting: ");
//int b = int.Parse(Console.ReadLine());
//int S;
//S = b * b;
//Console.WriteLine("Yuzasi = " +  S);


//// begin 3
//Console.Write("a Tomonini kiriting: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("b Tomonini kiriting: ");
//int b = int.Parse(Console.ReadLine());
//int S;
//int P;
//S = a * b;
//P = 2 * ( a + b );
//Console.WriteLine("Yuzasi : " + S);
//Console.WriteLine("Peremetri : " +  P);


//// begin 4 
//const double PI = 3.14;```
//Console.Write("Raidusni kiriting: ");
//int R = int.Parse(Console.ReadLine());
//double L;
//L = PI * R;
//Console.WriteLine("Aylana uzunligi: " + L);


////begin 5
//Console.Write("Kub qirrasini kiriting: ");
//int a = int.Parse(Console.ReadLine());
//int V;
//int S;
//V = a * a * a;
//S = 6 * a * a;
//Console.WriteLine("Kub hajmi: " + V);
//Console.WriteLine("Kub to'la sirti: " + S);


////begin 6
//Console.Write("Paralelopipedning qirralarini kiriting: ");
//var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int V;
//int S;
//V = num[0] * num[1] * num[2];
//S = 2 * (num[0] * num[1] + num[1] * num[2] + num[0] * num[2]);
//Console.WriteLine(" Hajmi: " + V);
//Console.WriteLine(" Yuzasi: " + S);


////begin 7
//const double PI = 3.14;
//Console.Write("Raidusni kiriting: ");
//int R = int.Parse(Console.ReadLine());
//double L;
//double S;
//L = PI * R;
//S = PI * R * R; 
//Console.WriteLine("Doira uzunligi: " + L  + "  Doira yuzasi: " + S);


////begin 8
//float a = float.Parse(Console.ReadLine());
//float b = float.Parse(Console.ReadLine());
//float c;
//c = (a + b) / 2;
//Console.WriteLine(c);


////begin 9
//float a = float.Parse(Console.ReadLine());
//float b = float.Parse(Console.ReadLine());
//double c;
//if (a > 0 && b > 0)
//{
//    c = Math.Sqrt(a * b);
//    Console.WriteLine(c);
//}
//else
//{
//    Console.WriteLine("Narmalniy son kiriting brat!!! f.e  3 bilan 5");
//}


////begin 10
//float a = float.Parse(Console.ReadLine());
//float b = float.Parse(Console.ReadLine());
//float c;
//float d;
//float e;
//if (a != 0 && b != 0)
//{
//    c = a + b;
//    d = a - b;
//    e = a * b;
//    Console.WriteLine("Yigindisi: " + c * c  + "   Ayrimasi: " + d * d + "   Kopaytmasi: " + e * e);
//}


////begin 24
//double A = double.Parse(Console.ReadLine());
//double B = double.Parse(Console.ReadLine());
//(A, B) = (B, A);
//Console.WriteLine($"  {A}  {B}");


////begin 23
//double A = double.Parse(Console.ReadLine());
//double B = double.Parse(Console.ReadLine());
//double C = double.Parse(Console.ReadLine());
//(A, B, C) = (C, A, B);
//Console.WriteLine($"  {A}  {B}  {C}");


////begin 24
//double A = double.Parse(Console.ReadLine());
//double B = double.Parse(Console.ReadLine());
//double C = double.Parse(Console.ReadLine());
//(A, B, C) = (B, C, A);
//Console.WriteLine($"  {A}  {B}  {C}");


////begin 25
//int x = int.Parse(Console.ReadLine());
//int y;
//y = 3 * x * x * x * x * x * x - 6 * x * x - 7;
//Console.WriteLine(y);


////begin 27
//int A = int.Parse(Console.ReadLine());
//int A2;
//int A4;
//int A8;
//A2 = A * A;
//A4 = A2 * A2;
//A8 = A4 * A2;
//Console.WriteLine($" {A2}  {A4}  {A8}");


////begin 28
//int A = int.Parse(Console.ReadLine());
//int A2;
//int A3;
//int A5;
//int A10;
//int A15;
//A2 = A * A;
//A3 = A2 * A;
//A5 = A3 * A2;
//A10 = A5 * A5;
//A15 = A10 * A5;
//Console.WriteLine($" {A2}  {A3}  {A5}  {A10}  {A15}");


////begin 33
//int x = int.Parse(Console.ReadLine());
//int A = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//int kg = A / x;
//y = y * kg;
//Console.WriteLine(kg);
//Console.WriteLine(y);

////begin 34
//int x = int.Parse(Console.ReadLine());
//int A = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//int B = int.Parse(Console.ReadLine());
//int kg = A / x;
//int kh = B / y;
//int sum1;
//sum1 = kg + kh;
//int sum2;
//sum2 = kg - kh;
//Console.WriteLine(sum1);
//Console.WriteLine(sum2);

////begin 38
//var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int A = num[0];
//int B = num[1];
//int x;
//if(A != 0)
//{
//    x = (-B) / A;
//    Console.WriteLine(x);
//}

