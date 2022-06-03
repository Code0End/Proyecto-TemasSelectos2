using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buy_show : MonoBehaviour
{

    public GameObject shoe1;
    public GameObject shoe2;
    public GameObject shoe3;
    public GameObject shoe4;

    public GameObject player;

    public GameObject clone1;
  
    public bool shorts = false;
    public bool shoestwice = false;
    public bool floaty = false;

    bool floaty2;

    public GameObject pos;

    public bool target = false;
    public string url;

    private UnityEngine.Object flo;


    public Texture shirt_mat; 

    private void Start()
    {
        shoe1.SetActive(false);
        flo = Resources.Load("flotadorsim");
        floaty2 = false;
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

    public void updateshorts(bool nu)
    {
        shorts = nu;
    }

    public void updateshoes(bool nu)
    {
        shoestwice = nu;
    }

    public void updatefloaty(bool nu)
    {
        floaty = nu;
    }

    public void Showshoetarget()
    {
        if (shorts == true){
            if(shoe2.active == false)
            {
                shoe2.SetActive(true);
            }
            return;
        }

        if (floaty == true)
        {
            if (floaty2 == false)
            {
                clone1 = (GameObject)Instantiate(flo);
                clone1.transform.position = pos.transform.position;
                floaty2 = true;
            }
            if (floaty2 == true)
            {
                clone1.active = false;
                clone1.transform.position = pos.transform.position;
                clone1.active = true;
            }
            return;
        }

        if (shoestwice == true)
        {
            if (shoe3.active == false)
            {
                shoe3.SetActive(true);
            }
            if (shoe4.active == false)
            {
                shoe4.SetActive(true);
            }
            return;
        }

        if (shoe1.active == false)
        {
            shoe1.SetActive(true);
            shoe1.GetComponentInChildren<SkinnedMeshRenderer>().material.mainTexture = shirt_mat;
        }
        shoe1.GetComponentInChildren<SkinnedMeshRenderer>().material.mainTexture = shirt_mat;
    }

}
