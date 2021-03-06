﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOMNI.SDK.Public.Models.Catalog
{
    public class CategoryTreeItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public List<Metadata> CategoryMetadata { get; set; }
        public List<ImageAsset> ImageAssets { get; set; }
        public List<Asset> DocumentAssets { get; set; }
        public List<Asset> VideoAssets { get; set; }
        public List<CategoryTreeItem> CategoryTreeItems { get; set; }
    }
}
