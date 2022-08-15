DateTime simdi = DateTime.Now; //Program çalıştırıldığı anki tarihi alır.
DateTime yarin = simdi.AddDays(1); //Ertesi günü verir.
DateTime birHaftaOncesi = simdi.AddDays(-7); //Bir hafta öncesini verir.

if(yarin.CompareTo(simdi)>0) //yarin>simdi
    Console.WriteLine("yarin>simdi");
else if(yarin.CompareTo(simdi)<0)
    Console.WriteLine("yarin<simdi");
else
    Console.WriteLine("yarin=simdi"); //Bunlar eski usül ile karşılaştırma. (Metinsel olan date veritipi için)

if (yarin > simdi)
{
    Console.WriteLine("yarin>simdi");
}else if (yarin < simdi)
{
    Console.WriteLine("yarin<simdi");
}else
    Console.WriteLine("yarin=simdi"); //Artık bunlar da kullanabilir.

Console.WriteLine(simdi.DayOfWeek + "-" + simdi.DayOfYear + "-" + simdi.Ticks);
Console.WriteLine(simdi.Date+" - "+DateTime.Today); //Sadece tarih kısmı.

DateTime dt1 = DateTime.Parse("15.08.2022 13:00:00"); //Başlangıç Tarihi
DateTime dt2 = DateTime.Parse("15.08.2022 14:35:15"); //Bitiş Tarihi

TimeSpan sure = dt2.Subtract(dt1);
int days = sure.Days; //0
int seconds = sure.Seconds; //15
double totalSeconds = sure.TotalSeconds; // sure
double totalMinutes = sure.TotalMinutes; // 
Console.WriteLine(sure);





