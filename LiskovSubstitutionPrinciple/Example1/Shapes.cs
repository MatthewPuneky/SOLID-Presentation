using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Example1
{
    public class Rectangle
    {
        protected int _width;
        protected int _height;

        public int Width => _width;
        public int Height => _height;

        public virtual void SetWidth(int width) => _width = width;
        public virtual void SetHeight(int height) => _height = height;

        public object GetArea => _width * _height;
    }

    public class Square : Rectangle
    {
        public override void SetWidth(int width)
        {
            base.SetWidth(width);
            _height = width;
        }
        public override void SetHeight(int height)
        {
            base.SetHeight(height);
            _width = height;
        }
    }
}
