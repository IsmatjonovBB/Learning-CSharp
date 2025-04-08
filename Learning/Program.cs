using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

////bool isTrue = true; //true
////bool isFalse = false; //false

////byte bit1 = 1; // fron 0 to 255
////byte bit2 = 255;

////sbyte bit3 = -128; //from -128 to 127
////sbyte bit4 = 127;

////short n1 = -32768; //from -32768 to 32767
////short n2 = 32767;

////ushort n3 = 0;  //from 0 to 65535
////ushort n4 = 65535;

////int number = -2147483648; //from -2147483648 to 2147483647
////int number2 = 2147483647;

////uint number3 = 0; //Use ['U' or 'u'] in end of value!!!
////uint number4 = 4294967295;

////long m1 = -9223372036854775808; //from -9223372036854775808 to 9223372036854775807 [Use L or l]
////long m2 = 9223372036854775807;

////ulong m3 = 0;
////ulong m4 = 18446744073709551615;

////float f1 = -3.4f; //from -3.4*10^38 to 3.4*10^38 [Use F or f]
////float f2 = 3.4f;

////double d1 = -0.5 * 0.00000000000001; //from ±5.0*10^-324 to ±1.7*10^308
////double d2 = 0.5 * 1000000000000000;

////decimal dm1 = 1005.8M; //from ±1.0*10^-28 to ±7.9228*10^28 [Use M or m]
////decimal dm2 = 334.8m; 


////char a =  'a'; //Get only one symbol
////char b = 'B';
////char c = '\u0420';

////string name = "Bakhtovar";

////object objSurname = "Ismatjonov"; //Get all data types
////object objAge = 18;
////object _weight = 60.05;
////object haveGF = false;

////System.Int32 mainNumber = 69;
////System.String mainText = "I cannot speak Hello!";

////var hello = "Hello to World!";
////var x = 20;

//////string firstName = "Ismatjonov";
//////string lastName = "Bakhtovar";
//////int age = 18;
//////double weight = 59.54;
//////bool isEmployed = false;

//////Console.WriteLine($"Firstname: {firstName}");
//////Console.WriteLine($"Lastnmae: {lastName}");
//////Console.WriteLine($"Age: {age}");
//////Console.WriteLine($"Weight: {weight}");
//////Console.WriteLine($"Is he working: {isEmployed}");


//Console.Write("Enter your name: ");
//string? name = Console.ReadLine();

//Console.Write("Enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter your height: ");
//double height = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter your size of salary: ");
//decimal salary =  Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine($"Name:{name}, Age:{age}, Height:{height}, Salary:{salary}$");

//int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
//int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

//int encrypt = x ^ key; //Результатом будет число 1001011 или 75
//Console.WriteLine($"Зашифрованное число: {encrypt}");

//int decrypt = encrypt ^ key; // Результатом будет исходное число 45
//Console.WriteLine($"Расшифрованное число: {decrypt}");

//int a = 9;  // 1001 
//int b = 5;  // 0101

//a = a ^ b;  // a = 1001 ^ 0101 = 1100 = 12
//b = a ^ b;  // b = 12 ^ 5 = 1100 ^ 0101 = 1001 = 9
//a = a ^ b;  // a = 12 ^ 9 = 1100 ^ 1001 = 0101 = 5

//Console.WriteLine($"a: {a}");  // 5
//Console.WriteLine($"b: {b}");  // 9

//int a = 16; // в двоичной форме 10000
//int b = 2; // в двоичной форме
//int c = a << b; // Сдвиг числа 10000 влево на 2 разряда, равно 1000000 или 64 в десятичной системе

//Console.WriteLine($"Зашифрованное число: {c}");    // 64

//int d = a >> b; // Сдвиг числа 10000 вправо на 2 разряда, равно 100 или 4 в десятичной системе
//Console.WriteLine($"Зашифрованное число: {d}");     // 4

//int value1 = 3;  // 0b0000_0011
//int value2 = 2;  // 0b0000_0010
//int value3 = 1;  // 0b0000_0001
//int result = 0b0000_0000;
//// сохраняем в result значения из value1
//result = result | value1; // 0b0000_0011
//// сдвигаем разряды в result на 2 разряда влево
//result = result << 2;   // 0b0000_1100
//// сохраняем в result значения из value2
//result = result | value2;  // 0b0000_1110
//// сдвигаем разряды в result на 2 разряда влево
//result = result << 2;   // 0b0011_1000
//// сохраняем в result значения из value3
//result = result | value3;  // 0b0011_1001

