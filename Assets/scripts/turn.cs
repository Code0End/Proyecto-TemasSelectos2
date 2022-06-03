using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class turn : MonoBehaviour
{
    public bool on = true;
    public bool reset = false;
    public bool high = false;
    float speed = 100.0f;
    public AnimationCurve lacurvo;

    void Start()
    {

    }

    void Update()
    {
        if(high == true)
        {
            if (on == true)
            {
                transform.Rotate(Vector3.up * speed * Time.deltaTime);
                transform.position = new Vector3(transform.position.x*3, lacurvo.Evaluate((Time.time)), transform.position.z);
            }
            if (reset == true)
            {
                transform.rotation = Quaternion.identity;
                reset = false;
            }
        }
        if (on == true)
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, lacurvo.Evaluate((Time.time)), transform.position.z);
        }
        if (reset == true)
        {
            transform.rotation = Quaternion.identity;
            reset = false;
        }
    }
}
