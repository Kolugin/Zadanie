using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class IFF
    {
        IFigure CreateFigure(double radius);

        IFigure CreateFigure(double[] sides);

        IFigure CreateFigure(double sideA, double sideB, double sideC);

        //В случае добавления нового типа фигур, необходимо добавить перегрузку метода здесь
    }
}
