using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Invector.vCharacterController
{


    public class viewmode : MonoBehaviour
    {
        public GameObject p;
        public vThirdPersonInput script;
        public int stand;
        public Button but;
        public Camera cam;

        public char name;
        public float cost;
        public Texture design;
        public Sprite titulo;
        public Sprite descripcion;
        public Sprite playera1;
        public Sprite playera2;
        public string url;
        public bool u;

        


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                script = other.GetComponent<vThirdPersonInput>();
                script.close = true;
                script.lu = stand;
                script.updatecam(cam);
                script.updatestand(titulo, descripcion, playera1, playera2);
                script.updateurl(url,design);
                if (u == true)
                {
                    script.lnk = true;
                }
            }
        }

        void OnTriggerExit(Collider other)
        {
            script.close = false;
            script.lnk = false;
        }

    }
}
