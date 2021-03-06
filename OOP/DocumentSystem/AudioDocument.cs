﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AudioDocument : MultimediaDocument
{
    public int? SampleRate { get; protected set; }


    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
        {
            this.SampleRate = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }
}
