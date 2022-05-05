using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videop : MonoBehaviour
{
    public VideoPlayer vp;
    void Start()
    {
        vp.url = System.IO.Path.Combine(Application.streamingAssetsPath, "from_trash.mp4");
        vp.Play();
    }


    void Update()
    {
        
    }
}
