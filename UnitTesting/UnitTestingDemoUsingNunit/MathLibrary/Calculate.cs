namespace MathLibrary
{
    public class Calculate
    {
        public int Add(int a, int b)
        {
            int result = a+b;
            return result;
        }
        public bool IsEven(int a)
        {
            if(a%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
