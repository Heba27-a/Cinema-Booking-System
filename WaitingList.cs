using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cinema
{
    public class WaitingList
    {
        public Movie Movie { get; private set; }

        public Queue<string> waitingList { get; private set; } = new Queue<string>(); 

        public WaitingList(Movie movie)
        {
            Movie = movie;
        }

        public void AddToWaitingList(string userName)
        {
            waitingList.Enqueue(userName); 
        }

        public string PopNextUser()
        {
            if (waitingList.Count > 0)
                return waitingList.Dequeue();
            return null;
        }
    }

}

