//вывести квадрат числа
/* 
int F(int x)
{
   return x*x;
}
Console.WriteLine("Введите число: ");
int total= F(int.Parse(Console.ReadLine()));
Console.WriteLine(total); */

// По двум заданным числам проверить является ли первое квадратом второго

/* Console.WriteLine("Введите 1ое число: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2ое число: ");
int second = int.Parse(Console.ReadLine());

if (second==Math.Sqrt(first))
{
    Console.WriteLine("Да, является");
}
else
{
    Console.WriteLine("Нет, не является");
} */
// По двум заданным числам проверить является ли первое квадратом второго через метод
/* void A(int first, int second)
{
    if (second==Math.Sqrt(first))
    {
    Console.WriteLine("Да, является");
    }
    else
    {
    Console.WriteLine("Нет, не является");
    }
}
A(6, 2); */

// Даны два числа показать большее и меньшее число

/* void A(int first, int second)
{
    if (second>first)
    {
    Console.WriteLine($"Большее число = {second} Меньшее число = {first}" );
    }
    else
    {
        Console.WriteLine($"Большее число = {first} Меньшее число = {second}" );
    }
    if (second==first)
    { Console.WriteLine("Никто");
    }
}
A(3, 12); */


/* void A (int day)
{
 while (!(day >= 1 && 7 <= day))// пока числа находятся за пределом данного отрезка предлагать заново вести число
{
         if (day== 1)
 {
     Console.WriteLine("Понедельник");
 }
if (day==2)
 {
     Console.WriteLine("Вторник");
 }
 if (day==3)
 {
     Console.WriteLine("Среда");
 }
if (day==4)
 {
     Console.WriteLine("Четверг");
 }
 if (day==5)
 {
     Console.WriteLine("Пятница");
 }
 if (day==6)
 {
     Console.WriteLine("Суббота");
 }
 if (day==7)
 {
     Console.WriteLine("Воскресенье");
 }
 break;
} 
}
A(5); */

//Найти максимальное из 3 чисел

//int max(int []array)

/* int[] array= {121,9,100};   
int maxvalue=array[0];
int i=0;
while (i< array.Length)
{
  if (array[i]>maxvalue)
  {
      maxvalue=array[i];
  }
 i++; 
}
 Console.WriteLine(maxvalue);
 */

//Найти максимальное из 3 чисел с помощью метода

/* void method(int []array)
{  
int maxvalue=array[0];
int i=0;
while (i< array.Length)
{
  if (array[i]>maxvalue)
  {
      maxvalue=array[i];
  }
 i++; 
}
}
method(2}; */

//Написать программу вычисления значения функции y=f(a) 

/* double method (double a)
{
    a=Math.Sin(a);
    return a;
    Console.WriteLine(a);
}
method(30); */

//Написать программу вычисления значения функции y=f(a) для ввода радиан
/* Console.WriteLine ("Введите число для вычисления функиции = ");
int a = int.Parse(Console.ReadLine());
double sin=Math.Sin(a);
 Console.WriteLine(sin); */

//Написать программу вычисления значения функции y=f(a) для ввода радиан через метод
/* double met (double a)
{
double sin=Math.Sin(a);
return sin;
}
double  res = met(50);
Console.WriteLine(res); */


//Выяснить является ли число чётным

/* void met (int a)
{

if (a%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
}
met(4); */

//Показать числа от -N до N

/* void met (int N)
{
int count = -N;
while (count<= N)
{
    Console.WriteLine(count);
     count++;
}
}
met(15); */


//Показать четные числа от 1 до N 

/* int met (int N)
{ 
int count = 1;
while (count< N-1)
{
    if (count % 2==0)
    {
     Console.WriteLine(count);
     count++;
     
    }
    count++;
    
}
return count;
}
int number = met(17);
Console.WriteLine(number); */

/* int N = 30;
int count = 1;
while (count< N)
{
    if (count % 2==0)
    {
     Console.WriteLine(count);
     count++;
    }
    else
    {
        count++;
    }
} */

