public class Ticket
{
    private String name;
    private String seat;
    private String time;
    private String date;
    private String price;
    private String movieName;
    private String movieTime;
    private String movieDate;
    private String moviePrice;

    public void setName(String name)
    {
        this.name = name;
    }
    public String getName()
    {
        return name;
    }


    public String getSeat()
    {
        return seat;
    }

    public void setSeat(String seat)
    {
        this.seat = seat;
    }

    public void setTime(String time)
    {
        this.time = time;
    }

    public String getTime()
    {
        return time;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}