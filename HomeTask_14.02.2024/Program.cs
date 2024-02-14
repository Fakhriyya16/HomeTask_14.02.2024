//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//void Divide(int n)
//{
//    if(n%3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("Bolunur");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur");
//    }
//}

//Console.WriteLine("Add input:");
//int n = int.Parse(Console.ReadLine());

//Divide(n);




//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//int SumOfEvenNumbers(int n, int m)
//{
//    int sum = 0;
//    if(n%2==0 && m % 2 == 0)
//    {
//       sum = n + m;
//    }
//    return sum;
//}

//Console.WriteLine("Add First Input:");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine("Add Second Input:");
//int m = int.Parse(Console.ReadLine());

//int result = SumOfEvenNumbers(n, m);
//Console.WriteLine(result);




//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//void CountOfOddNumbers(int n, int m)
//{
//    int count = 0;
//    for(int i = n; i <= m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//Console.WriteLine("First Input:");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine("Second Input:");
//int m = int.Parse(Console.ReadLine());

//SumOfOddNumbers(n, m);




//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//void SumOfOddNumbers(int n, int m)
//{
//    int sum = 0;
//    for(int i = n; i <= m; i++)
//    {
//        if(i%2==1)
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}
//Console.WriteLine("First Input");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine("Second Input:");
//int m  = int.Parse(Console.ReadLine());

//SumOfOddNumbers(n, m);




//5)Verilmish arrayin icindeki tek ededlerin cemini tapin.

//void SumOfOddNumbers(int[] nums)
//{
//    int sum = 0;
//    for(int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i]%2 == 1)
//        {
//            sum += nums[i];
//        }
//    }
//    Console.WriteLine(sum);
//}

//int[] nums = { 1, 3, 5, 4, 2, 7 };
//SumOfOddNumbers(nums);






//6)Verilmish arrayin icindeki cut ededlerin sayini tapin.

//void CountOfEvenNumbers(int[] nums)
//{
//    int count = 0;
//    for(int i  = 0; i < nums.Length; i++)
//    {
//        if (nums[i]%2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//int[] nums = { 1, 3, 2, 4, 6, 7 };
//CountOfEvenNumbers(nums);






//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//void PrimeOrComposite(int n)
//{
//    int count = 0;
//    for(int i = 1; i <= n; i++)
//    {
//        if(n%i == 0)
//        {
//            count++;
//        }
//    }
//    if (count >= 3)
//    {
//        Console.WriteLine("Murekkeb");
//    }
//    else
//    {
//        Console.WriteLine("Sade");
//    }
//}

//int n = 19;
//PrimeOrComposite(n);






//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
//Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

//void Power(int n)
//{
//    bool isEqual = false;
//    for(int i = 1; i < n; i*=2)
//    {
//        if (2 * i == n)
//        {
//            isEqual = true;
//            break;
//        }
//        else
//        {
//            isEqual = false;
//        }
//    }
//    if (isEqual)
//    {
//        Console.WriteLine("Beraberdir");
//    }
//    else
//    {
//        Console.WriteLine("Beraber deil");
//    }
//}
//Console.WriteLine("Input:");
//int n = int.Parse(Console.ReadLine());

//Power(n);







//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.
//Mes ([1,3,55,6,33], cavab: 18).

//int MultiplicationOfNumbers(int[] nums)
//{
//    int multiplication = 1;
//    for(int i = 0;i < nums.Length; i++)
//    {
//        if (nums[i] >=1 && nums[i] < 20)
//        {
//            multiplication *= nums[i];
//        }
//    }
//    return multiplication;
//}

//int[] nums = { 1, 3, 55, 6, 33, 2 };

//int result = MultiplicationOfNumbers(nums);

//Console.WriteLine(result);







//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

//int SquareOfSum(params int[] nums)
//{
//    int sum = 0;
//    int square;
//    for(int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i]%2== 0) 
//        {
//            sum += nums[i];
//        }
//    }
//    square = sum * sum;
//    return square;
//}

//int result = SquareOfSum(1, 3, 4, 2, 6, 5);
//Console.WriteLine(result);






//11)temp qebul eden method yazirsiz. Return type olan method olmalidir.
//Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.

//string Temp(int temperature)
//{
//    if(temperature < 20)
//    {
//        return "Soyug";
//    }else if (temperature > 20)
//    {
//        return "Isti";
//    }
//    else
//    {
//        return "Normal";
//    }
//}

//Console.WriteLine("Temperature:");
//int temperature = int.Parse(Console.ReadLine());

//Console.WriteLine(Temp(temperature));








//12)methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin.

//int AmountOfNumbersBetween(int a, int b)
//{
//    int count = 0;
//    for (int i = a+1;  i < b; i++)
//    {
//        count++;
//    }
//    return count;
//}

//Console.WriteLine("First Input");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Second Input");
//int b = int.Parse(Console.ReadLine());

//Console.WriteLine(AmountOfNumbersBetween(a, b));








//13)method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin.

//int SumOfNumbers(int[] nums1, int[] nums2)
//{
//    int sum = 0;
//    for(int i = 0; i < nums1.Length; i++)
//    {
//        sum += nums1[i];
//    }
//    for(int i = 0;i < nums2.Length; i++)
//    {
//        sum += nums2[i];
//    }
//    return sum;
//}

//int[] nums1 = { 1, 3, 5, 6, 34 };
//int[] nums2 = { 5, 4, 32, 5, 4 };

//int result = SumOfNumbers(nums1, nums2);
//Console.WriteLine(result);







//14)methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin.

//int Square(int n)
//{
//    int square = n * n;
//    return square;
//}
//Console.WriteLine("Input");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine(Square(n));








//15)methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.

//int SumOfEvenNumbers(int a)
//{
//    int sum = 0;
//    for(int i = 0; i < a; i++)
//    {
//        if(i % 2 == 0)
//        {   
//            sum += i;
//        }
//    }
//    return sum;
//}

//Console.WriteLine("Input:");
//int a = int.Parse(Console.ReadLine());

//int result = SumOfEvenNumbers(a);

//Console.WriteLine(result);



