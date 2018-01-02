using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8_lesson
{
    class AddArray
    {
        public int[] AddArray2 (string str)
        {
            FileStream fs_masSm = new FileStream(str, FileMode.Open, FileAccess.Read);
            StreamReader sr_masSm = new StreamReader(fs_masSm);
            //int[,] arr_masSm;//= new int [,] ();
            // List<List<int>> arr_mass = new List<List<int>>();
            // arr_mass.Add(new List<int>());

            List<int> arr_list = new List<int>();
            char ch;
            string temp = "";
            int n = 0;

            while (!sr_masSm.EndOfStream)
            {
                ch = (char)sr_masSm.Read();
                if (ch != '\t' && ch != '\n')// && ch != '\r')
                {
                    temp += ch;
                }
                else
                {
                    //arr_mass.Add();
                    arr_list.Add(Convert.ToInt32(temp));
                    temp = "";
                }
            }

            int[] arr_int = new int[arr_list.Count];

            for (int i = 0; i < arr_int.Length; i++)
            {
                arr_int[i] = arr_list[i];
            }

            sr_masSm.Close();
            fs_masSm.Close();

            return arr_int;
        }

    }
}
