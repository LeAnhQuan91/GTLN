internal class Program
{
    private static void Main(string[] args)
    {
         Console.WriteLine("Nhap 1 so vao man hinh");
          int size = 0;
         
          do
          {
            size = Convert.ToInt32(Console.ReadLine());
            
             
          }  
          while (size > 20);        
          int[] myArray = new int[size];
          for (int i = 0;i< myArray.Length; i++)
          {
            myArray[i] = Convert.ToInt32(Console.ReadLine());
          }
for (int i = 0;i < myArray.Length; i++)
          {
            Console.WriteLine(myArray[i] +",");
          }
            int maxValue = 0;
            for (int i = 0;i < myArray.Length; i++)
            {
          
          if(maxValue<myArray[i])
          {
            maxValue = myArray[i];
          }
          Console.WriteLine("gia tri lon nhat cua mang la:"+maxValue);
    }
    }
}