//Показать последнюю цифру трёхзначного числа

/* void met (int a)
{
   a= a % 10;
   Console.WriteLine(a);
}
met(125); */

//Показать вторую цифру трёхзначного числа

/* void met (int a)
 {
    a= (a % 100)/10;
    Console.WriteLine(a);
 }
 met(678); */


//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
/* 
 void met (int a)
 {
    if (a%10 > a/10)
    {
        a = a%10;
        
    }
    else
    {
        a=a/10;
    }
    Console.WriteLine(a);
 }
 met(96); */

//Удалить вторую цифру трёхзначного числа == ее приравнял к нулю

/* void met (int a)
 {
    a= a- ((a % 100)/10)*10;
    Console.WriteLine(a);
 }
 met(327); */

/* void met (int a)
{
   a= (a/100)*10 + ((a%100)%10);
   Console.WriteLine(a);
}
met(679); */

// Выяснить, кратно ли число заданному, если нет, вывести остаток.

/* void met (int a, int b)
{
   if (a%b==0)
   {
       Console.WriteLine("Кратно");
   }
   else
   {
       Console.WriteLine($"Остаток = {a%b} ");
   }

}
met(9, 3); */

/* //Найти третью цифру числа или сообщить, что её нет? // подходит для 3 значных цифр.

 void met (double a)
{

    if ((a/100)<2)
    {
        Console.WriteLine("Третьей цифры нет");
    }
   if ((a/100)>1)
    {
        a= a % 10;
        Console.WriteLine(a);
    }
}
met(99); */

/* double met (string b, double c)
{
int size = b.Length;
if (size<=3)
{
     if ((c/100)<1)
     {
         Console.WriteLine("Третьей цифры нет");
     }

    if ((c/100)>1)
     {
         c= c % 10;
     }
    
}
return c;
}
var namber = met("28", 28);
Console.WriteLine(namber); */

// Сформировать случайным образом N элементарный массив
//заполненный однозначными целыми числами из разных знаков

/* void FillArray(int[] collection)
{
    int index=0;
    int length=collection.Length;
    while (index<length)
     {
         collection[index]= new Random().Next(-10,10);
         index++;
     }
} 

void PrintArray(int[] coll, int k)
{
 int size=coll.Length;
 int count=0;
 int temp=0;
 int numberindexmax=0;
 int numberindexmin=0;
 while (count<size)
 {
     if (k==coll[count])
     {
     temp++;
            if (temp==1)
            {
            numberindexmin=count;
            }
            if (temp>=2)
            {
            numberindexmax=count;
            }
    
     }
      Console.WriteLine(coll[count]);
      count++;
    
  
}
 Console.WriteLine();
 Console.WriteLine(temp);
 Console.WriteLine();
 Console.WriteLine($"{numberindexmax-numberindexmin-1}");
} 

int[] array = new int[50];
FillArray(array);
PrintArray(array, 5); */



// задать к и выяснить сколько раз повторяется К в массиве

// сколько элементов нах-ся между 1 и последним в К в массиве


// сформировать случайным образом массив из натуральных двухзначных чисел
// создать на его основе массив В 
// отбрасывая те которые нарушают порядок возрастания средне арифметического элементов А четные

/* void FillArray(int[] collection)
{
    int index=0;
    int length=collection.Length;
    while (index<length)
    {
    collection[index] = new Random().Next(10,99);
    index++;
    }
    
} 
void PrintArray(int[]coll)
{
  int count=0;
  int size=coll.Length;
  while (count<size)
  {
      Console.WriteLine(coll[count]);
       count++;
  }  

}   
int[] array= new int[10];
FillArray(array);
PrintArray(array);
 */

//Задача 
//сформировать случайным образом целочисленный массив А
//из натуральных двухзначных чисел
// создать на его основе массив В отбрасывая те, которые,
//1 нарушают порядок возрастания
//2 больше среднего арифметического А
//3 четные

