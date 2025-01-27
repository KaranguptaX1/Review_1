// Create an array 0,1,1,0,1,0,1,1,1
// create a method sort left 0, right 1 in new array
//task2 method in array print element acc. to index
// task3 2d arrray - center same swap 1 and 3 column
using System;
class arraySort{
	Console.WriteLine("Enter the size of array");
	int n = Convert.ToInt34(Console.RealLine());
	int[] arr = new int[n];
	Console.WriteLine("Enter 0 or 1 for array element : ");
	for(int i=0;i<n;i++){
		arr[i] = Convert.ToInt34(Console.ReadLine());
	}
	Console.WriteLine("Enter 1 to sort array or 2 to find element: ");
	string t = Console.ReadLine();
	switch (t){
		case "1" :
			Array.sort(arr);
			for(int j = 0; j < n; j++){
				Console.WriteLine(arr[j]);
			}
	}
}