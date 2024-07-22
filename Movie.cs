public class Movie
{
    private String title;
    private String genre;
    private int year;
    public Movie()
    {

    }
    public Movie(String movieName)
    {
        this.title = movieName;
    }
    public void setTitle(String title)
    {
        this.title = title;
    }

    public String getTitle()
    {
        return title;
    }

    public void setGenre(String genre)
    {
        this.genre = genre;
    }

    public String getGenre()
    {
        return genre;
    }

    public void setYear(int year)
    {
        this.year = year;
    }

    public int getYear()
    {
        return year;
    }

}