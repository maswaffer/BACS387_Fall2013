using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IfPhotoCondition;
namespace FlickrPhoto.Test
{
    [TestClass]
    public class SizeTooBigTest
    {
        private SizeTooBig criteria { get; set; }

        [TestInitialize]
        public void Setup()
        {
            criteria = new SizeTooBig();
        }

        [TestMethod]
        public void ShouldBeMetIfPhotoSizeWidthGreaterThanUserSet()
        {
            // user set this criteria width of photo can not exceed 1400pixel
            criteria.MaxSize = 1400;

            // set data for the fake photo to test
            var photo = new Photo{ PhotoSize = 1500};

            // now run the Check method from SizeTooBig it should return true because
            // photoSize is greater than user set MaxSize
            var isMet = criteria.Check(photo);
            Assert.IsTrue(isMet);  
        }

        [TestMethod]
        public void ShouldNotMetPhotoSizeLessThenMaxSize()
        {
            // user set this criteria width of photo can not exceed 1400pixel
            criteria.MaxSize = 900;

            // set data for the fake photo to test
            var photo = new Photo { PhotoSize = 700 };

            // now run the Check method from SizeTooBig it should return FALSE because
            // photoSize is LESS than user set MaxSize
            var isMet = criteria.Check(photo);
            Assert.IsFalse(isMet);
        }

    }
}
