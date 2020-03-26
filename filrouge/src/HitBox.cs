using System;
using System.Collections.Generic;
using System.Text;

namespace FilRouge.src
{
    /**
     * <summary>Class <c>HitBox</c>
     * Represente la HitBox d'un objet (Entity).
     * Celui peut en avoir une ou plusieurs selon les moments
     * </summary>
     * 
    */
    class HitBox
    {
        ///<value>Property <c>Forme</c>: Represente la forme de 
        ///la hitbox</value>
        private Forme forme
        {
            get; set;
        }


        /**
         * <summary>Methode <c>detectCollision</c>
         * This method uses <a href="http://www.dyn4j.org/2010/01/sat">SAT</a> 
         * </summary>
        */
        public bool detectCollision(HitBox other)
        {
            List<Point> projectionAxes1 = this.forme.getNormalVertices();
            List<Point> projectionAxes2 = other.forme.getNormalVertices();

            for (int i = 0; i < projectionAxes1.Count; i++)
            {
                float[] p1 = this.forme.projection(projectionAxes1[i]);
                float[] p2 = other.forme.projection(projectionAxes1[i]);
                if (!Overlap(p1, p2))
                {
                    return false;
                }
            }

            for (int i = 0; i < projectionAxes2.Count; i++)
            {
                float[] p1 = this.forme.projection(projectionAxes2[i]);
                float[] p2 = other.forme.projection(projectionAxes2[i]);
                if (!Overlap(p1, p2))
                {
                    return false;
                }
            }
            return true;    
        }


        /**
         * <summary>Methode verifiant si deux projections 
         * se superposent ou non.</summary>
         * 
         */
        public static bool Overlap(float[] p1, float[] p2)
        {
            if ((p2[0] < p1[1] && p2[0] > p1[0]) || (p2[1] < p1[1] && p2[1] > p1[0]))
                return true;
            return false;
        }
    }



}
