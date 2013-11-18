using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;
// using Flickr .NET HERE...
namespace IfPhotoCondition
{
    public class Flickr
    {

        ///<summary>
        /// Adding some Code using Flickr API
        /// here
        /// </summary>
        #region
        // do something in here


        #endregion

        // properties here
        public FlickrNet.Flickr Service {get;set;}


         
        // there will be a constructor for flickr here...
        public Flickr()
        {
            Service = new FlickrNet.Flickr();
        }

        // go to flickr API get the photo value
        public Photo GetPhoto()
        {
            throw new NotImplementedException();
        }
    }
}
