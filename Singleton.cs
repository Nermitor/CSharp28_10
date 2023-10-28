namespace CSharp28_10
{
    public class Singleton : BaseClass
    {
        private static Singleton _uniqueInstance = null;

        public static Singleton Instance()
        {
            if (_uniqueInstance is null)
                _uniqueInstance = new Singleton();
            return _uniqueInstance;
        }

        public static int InstancesCount() => _uniqueInstance is null ? 0 : 1;
        
    }
}