//Console.WriteLine(result);  // 57

//// обратное получение данных
//int newValue3 = result & 0b000_0011;
//// сдвигаем данные на 2 разряда вправо
//result = result >> 2;
//int newValue2 = result & 0b000_0011;
//// сдвигаем данные на 2 разряда вправо
//result = result >> 2;
//int newValue1 = result & 0b000_0011;
//Console.WriteLine(newValue1);    // 3
//Console.WriteLine(newValue2);   // 2
//Console.WriteLine(newValue3);   // 1

//int a = 10;
//a += 10;        // 20
//a -= 4;         // 16
//a *= 2;         // 32
//a /= 8;         // 4
//a <<= 4;      // 64
//a >>= 2;      // 16

//Console.WriteLine(a);

//byte a = 4;
//byte b = (byte)(a + 70);
//Console.WriteLine(b);

//var i = 1;

//for (Console.WriteLine("Начало выполнения цикла"); i < 4; Console.WriteLine($"i = {i}"))
//{
//    i++;
//}

//int i = 1;
//for (;  i < 4;)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//for (int i = 1, j = 1; i < 10; i++, j++)
//    Console.WriteLine($"{i * j}");

//int i = -1;
//do
//{
//    Console.WriteLine(i);
//    i--;
//}
//while (i > 0);

//int i = 6;
//while (i > 0)
//{
//    Console.WriteLine(i);
//    i--;
//}

//foreach (var c in "12345678")
//{
//    Console.WriteLine(c);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//        continue;
//    Console.WriteLine(i);
//}

//for (int i = 2; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        Console.WriteLine($"{i * j} \t");
//    }
//    Console.WriteLine();
//}

//Console.Write("Your Deposit: ");
//decimal deposit = Convert.ToDecimal(Console.ReadLine());
//Console.Write("How long do you wand to save your deposit: ");
//int month = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < month; i++)
//{
//    deposit += deposit * 0.07M;
//}
//Console.WriteLine(deposit);

//Console.Write("Your Deposit: ");
//decimal deposit = Convert.ToDecimal(Console.ReadLine());
//Console.Write("How long do you wand to save your deposit: ");
//int month = Convert.ToInt32(Console.ReadLine());

//int i = month;
//while (i > 0)
//{
//    deposit += deposit * 0.07M;
//    i--;
//}
//Console.WriteLine(deposit);

//for (int i = 1; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i * j} \t");
//    }
//    Console.WriteLine();
//}
//}

//while (true)
//{
//    int a = Convert.ToInt32(Console.ReadLine());
//    int b = Convert.ToInt32(Console.ReadLine());
//    if (a < 0 || a > 10 || b < 0 || b > 10)
//    {
//        Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
//    }
//    else
//    {
//        Console.WriteLine($"{a} * {b} = {a * b}");
//        break;
//    }
//}

//int[] nums = new int[4] { 1, 2, 3, 5 };
//int[] nums2 = new int[] { 1, 2, 3, 5 };
//int[] nums4 = new[] { 1, 2, 3, 5 };
//int[] nums5 = { 1, 2, 3, 5 };

//string[] people = { "Tom", "Sam", "Bob" };

//int[] number = {1, 2, 3, 4, 5, 6 };
//Console.WriteLine(number[5]);

//int[] num = [1, 2, 3, 5];
//Console.WriteLine(num[2]);

//int[] nums = { 1, 2, 3, 5, 9, 4, 67, 21, 54, 24 };

//foreach (int num in nums)
//{
//    Console.WriteLine(num);
//}

//for (int i = 0; i < nums.Length; i++)
//{
//    nums[i] = nums[i] * 2;
//    Console.WriteLine(nums[i]);
//}

//int i = 0;
//while (i < nums.Length)
//{
//    Console.WriteLine(nums[i]);
//    i++;
//}

//int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
//int[,] nums2 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };

//int[,] nums1;
//int[,] nums2 = new int[2, 3];
//int[,] nums3 = new int[2, 4] { { 0, 1, 2, -1 }, { 3, 4, 5, -2 } };
//int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
//int[,] nums6 = { { 0, 1, 2}, {  3, 4, 5 } };

