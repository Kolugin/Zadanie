using System;

namespace Library1
{
    public interface IFigure
    {
        double Area { get; }

        string Type { get; }

        double[] FigureSides { get; set; }

        void Set(double[] sides);

        void Set(double side);

        void Set(double sideA, double sideB, double sideC);

        double UpdateArea(double[] sides);

        double UpdateArea(double side);

        double UpdateArea(double sideA, double sideB, double sideC);

        bool Rectangular();

        bool Equals(Object obj);
    }
}