public abstract class Activity
{
 private string _date;
 private int _length;

 public Activity(string Date, int Length)
 {
    _date = Date;
    _length = Length;
 }

 public virtual void GetSummary()
 {
    Console.WriteLine($"{_date} @ {_length}");
 }
 public abstract int GetPace();
}