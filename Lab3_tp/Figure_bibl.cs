using System;
namespace Practice
{
    // Родительский класс
    public abstract class Geometric_Shapes
    {
        // Хранит имя фигур 
        private string name;

        // Хранит периметр фигур 
        private int perimeter;

        //Хранит площадь фигур 
        private int area;

        //Хранит углы фигур 
        private int corners;

        //Хранит количество фигур 
        private int number;

        //свойства имени
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                    throw new ArgumentNullException();
                else
                    name = value;
            }
        }
        //свойства периметра
        public int Perimeter
        {
            get { return perimeter; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    perimeter = value;
            }
        }
        //свойства телефона
        public int Area
        {
            get { return area; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    area = value;
            }
        }
        //свойства персонала
        public int Corners
        {
            get { return corners; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    corners = value;
            }
        }

        //свойства количества 
        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    number = value;
            }
        }
        //возвращает строку с информацией об объектах
        public virtual string GetInfo()
        {
            return $"У {name}  {corners} углов, периметр - {perimeter}, площадь = {area} всего их {number}.";
        }

        //Конструктор по умолчанию
        public Geometric_Shapes()
        {

        }
        //Конструктор, задающий имя
        public Geometric_Shapes(string Name)
        {
            this.Name = Name;
        }

        //Конструктор, задающий количество углов, площадь, периметр, количество фигур
        public Geometric_Shapes(int Perimeter, int Number, int Area, int Corners)
        {
            this.Perimeter = Perimeter;
            this.Area = Area;
            this.Number = Corners;
            this.Number = Number;
        }

    }
    //Дочерний класс
    public class Square : Geometric_Shapes
    {
        //Функция для получения информации
        public override string GetInfo()
        {
            return base.GetInfo();
        }

        //Конструктор по умолчанию 
        public Square() : base()
        {

        }

        //Конструктор, задающий имя
        public Square(string Name) : base(Name)
        {

        }
        //Конструктор, задающий количество углов, площадь, периметр, количество фигур
        public Square(int Perimeter, int Number, int Area, int Corners) : base(Perimeter, Number, Area, Corners)
        {

        }
    }
    //Дочерний класс
    public class Circle : Geometric_Shapes
    {
        //Функция для получения информации
        public override string GetInfo()
        {
            return base.GetInfo();
        }

        //Конструктор по умолчанию  
        public Circle() : base()
        {

        }

        //Конструктор, задающий имя
        public Circle(string Name) : base(Name)
        {

        }
        //Конструктор, задающий количество углов, площадь, периметр, количество фигур
        public Circle(int Perimeter, int Number, int Area, int Corners) : base(Perimeter, Number, Area, Corners)
        {

        }
    }
}