//int[,,] nums3 = new int[2, 3, 4];

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

//Console.WriteLine(numbers.GetUpperBound(0));
//Console.WriteLine(numbers.GetUpperBound(1));

//int rows = numbers.GetUpperBound(0) + 1;
////int columns = numbers.Length / rows;
//int columns = numbers.GetUpperBound(1) + 1;

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{numbers[i, j]} \t");
//    }
//    Console.WriteLine('\n');
//}

//int[][] numbers = new int[3][];
//numbers[0] =  new int[2] { 1, 2 };    // выделяем память для первого подмассива
//numbers[1] = new int[3] { 3, 4, 5 };  // выделяем память для второго подмассива
//numbers[2] = new int[5] { 6, 7, 8, 9, 10 };   //выделяем память для третьего подмассива

//int[][] numbers = {
//    new int[] { 1, 2 },
//    new int[] { 3, 4, 5 },
//    new int[] { 6 }
//};

//int[][] numbers = new int[3][];
//numbers[0] = new int[] { 1, 2 };
//numbers[1] = new int[] { 1, 2, 3 };
//numbers[2] = new int[] { 1, 2, 3, 4, 5 };
////foreach (int[] row in numbers)
////{
////    foreach (int number in row)
////    {
////        Console.Write($"{number} ");
////    }
////    Console.WriteLine();
////}

////Console.WriteLine(numbers[2][4]);

//// перебор с помощью цикла for
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = 0; j < numbers[i].Length; j++)
//    {
//        Console.Write($"{numbers[i][j]}\t");
//    }
//    Console.WriteLine();
//}

//int[,,] mas = { 
//                { { 1, 2 },{ 3, 4 } },
//                { { 4, 5 }, { 6, 7 } },
//                { { 7, 8 }, { 9, 10 } },
//                { { 10, 11 }, { 12, 13 } }
//              };

//int x = mas.GetUpperBound(0); // 3
//int y = mas.GetUpperBound(1); // 1
//int z = mas.GetUpperBound(2); // 1

//Console.Write("{");
//for (int i = 0; i <= x; i++)
//{
//    Console.Write("{");
//    for (int j = 0; j <= y; j++)
//    {
//        Console.Write("{");
//        for (int k = 0; k <= z; k++)
//        {
//            Console.Write(mas[i, j, k]);
//            if (k < z)
//                Console.Write(" , ");
//        }

//        Console.Write("}");
//        if (j < y)
//            Console.Write(" , ");
//    }
//    Console.Write("}");

//    if (i < x)
//        Console.Write(" , ");
//}
//Console.Write("}");



//void SayHelloRu()
//{
//    Console.WriteLine("Привет!");
//}
//void SayHelloEn()
//{
//    Console.WriteLine("Hello");
//}
//void SayHelloFr()
//{
//    Console.WriteLine("Salut");
//}

//string language = "ru";

//switch (language)
//{
//    case "en": SayHelloEn(); break;
//    case "ru": SayHelloRu(); break;
//    case "fr": SayHelloFr(); break;
//    default: Console.WriteLine("Wrong type!"); break;
//}

//void PrintMessage(string message)
//{
//    Console.WriteLine(message);
//}

//PrintMessage("Hello My Name is Bakhtovar");
//PrintMessage("Hello C#");
//PrintMessage("Hello METANIT.COM");

//void Summ(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

//int a = 10, b = 20, c = 30;
//Summ(a, b);

//void PrintPerson(string name, int age = 1, string company = "Undefined")
//{
//    Console.WriteLine($"Name: {name}, Age: {age}, Company: {company}");
//}

//PrintPerson("Tom", company: "Apple", age: 20);
//PrintPerson(age: 22, name: "Bob");
//PrintPerson(company: "Google", name: "Sam");

//string GetMessage() => "Hello World!";
//void PrintMessage(string message)
//{
//    Console.WriteLine(message);
//}

//PrintMessage(GetMessage());

//int Summa(int x, int y) => x + y;

//int result = Summa(10, 15);
//Console.WriteLine(result);

//Console.WriteLine(Summa(5, 6));

//string GetHello()
//{
//    return "Hello Everyone!";
//    Console.WriteLine("After return");
//}

