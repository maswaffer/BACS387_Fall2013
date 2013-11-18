using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;
namespace IfPhotoCondition
{
    class AreaCriteria
    {
        // some properties here
        public BoundaryBox Greeley { get; private set; }
        public BoundaryBox Loveland { get; private set; }
        public BoundaryBox FortCollins { get; private set; }
        public BoundaryBox HCMcity { get; private set; }

        // constructor for Area Criteria
        public AreaCriteria()
        {
            Greeley = new BoundaryBox(-104.840312, 40.373445, -104.665904, 40.444029d);
            Loveland = new BoundaryBox(-105.155482, 40.360366, -104.998927, 40.452912);
            FortCollins = new BoundaryBox(-109.062495, 37.017036, -102.064204, 41.014317);
        }
    }
}
