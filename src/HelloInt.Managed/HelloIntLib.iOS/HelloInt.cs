using System.Runtime.InteropServices;

namespace HelloInt
{
    public class HelloInt
    {
        [DllImport("__Internal")]
        private static extern int hello_int_get_value();

        [DllImport("__Internal")]
        private static extern void hello_int_set_value(int val);

        public int GetValue()
        {
            return hello_int_get_value();
        }

        public void SetValue(int val)
        {
            hello_int_set_value(val);
        }
    }
}