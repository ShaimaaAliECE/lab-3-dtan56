using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        // Field of CollectionBoard type
        private CollectionBoard board;
        private string description;

        public CollectionBoard Board
        {
            get { return board; }
            set { board = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Collectable(string description)
        {
            Description = description;
        }
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Description} is displayed");
        }
    }
}
