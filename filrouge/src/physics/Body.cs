using FilRouge.src.shape;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilRouge.src.physics
{
    public class Body
    {
        public Body(Shape shape, Point position, float density, float restitution)
        {
            this.shape = shape;
            this.position = position;

        }

        private Shape shape { get; set; }
        private Point position { get; set; }
        private Material material { get; set; }
        private MassData mass_data { get; set; }
        private Point velocity { get; set; }
        private Point force { get; set; }

    }

    struct MassData
    {
        readonly float mass;
        readonly float inv_mass;
    }

    struct Material
    {
        readonly float density;
        readonly float restitution;
    };
}
