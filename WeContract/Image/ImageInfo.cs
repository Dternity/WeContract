using System;
using System.Collections.Generic;
using System.Drawing;
using WeContractLib;

namespace WeContract.Helpers
{
    public class ImageInfo : IThing
    {

        public ImageInfo()
        {
            DateCreated = DateTime.Now;
            CID = Guid.NewGuid();
            Images = new Dictionary<string, Image>();
            ImageManager.Inst.Add(this);
        }

        public ImageInfo(string name) : this()
        {
            Name = name;
        }

        public ImageInfo(string name,string imageName , Image image) : this()
        {
            Name = name;
            Images.Add(imageName, image);
        }

        public int ID { get; set; }
        public Guid CID { get; set; }

        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public Dictionary<string, Image> Images;

        public bool AttachEntity(IThing entity)
        {
            return true;
        }

        public bool DeattachEntity(IThing entity)
        {
            return true;
        }
    }
}
