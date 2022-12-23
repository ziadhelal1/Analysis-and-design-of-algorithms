using System;

namespace testOnSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter yhe numbers of array");
            int[] arr1 = new int[int.Parse(Console.ReadLine())]; ;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("inter the value ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array is sorted now ......");
            insertionSort(arr1);
            Console.WriteLine("inter the value that u want to search on it : ");

            Console.WriteLine(BSR(arr1, arr1.Length - 1, 0, int.Parse(Console.ReadLine())));
           // Console.WriteLine(binarysearch(17, arr1));
            //    //foreach (var item in arr1)
            //    {
            //        Console.WriteLine(item);
            //    }
            }
            static void selectionSort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int minI = i;
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[k] < arr[minI]) { minI = k; }

                    }
                    swap(ref arr[i], ref arr[minI]);

                }

            }
            static void insertionSort(int[] arr)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    int key = arr[j];
                    int i = j - 1;
                    while (i >= 0 && key < arr[i])
                    {

                        arr[i + 1] = arr[i];
                        i--;
                    }
                    arr[i + 1] = key;
                }
            }
            static void bubbleSort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int k = arr.Length - 1; k > i; k--)
                    {
                        if (arr[k] < arr[k - 1]) { swap(ref arr[k], ref arr[k - 1]); }

                    }
                }
            }
            static void swap(ref int x, ref int y)
            {
                int s = x;
                x = y;
                y = s;

            }
            static int binarysearch(int value, int[] arr)
            {
                int l = 0, h = arr.Length - 1;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                if (value < arr[mid]) 
                    { h = mid - 1; }
                else if (value > arr[mid]) 
                    { l = mid + 1; }
                else
                    { return value; }
                    
                }
                return -1;
            }
            static int BSR( int[] arr, int h,int l , int k) 
        {
            int mid; 
            if (l > h)
                return -1;
            else
                mid = (h + l) / 2;
            if (k < arr[mid]) {return BSR(arr, mid - 1, l, k); }
            else if (k > arr[mid]) {return BSR(arr, h, mid + 1, k); }
            else return k;

        }

    }    
}
