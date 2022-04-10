using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buy_show : MonoBehaviour
{

    public GameObject shoe1;
    public GameObject shoe2;
    public GameObject[] shoes;
    public GameObject[] shoes2;

    private void Start()
    {

     


    }

    public void Showshoe()
    {
        shoes = GameObject.FindGameObjectsWithTag("w_shoe");
        shoes2 = GameObject.FindGameObjectsWithTag("w2_show");

        foreach (GameObject shoe in shoes)
        {

            shoe1 = shoe;
            
        }
        foreach (GameObject shoe in shoes2)
        {

            shoe2 = shoe;
         
        }

        shoe1.SetActive(true);
       
     
        shoe2.SetActive(true);
     

    }

    

}
