using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videop : MonoBehaviour
{
    public VideoPlayer vp;
    public string vid = "";
    void Start()
    {
        vp.url = System.IO.Path.Combine(Application.streamingAssetsPath, vid);
        vp.Play();
    }


    
}
