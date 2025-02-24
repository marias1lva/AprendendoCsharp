﻿using AreaDasFiguras2.Model.Enums;
namespace AreaDasFiguras2.Model.Entities {
    abstract class AbstractShape : IShape{
        public Color Color { get; set; }

        public abstract double Area();
    }
}