//void PrintPerson(string name, int age)
//{
//    if (age > 120 || age < 1)
//    {
//        Console.WriteLine("Avaliable age!");
//        return;
//    }
//    Console.WriteLine($"Name: {name}, Age: {age}");
//}

//PrintPerson("Tom", 37);
//PrintPerson("Bakhtovar", 1234);

//void Increment(ref int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}

//int number = 5;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(ref number);
//Console.WriteLine($"Число после метода Increment: {number}");

//void Summa(int x, int y, out int result)
//{
//    result = x + y;
//}

//int number;

//Summa(10, 15, out number);
//Console.WriteLine(number);

//void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
//{
//    rectArea = width * height;
//    rectPerimetr = (width + height) * 2;
//}

//int area;
//int perimetr;

//GetRectangleData(10, 20, out area, out perimetr);

//Console.WriteLine($"Площадь прямоугольника: {area}");
//Console.WriteLine($"Периметр прямоугольника: {perimetr}");

//void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
//{
//    rectArea = width * height;
//    rectPerimetr = (width + height) * 2;
//}

//int w = 20;
//int h = 10;

//GetRectangleData(w, h, out var area, out var perimetr);

//Console.WriteLine($"The Area is {area}");
//Console.WriteLine($"The Perimetr is {perimetr}");

//void Checking(ref int n)
//{
//    n++;
//    Console.WriteLine($"Number is {n}");
//}

//int number = 12;
//Console.WriteLine($"The number before method is {number}");
//Checking(ref number);
//Console.WriteLine($"The number after method is {number}");

//void Checking(ref readonly int n)
//{
//    //n++; Error is here | You shoudn`t change parametres, because you use "readonly"
//    Console.WriteLine($"The number is {n}");
//}

//int number = 12;

//Console.WriteLine($"The number before nethod is {number}");
//Checking(ref number);
//Console.WriteLine($"The numebr after method is {number}");

//void Sum(int[] numbers, int initualValue)
//{
//    int result = initualValue;
//    foreach (int number in numbers)
//    {
//        result += number;
//    }
//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(nums, 10);

//Sum( 1, 3); It doesn`t work!

//int Factorial(int n)
//{
//    if (n == 1) return 1;

//    return n * Factorial(n - 1);
//}

//int factorial4 = Factorial(4);  // 24
//int factorial5 = Factorial(5);  // 120
//int factorial6 = Factorial(6);  // 720

//Console.WriteLine($"Факториал числа 4 = {factorial4}");
//Console.WriteLine($"Факториал числа 5 = {factorial5}");
//Console.WriteLine($"Факториал числа 6 = {factorial6}");

//int Fibonachi(int n)
//{
//    if (n == 0 ||  n == 1) return n;

//    return Fibonachi(n - 1) + Fibonachi(n - 2);
//}


//int fib4 = Fibonachi(4);
//int fib5 = Fibonachi(5);
//int fib6 = Fibonachi(6);

//Console.WriteLine($"4 число Фибоначчи = {fib4}");
//Console.WriteLine($"5 число Фибоначчи = {fib5}");
//Console.WriteLine($"6 число Фибоначчи = {fib6}");

//static int Fibonachi2(int n)
//{
//    int result = 0;
//    int b = 1;
//    int tmp;

//    for (int i = 0; i < n; i++)
//    {
//        tmp = result;
//        result = b;
//        b += tmp;
//    }

//    return result;
//}

//Console.WriteLine(Fibonachi2(4))


//void Compare(int[] numbers1,  int[] numbers2)
//{
//    int numbers1Sum = Summa(numbers1);
//    int numbers2Sum = Summa(numbers2);

//    if (numbers1Sum > numbers2Sum)
//        Console.WriteLine($"Сумма чисел из массива number1 больше");
//    else if (numbers1Sum < numbers2Sum)
//        Console.WriteLine($"Сумма чисел из массива number2 больше");
//    else
//        Console.WriteLine($"Суммаи чисел обоих массивов равны");

//    int Summa(int[] numbers)
//    {
//        int result = 0;
//        foreach (int number in numbers)
//        {
//            result += number;
//        }
//        return result;
//    }

//}

//int[] numbers1 = { 1, 2, 3, 4, 5, 9 };
//int[] number2 = { 6, 7, 8 };

//Compare(numbers1, number2);


//int Sum(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        if (IsPassed(number)) result += number;
//    }
//    return result;

