using OOP4;

class Program
{
    static void Main(string[] args)
    {
        //Kapı sayısı  "2 veya 4"  harici girerse,kapı sayısı -1 olarak döner
        Cars car = new Cars("Toyoto","Prado","Black",3);
        //Arac bilgileri Gösterme Methodu
        car.CarDisplay();


    }
}