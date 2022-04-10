using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class inspect : MonoBehaviour
    {
        Vector3 lastpos;
        //public Camera camaraz;
        public bool inspectmode = false;
        // Start is called before the first frame update
        void Start()
        {
            //GameObject.GetComponent<turn>().on=false;
            inspectmode = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (inspectmode == true)
            {
                if (Input.GetMouseButtonDown(0))
                    lastpos = Input.mousePosition;

                if (Input.GetMouseButton(0))
                {

                    var delta = Input.mousePosition - lastpos;
                    lastpos = Input.mousePosition;

                    var axis = Quaternion.AngleAxis(-90f, Vector3.forward) * delta;
                    transform.rotation = Quaternion.AngleAxis(delta.magnitude * 1.0f, axis) * transform.rotation;

                }
            }
        }
    }

