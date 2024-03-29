﻿using System;

namespace WeContractLib
{
    public  interface IThing
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid CID { get; set; }
        public DateTime DateCreated { get; set; }
        public abstract bool AttachEntity(IThing entity);
        public abstract bool DeattachEntity(IThing entity);
    }
}