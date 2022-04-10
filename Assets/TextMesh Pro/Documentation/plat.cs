using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class plat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isMobile() == false)
        {
            gameObject.SetActive(false);
        }
    }

    [DllImport("__Internal")]
    private static extern bool IsMobile();

    public bool isMobile()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
         return IsMobile();
#endif
        return false;
    }


}
