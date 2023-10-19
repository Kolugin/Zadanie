using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    internal class FF : IFF
    {
        public IFigure CreateFigure(double radius)
        {
            return new Circle(radius);
        }

        public IFigure CreateFigure(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

        //Новый тип фигуры необходимо указать здесь - перезагрузка с нужными параметрами

        public IFigure CreateFigure(double[] sides)
        {
            switch (sides.Length)
            {
                case 1:
                    {
                        return new Circle(sides);
                    }
                case 3:
                    {
                        return new Triangle(sides);
                    }
                // For new Type
                // Новый тип фигуры необходимо добавить здесь


                // End block for new Type


                // Дефолтно устанвливется фигура Circle. Валидация возлагается на объект
                default:
                    {
                        return new Circle(sides);
                    }
            }
        }

        public override string ToString()
        {
            return "IFigureFactory";
        }
    }
}
