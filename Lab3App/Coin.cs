using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int val;
        public int Value
        {
            get { return val; }
            set { val = value; }
        }
        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }
        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}
