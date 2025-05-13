/// 2. Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
/// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
/// You must write an algorithm that runs in O(n) time and without using the division operation.
/// Example 1:
/// Input: nums = [1,2,3,4]
/// Output: [24,12,8,6]
/// Example 2:
/// Input: nums = [-1,1,0,-3,3]
/// Output: [0,0,9,0,0]
/// 

Demo([1, 2, 3, 4]);
Demo([-1, 1, 0, -3, 3]);

void Demo(int[] arr)
{
    Console.WriteLine($"Input:  [{string.Join(", ", arr)}]");
    Console.WriteLine($"Output: [{string.Join(", ", ArrayProduct(arr))}]\n");
}

int[] ArrayProduct(int[] arr)
{
    int[] prodArr = new int[arr.Length]; // Tracks the products of each iteration
    Array.Fill(prodArr, 1); // Fill product array with ones
    int lProd = 1; // Tracks products to the left of index
    int rProd = 1; // Tracks products to right of index

    for (int i = 0; i < arr.Length; i++)
    {
        prodArr[i] = lProd;
        lProd *= arr[i];
    }
    
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        prodArr[i] *= rProd;
        rProd *= arr[i];
    }

    return prodArr;
}