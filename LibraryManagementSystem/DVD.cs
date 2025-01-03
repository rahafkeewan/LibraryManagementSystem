using LibraryManagementSystem;

public class DVD : LibraryItem
{
    public string Director { get; private set; }
    public int Duration { get; private set; }

    public DVD(int id, string titleofbook, string director, int duration) : base(id, titleofbook)
    {
        Director = director;
        Duration = duration;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"DVD ID: {ID}, Title: {TitleOfBook}, Director: {Director}, Duration: {Duration} minutes, Borrowed: {IsBorrowed}");
    }
}