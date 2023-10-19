using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Circle : IFigure
    {
        /// значение площади фигуры
        private double area;
        /// значение радиуса
        private double[] figureSides;
        /// Функция расчета площади.
        /// <param name="radius">значение радиуса double</param>
        /// <returns>площадь круга double</returns>
        private static double AreaCalculate(double radius)
        {
            return Math.PI * radius * radius;
        }
        /// Валидация круга. Если радиус больше или равен 0 - фигура соответствует.
        /// <param name="radius">значение радиуса double</param>
        /// <returns>true - круг; исключение - при отрицательном радиусе</returns>
        private static bool CircleValidate(double radius)
        {
            if (radius < 0)
            {
                throw new NotValidateException("Radius cannot be assigned as negative value");
            }

            return true;
        }
        /// Тип фигуры
        public string Type { get; }
        /// Площадь круга
        public double Area
        {
            get { return area; }
        }
        /// Радиус окружности double[]
        public double[] FigureSides
        {
            get { return figureSides; }
            set
            {
                double[] radius = (double[])value;

                if ((radius != figureSides) && CircleValidate(radius[0]))
                {
                    figureSides = value;
                    area = AreaCalculate(radius[0]);
                }
            }
        }
        /// Конструктор Circle
        public Circle() : this(new double[] { 0 }) { }

        /// Конструктор Circle
        /// <param name="radius">значение радиуса double</param>
        public Circle(double radius) : this(new double[] { radius }) { }

        /// Конструктор Circle
        /// <param name="radius">значение радиуса double[]</param>
        public Circle(double[] radius)
        {
            FigureSides = radius;
            Type = "circle";
        }
        /// Установить значения сторон
        /// <param name="sides">Массив double[]</param>
        public void Set(double[] sides)
        {
            FigureSides = sides;
        }
        /// Установить значение радиуса
        /// <param name="side">side радиус double</param>
        public void Set(double side)
        {
            FigureSides = new double[] { side };
        }
        /// Вызывает исключение - слишком много параметров
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        public void Set(double sideA, double sideB, double sideC)
        {
            throw new NotValidateException("Too many parameters for Circle");
        }
        /// Обновление значений сторон и возврат значения площади
        /// <param name="side">радиус double</param>
        public double UpdateArea(double side)
        {
            return UpdateArea(new double[] { side });
        }
        /// Обновление значений сторон и возврат значения площади
        /// <param name="side">радиус double[]</param>
        /// <returns></returns>
        public double UpdateArea(double[] side)
        {
            FigureSides = side;
            return area;
        }
        /// Вызывает исключение для Circle
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public double UpdateArea(double sideA, double sideB, double sideC)
        {
            throw new NotValidateException("Too much parameters for Circle");
        }

        /// Площадь круга
        /// <param name="radius">значение радиуса double[]</param>
        /// <returns>площадь круга double</returns>
        public static double GetArea(double[] radius)
        {
            return GetArea(radius[0]);
        }
        /// Площадь круга
        /// <param name="radius">значение радиуса double</param>
        /// <returns>площадь круга double</returns>
        public static double GetArea(double radius)
        {
            if (CircleValidate(radius))
            {
                return AreaCalculate(radius);
            }
            else
            {
                return 0;
            }
        }
        /// Соответствие прямоугольности
        /// <returns>False</returns>
        public bool Rectangular()
        {
            return false;
        }
        /// сравнение площадей
        /// <param name="circleA"></param>
        /// <param name="circleB"></param>
        /// <returns></returns>
        public static bool operator >(Circle circleA, Circle circleB)
        {
            return circleA.Area > circleB.Area;
        }

        /// сравнение площадей
        /// <param name="circleA"></param>
        /// <param name="circleB"></param>
        /// <returns></returns>
        public static bool operator <(Circle circleA, Circle circleB)
        {
            return circleA.Area < circleB.Area;
        }
        /// сравнение площадей
        /// <param name="circleA"></param>
        /// <param name="circleB"></param>
        /// <returns></returns>
        public static bool operator >=(Circle circleA, Circle circleB)
        {
            return circleA.Area >= circleB.Area;
        }

        /// сравнение площадей
        /// <param name="circleA"></param>
        /// <param name="circleB"></param>
        /// <returns></returns>
        public static bool operator <=(Circle circleA, Circle circleB)
        {
            return circleA.Area <= circleB.Area;
        }
        /// сравнение площадей
        /// <param name="circleA"></param>
        /// <param name="circleB"></param>
        /// <returns></returns>
        public static bool operator !=(Circle circleA, Circle circleB)
        {
            return circleA.Area != circleB.Area;
        }
        /// сравнение площадей
        /// <param name="circleA"></param>
        /// <param name="circleB"></param>
        /// <returns></returns>
        public static bool operator ==(Circle circleA, Circle circleB)
        {
            return circleA.Area == circleB.Area;
        }
        /// Сравнение сторон объектов
        /// <param name="obj">Объект Circle</param>
        /// <returns>bool</returns>
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Circle otherObj = (Circle)obj;
                return this.figureSides[0] == otherObj.figureSides[0];
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// Получить название фигуры
        /// <returns>название фигуры string</returns>
        public override string ToString()
        {
            return Type;
        }
    }
    public class Triangle : IFigure
    {
        /// Значение площади фигуры
        private double area;
        /// Значение сторон фигуры
        private double[] figureSides;
        /// Тип фигуры
        public string Type { get; }
        /// Площадь треугольника
        public double Area
        {
            get { return area; }
        }
        /// Стороны фигуры double[]
        public double[] FigureSides
        {
            get { return figureSides; }
            set
            {
                double[] triangleSides = (double[])value.Clone();

                if (triangleSides != figureSides)
                {
                    if (TriangleValidate(triangleSides))
                    {
                        figureSides = triangleSides;
                        area = AreaCalculate(triangleSides);
                    }
                }
            }
        }
        /// Конструктор Triangle
        public Triangle() : this(0, 0, 0) { }
        /// Конструктор Triangle
        /// <param name="radius">значение радиуса double</param>
        public Triangle(double sideA, double sideB, double sideC) : this(new double[] { sideA, sideB, sideC }) { }

        /// Конструктор Triangle
        /// <param name="radius">значение радиуса double[]</param>
        public Triangle(double[] sides)
        {
            FigureSides = sides;
            Type = "triangle";
        }
        /// Установить значения сторон фигуры
        /// <param name="sides">Массив со значением сторон double[]</param>
        public void Set(double[] sides)
        {
            FigureSides = sides;
        }
        /// Установить значения сторон фигуры
        /// <param name="sideA">sideA double</param>
        /// <param name="sideB">sideB double</param>
        /// <param name="sideC">sideC double</param>
        public void Set(double sideA, double sideB, double sideC)
        {
            FigureSides = new double[] { sideA, sideB, sideC };
        }
        /// Вызывает исключение - слишком мало парметров
        /// <param name="side"></param>
        public void Set(double side)
        {
            throw new NotValidateException("Too few parameters for Triangle");
        }
        /// Вызывает исключение для Triangle
        /// <param name="side"></param>
        /// <returns></returns>
        public double UpdateArea(double side)
        {
            throw new NotValidateException("Too few parameters for Triangle");
        }
        /// Обновление значений сторон и возврат значения площади
        /// <param name="side">значения сторон double[]</param>
        /// <returns></returns>
        public double UpdateArea(double[] side)
        {
            FigureSides = side;
            return area;
        }
        /// Обновление значений сторон и возврат значения площади
        /// <param name="sideA">sideA double</param>
        /// <param name="sideB">sideB double</param>
        /// <param name="sideC">sideC double</param>
        /// <returns></returns>
        public double UpdateArea(double sideA, double sideB, double sideC)
        {
            return UpdateArea(new double[] { sideA, sideB, sideC });
        }
        /// Площадь треугольника
        /// <param name="sideA">сторона A double</param>
        /// <param name="sideB">стоорна B double</param>
        /// <param name="sideC">сторона C double</param>
        /// <returns>площадь треугольника double</returns>
        public static double GetArea(double sideA, double sideB, double sideC)
        {
            return GetArea(new double[] { sideA, sideB, sideC });
        }
        /// Площадь треугольника
        /// <param name="sides">стороны треугольника double[]</param>
        /// <returns>площадь треугольника double</returns>
        public static double GetArea(double[] sides)
        {
            double[] triangleSedes = (double[])sides.Clone();

            if (TriangleValidate(triangleSedes))
            {
                return AreaCalculate(triangleSedes);
            }
            else
            {
                return 0;
            }
        }
        public bool Rectangular()
        {
            if (figureSides[2] == Math.Sqrt(Math.Pow(figureSides[0], 2) + Math.Pow(figureSides[1], 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// сравнение площадей
        /// <param name="triangleA"></param>
        /// <param name="triangleB"></param>
        /// <returns></returns>
        public static bool operator >(Triangle triangleA, Triangle triangleB)
        {
            return triangleA.Area > triangleB.Area;
        }
        /// сравнение площадей
        /// <param name="triangleA"></param>
        /// <param name="triangleB"></param>
        /// <returns></returns>
        public static bool operator <(Triangle triangleA, Triangle triangleB)
        {
            return triangleA.Area < triangleB.Area;
        }
        /// сравнение площадей
        /// <param name="triangleA"></param>
        /// <param name="triangleB"></param>
        /// <returns></returns>
        public static bool operator >=(Triangle triangleA, Triangle triangleB)
        {
            return triangleA.Area >= triangleB.Area;
        }
        /// сравнение площадей
        /// <param name="triangleA"></param>
        /// <param name="triangleB"></param>
        /// <returns></returns>
        public static bool operator <=(Triangle triangleA, Triangle triangleB)
        {
            return triangleA.Area <= triangleB.Area;
        }
        /// сравнение площадей
        /// <param name="triangleA"></param>
        /// <param name="triangleB"></param>
        /// <returns></returns>
        public static bool operator !=(Triangle triangleA, Triangle triangleB)
        {
            return triangleA.Area != triangleB.Area;
        }
        /// сравнение площадей
        /// <param name="triangleA"></param>
        /// <param name="triangleB"></param>
        /// <returns></returns>
        public static bool operator ==(Triangle triangleA, Triangle triangleB)
        {
            return triangleA.Area == triangleB.Area;
        }
        /// Сравнение сторон объектов
        /// <param name="obj">объект Triangle</param>
        /// <returns>bool</returns>
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Triangle triangle = (Triangle)obj;

                IStructuralEquatable testThis = this.figureSides;
                double[] testObj = triangle.figureSides;

                return testThis.Equals(testObj, StructuralComparisons.StructuralEqualityComparer);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// Получить название фигуры
        /// <returns>название фигуры string</returns>
        public override string ToString()
        {
            return Type;
        }
        /// Расчет площади треугольника
        /// <param name="sides">список сторон треугольника List of double</param>
        /// <returns>площадь треугольника double</returns>
        private static double AreaCalculate(double[] sides)
        {
            double halfP = Service.arraySum(sides) / 2;
            return Math.Sqrt(halfP * (halfP - sides[0]) * (halfP - sides[1]) * (halfP - sides[2]));
        }
        /// Валидация треугольника. Фигура соответствует треугольнику если (в соответствии с контролем):
        /// - задано сторон не меньше 3
        /// - задано сторон не более 3
        /// - отдельные стороны не равны 0 и не меньше (исключение, если все стороны = 0 - для создания пустого объекта)
        /// - наибольшая сторона не больше суммы двух других
        /// <param name="radius">значение радиуса double</param>
        /// <returns>true - треугольник; исключение - при несоответствии</returns>
        private static bool TriangleValidate(double[] sides)
        {
            double sumOfSides = Service.arraySum(sides);
            Service.arraySort(sides);

            if (sides.Length < 3)
            {
                throw new NotValidateException("Too few parameters for sides");
            }

            if (sides.Length > 3)
            {
                throw new NotValidateException("Too many parameters for sides");
            }

            foreach (var side in sides)
            {
                if (side <= 0 & sumOfSides != 0)
                {
                    throw new NotValidateException("One of the side has bad size (0 or negative)");
                }
            }

            if (sides[2] > sides[1] + sides[0] & sumOfSides != 0)
            {
                throw new NotValidateException("One of the sides too long");
            }

            return true;
        }
    }
}
