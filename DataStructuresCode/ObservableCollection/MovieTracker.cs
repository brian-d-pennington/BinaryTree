using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace DataStructuresCode.ObservableCollection
{
    public class MovieTracker
    {
        ObservableCollection<string> FastFuriousFilmFranchise;
        public MovieTracker()
        {
            FastFuriousFilmFranchise = new ObservableCollection<string>
            {
                "The Fast and the Furious",
                "2 Fast 2 Furious",
                "Tokyo Drift",
                "Fast and Furious",
                "Fast Five",
                "Fast and Furious 6",
                "Furious 7",
                "Fast 8"
            };
        }
        public void GetFastFuriousFilmCollection()
        {
            foreach (var film in FastFuriousFilmFranchise)
            {
                Console.WriteLine(film);
            }

            FastFuriousFilmFranchise.CollectionChanged += FastFuriousFilmFranchise_CollectionChanged;
            FastFuriousFilmFranchise.Remove("Fast 8");
            FastFuriousFilmFranchise.Add("The Fate of the Furious");
            

            foreach (var film in FastFuriousFilmFranchise)
            {
                Console.WriteLine(film);
            }
        }

        private void FastFuriousFilmFranchise_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            
            Console.WriteLine(e.Action);
        }
    }
}
