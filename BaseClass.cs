namespace CSharp28_10
{
    public class BaseClass
    {
        protected int Data = 0;
        public void IncData(int increment) => Data += increment;
        public int GetData() => Data;
        
    }
}