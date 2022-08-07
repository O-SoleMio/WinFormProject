using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UsingApplication
{
    class UsingApplication : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if(m.Msg == 0x0F || m.Msg == 0xA0 ||
                m.Msg == 0x200 || m.Msg == 0x113)
            return false;

            Console.WriteLine($"{m.ToString()} : {m.Msg}");

            if (m.Msg == 0x201)
                Application.Exit();

            return true;
        }
    }
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new UsingApplication());
            Application.Run(new MainApp());
        }
    }
}
