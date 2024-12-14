public abstract class Activity
{
   private string _date;
   private double _length;

 public Activity(string Date, double Length)
 {
    _date = Date;
    _length = Length;
 }

public string GetDate()
 {
   return _date;
 }
public double GetLength()
 {
   return _length;
 }
public virtual string GetSummary()
 {
    return $"{_date} {this.GetType()} ({_length} min)- Distance {Math.Round(GetDistance(),2)} miles, Speed {Math.Round(GetSpeed(),2)} mph, Pace: {Math.Round(GetPace(),2)} min per mile ";
 }
public abstract double GetDistance();
public abstract double GetPace();
public abstract double GetSpeed();
}