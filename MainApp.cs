using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWindow
{
    class MainApp : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.Run(new MainApp()); //  기본 창 생성
            
        }
    }
}
