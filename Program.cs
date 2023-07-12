// task1

// int s=Convert.ToInt32(Console.ReadLine());
// int son = s % 60;
// int min = s / 60 % 60;
// int h = s / 3600 % 24;
// System.Console.WriteLine($"{h} : {min/10}{min%10} : {son/10}{son%10} "); Soat


// task2

// int somoni = Convert.ToInt32(Console.ReadLine());
// int diram = Convert.ToInt32(Console.ReadLine());
// int somoni2 = Convert.ToInt32(Console.ReadLine());
// int diram2 = Convert.ToInt32(Console.ReadLine());
// int bis = somoni * 100 + diram;
// int bis2 = somoni2 * 100 + diram2;
// int zadach = bis2-bis;
// System.Console.WriteLine($"{zadach/100} {zadach%100d}");


// task3


// int zarp =Convert.ToInt32(Console.ReadLine());
// int sol = Convert.ToInt32(Console.ReadLine());
// if (sol>5)
// {
//     System.Console.WriteLine($"{zarp*5/100+zarp}");
  
// } 
//  else
//     {
//         System.Console.WriteLine($"{zarp}");
//     }


// task4


// int k = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int nf = 1;
//   for(int i = 1; i <= n; i++)
//     {
//         nf = i * nf;

//     }
//     int kf =1;
//       for(int i = 1; i <= k; i++)
//     {
//         kf = i * kf;

//     }
//     int mn = k-n;
//     int min = 1;
//       for(int i = 1; i <= mn; i++)
//     {
//         min = i * min;

//     }
//     int c = nf/kf*min;
//     System.Console.WriteLine($"{c}");


// task5


// int n =Convert.ToInt32(Console.ReadLine());
// int num = 1;
// int cou = Convert.ToInt32(Console.ReadLine());
// double fc = Convert.ToDouble(Console.ReadLine());
// double sum = 0.0;
// while(num <= n)
// {
//     fc = 1;
//     for(cou = 0; cou <=num; cou++)
//     {
//         fc = fc * cou;
//     }
//     sum = sum + (num / fc);

//     num ++;
// }
//  System.Console.WriteLine($"{sum}");


// task6

// int n = Convert,ToInt32(Console.ReadLine());
// int even;
// int odd;
// int digi;
// int sum;
// {
//     if(n%2==0)
//     System.Console.WriteLine($"{}");
// }

// task7
//   int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// // int sum=0;
// int cnt=0;
// for(int i=0; i<n; i++)
// {
//     arr[i]=int.Parse(Console.ReadLine());
// }
// for(int i=1; i<n-1; i++)
// {
//     if(arr[i]>arr[i+1] && arr[i-1]<arr[i])cnt++;
// }
// System.Console.WriteLine($"{cnt}");


// task8

// int n = int.Parse(Console.ReadLine());

// int [] arr = new int [n];
// for(int i=0; i<n; i++ )
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// for(int i = 0; i<n; i++)
// Array.Sort(arr);
// Array.Reverse(arr);
// for(int i = 0; i < n; i++)
// {
//     System.Console.WriteLine($"{arr[i]}");
// }

// task9

// int n = int.Parse(Console.ReadLine());
// int cnt = 0;

// int [] arr = new int [n];
// for(int i=0; i<n; i++ )
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// for(int i = 0; i < n-1; i++)
// {
//     if(arr[i] > arr[i+1]) cnt++;
// }
// System.Console.WriteLine($"{cnt}");

// task10

// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//  int minn = 99999;
// for(int i=0; i<n; i++)
// {
//     arr[i]=int.Parse(Console.ReadLine());
// }
// Array.Sort(arr);
// for(int i=0; i<n-1; i++)
// {
//     if(arr[i]<minn)minn=arr[i];
// }
// System.Console.WriteLine($"{minn}");

// task11

// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//  int maxx = -99999;
// for(int i=0; i<n; i++)
// {
//     arr[i]=int.Parse(Console.ReadLine());
// }
// Array.Sort(arr);
// for(int i=0; i<n-1; i++)
// {
//     if(arr[i]<maxx)maxx=arr[i];
// }
// System.Console.WriteLine($"{maxx}");

// task12

// int n = int.Parse(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// int cnt=0;
// for(int i=0; i<n; i++)
// {
//     arr[i]=int.Parse(Console.ReadLine());
// }

// for(int i=0; i<n-1; i++)
// {
//     if(arr[i]== a)cnt++;
// }
// System.Console.WriteLine($"{cnt}");

// task13

// int n = int.Parse(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// int cnt=0;
// for(int i=0; i<n; i++)
// {
//     arr[i]=int.Parse(Console.ReadLine());
// }

// for(int i=0; i<n-1; i++)
// {
//     if(arr[i]== a)cnt++;
// }
// if(cnt>0)
// System.Console.WriteLine($"Yes");

