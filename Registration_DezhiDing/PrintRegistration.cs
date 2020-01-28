using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_DezhiDing
{
    class PrintRegistration
    {

        static FileStream fs;
        static StreamWriter sw;

        //delegate declaration
        public delegate void printRegistration(Registration registration);

        //print to Screen
        public static void PrintToScreen(Registration registration)
        {
            string reg = registration.GetRegString();
            MessageBox.Show(reg,"This registration information will be saved to a file!");
        }

        //save to file
        public static void PrintToFile(Registration registration)
        {
            string reg = registration.GetRegString();

            using (fs = new FileStream("Registration.txt", FileMode.Append, FileAccess.Write))
            {
                using (sw = new StreamWriter(fs))
                {
                    sw.WriteLine(reg);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
        }
    }
}
