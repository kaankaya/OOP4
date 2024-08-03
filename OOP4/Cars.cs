using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class Cars
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _numberDoors;

        //Field(alan) Property(özellik) Tanımı Yapma
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        public string Model
        {
            get => _model;
            set => _model = value;
        }
        public string Color
        {
            get => _color;
            set => _color = value;
        }
        public int NumberDoors
        {
            get
            {
                return _numberDoors;
            }
            set
            {
                //Burada araç kapı sayısında eger 2 veya 4 Girilirse,hata mesajı dönecektir ve kapı sayısı -1 olarak atanacaktır.
                if(value == 2 || value == 4)
                {
                    _numberDoors = value;
                }
                else
                {
                    Console.WriteLine("!!! HATA !!!");
                    Console.WriteLine("Yanlış Kapı Seçimi,Kapı Seçimini 2 veya 4 olarak belirliyebilirsiniz");
                    Console.WriteLine("**********************");
                    _numberDoors = -1;
                }
            }
        }
        //Boş Constructor
        public Cars()
        {

        }
        //Constructor
        public Cars(string brand, string model, string color,int numberDoors)
        {
            _model = model;
            _brand = brand;
            _color = color;
            NumberDoors = numberDoors;
            
        }
        //Araç Bilgileri Göstermek için method
        public void CarDisplay()
        {
            Console.WriteLine($"Araç Markası : {_brand}");
            Console.WriteLine($"Araç Modeli : {_model}");
            Console.WriteLine($"Araç Rengi : {_color}");
            Console.WriteLine($"Kapı Sayısı : {_numberDoors}");
        }
    }
}
