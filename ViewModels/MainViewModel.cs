using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Song_Libary.Models;
using Song_Libary.Utils;

namespace Song_Libary.ViewModels
{
    internal class MainViewModel : PropertyChangedBase
    {
        public MainViewModel() { Songs = [
            new Song(1, "Testname", "TestRecord", 1, new DateTime(1990, 01, 01), "link", "BandNameTest"),
            new Song(2, "Testname", "TestRecord", 2, new DateTime(1990, 01, 01), "link", "BandNameTest"),
            new Song(3, "Testname", "TestRecord", 3, new DateTime(1990, 01, 01), "link", "BandNameTest"),
            new Song(4, "Testname", "TestRecord", 4, new DateTime(1990, 01, 01), "link", "BandNameTest")
            ]; }
        private int viewType;

        public int ViewType
        {
            get { return viewType; }
            set
            {
                viewType = value;
                NotifyOfPropertyChange("ViewType");
            }
        }
        public ObservableCollection<Song> Songs { get; set; }

    }
}
