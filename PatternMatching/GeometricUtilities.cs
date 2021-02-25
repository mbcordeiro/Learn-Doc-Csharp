using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching
{
    class GeometricUtilities
    {
        public static double ComputeArea(object shape)
        {
            if (shape is Square)
            {
                var s = (Square)shape;
                return s.Side * s.Side;
            }
            else if (shape is Circle)
            {
                var c = (Circle)shape;
                return c.Radius * c.Radius * Math.PI;
            }
            // elided
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
        }

        public static double ComputeAreaModernIs(object shape)
        {
            if (shape is Square s)
                return s.Side * s.Side;
            else if (shape is Circle c)
                return c.Radius * c.Radius * Math.PI;
            else if (shape is Rectangle r)
                return r.Height * r.Length;
            // elided
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
        }

        public static string GenerateMessage(params string[] parts)
        {
            switch (parts.Length)
            {
                case 0:
                    return "No elements to the input";
                case 1:
                    return $"One element: {parts[0]}";
                case 2:
                    return $"Two elements: {parts[0]}, {parts[1]}";
                default:
                    return $"Many elements. Too many to write";
            }
        }

        public static double ComputeAreaModernSwitch(object shape)
        {
            switch (shape)
            {
                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                case Rectangle r:
                    return r.Height * r.Length;
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
        }

        public static double ComputeArea_Version3(object shape)
        {
            switch (shape)
            {
                case Square s when s.Side == 0:
                case Circle c when c.Radius == 0:
                    return 0;

                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
        }
    }
}
