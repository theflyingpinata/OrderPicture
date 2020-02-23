using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoading : MonoBehaviour
{
    ImageInfo[] testimages;

    // Start is called before the first frame update
    void Start()
    {
        testimages = LoadImages.Load("TestImages");

        foreach(ImageInfo ii in testimages)
        {
            Debug.Log(ii.dateAndTime);
        }

        Debug.Log("done");
    }
}