/* int[] A = new int[10];
int index=0;
while (index<10)
{
     A[index]= new Random().Next(10, 99);
     index++;
}
index= 0;
while (index<10)
{
     Console.WriteLine(A[index]);
     index++;
}  */
/* 
 int getRandom()
{
     return new Random().Next(10, 99);
}
int[] A = new int[10];
int index=0;
while (index<10)
{
     A[index]= getRandom();
     index++;
}
index= 0;
while (index<10)
{
     Console.WriteLine(A[index]);
     index++;
} */


/* int[] A = new int[10];
int index=0;
while (index<10)
{
    A[index]= new Random().Next(10, 99);
    index++;
}
index= 0;
while (index<10)
{
    Console.WriteLine(A[index]);
    index++;
} 
Console.WriteLine();  */
//1 нарушают порядок возрастания
/* index= 1;
int temp= A[0];
Console.WriteLine(temp);
while (index<10)
{
    if (A[index]>temp)
    {
        Console.WriteLine(A[index]);
        temp=A[index];  
    } 
index++;
}  */
// четные

/* index= 0;
while (index<10)
{
    if (A[index]%2==0)
    {
        Console.WriteLine(A[index]); 
    } 
index++;
} */
// больше среднего арифметического А 
/* int sum=A[0];
index=1;
while (index<10)
{
    sum=sum+A[index];
    Console.WriteLine(sum);
    ;
    
index++;
} 
Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine();
Console.WriteLine(sum/10);
Console.WriteLine();
index=0;
while (index<10)
{   
    if (A[index]<sum/10)
    {
        Console.WriteLine(A[index]);
    }
 index++;   
} */


//Найти третью цифру числа или сообщить, что её нет? // подходит для 3 значных цифр.

/*   void met (int a)
 {
     int index = 0;
     int b= a;
     while (index<2&& a>=10)
     {
         a=a/10;
          
          index++;
     }
    Console.WriteLine(index);


      if ((b/100)<1)
     {
         Console.WriteLine("Третьей цифры нет");
     }

    /* if ((a/100)>1)
     {
         a= a % 10;
         Console.WriteLine(a);
     } */

/* if ((b/100)>=1)
  {
      Console.WriteLine(b % (Math.Pow(10, index-1)));
  }


}
met(2128); */

/*  Почувствуй себя джуном
15. Дано число. Проверить кратно ли оно 7 и 23
16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
17. По двум заданным числам проверять является ли одно квадратом другого
18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
20. Ввести номер четверти, показать диапазоны для возможных координат
21. Программа проверяет пятизначное число на палиндромом.
22. Найти расстояние между точками в пространстве 2D/3D */

/* Дано число. Проверить кратно ли оно 7 и 23 */

/* string sum( int a, int b, int c)
{
   string res = "ДА делится";
   if (c % a == 0 && c % b ==0 )
   {
       return res;
   }
   else
   {
       res= "НЕ делится";
       return res;
   }

}
string number = sum(7,23, 162);
Console.WriteLine(number); */


//Дано число обозначающее день недели. Выяснить является номер недели выходным днём

/* Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

string met (int a)
{
    string res = "Выходной";
  if (a==6 | a==7)
  {
      return res;
  }
  if (a>=1 && a<=5)
  {
      res="Рабочий";
      return res;
  }
  else
  {
     res= "Не верно указан день";
     return res;
  }
  
}
string day = met(a);
Console.WriteLine(day); */


//По двум заданным числам проверять является ли одно квадратом другого

/* string a ( int one, int two)

{ 
    string res = string.Empty;

    if (one==Math.Sqrt(two))
    {
        res= "Число two явлеется квадратом one";
        return res;
    }
    if (two==Math.Sqrt(one))
    {
        res= "Число one явлеется квадратом two";
        return res;
    }
    else
    {
        res= "Не являются";
        return res;
    }
}
string number= a(2, 4);
Console.WriteLine(number); */

/* Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y */

