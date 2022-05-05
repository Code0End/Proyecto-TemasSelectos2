using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buy_show : MonoBehaviour
{

    public GameObject shoe1;
    public GameObject shoe2;
    
    public GameObject player;
  

    public bool target = false;
    public string url;
   

    public Texture shirt_mat; 

    private void Start()
    {
        shoe1.SetActive(false);
        
    }

    public void gopage()
    {
        Application.OpenURL(url); 
    }

    public void updateurl(string nu, Texture nm)
    {
        url = nu;
        shirt_mat = nm;
    }
    

    public void Showshoetarget()
    {
        if (shoe1.active == false)
        {
            shoe1.SetActive(true);
            shoe1.GetComponentInChildren<SkinnedMeshRenderer>().material.mainTexture = shirt_mat;
        }
        shoe1.GetComponentInChildren<SkinnedMeshRenderer>().material.mainTexture = shirt_mat;
    }

}
