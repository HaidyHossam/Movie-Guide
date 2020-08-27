using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace MovieGuide
{
    public class Director
    {
        public string Name;
        public Director()
        {

        }
        public Director(string x)
        {
            this.Name = x;
        }
    }
    public class Movie
    {
        public string ID;
        public string Title;
        public string Year;
        public string Director;
        public string Rating;
        public string Poster;
        public List<Genree> Genres = new List<Genree>();

        public Movie()
        {
            Genres = new List<Genree>();
        }
        public List<Movie> Recommend(List<Genree> Genrees)
        {
            List<bool> check = new List<bool>(); 
            XmlDocument doc = new XmlDocument();
            doc.Load("Main.xml");
            List<Movie> RecMovies = new List<Movie>();
            List<string> list1 = new List<string>();
            for (int i = 0; i < Genrees.Count; i++)
            {
                list1.Add(Genrees.ElementAt(i).nameofgenre);
            }

            foreach (XmlNode node in doc.SelectNodes("AllMovies/Director/Movies/Movie"))
            {
                Movie M = new Movie();
                M.ID = node.SelectSingleNode("ID").InnerText;
                M.Title = node.SelectSingleNode("Title").InnerText;
                M.Director = node.SelectSingleNode("Director").InnerText;
                M.Year = node.SelectSingleNode("Year").InnerText;
                M.Rating = node.SelectSingleNode("Rating").InnerText.ToString();
                M.Poster = node.SelectSingleNode("Poster").InnerText.ToString();
                XmlNodeList Genres = node.SelectNodes("Genres/Genree");
                for (int k = 0; k < Genres.Count; k++)
                {
                    Genree genree = new Genree(Genres[k].InnerText);
                    M.Genres.Add(genree);
                }
                if (Genrees.Count == 1)
                {
                    for (int j = 0; j < M.Genres.Count; j++)
                    {
                        if (Genrees.ElementAt(0).nameofgenre == M.Genres.ElementAt(j).nameofgenre)
                        {
                            RecMovies.Add(M);
                        }
                    }
                }
                else
                {
                    List<string> list2 = new List<string>();
                    for(int m=0;m<M.Genres.Count;m++)
                    {
                        list2.Add(M.Genres.ElementAt(m).nameofgenre);
                    }
                    var firstNotSecond = list1.Except(list2).ToList();
                    var secondNotFirst = list2.Except(list1).ToList();
                    if (firstNotSecond.Count == 0 && secondNotFirst.Count==0 || secondNotFirst.Count > 0 && firstNotSecond.Count==0)
                    {
                        RecMovies.Add(M);
                    }
                }
            }
            return RecMovies;
        }
        public void Save_Movie(string A_File, string A_Eit, string A_ID, string A_Title, string A_Director, string A_Year, string A_Rate, List<Genree> A_Genres)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(A_File + ".xml");
            foreach (XmlNode node in doc.SelectNodes("ArrayOfMovie/Movie"))
            {

                if (node.SelectSingleNode("Title").InnerText == A_Eit)
                {
                    node.SelectSingleNode("ID").InnerText = A_ID;
                    node.SelectSingleNode("Title").InnerText = A_Title;

                    node.SelectSingleNode("Genres").RemoveAll();
                    for (int m = 0; m < A_Genres.Count; m++)
                    {
                        XmlElement NewGenre = doc.CreateElement("Genree");
                        XmlElement Name = doc.CreateElement("nameofgenree");
                        Name.InnerText = A_Genres.ElementAt(m).nameofgenre;
                        NewGenre.AppendChild(Name);
                        node.SelectSingleNode("Genres").AppendChild(NewGenre);
                    }
                    node.SelectSingleNode("Director").InnerText = A_Director;
                    node.SelectSingleNode("Year").InnerText = A_Year;
                    node.SelectSingleNode("Rating").InnerText = A_Rate;
                }
            }
            doc.Save(A_File + ".xml");
        }
        public Movie MovieEdit(string FileName, string ToEdit)
        {
            XmlDocument doc = new XmlDocument();
            Movie m = new Movie();
            doc.Load(FileName + ".xml");
            foreach (XmlNode node in doc.SelectNodes("ArrayOfMovie/Movie"))
            {
                if (node.SelectSingleNode("Title").InnerText == ToEdit)
                {
                    m.ID = node.SelectSingleNode("ID").InnerText;
                    m.Title = node.SelectSingleNode("Title").InnerText;
                    m.Director = node.SelectSingleNode("Director").InnerText;
                    m.Year = node.SelectSingleNode("Year").InnerText;
                    m.Rating = node.SelectSingleNode("Rating").InnerText.ToString();
                    List<Genree> List = new List<Genree>();
                    XmlNodeList Genres = node.SelectNodes("Genres/Genree");
                    for (int k = 0; k < Genres.Count; k++)
                    {
                        Genree list = new Genree(Genres[k].InnerText);
                        List.Add(list);

                    }
                    m.Genres = List;


                }
            }
            return m;
        }
        public void Remove(string filename,string toRemove) {
            XmlDocument Doc = new XmlDocument();

            Doc.Load(filename+".xml");

            foreach (XmlNode node in Doc.SelectNodes("ArrayOfMovie/Movie"))
            {
                if (node.SelectSingleNode("Title").InnerText ==toRemove)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }
            Doc.Save(filename+".xml");
        }
    
        public Movie TitleSearch(string search)
        {

            bool recordFound = false;
            string fileName = "Main.xml";
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }
            if (search == "")
                throw new ArgumentNullException();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlNodeList list = doc.GetElementsByTagName("Movie");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childrens = list[i].ChildNodes;
                
                if (childrens[1].InnerText == search)
                {
                    
                    recordFound = true;
                    Title = childrens[1].InnerText;
                    ID = childrens[0].InnerText;
                    Director = childrens[3].InnerText;
                    Year = childrens[2].InnerText;
                    Rating = childrens[4].InnerText;
                    Poster = childrens[6].InnerText;
                    XmlNodeList GenreChildren = childrens[5].ChildNodes;
                    Genree genre;
                    for (int j = 0; j < GenreChildren.Count; j++)
                    {
                         genre = new Genree(GenreChildren[j].InnerText);
                         Genres.Add(genre);
                    }
                   
                }
                else
                    continue;
            }

            if (recordFound)
                return this;
            else
                return null;

        }
        public List<Movie> YearSearch(string Year)
        {
            Movie m;
            List<Movie> movies = new List<Movie>();
            List<Genree> Genrevalue = new List<Genree>();
            bool recordFound = false;
            string fileName = "Main.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlNodeList list = doc.GetElementsByTagName("Movie");

            for (int i = 0; i < list.Count; i++)
            {
                Genrevalue = new List<Genree>();
                m = new Movie();
                XmlNodeList childrens = list[i].ChildNodes;

                if (childrens[2].InnerText == Year)
                {

                    recordFound = true;
                    
                    string IDval = childrens[0].InnerText;
                    string Titleval = childrens[1].InnerText;
                    string Yearval = childrens[2].InnerText;
                    string Directorval = childrens[3].InnerText;
                    string Ratingval = childrens[4].InnerText;
                    string Posterval = childrens[6].InnerText;
                    XmlNodeList GenreChildren = childrens[5].ChildNodes;
                    for (int j = 0; j < GenreChildren.Count; j++)
                    { 
                        Genree genre = new Genree(GenreChildren[j].InnerText);
                        Genrevalue.Add(genre);
                    }
                    m.ID = IDval;
                    m.Title = Titleval;
                    m.Year = Yearval;
                    m.Rating = Ratingval;
                    m.Poster = Posterval;
                    m.Director = Directorval;
                    m.Genres = Genrevalue;
                    movies.Add(m);
                }
                else
                    continue;

            }
            if (recordFound)
                return movies;
            else
                return null;
        }
        public void AddCreateFile(string id, string title, List<Genree> Genre, string director, string year, string rating, string filename, string path)
        {
            List<Movie> movielist = new List<Movie>();
            Movie mov = new Movie();
            mov.ID = id;
            mov.Title = title;
            mov.Genres = Genre;
            mov.Director = director;
            mov.Year = year;
            mov.Rating = rating;
            mov.Poster = path;

            bool check = false;
            List<Director> Directors = new List<Director>();
            if (File.Exists("Directors.xml"))
            {
                XmlSerializer Xs = new XmlSerializer(Directors.GetType());
                FileStream Fs = new FileStream("Directors.xml", FileMode.Open);
                Directors = (List<Director>)Xs.Deserialize(Fs);
                Fs.Close();
                for (int i = 0; i < Directors.Count; i++)
                {
                    if (Directors[i].Name == director)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                    Directors.Add(new Director(director));

                XmlSerializer sxx = new XmlSerializer(Directors.GetType());
                FileStream f = new FileStream("Directors.xml", FileMode.OpenOrCreate);
                sxx.Serialize(f, Directors);
                f.Close();              
            }
            else
            {
                Directors.Add(new Director(director));
                XmlSerializer sxx = new XmlSerializer(Directors.GetType());
                FileStream f = new FileStream("Directors.xml", FileMode.OpenOrCreate);
                sxx.Serialize(f, Directors);
                f.Close();
            }

            movielist.Add(mov);

            XmlSerializer s = new XmlSerializer(movielist.GetType());
            FileStream fs = new FileStream(filename+".xml", FileMode.Create);
            s.Serialize(fs, movielist);
            fs.Close();
        }
        public void AddToExist(string id, string title, List<Genree> Genre, string director, string year, string rating, string filename, string path)
        {
            List<Movie> movielist = new List<Movie>();
            Movie mov = new Movie();
            mov.ID = id;
            mov.Title = title;
            mov.Genres = Genre;
            mov.Director = director;
            mov.Year = year;
            mov.Rating = rating;
            mov.Poster = path;


            bool check = false;
            List<Director> Directors = new List<Director>();
            if (File.Exists("Directors.xml"))
            {
                XmlSerializer Xs = new XmlSerializer(Directors.GetType());
                FileStream Fs = new FileStream("Directors.xml", FileMode.Open);
                Directors = (List<Director>)Xs.Deserialize(Fs);
                Fs.Close();
                for (int i = 0; i < Directors.Count; i++)
                {
                    if (Directors[i].Name == director)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                    Directors.Add(new Director(director));

                XmlSerializer sxx = new XmlSerializer(Directors.GetType());
                FileStream f = new FileStream("Directors.xml", FileMode.OpenOrCreate);
                sxx.Serialize(f, Directors);
                f.Close();  
            }
            else
            {
                Directors.Add(new Director(director));
                XmlSerializer sxx = new XmlSerializer(Directors.GetType());
                FileStream f = new FileStream("Directors.xml", FileMode.OpenOrCreate);
                sxx.Serialize(f, Directors);
                f.Close();
            }

            if (File.Exists(filename+".xml"))
            {
                XmlSerializer S = new XmlSerializer(movielist.GetType());
                FileStream fs = new FileStream(filename+".xml", FileMode.Open);
                movielist = (List<Movie>)S.Deserialize(fs);
                fs.Close();
            }
            movielist.Add(mov);

            XmlSerializer s = new XmlSerializer(movielist.GetType());
            FileStream fff = new FileStream(filename+".xml", FileMode.Create);
            s.Serialize(fff, movielist);
            fff.Close();
        } 

        public bool SearchUniquID(string search, string filename)
        {
            if (!File.Exists(filename + ".xml"))
            {
                throw new FileNotFoundException();
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(filename + ".xml");
            XmlNodeList list = doc.GetElementsByTagName("Movie");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childrens = list[i].ChildNodes;
                ID = childrens[0].InnerText;

                if (ID == search)
                {
                    return false;
                }
            }
            return true;
        }
        public List<Movie> AboveRatingSearch(int rate)
        {
            Movie m;
            List<Movie> movies = new List<Movie>();
            XmlDocument Doc = new XmlDocument();
            Doc.Load("Main.xml");
            XmlNodeList List = Doc.GetElementsByTagName("Movie");
            List<Genree> Genrevalue;
            for (int i = 0; i < List.Count; i++)
            {
                Genrevalue = new List<Genree>();
                m = new Movie();
                XmlNodeList children = List[i].ChildNodes;

                if (int.Parse(children[4].InnerText) > rate)
                {
                    string IDvalue = children[0].InnerText;
                    string Titlevalue = children[1].InnerText;
                    string Yearvalue = children[2].InnerText;
                    string Directorvalue = children[3].InnerText;
                    string Ratingvalue = children[4].InnerText;
                    XmlNodeList GenreChildren = children[5].ChildNodes;

                    for (int j = 0; j < children[5].ChildNodes.Count; j++)
                    {
                        Genree genre = new Genree(GenreChildren[j].InnerText);
                        Genrevalue.Add(genre);
                    }
                    string Imagevalue = children[6].InnerText;
                    m.ID = IDvalue;
                    m.Title = Titlevalue;
                    m.Year = Yearvalue;
                    m.Rating = Ratingvalue;
                    m.Poster = Imagevalue;
                    m.Director = Directorvalue;
                    m.Genres = Genrevalue;
                    movies.Add(m);
                }

            }
            return movies;
        }

        public List<Movie> BelowRatingSearch(int rate)
        {
            Movie m;
            List<Movie> movies = new List<Movie>();
            XmlDocument Doc = new XmlDocument();
            Doc.Load("Main.xml");
            XmlNodeList List = Doc.GetElementsByTagName("Movie");
            List<Genree> Genrevalue = new List<Genree>();
            for (int i = 0; i < List.Count; i++)
            {
                Genrevalue = new List<Genree>();
                m = new Movie();
                XmlNodeList children = List[i].ChildNodes;

                if (int.Parse(children[4].InnerText) < rate)
                {
                    string IDvalue = children[0].InnerText;
                    string Titlevalue = children[1].InnerText;
                    string Yearvalue = children[2].InnerText;
                    string Directorvalue = children[3].InnerText;
                    string Ratingvalue = children[4].InnerText;
                    XmlNodeList GenreChildren = children[5].ChildNodes;

                    for (int j = 0; j < children[5].ChildNodes.Count; j++)
                    {
                        Genree genre = new Genree(GenreChildren[j].InnerText);
                        Genrevalue.Add(genre);
                    }
                    string Imagevalue = children[6].InnerText;
                    m.ID = IDvalue;
                    m.Title = Titlevalue;
                    m.Year = Yearvalue;
                    m.Rating = Ratingvalue;
                    m.Poster = Imagevalue;
                    m.Director = Directorvalue;
                    m.Genres = Genrevalue;
                    movies.Add(m);
                }

            }
            return movies;
        }
        public void Join(List<string> files)
        {
            List<Director> Directors = new List<Director>();
            List<Movie> AllMovies = new List<Movie>();
            Dictionary<string, List<Movie>> DirectorMovie = new Dictionary<string, List<Movie>>();

            XmlSerializer Xs = new XmlSerializer(Directors.GetType());
            FileStream fs = new FileStream("Directors.xml", FileMode.Open);
            Directors = (List<Director>)Xs.Deserialize(fs);

            fs.Close();

            XmlSerializer xs = new XmlSerializer(AllMovies.GetType());
            for (int i = 0; i < files.Count; i++)
            {
                bool check = false;
                List<Movie> M = new List<Movie>();
                FileStream FileS = new FileStream((files[i] + ".xml"), FileMode.Open);
                M = ((List<Movie>)xs.Deserialize(FileS));
                for (int j = 0; j < M.Count; j++)
                {
                    if (AllMovies.Count != 0)
                    {
                        for (int k = 0; k < AllMovies.Count; k++)
                        {
                            if (AllMovies.ElementAt(k).Title == M.ElementAt(j).Title)
                            {
                                check = true;
                                break;                            
                            }
                        }
                        if(check == false)
                        {
                            AllMovies.Add(M.ElementAt(j));
                        } 
                    }
                    else
                    {
                        AllMovies.Add(M.ElementAt(j));
                    }
                }
                FileS.Close();
            }
            for (int i = 0; i < Directors.Count; i++)
            {
                List<Movie> Movies = new List<Movie>();
                for (int j = 0; j < AllMovies.Count; j++)
                {
                    if (Directors[i].Name == AllMovies[j].Director)
                    {
                        Movies.Add(AllMovies[j]);
                    }
                }
                if (Movies.Count != 0)
                {
                    DirectorMovie.Add(Directors[i].Name, Movies);
                }
            }
            if (File.Exists("Main.xml"))
            {
                File.Delete("Main.xml");
            }

            XmlWriter W = XmlWriter.Create("Main.xml");

            W.WriteStartDocument();
            W.WriteStartElement("AllMovies");
            for (int i = 0; i < DirectorMovie.Count; i++)
            {
                W.WriteStartElement("Director");

                W.WriteStartElement("Name");
                W.WriteString(DirectorMovie.ElementAt(i).Key);
                W.WriteEndElement();

                W.WriteStartElement("Movies");
                for (int j = 0; j < DirectorMovie.ElementAt(i).Value.Count; j++)
                {
                    W.WriteStartElement("Movie");

                    W.WriteStartElement("ID");
                    W.WriteString(DirectorMovie.ElementAt(i).Value.ElementAt(j).ID);
                    W.WriteEndElement();

                    W.WriteStartElement("Title");
                    W.WriteString(DirectorMovie.ElementAt(i).Value.ElementAt(j).Title);
                    W.WriteEndElement();

                    W.WriteStartElement("Year");
                    W.WriteString(DirectorMovie.ElementAt(i).Value.ElementAt(j).Year);
                    W.WriteEndElement();

                    W.WriteStartElement("Director");
                    W.WriteString(DirectorMovie.ElementAt(i).Value.ElementAt(j).Director);
                    W.WriteEndElement();

                    W.WriteStartElement("Rating");
                    W.WriteString(DirectorMovie.ElementAt(i).Value.ElementAt(j).Rating);
                    W.WriteEndElement();

                    W.WriteStartElement("Genres");
                    for (int k = 0; k < DirectorMovie.ElementAt(i).Value.ElementAt(j).Genres.Count; k++)
                    {
                        W.WriteStartElement("Genree");
                        W.WriteString(DirectorMovie.ElementAt(i).Value.ElementAt(j).Genres.ElementAt(k).nameofgenre);
                        W.WriteEndElement();
                    }
                    W.WriteEndElement();

                    W.WriteStartElement("Poster");
                    W.WriteString(DirectorMovie.ElementAt(i).Value.ElementAt(j).Poster);
                    W.WriteEndElement();

                    W.WriteEndElement();
                }
                W.WriteEndElement();
                W.WriteEndElement();
            }
            W.WriteEndDocument();
            W.Close();
        }
    }
}


public class Genree
{
    public string nameofgenre;
    public Genree()
    {
    }
    public Genree(string name)
    {
        nameofgenre = name;
    }
}
    


