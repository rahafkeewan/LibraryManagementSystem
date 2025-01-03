using LibraryManagementSystem;

public class Magazine : LibraryItem
{
    public string Publisher { get; private set; }
    public int IssueNumber { get; private set; }
    public int Year { get; private set; }

    public Magazine(int id, string titleofbook, string publisher, int issueNumber, int year) : base(id, titleofbook)
    {
        Publisher = publisher;
        IssueNumber = issueNumber;
        Year = year;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Magazine ID: {ID}, Title: {TitleOfBook}, Publisher: {Publisher}, Issue Number: {IssueNumber}, Year: {Year}, Borrowed: {IsBorrowed}");
    }
}