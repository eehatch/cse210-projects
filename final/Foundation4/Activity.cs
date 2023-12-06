public abstract class Activity
{
   private string _date;
   private int _length;

 public Activity(string Date, int Length)
 {
    _date = Date;
    _length = Length;
 }

   public string GetDate()
 {
   return _date;
 }
 public int GetLength()
 {
   return _length;
 }
 public virtual string GetSummary()
 {
    return $"{_date} @ {_length}";
 }
 public abstract double GetPace();
}