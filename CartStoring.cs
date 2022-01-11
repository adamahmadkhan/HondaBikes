using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Login
{
    class CartStoring
    {
       public static List<Panel> cart = new List<Panel>();
       public static List<int> DataPrices= new List<int>();
       public static List<String> DataNames = new List<String>();
       public static int x=0;


       public static void SendToDatabase()
        {
            for(int i = 0; i < x; i++)
            {
                int x = DataPrices[i];
                string y = DataNames[i];
                // send price and bikeName to database From here 

            }

        }
    }
   

}
