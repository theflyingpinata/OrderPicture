using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class LoadImages
{
    // Returns an array of ImageInfo that have the texture and date info of all the images in a folder
    public static ImageInfo[] Load(string path)
    {
        Object[] textures = Resources.LoadAll(path, typeof(Texture2D));
        Debug.Log("textures.Length = " + textures.Length);
        ImageInfo[] imageInfos = new ImageInfo[textures.Length];
        for (int i = 0; i < textures.Length; i++)
        {
            Debug.Log("Loading " + i);
            imageInfos[i] = new ImageInfo((Texture2D)textures[i], StringToDateAndTime(textures[i].name));
        }
        return imageInfos;
    }

    // TODO add more sanitizing
    // Converts a string into DateAndTime, and returns it
    public static DateAndTime StringToDateAndTime(string stringdt)
    {
        string[] parts = stringdt.Split('.')[0].Split('_');

        if (parts.Length == 5)
        {
            DateAndTime value = new DateAndTime(int.Parse(parts[0]),
                                                int.Parse(parts[1]),
                                                int.Parse(parts[2]),
                                                int.Parse(parts[3]),
                                                int.Parse(parts[4]));

            return value;
        }

        return null;
    }
}
