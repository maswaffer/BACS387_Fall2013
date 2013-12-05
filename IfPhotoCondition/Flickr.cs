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
            Service = new FlickrNet.Flickr(key, secret);
        }

        // this will be use instead of the GetPhoto method outside
        public IfPhotoCondition.Photo GetPhotosByArea()
        {
            BoundaryBox Greeley = new BoundaryBox(-104.840312, 40.373445, -104.665904, 40.444029d);
            // PhotoSearchOptions is comming FlickrNet
            var options = new PhotoSearchOptions();
            options.BoundaryBox = Greeley;
            // creating a set of photo from Service and get the first one
            var collection = Service.PhotosSearch(options);
            var firstInCollection = collection.First();

            // creating a photo from our own photo class and map data from service photo ---> our Photo class
            var myPhoto = new IfPhotoCondition.Photo();
            myPhoto.PhotoSize = firstInCollection.OriginalWidth;
            myPhoto.ImageLink = firstInCollection.WebUrl;

            // come back there modify tag to a list of string not just a string ASK QUESTION HERE...
            // ToList() is an extension method...
            // Tags is a collection list but photoTag is a list so we need ToList() method
            myPhoto.PhotoTag = firstInCollection.Tags.ToList();
            return myPhoto;
        }

        #endregion

        // will delete this method soon
        public Photo GetPhoto()
        {
            // to get rid of the error
            Photo dummyPhoto = new Photo();
            return dummyPhoto;
        }
    }
}
