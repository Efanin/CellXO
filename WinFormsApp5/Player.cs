using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Player
    {
        private string symbol;
        private int combo = 1;
        private int[] combolist = new[] { 30,238,506,627,935,1001,1495,7429};
        public Player(string symbol)
        {
            this.symbol = symbol;
        } 
        public string Win(int combo)
        {
            this.combo *= combo;
            foreach (var item in combolist)
            {
                if (this.combo % item == 0)
                {
                    //MessageBox.Show("Win: " + symbol);
                    return "Win: " + symbol;
                }
            } 
            return "Win: ";
        }
        public void DeleteCombo(int combo)
        {
            if (this.combo % combo == 0) 
                this.combo /= combo;
        }


    }
}