/* bool a (bool x, bool y)
{
  bool res = true;
  if (!(x|y) == (!x && !y))
  {   
      return res;
  }
    else
    {
       res= false;
       return res;
    }

}

bool var = a(true, true); 
Console.WriteLine(var);
Console.WriteLine();

var = a(false, true); 
Console.WriteLine(var);
Console.WriteLine();

var = a(true, false); 
Console.WriteLine(var);
Console.WriteLine();

var = a(false, false); 
Console.WriteLine(var);
 */


//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

/* int a(int x, int y)
{
  int res=0;
  if (x>0 && y>0)
  {   
      res=1;
      return res;
  }
  if (x<0 && y>0)
  {   
      res=2;
      return res;
  }
    if (x<0 && y<0)
  {   
      res=3;
      return res;
  }
  else
  {
      res=4;
      return res;
  }

}
int qvadro= a(-100, 200);
Console.WriteLine($"Определен номер четверти= {qvadro}"); */

//Ввести номер четверти, показать диапазоны для возможных координат

/* string a (int number)
{
  string res=string.Empty;
    if (number==1)
    {
        res="Данная четверть принимает значения x (0....100], y (0....100] ";
        return res;
    }
    if (number==2)
    {
        res="Данная четверть принимает значения x [-100....0), y (0....100] ";
        return res;
    }
    if (number==3)
    {
        res="Данная четверть принимает значения x [-100....0), y (-100....0] ";
        return res;
    }
    if (number==4)
    {
        res="Данная четверть принимает значения x (0....100], y (-100....0] ";
        return res;
    }
    else
    {
        res="Неправильно введен номер четверти";
        return res;
    }
}

string num= a(1);
Console.WriteLine(num); */

////Программа проверяет пятизначное число на палиндромом

/* string a (int number)
{
    string res= string.Empty;
    if (number>=10000&&number<=99999)
    {
        if ((number/10000==number%10)&& (number/1000%10==number%100/10))
        {
            res= "Число является палиндромом";
            return res;
        }
        else
        {
            res= "Число НЕ является палиндромом";
            return res;
        }
       
    }
    else
    {
        res= "Число НЕ пятизначное";
        return res;
    }
}

string pal= a(11311);
Console.WriteLine(pal); */


//Найти расстояние между точками в пространстве 2D/3D
/* 
double a (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance=0;
    distance= Math.Pow((Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)), (1.0/3.0));
    return distance;
}
double result = a(1, 4, 1, 4, 1, 4);
Console.WriteLine(result); */

/* Почувствуй себя мидлом
23. Показать таблицу квадратов чисел от 1 до N 
24. Найти кубы чисел от 1 до N
25. Найти сумму чисел от 1 до А
26. Возведите число А в натуральную степень B используя цикл
27. Определить количество цифр в числе
28. Подсчитать сумму цифр в числе
29. Написать программу вычисления произведения чисел от 1 до N
30. Показать кубы чисел, заканчивающихся на четную цифр */


//Показать таблицу квадратов чисел от 1 до N 

/* void a(int N)
{
    int count=1;
    while (count<=N)
    {   
        Console.WriteLine(count*count);
        count++;
    }

}
a(10); */

//Показать числа от -N до N
/* string met(int arg) 
{
    var res= "";
    for (int i = -arg; i <= arg; i++)
    {
        res+=i+" "; /// res+ будет возвращать каждое число в данном цикле
    }
    return res;
}
Console.WriteLine(met(4)); */

//Показать таблицу квадратов чисел от 1 до N 

/* string met(int arg)
{
    var res = " ";
    for (int i = 1; i <= arg; i++)
    {
        res += i * i + " ";//res+ будет возвращать каждое число в данном цикле, +" " для разделения чисел , тип данных var можно использовать как для int так и для string
    }
    return res;
}
Console.WriteLine(met(5)); */

//Найти кубы чисел от 1 до N

