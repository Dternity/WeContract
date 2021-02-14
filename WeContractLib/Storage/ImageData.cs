using System;
using System.Collections.Generic;
using System.Drawing;

namespace WeContractLib.Storage
{
	public class ImageData : IThing
	{
        public ImageData()
        {
            DateCreated = DateTime.Now;
            CID = Guid.NewGuid();
            Images = new Dictionary<string, Image>();
            Controller.ImageManager.Add(this);
        }

        public ImageData(string name) : this()
        {
            Name = name;
        }

        public ImageData(string name, string imageName, Image image) : this()
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
