using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class Coin
    {
         Random random = new Random();
        private string sideUp;  //儲存目前朝上的面

        public Coin() //建構子，設定初始值
        { 
            sideUp = "Heads"; //建設為正面朝上
        }
        public void Toss()
        {
            
            int side = random.Next(2);
            if (side == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
                
        }
        public string GetSideUp()
        {
            return sideUp;
        }

    }
    
}
