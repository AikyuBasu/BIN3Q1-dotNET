using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

    public class PlacesData
    {
    public object placesList { get; }

    public PlacesData()
        {
            string pathProject = Environment.CurrentDirectory;
            Place p1 = new Place(pathProject + "/photos/bruxelles.jpg", "Bruxelles");
            Place p2 = new Place(pathProject + "/photos/paris.jpg", "Paris");
            Place p3 = new Place(pathProject + "/photos/moscou.jpg", "Moscou");
            Place p4 = new Place(pathProject + "/photos/amsterdam.jpg", "Amsterdam");
            Place p5 = new Place(pathProject + "/photos/newyork.jpg", "New York");

            placesList = new List<Place>
            {
                p1,
                p2,
                p3,
                p4,
                p5
            };

        }


    }

    public class Place
    {
        private string _description { get; set; }
        private string _pathImageFile { get; set; }
        private int _nbVotes { get; set; }
        private Uri _uri { get; set; }
        private BitmapFrame _image { get; set; }

        public Place(string path, string description)
        {
            _description = description;
            _pathImageFile = path;
            _nbVotes = 0;
            _uri = new Uri(_pathImageFile);
            _image = BitmapFrame.Create(_uri);
        }

    }
