class Program{

  public void Main(string[] args){
    
    Book book1 = new Book();
    book1.Title = "The book of Life";

    List<ILibraryItem> libraryItems = new List<ILibraryItem>();

    libraryItems.Add(
      new Book{
      Title = "",
      Publishing = ""
    });

    AudioBook audioBook= new AudioBook();
    libraryItems.Add(audioBook);

    Journal journal = new Journal();
    libraryItems.Add(journal);

  }
}


interface ILibraryItem{ // parent class :: base class
  public string?  Title { get; set; } 
  public string?  Publishing { get; set; }
}

interface IPodcast {
  public int Duration { get; set; }
}

interface IAudioBook :  ILibraryItem, IPodcast{

}

class JournalD : ILibraryItem {
  public int VolNum { get; set;}
  public string? Title { get; set; }
  public string? Publishing { get; set; }
}

class Journal : JournalD
{
  
}

// child/ren clas :: subclass
class Book : ILibraryItem
{
  public string? Title { get ; set ; }
  public string? Publishing { get ; set ; }
}

class AudioBook : IAudioBook
{
  public string? Title { get; set; }
  public string? Publishing { get; set; }
  public int Duration { get; set; }
}


// Library?
/*
  book
  audiobook
  journal

info in them:
  title
  publishing

special info:   

  book
    ISBN
    ACCN #
  aBook 
    duration
  Journal
    Vol# 

*/


