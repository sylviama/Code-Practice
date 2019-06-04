using System;
					
public class Program
{
	public static void Main()
	{
		double angle=96;
		string result=ClockAngle.ClockAngleFunction(angle);
		Console.WriteLine(result);
	}
}

public class ClockAngle
{
	public static string ClockAngleFunction(double angle)
	{
		//calculate hour 360/12=angle/hour
		int hour= (int)Math.Floor(angle/30);
		
		//calculate min: 360/(12*60)=minAngle/min
		double minAngle= angle-hour*30;
		int min= (int)Math.Floor(minAngle *2);
		
		//calculate sec: 360/(12*60*60)=secAngle/sec
		double secAngle = minAngle-min/2;
		double sec= 120*secAngle;
		
		
		return hour.ToString()+":"+min.ToString()+":"+sec.ToString();
	}
	
}
