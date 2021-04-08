using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab4
{
    [Serializable]
    public class Triangle : Geometric_figure
    {
        //уникальные поля наследника
        public double height;
        public double base_tr;
        // их свойства
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                    height = value;
                else height = 0;
            }
        }
        public double Base_tr
        {
            get
            {
                return base_tr;
            }
            set
            {
                if (value > 0)
                    base_tr = value;
                else base_tr = 0;
            }
        }
        //конструкторы
        public Triangle(): base ()
        {
            num_angle = 3;
            height = 0;
            base_tr = 0;
        }
        public Triangle(string Name, int Num_angle, double Height, double Base_tr): base(Name, Num_angle)
        {
            num_angle = 3;
            height = Height;
            base_tr = Base_tr;
        }

        public Triangle(string name, double Height, double Base_tr)
        {
            this.name = name;
            num_angle = 3;
            height = Height;
            base_tr = Base_tr;
        }
        //переопределение абстрактного метода родителя
        public override void Information()
        {
            Console.WriteLine("Треугольник — геометрическая фигура, образованная тремя отрезками, \n которые соединяют три точки, не лежащие на одной прямой.");
        }
        //скрытие методы родителя
        new public void Area ()
        {
            double area = (base_tr / 2) * height;
            Console.WriteLine("My area = "+area);
        }



        public static void SaveClass(string filename)
        {//запишет в текстовый файл всю информацию о типе вашего класса
            Type type = typeof(Triangle);
            StreamWriter f = new StreamWriter(filename);
            f.WriteLine("Полное имя класса:" + type.FullName);
            if (type.IsAbstract) f.WriteLine("Абстрактный класс");
            if (type.IsClass) f.WriteLine("Обычный класс");
            if (type.IsInterface) f.WriteLine("Интерфейс");
            if (type.IsEnum) f.WriteLine("Перечисление");
            if (type.IsSealed) f.WriteLine("Закрыт для наследования");
            f.WriteLine("Базовый класс - " + type.BaseType);
            FieldInfo[] fields = type.GetFields();
            if (fields.Count() > 0)
                f.WriteLine("*** Поля класса: ***");
            foreach (var field in fields)
            {
                f.WriteLine(field);
            }
            PropertyInfo[] properties = type.GetProperties();
            if (properties.Count() > 0)
                f.WriteLine("*** Свойства класса: ***");
            foreach (var property in properties)
            {
                f.WriteLine(property);
            }
            MethodInfo[] methods = type.GetMethods();
            if (methods.Count() > 0)
                f.WriteLine("*** Методы класса: ***");
            foreach (var method in methods)
            {
                f.WriteLine(method);
            }
            f.Close();

        }
        public void SaveObject(string filename)
        {// экземплярный метод, который будет сохранять в бинарный файл всю информацию о текущем объекте.
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(name);
            bw.Write(num_angle);
            bw.Write(height);
            bw.Write(base_tr);
            fs.Close();

        }
        public static Triangle LoadObject(string filename)
        {//Метод, который будет читать информацию из бинарного файла и возвращать готовый объект. 
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            string bname = br.ReadString();
            int bnum_angle = br.ReadInt32();
            double bheight = br.ReadDouble();
            double bbase_tr = br.ReadDouble();
            fs.Close();
            return new Triangle(bname, bheight, bbase_tr);

        }
        public void Serialize(string filename)
        {// метод, который сериализуют объект класса.
            Stream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter fmt = new BinaryFormatter();
            fmt.Serialize(fs, this);
            fs.Close();

        }
        public static Triangle Deserialize(string filename)
        {// метод, который десериализуют объект класса.
            Stream fs = new FileStream(filename, FileMode.Open);
            BinaryFormatter fmt = new BinaryFormatter();
            Triangle line = (Triangle)fmt.Deserialize(fs);
            fs.Close();
            return line;


        }
                     
public override string ToString()
        {
            return "Треугольник " + name + " имеет " + num_angle + " угла. Высота треугольника = "+height+". Основание треугольника = "+base_tr;
        }
    }
}