/* string met(int arg)
{
    var res = " ";
    for (int i = 1; i <= arg; i++)
    {
        res += i * i * i + " ";//res+ будет возвращать каждое число в данном цикле, +" " для разделения чисел , тип данных var можно использовать как для int так и для string
    }
    return res;
}
Console.WriteLine(met(5)); */

//Найти сумму чисел от 1 до А
/* int met(int arg)
{
    var res = 0;
    for (int i = 1; i <= arg; i++)
    {
        res = i + res;
    }
    return res;
}
Console.WriteLine(met(6)); */

//Возведите число А в натуральную степень B используя цикл

/* double met (double a, double b)
{
    double res=0;
    while (a!=0)
    {
        res= Math.Pow(a,b);
        break;
    }
    return res;
    
}
double quadro = met(4, 2);
Console.WriteLine(quadro); */

//Определить количество цифр в числе

 /* int met (int a)
 {
     int count=1;
     int b =a;
     while (a/10>0)
     {     
      a=a/10;
        
       count++; 
     }
     while (b<10)
     {     
       count=1;
        break;
       
     }
return count;
}
 int number=met(94564465);
 Console.WriteLine(number); */

//Определить количество уникальных цифр в числе (додумать)


 //Подсчитать сумму цифр в числе
/* int met (int a)
 {
     int b =a;
     int c=a%10;
     while (a/10>0)
     { 
      a=a/10;
      b = a % 10; 
      c=c+b;
     }
     
return c;
}
 int number=met(123456);
 Console.WriteLine(number); */

 //Написать программу вычисления произведения чисел от 1 до N

 /* int met (int N)
 {  int res=1;
    int num=1;
     while (num<=N)
     {
          res= res*(num);
          Console.WriteLine(res);
          num++;
     }
 return res;
 }
 Console.WriteLine(met(5)); */


 //Показать кубы чисел, заканчивающихся на четную цифр

 /* string met (int a)
{
    int res= 1;
    var num =0;
    string three = " ";
    
    for (num = 0; num <= a; num++)
    {
        res = num*num*num;
        if (res%2==0 && res!=0)
        {
            three+= ($"{res}  ");
        }
        
    }

return three;
}
Console.WriteLine(met(11)); */

//Почувствуй себя сеньором
/* 31. Задать массив из 8 элементов и вывести их на экран 
32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
34. Написать программу замену элементов массива на противоположные
35. Определить, присутствует ли в заданном массиве, некоторое число 
36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом */

//Задать массив из 8 элементов и вывести их на экран 

/* void FillArray(int[] mass)
{   
    int index =0;
    int length= mass.Length;
    while (index<length)
    {
     mass[index]= new Random().Next(1, 10);
     index++;
    }
}

void PrintArray(int[] mas)
{
    int count=0;
    int size= mas.Length;
    while (count<size)
    {   
        Console.WriteLine(mas[count]);
         count++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array); */

//Задать массив из 8 элементов и вывести их на экран 

/* int getRandom ()
{

    return new Random().Next(1, 10);
}

int[] N= new int[8];
int index=0;
while (index<8)
{
     N[index]=getRandom();
     index++;
}

index=0;

while (index<8)
{
Console.WriteLine(N[index]);
index++;
} */

//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

/* int getRandom ()
{

    return new Random().Next(0, 2);
}

int[] N= new int[8];
int index=0;
while (index<8)
{
     N[index]=getRandom();
     index++;
}

index=0;

while (index<8)
{
Console.WriteLine(N[index]);
index++;
} */


//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

/* int getRandom()
{
    return new Random().Next(-10,10);
}
int[] N = new int [12];
int index=0;
while (index<12)
{
     N[index]=getRandom();
     index++;
}
index=0;

while (index<12)
{
    Console.WriteLine(N[index]);
    index++;
}

index=0;
var res=0;
while (index<12)
    { if (N[index]>0)
        {
        res= res+N[index];
        }
         index++;    
    }
Console.WriteLine();    
Console.WriteLine(res);

 */

