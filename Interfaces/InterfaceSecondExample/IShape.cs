﻿namespace InterfaceSecondExample
{
    public interface IShape
    {
        void DrawMe();
    }

    public interface ISuperShape : IShape
    {
        void Draw3D();
    }
}