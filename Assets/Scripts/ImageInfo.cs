using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageInfo
{
    public Texture2D texture;
    public DateAndTime dateAndTime;

    public ImageInfo(Texture2D texture, DateAndTime dateAndTime)
    {
        this.texture = texture;
        this.dateAndTime = dateAndTime;
    }
}