//Написать программу замену элементов массива на противоположные
/*  int getRandom()
 {
     return new Random().Next(-10,10);
    
 }
int[] N = new int [10];
int index=0;
while (index<10)
{
     N[index]=getRandom();
     index++;
}
index=0;
int res=0;
while (index<10)
{
     res=N[index]*(-1);
     Console.WriteLine(res);
     index++;
} */

//Определить, присутствует ли в заданном массиве, некоторое число 

/* int getRandom()
{
    return new Random().Next(1,10);
}
int[] array=new int[10];
int index=0;
int number=5;
while (index<10)
{
     array[index]=getRandom();
    index++; 
}
index=0;

while (index<10)
{
     Console.WriteLine(array[index]);
     index++;
     
}
Console.WriteLine();
index=0;

while (index<10)
{
    if (array[index]==number)
    {
        Console.WriteLine($"{array[index]} Присутствует");
    }
    if (array[index]!=number)
    {
        Console.WriteLine($"{array[index]} НЕ Присутствует");
    }
    
 index++;
} */

//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
/* int getRandom()
{
    return new Random().Next(100,1000);
}
int[] array=new int[10];
int index=0;
int count=0;
while (index<10)
{
     array[index]=getRandom();
    index++; 
}
index=0;

while (index<10)
{
     Console.WriteLine(array[index]);
     index++; 
}
index=0;
Console.WriteLine();
while (index<10)
{   
    if (array[index]%2==0)
    {
        count++;
    }
     
     index++; 
}
Console.WriteLine(count); */

//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

/* int getRandom()
{
    return new Random().Next(1,1000);
}
int[] array=new int[123];
int index=0;
int count=0;
while (index<123)
{
     array[index]=getRandom();
    index++; 
}
index=0;

while (index<123)
{ 
    if (array[index]>=10 && array[index]<=99)
    {
        count++;
        Console.WriteLine($"Найдено число из заданного отрезка {array[index]}, кол-во чисел = {count} ");
    }
 index++; 
} */
/* index=0;

while (array[index]>=10 && array[index]<=99)
{
     Console.WriteLine(index);
     Console.WriteLine(array[index]);
     count++;
     index++; 
     
} */


//Найти сумму чисел одномерного массива стоящих на нечетной позиции

/* int getRandom()
{
    return new Random().Next(1,10);
}
int[] array=new int[5];
int index=0;
int count=0;
while (index<5)
{
     array[index]=getRandom();
    index++; 
}
index=0;

while (index<5)
{
     Console.WriteLine(array[index]);
     index++;
} 
Console.WriteLine();
index=0;

while (index<5)
{
     if (index%2==0)
     {   
         count=count+array[index];
     }
     index++;
} 
Console.WriteLine(count); */

//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

/* int getRandom()
{
    return new Random().Next(1, 10);
}
 int[] array= new int[10];
 int length= array.Length;
 int index = 0;
 int res=0;
 while (index<10)
 {
      array[index]=getRandom();
      index++;
 }
 index=0;

 while (index<10)
{
     Console.WriteLine(array[index]);
     index++;
}
index=0;
Console.WriteLine();

 while (index<10/2)
 {
      res=array[index] * array[9-(index)];
      Console.WriteLine(res);
      index++;
 }
  */
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

/* double A()
{
    return new Random().Next(-100, 100)/10.0;
}
double[] array= new double[10];
int index=0;
while (index<10)
{
     array[index]=A();
     index++;
}
index=0;
while (index<10)
{
     Console.WriteLine(array[index]);
     index++;
}
index=0;
Console.WriteLine();
double maxvalue=array[0];
double minvalue=array[0];
while (index<10)
{   
    if (array[index]>maxvalue)
    {
        maxvalue=array[index];
    }
    if (array[index]<minvalue)
    {
        minvalue=array[index];
    }
     
     index++;
}

Console.WriteLine(maxvalue);
Console.WriteLine(minvalue);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом = {maxvalue-minvalue}"); */


//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом и индексом

