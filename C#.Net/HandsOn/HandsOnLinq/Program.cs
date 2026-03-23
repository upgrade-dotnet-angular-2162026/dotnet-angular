namespace HandsOnLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 23, 34, 45, 56, 76,67, 78,12, 89, 90, 98, 87, 76, 65, 54, 43, 32, 21 };
            IEnumerable<int> r=from k in numbers
                               where k%2!=0
                               select k;
           
            //fetch numbers> 50 from the numbers array
            var result=from int a in numbers
                       where a>50 
                       select a;
          
            var result1 = numbers.Where(n => n > 50);
            ////Note: actural result type is IEnumaralble<int>
            ////fetch even numbers >50
            result = from a in numbers
                     where a > 50 && a % 2 == 0
                     select a;
            result1=numbers.Where(n=>n>50 && n % 2 == 0);
            //retch even numbers>50 and dispaly in sorted order
            result = from a in numbers
                     where a > 50 && a % 2 == 0
                     orderby a ascending
                     select a;
            result1=numbers.Where(n=>n>50&&n%2==0).OrderBy(n=>n); //ascending order
            result1 = numbers.Where(n => n > 50 && n % 2 == 0).OrderByDescending(n => n);
            ////fetch unique data
            result = (from a in numbers
                      where a > 50
                      select a).Distinct();
            result1 = numbers.Where(n => n > 50).Distinct();
            ////fetch 1st 5 values
            result = (from a in numbers
                      where a > 50
                      select a).Take(5);
            result1 = numbers.Where(n => n > 50).Take(5);
            ////fetch values to skip first 3
            result = (from a in numbers
                      where a > 50
                      select a).Skip(3);
            Console.WriteLine(result.GetType());
            result1 = numbers.Where(n => n > 50).Skip(5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
