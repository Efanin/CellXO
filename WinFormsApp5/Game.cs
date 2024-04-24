using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Game
    {
        private string[] symbol = new[] { "IG", "IV", "PV", "AL", "VA", "MA", "YA", "NI" };
        private int steps = 0;
        private List<Player> players = new List<Player>();
        public Game()
        {
            for(int i = 0; i < symbol.Length; i++)
            {
                players.Add(new Player(symbol[i]));
            }
        }
        public string Click(int combo,Label step,Label win)
        {
            int i = steps % symbol.Length;
            for (int j = 0; j < symbol.Length; j++)
                players[j].DeleteCombo(combo);
            win.Text = players[i].Win(combo);
            step.Text = "Step: " + symbol[(i + 1) % symbol.Length];
            steps++;
            return symbol[i];
        }
        public void clear()
        {
            players.Clear();
            for (int i = 0; i < symbol.Length; i++)
            {
                players.Add(new Player(symbol[i]));
            }
            steps = 0;
        }
    }
}
