using LiteDB;

namespace WeContractLib.Storage
{
	public class ImageManager : Atlas<ImageData>
    {
        public ImageManager() : base("Image")
        {
        }

        protected override bool AddToDbAfterInserted(LiteCollection<ImageData> col, ImageData entity)
        {
            return true;
        }

        protected override bool AddToDbPreCheck(ImageData entity)
        {
            return true;
        }
    }
}
