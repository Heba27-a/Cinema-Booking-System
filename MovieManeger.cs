using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class MovieManeger
    {
        public List<Movie> Movies { get; } = new List<Movie>();

        public MovieManeger()
        {
            Movies.Add(new Movie(
                "Interstellar",
                       "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                       "Matthew McConaughey, Anne Hathaway, Jessica Chastain"));

            Movies.Add(new Movie(
                    "Inception",
                "A thief who steals corporate secrets through dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page"));

            Movies.Add(new Movie(
                    "The Dark Knight",
                "Batman sets out to dismantle the remaining criminal organizations that plague Gotham, but the rise of the Joker brings chaos and tests his moral code.",
                "Christian Bale, Heath Ledger, Aaron Eckhart"));

            Movies.Add(new Movie(
                    "Avatar",
                "On the lush alien world of Pandora, a paraplegic Marine is sent to interact with the native Na'vi people and becomes torn between following orders and protecting the world he feels is his home.",
                "Sam Worthington, Zoe Saldana"));

            Movies.Add(new Movie(
                    "Dune",
                "Paul Atreides, a brilliant young noble, travels to the dangerous desert planet Arrakis, where his family becomes embroiled in a war over the galaxy's most valuable substance, spice.",
                "Timothée Chalamet, Rebecca Ferguson, Oscar Isaac"));

            Movies.Add(new Movie(
                    "Matrix",
                "A computer hacker learns about the true nature of reality and his role in the war against its controllers.",
                "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss"));
        }
        
    }

}
