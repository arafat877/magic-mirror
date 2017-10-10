﻿using System;

namespace MagicMirror.Business.Models.Cognitive
{
    public class FaceInfoModel : IModel
    {
        public Guid? PersonId { get; set; }
        public double? Age { get; set; }
        public string Gender { get; set; }
    }
}