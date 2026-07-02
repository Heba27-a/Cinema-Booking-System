namespace Cinema
{
    public class Movie
    { 
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public string Cast { get; protected set; }
        public LinkedList<Seat> Seats { get; set; }
        public WaitingList WaitingList { get; set; }

        public Movie(string title, string description, string cast)
        {
            Title = title;
            Description = description;
            Cast = cast;

            WaitingList = new WaitingList(this);

            Seats = new LinkedList<Seat>();

            for (int i = 1; i <= 20; i++)
            {
                Seats.AddLast(new Seat(i));
            }
        }

        public string MovieInfo()
        {
            return "Movie Title: " +Title + "\n\n" + "Story: "+ Description + "\n\n" + "Cast: " + Cast;
        }

    }

}
