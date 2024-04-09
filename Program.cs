class Program{
    public static void Main(string[] args)
    {
        int[] myArray = new int[10];
        for(int i = 0; i < myArray.Length; i++) {
            myArray[i] = i + 1;
        } 
        int sum = 0;
        for(int i = 0; i < myArray.Length; i++) {
            sum += myArray[i];
        }
        Console.WriteLine("Tong cua mang la " + sum);
    }
}