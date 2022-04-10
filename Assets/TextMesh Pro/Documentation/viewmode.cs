using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Invector.vCharacterController
{


    public class viewmode : MonoBehaviour
    {
        public GameObject p;
        public vThirdPersonInput script;
        public int stand;
        // Start is called before the first frame update
        void Start()
        {
            //script = p.GetComponent<vThirdPersonInput>();

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                script = other.GetComponent<vThirdPersonInput>();
                script.close = true;
                script.lu = stand;
                  

            }
        }

        void OnTriggerExit(Collider other)
        {
            script.close = false;
        }

    }
}