/* 
double A()
{
    return new Random().Next(-100, 100)/10.0;
}
double[] array= new double[10];
int index=0;
while (index<10)
{
     array[index]=A();
     index++;
}
index=0;
while (index<10)
{
     Console.WriteLine(array[index]);
     index++;
}
index=0;
Console.WriteLine();
double maxvalue=array[0];
double minvalue=array[0];
double countmax=0;
double countmin=0;
while (index<10)
{   
    if (array[index]>maxvalue)
    {
        maxvalue=array[index];
        countmax=index;
    }
    if (array[index]<minvalue)
    {
        minvalue=array[index];
        countmin=index;
    }
     
     index++;
}

Console.WriteLine(maxvalue);
Console.WriteLine(minvalue);
Console.WriteLine();
Console.WriteLine(countmax);
Console.WriteLine(countmin);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом = {maxvalue-minvalue}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом индекса = {Math.Abs(countmax-countmin)}"); */


/* Почувствуй себя лидом
41. Выяснить являются ли три числа сторонами треугольника 
42. Определить сколько чисел больше 0 введено с клавиатуры
43. Написать программу преобразования десятичного числа в двоичное
44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
45. Показать числа Фибоначчи
46. Написать программу масштабирования фигуры
47. Написать программу копирования массива */


//41. Выяснить являются ли три числа сторонами треугольника 

/* string met (int a, int b, int c)
{
    string res= string.Empty;
    if (a+b>c&&b+c>a&&c+a>b)
    {
        res=res+($"Данные числа являются сторонами треугольника");
        
    }
    else
    {
        res=res+($"Данные числа НЕ являются сторонами треугольника");
    }
    return res;
}
string A = met(4,5,10);
Console.WriteLine(A); */

//42. Определить сколько чисел больше 0 введено с клавиатуры


/* int A()
{
    return int.Parse(Console.ReadLine());
}
int[] array= new int[10];
int index=0;
while (index<10)
{
    Console.WriteLine("Введите число");
     array[index]=A();
     index++;
}
index=0;
Console.WriteLine();
while (index<10)
{
     Console.WriteLine(array[index]);
     index++;
}
index=0;
int count=0;
Console.WriteLine();
while (index<10)
{        
    if (array[index]>0)
    {
        count++;
    }
index++;
}
Console.WriteLine($"Количество введеных чисел с клавиатуры, которые больше 0 = {count}"); */

//Написать программу преобразования десятичного числа в двоичное

/* Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()); */

/* string met (int N)
{
    string res=string.Empty;
    while ((N+1)/2>=1)
    {
        res+= " "+N%2;
        N=N/2;
    }
return res;
}
string total= met(4);
Console.WriteLine();
Console.WriteLine(total); */

//44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы

/* string method (double k1, double b1, double k2, double b2)
{
    string resy=string.Empty;
    double resx=0;
    double resb=0;
    resx= k1-k2;
    resb= b2-b1;
    resy= $"Значение Y={k1*(resb/resx)+b1}, Значение Х={resb/resx} ";
    if (k1==k2)
    {
        resy="Прямые параллельны ";
    }
return resy;
}
string A= method(1, -4, 3 , 2);
Console.WriteLine(A); */

//Показать числа Фибоначчи

/* string Fibonacci (int N)
{
    string res= string.Empty;
    int a=0;
    int b=1;
    int temp=0;
    int count=0;
    while (count<N)
    {
      res+= $"{a+b}, ";
      temp= a+b;
      a=b;
      b=temp;
      count++;
    }
return res;
}

string Print = Fibonacci(10);
Console.WriteLine(Print); */


///  Написать программу масштабирования фигуры

