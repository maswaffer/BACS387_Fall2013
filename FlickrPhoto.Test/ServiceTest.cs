using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IfPhotoCondition;

namespace FlickrPhoto.Test
{
    [TestClass]
    public class ServiceTest
    {
        private Flickr myService { get; set; }
        
        [TestInitialize]
        public void Setup()
        {
            myService = new Flickr();
            
        }

        [TestMethod]
        public void shouldGetDataPhotoServiceCompareUserSet()
        {
            

            // call get photo by area
            var myPhoto = new Photo();
            myPhoto = myService.GetPhotosByArea();

            // run check
            Assert.IsNotNull(myPhoto);

        }


    }
}
