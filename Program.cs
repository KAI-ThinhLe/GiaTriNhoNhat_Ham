using System;

class Program
{
    // Phương thức tìm giá trị nhỏ nhất trong mảng và trả về vị trí của nó
    public static int MinValue(int[] array)
    {
        // Kiểm tra nếu mảng không rỗng
        if (array.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty.");
        }

        // Giả sử phần tử đầu tiên là nhỏ nhất
        int min = array[0];
        int index = 0;

        // Duyệt mảng từ phần tử thứ 2 đến hết mảng
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }

        // Trả về vị trí của phần tử nhỏ nhất
        return index;
    }

    public static void Main(string[] args)
    {
        int size;
        int[] arr;

        // Nhập kích thước mảng và kiểm tra đầu vào
        do
        {
            Console.Write("Enter the number of elements in the array (positive integer): ");
        } while (!Int32.TryParse(Console.ReadLine(), out size) || size <= 0);

        // Khởi tạo mảng với kích thước hợp lệ
        arr = new int[size];

        // Nhập giá trị cho các phần tử của mảng và kiểm tra đầu vào
        for (int i = 0; i < arr.Length; i++)
        {
            int element;
            do
            {
                Console.Write($"Enter element {i + 1}: ");
            } while (!Int32.TryParse(Console.ReadLine(), out element));

            arr[i] = element;
        }

        // Tìm vị trí của giá trị nhỏ nhất trong mảng
        int index = MinValue(arr);

        // In ra giá trị nhỏ nhất và vị trí của nó
        Console.WriteLine("The smallest element in the array is: " + arr[index]);
        Console.WriteLine("The position of the smallest element is: " + index);
    }
}