/* string mass( double x1, double y1, double  B1x2, double  y2, double x3, double y3, double x4, double y4, double zoom)//добавить стринг для вывода картинки
{
    string res= string.Empty;
    if (x1-B1x2!=0&&B1x2-x3!=0&&x3-x4!=0&&x4-x1!=0&&y1-y2!=0&&y2-y3!=0&&y3-y4!=0&&y4-y1!=0)
    {   
        Console.SetCursorPosition(x1, y1); 
        double x12 = (Math.Abs(B1x2-x1)/zoom);
        double y12 = (Math.Abs(y2-y1)/zoom);
        double x23 = (Math.Abs(x3-B1x2))/zoom;
        double y23 = (Math.Abs(y3-y2))/zoom;
        double x34 = (Math.Abs(x4-x3))/zoom;
        double y34 = (Math.Abs(y4-y3))/zoom;
        double x41 = (Math.Abs(x1-x4))/zoom;
        double y41 = (Math.Abs(y1-y4))/zoom;
        res= $"{(x12 , y12)}, {(x23, y23)}, {(x34,y34)}, {(x41,y41)}";
         Console.SetCursorPosition(x1, y1); 
    }
    return res;
}
 string Print = mass (1, 2, 4, 5 ,2 ,1, 6, 4 , (0.5));
 Console.WriteLine (Print);
 Console.WriteLine(); */

 int x1=1; int y1=20; int x2= 20; int y2= 20; int x3= 10; int y3=1;
 Double zoom = 0.25;
int mInt = (int)zoom;
Console.WriteLine(mInt);

    /* Console.SetCursorPosition(x1, y1); 
    Console.WriteLine("+");
    Console.SetCursorPosition(x2, y2);
    Console.WriteLine("+");
    Console.SetCursorPosition(x3, y3);
    Console.WriteLine("+");

    Console.SetCursorPosition(x1*zoom, y1*zoom); 
    Console.WriteLine("!");
    Console.SetCursorPosition(x2*zoom, y2*zoom);
    Console.WriteLine("!");
    Console.SetCursorPosition(x3*zoom, y3*zoom);
    Console.WriteLine("!"); */

/* string[,] table = new string [2,5];
// string.Empty
//  table[0.0] table[0.1] ... table[0.4]
//  table[1.0]  table[1.1]...  table[1.4]
table[1, 2]= "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} */



/* void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i , j]}");
    }
   Console.WriteLine(); 
}
}
void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
          matr[i,j] = new Random().Next(1, 10);
      }
      
  }

}
int[,] matrix = new int [3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix); */


/* int[,] matrix = new int[,]
{
{0, 1 , 0 , 0, 1
, 0, 1, 0, 1
}
}; */
/* int[,] matrix = new int[,]
{
{ 0, 1, 0, 0, 1},
{ 0, 1, 0, 1, 1}
};
void PrintImage(int[,] image)
{
for (int i = 0; i < image.GetLength(0); i++)
{
    for (int j = 0; j < image.GetLength(1); j++)
    {
        /* Console.Write($"{matr[i , j]}"); */
        /* if (image[i, j]==0) Console.Write("  ");
        else
        {
            Console.Write(" + ");
        }
    }
   Console.WriteLine(); 
}
}

void FillImage(int row, int columns)
{
 if(matrix[row, columns]==0)
     {
         matrix[row, columns]=1;
        FillImage(row-1, columns);
        FillImage(row, columns-1);
        FillImage(row+1, columns);
        FillImage(row, columns+1);
     } 

}



PrintImage(matrix);
FillImage(0,0);
Console.WriteLine();
PrintImage(matrix) */

/* int Factorial(int n)
{
    if (n==1) return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(3));
 */

/* int Fibonacci(int n)
{
    if (n==1||n==2) return 1;
    else return Fibonacci(n-1)+ Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
} */


//Повтор
/* void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(($"{matrix[i, j]}"));
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); 
        }
    }
}
int[,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
 */

/*  void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
            Console.Write(matrix[i]);
    }
}
void FillArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        
         matrix[i]= new Random().Next(1, 10); 
    }
}
int[] matrix = new int [10];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix); */

//Факториал через рекурсию повтор

/* int Factorial ( int n)
{
    if (n==1) return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(5)); */
