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

 //Найти третью цифру числа или сообщить, что её нет? // подходит для 3 значных цифр.

/*  void met (double a)
 {
     if ((a/100)<1)
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


 int[] A = new int[10];
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
Console.WriteLine(); 
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