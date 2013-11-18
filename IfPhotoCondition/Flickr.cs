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
        /// We put the key and secret key here
        /// </summary>
        #region
        // field key and secret are read only
        private readonly string key = "2da36d66a5f11fd563c507848f84ee3e";
        private readonly string secret = "7cb1e013d1374c52";

        // properties here
        public FlickrNet.Flickr Service { get; set; }

        // constructor for Flicrk, once instanciate creating a
        // new service using the key and secret above
        public Flickr()
        {
            // FlickrNet.Flickr method has 4 overloadings 
            // we are using the one that pass key and secret
            Service = new FlickrNet.Flickr(key,secret);
        }

        #endregion

        


         
        

        
    }
}
