﻿using Kentico.Kontent.Management.Models.Shared;
using Newtonsoft.Json;

namespace Kentico.Kontent.Management.Models.Assets.Patch
{
    public abstract class AssetFolderOperationBaseModel
    {
        [JsonProperty("op", Required = Required.Always)]
        public abstract string Op { get; }

        [JsonProperty("reference", Required = Required.Always)]
        public Reference Reference { get; set; }

    }
}