//    bool IsPassed(int number)
//    {
//        return number > limit;
//    }
//}

//int[] number1 = { -3, -2, -1, 0, 1, 2, 3 };
//int[] number2 = { 3, -4, 5, -6, 7 };

//Console.WriteLine(Sum(number1));
//Console.WriteLine(Sum(number2));


//int Sum(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        if (IsPassed(number, limit)) result += number;
//    }
//    return result;

//    static bool IsPassed(int number, int lim)
//    {
//        //return number > limit; Ошибка потому, что метод IsPassed не имеет доступ к переменной limit
//        return number > lim;
//    }
//}

//int[] number1 = { -3, -2, -1, 0, 1, 2, 3 };
//int[] number2 = { 3, -4, 5, -6, 7 };

//Console.WriteLine(Sum(number1));
//Console.WriteLine(Sum(number2));


//string name = "Alex";

//switch (name)
//{
//    case "Bob": Console.WriteLine($"Ваша имя Bob"); break;
//    case "Tom": Console.WriteLine("Ваша имя Tom"); break;
//    case "Sam": Console.WriteLine("Ваша имя Sam"); break;
//    default: Console.WriteLine("Неизвестное имя"); break;
//}


//int number = 1;

//switch (number)
//{
//    case 1:
//        Console.WriteLine("Case 1");
//        goto case 5;
//    case 2:
//        Console.WriteLine("Case 2");
//        break;
//    case 5:
//        Console.WriteLine("Case 5");
//        break ;
//    default:
//        Console.WriteLine("Default");
//        break;
//}


//int DoOperation(int op, int a, int b)
//{
//    switch (op)
//    {
//        case 1: return a + b;
//        case 2: return a - b;
//        case 3: return a * b;
//        default: return 0;
//    }
//}
//int result = DoOperation(2, 5, 2);
//Console.WriteLine(result);

//int DoOperation(int op, int a, int b)
//{
//    int result = op switch
//    {
//        1 => a + b,
//        2 => a - b,
//        3 => a * b,
//        _ => 0
//    };
//    return result;
//}
//Console.WriteLine(DoOperation(1, 2, 3));

//int DoOperation(int op, int a, int b) => op switch
//{
//    1 => a + b,
//    2 => a - b,
//    3 => a * b,
//    _ => 0
//};
//Console.WriteLine(DoOperation(1, 2, 4));



//const DayTime dayTime = DayTime.Morning;

//DayTime dayTime = DayTime.Morning;

//if (dayTime == DayTime.Morning)
//    Console.WriteLine("Доброе утро!");
//else
//    Console.WriteLine("Привет!");




//DayTime now = DayTime.Evening;

//PrintMessage(now);
//PrintMessage(DayTime.Afternoon);
//PrintMessage(DayTime.Night);

//void PrintMessage(DayTime dayTime)
//{
//    switch (dayTime)
//    {
//        case DayTime.Morning:
//            Console.WriteLine("Доброе утро!");
//            break;
//        case DayTime.Afternoon:
//            Console.WriteLine("Добрый день!");
//            break;
//        case DayTime.Evening:
//            Console.WriteLine("Добрый вечер!");
//            break;
//        case DayTime.Night:
//            Console.WriteLine("Доброй ночи!");
//            break;
//    }
//}
//enum DayTime
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}

//DayTime now = DayTime.Afternoon;

//Console.WriteLine((double)DayTime.Afternoon);  // 0
//Console.WriteLine((double)DayTime.Night);  // 3
//enum DayTime
//{
//    Morning = 1,
//    Afternoon,
//    Evening,
//    Night
//}


//void ResultOperation(int x, int y, Operation opera)
//{
//    int result = opera switch
//    {
//        Operation.Add => x + y,
//        Operation.Subtract => x - y,
//        Operation.Mutliply => x * y,
//        Operation.Divide => x / y,
//    };
//    Console.WriteLine(result);
//}
//ResultOperation(10, 5, Operation.Mutliply);
//enum Operation
//{
//    Add,
//    Subtract,
//    Mutliply,
//    Divide
//}

//Console.Write("What is your name?: 

//Person tom = new() { name = inputedName, address = { location = inputedLocation }, company = { title = inputedCompany }, car = { name = inputedCarName, age = inputedCarAge, color = inputedcarColor } };
//tom.Print();

