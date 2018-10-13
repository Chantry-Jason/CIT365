using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Jason_Chantry
{
    class Desk
    {
        private string name;
        private double width;
        private double depth;
        private int numDrawers;
        public enum SurfaceMaterial {
            
            Laminate = 1,
            Oak = 2,
            Rosewood = 3,
            Veneer = 4,
            Pine = 5
        };
        //Set up rush order array list
        ArrayList rushOrder = new ArrayList()
        {
            "14 days (Normal Delivery)",
            "7 Days",
            "5 Days",
            "3 Days"
        };
        private SurfaceMaterial surfaceMaterial;

        //Desk Constructor
        public Desk()
        {

        }
        //Rush Order array list property
        public ArrayList RushOrder
        {
            get { return rushOrder; }
        }
        //name property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //width property
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        //depth property
        public double Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }
        //Number of Drawers property
        public int NumDrawers
        {
            get { return this.numDrawers; }
            set { this.numDrawers = value; }
        }
       public SurfaceMaterial GetSurfaceMaterial()
        {
            
            return this.surfaceMaterial;
        }
        

    }
}
