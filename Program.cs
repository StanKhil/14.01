using System;
using System.Runtime.InteropServices;


namespace _14._01
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, String text, String caption, int type);

        static void Main()
        {
            MessageBox(IntPtr.Zero, "Мене звати Хіль Станіслав", "Name", 0);
            MessageBox(IntPtr.Zero, "Я навчаюся программування", "Course", 0);
            MessageBox(IntPtr.Zero, "Мені 17 років", "Age", 0);
            MessageBox(IntPtr.Zero, "Мій номер телефону: 380 99 999 99 99", "Phone", 0);
            
        }
    }
}
