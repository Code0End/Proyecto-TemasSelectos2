using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class image_holder : MonoBehaviour
{
    public Sprite img1;
    public Sprite img2;
    public Sprite img3;
    public Sprite img4;
    public Image img5;
    public Image img6;
    public Image img7;
    public bool img_pointer = true;
    public int p=0;

    public void changeimg()
    {
            if (img_pointer == true)
            {
                img5.sprite = img2;
                img_pointer = false;
            }
            else
            {
                img5.sprite = img1;
                img_pointer = true;
            }
    }

    public void setsprites(Sprite uno, Sprite dos, Sprite tres, Sprite cuatro)
    {
        img1 = tres;
        img2 = cuatro;
        img3 = uno;
        img4 = dos;
        img_pointer = true;
        updatesprites();
    }

    public void updatesprites()
    {
        img5.sprite = img1;
        img6.sprite = img3;
        img7.sprite = img4;
    }
 



}
