using LiteDB;
using WeContractLib;

namespace WeContract.Helpers
{

    public static class ImageManager
    {
        private static ImageAtlas _atlas;

        public static void Initialize()
        {
            _atlas = new ImageAtlas();
            Inst = _atlas;
        }


        public static ImageAtlas Inst ;
    }
    public class ImageAtlas : Atlas<ImageInfo>
    {
        public ImageAtlas() : base("Image")
        {
            
        }

        protected override bool AddToDbAfterInserted(LiteCollection<ImageInfo> col, ImageInfo entity)
        {
            return true;
        }

        protected override bool AddToDbPreCheck(ImageInfo entity)
        {
            return true;
        }
    }
}
