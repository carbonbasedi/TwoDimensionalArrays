
////                            Task 1 - Finding the sum of numbers fall under major and minor diagonal in 3x3 array

//int[,] arr = new int[3, 3]
//{
//    {4,69,10},
//    {5,5,-99},
//    {7,8,5},
//};
//int sumMajorDiagonal = 0;
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int q = 0; q < arr.GetLength(1); q++)
//    {
//        if (i == q)
//        {
//            sumMajorDiagonal += arr[i, q];
//        }
//        Console.Write(arr[i, q] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine($"Sum of Major diagonal is {sumMajorDiagonal}");

////                            Task 1.1(extra) - Finding the sum of numbers fall under minor diagonal in 3x3 array


//int[,] arr = new int[3, 3]
//{
//    {4,69,10},
//    {5,5,-99},
//    {7,8,5},
//};
//int sumMinorDiagonal = 0;
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int q = 0; q < arr.GetLength(1); q++)
//    {
//        if (i + q == 2)
//        {
//            sumMinorDiagonal += arr[i, q];
//        }
//        Console.Write(arr[i, q] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine($"Sum of Minor diagonal is {sumMinorDiagonal}");

////                            Task 1.2 (extra) - Finding the sum of numbers fall under major and minor diagonal in 3x3 array


//int[,] arr = new int[3, 3]
//{
//    {4,69,10},
//    {5,5,-99},
//    {7,8,5},
//};
//int sumMajorDiagonal = 0;
//int sumMinorDiagonal = 0;
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int q = 0; q < arr.GetLength(1); q++)
//    {
//        if (i == q)
//        {
//            sumMajorDiagonal += arr[i, q];
//        }
//        if (i + q == 2)
//        {
//            sumMinorDiagonal += arr[i, q];
//        }
//        Console.Write(arr[i, q] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine($"Sum of Major diagonal is {sumMajorDiagonal}");
//Console.WriteLine($"Sum of Minor diagonal is {sumMinorDiagonal}");



////                             Task 2 - adding up two matrices and creating the third matrix and assigning the values addition corresponding indexes.                              

//int[,] arr = new int[2, 2]
//{
//    {4,6 },
//    {7,6 }
//};
//int[,] ints = new int[2, 2]
//{
//    {65, 8 },
//    {14,6}
//};
//int[,] sum = new int[2, 2];

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int n = 0; n < arr.GetLength(1); n++)
//    {
//        sum[i, n] = arr[i, n] + ints[i, n];
//        Console.Write(sum[i, n] + " ");
//    }
//    Console.WriteLine();
//}


////                      Task 3 - Turning all the numbers under major diagonal into zeroes (excluding numbers that fall on diagonal itself)

//int[,] arr = new int[5, 5]
//{
//    {4,69,10,25,10},
//    {5,10,-99,30,14},
//    {7,8,5,70,35},
//    {74,14,32,65,45 },
//    {69,31,13,99,79 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int q = 0; q < arr.GetLength(1); q++)
//    {
//        for (int t = 1; t < arr.GetLength(0); t++)
//        {
//            if (q == i - t)
//            {
//                arr[i, q] = 0;
//            }
//        }
//        Console.Write(arr[i, q] + " ");
//    }
//    Console.WriteLine();

//}

////                      Task 3.1 (extra) - Turning all the numbers over major diagonal into zeroes (excluding numbers that fall on diagonal itself)


//int[,] arr = new int[5, 5]
//{
//    {4,69,10,25,10},
//    {5,10,-99,30,14},
//    {7,8,5,70,35},
//    {74,14,32,65,45 },
//    {69,31,13,99,79 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int q = 0; q < arr.GetLength(1); q++)
//    {
//        for (int t = 1; t < arr.GetLength(0); t++)
//        {
//            if (i == q - t)
//            {
//                arr[i, q] = 0;
//            }

//        }
//        Console.Write(arr[i, q] + " ");
//    }
//    Console.WriteLine();

//}