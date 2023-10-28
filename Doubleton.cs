using System;

namespace CSharp28_10
{
    public class Doubleton : BaseClass
    {
        private static Doubleton[] _instances = new Doubleton[]{null, null};

        public static Doubleton Instance1()
        {
            if (_instances[0] is null)
                _instances[0] = new Doubleton();
            return _instances[0];
        }

        public static Doubleton Instance2()
        {
            if (_instances[1] is null)
                _instances[1] = new Doubleton();
            return _instances[1];
        }

        public static int InstancesCount()
        {
            return Convert.ToInt16(_instances[0] != null) + Convert.ToInt16(_instances[1] != null);
        }
    }
}