using System;

namespace CSharp28_10
{
    public class TenTon : BaseClass
    {
        private static TenTon[] _instances = new TenTon[] {
            null, null, null,
            null, null, null,
            null, null, null,
            null 
        };

        public static TenTon Instance(int index)
        {
            if (0 > index || index > 9)
                return null;
            if (_instances[index] is null)
                _instances[index] = new TenTon();
            return _instances[index];
        }

        public static int InstancesCount()
        {
            int count = 0;
            foreach (TenTon tenton in _instances)
                count += Convert.ToInt16(tenton != null);
            return count;
        }
    }
}