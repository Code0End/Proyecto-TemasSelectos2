using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices;

namespace Invector.vCharacterController
{
    public class vThirdPersonInput : MonoBehaviour
    {
        float clicked = 0;
        float clicktime = 0;
        float clickdelay = 0.5f;

        bool DoubleClick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                clicked++;
                if (clicked == 1) clicktime = Time.time;
            }
            if (clicked > 1 && Time.time - clicktime < clickdelay)
            {
                clicked = 0;
                clicktime = 0;
                return true;
            }
            else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
            return false;
        }





        #region Variables       

        [Header("Controller Input")]
        public string horizontalInput = "Horizontal";
        public string verticallInput = "Vertical";
        public KeyCode jumpInput = KeyCode.Space;
        public KeyCode strafeInput = KeyCode.Tab;
        public KeyCode sprintInput = KeyCode.LeftShift;
        public KeyCode interactInput = KeyCode.E;
        public KeyCode mouseclick = KeyCode.Mouse0;
        public bool close = false;
        public Camera camera1;
        public bool lnk = false;
        public string url;
        public Camera currcam;
        public Joystick joy;
        Camera activecam;
        public GameObject shoe;
        public GameObject shoe22;
        public GameObject shoe33;
        public GameObject shoe44;
        public GameObject shoe55;
        public GameObject shoe66;
        public turn script;
        public inspect script2;
        public turn script3;
        public inspect script4;
        public turn script5;
        public inspect script6;
        public turn script7;
        public inspect script8;
        public turn script9;
        public inspect script10;
        public turn script11;
        public inspect script12;

        string selectableTag = "shoeable";
        bool m = true;
        bool s = true;
        bool shorts = false;
        bool shos = false;
        bool flots = false;
        GameObject[] s_l;

        GameObject b_buy;

        public int lu = 0;
        public bool shirton = false;

        public buy_show botonurl;
        public buy_show botonurl2;
        public image_holder camiseta_show;

        public Texture design;

        public GameObject shoe1;
        public GameObject shoe2;
        public GameObject[] shoes;


        [Header("Camera Input")]
        public string rotateCameraXInput = "Mouse X";
        public string rotateCameraYInput = "Mouse Y";

        [HideInInspector] public vThirdPersonController cc;
        [HideInInspector] public vThirdPersonCamera tpCamera;
        [HideInInspector] public Camera cameraMain;

        #endregion

        protected virtual void Start()
        {
            InitilizeController();
            InitializeTpCamera();
            camera1.gameObject.SetActive(true);
            script = shoe.GetComponent<turn>();
            script2 = shoe.GetComponent<inspect>();
            script3 = shoe22.GetComponent<turn>();
            script4 = shoe22.GetComponent<inspect>();
            script5 = shoe33.GetComponent<turn>();
            script6 = shoe33.GetComponent<inspect>();
            script7 = shoe44.GetComponent<turn>();
            script8 = shoe44.GetComponent<inspect>();
            script9 = shoe55.GetComponent<turn>();
            script10 = shoe55.GetComponent<inspect>();
            script11 = shoe66.GetComponent<turn>();
            script12 = shoe66.GetComponent<inspect>();
            activecam = camera1;
            
            turnoffui();
                                          
            if (isMobile() == false)
            {
                m = false;
            }
        }

        protected virtual void FixedUpdate()
        {
            cc.UpdateMotor();               // updates the ThirdPersonMotor methods
            cc.ControlLocomotionType();     // handle the controller locomotion type and movespeed
            cc.ControlRotationType();       // handle the controller rotation type
        }

        protected virtual void Update()
        {
            InputHandle();                  // update the input methods
            cc.UpdateAnimator();

        }

        public virtual void OnAnimatorMove()
        {
            cc.ControlAnimatorRootMotion(); // handle root motion animations 
        }

        #region Basic Locomotion Inputs

        protected virtual void InitilizeController()
        {
            cc = GetComponent<vThirdPersonController>();

            if (cc != null)
                cc.Init();
        }

        protected virtual void InitializeTpCamera()
        {
            if (tpCamera == null)
            {
                tpCamera = FindObjectOfType<vThirdPersonCamera>();
                if (tpCamera == null)
                    return;
                if (tpCamera)
                {
                    tpCamera.SetMainTarget(this.transform);
                    tpCamera.Init();
                }
            }
        }

        protected virtual void InputHandle()
        {
            MoveInput();
            CameraInput();
            SprintInput();
            StrafeInput();
            JumpInput();
            InteractInput();
            mouseclick2();
        }

        public virtual void MoveInput()
        {
            if (s == true)
            {
                if (m == false)
                {
                    cc.input.x = Input.GetAxis(horizontalInput);
                    cc.input.z = Input.GetAxis(verticallInput);
                }
                else
                {
                    cc.input.x = joy.Horizontal;
                    cc.input.z = joy.Vertical;
                }
            }
            else
            {
                cc.input.x = Input.GetAxis(horizontalInput) - Input.GetAxis(horizontalInput);
                cc.input.z = Input.GetAxis(verticallInput) - Input.GetAxis(verticallInput);
                cc.input.x = joy.Horizontal - joy.Horizontal;
                cc.input.z = joy.Vertical - joy.Vertical;
            }
        }

        public virtual void InteractInput()
        {
            if (Input.GetKeyDown(interactInput))
            {
                if (close == true) {
                    if (lnk != true)
                    {
                        if (camera1.gameObject.active)
                        {
                            s = false;
                            camera1.gameObject.SetActive(false);
                            currcam.gameObject.SetActive(true);
                            turnonui();
                        }
                        else
                        {
                            camera1.gameObject.SetActive(true);
                            currcam.gameObject.SetActive(false);
                            s = true;
                            turnoffui();
                        }
                    
                    if (script.on == true)
                    {
                        script.on = false;
                        script2.inspectmode = true;
                        script3.on = false;
                        script4.inspectmode = true;
                        script5.on = false;
                        script6.inspectmode = true;
                        script7.on = false;
                        script8.inspectmode = true;
                        script9.on = false;
                        script10.inspectmode = true;
                        script11.on = false;
                        script12.inspectmode = true;

                        }
                    else
                    {
                        script.on = true;
                        script2.inspectmode = false;
                        script.reset = true;
                        script4.inspectmode = false;
                        script3.reset = true;
                        script3.on = true;
                        script6.inspectmode = false;
                        script5.reset = true;
                        script5.on = true;
                        script8.inspectmode = false;
                        script7.reset = true;
                        script7.on = true;
                        script10.inspectmode = false;
                        script9.reset = true;
                        script9.on = true;
                        script12.inspectmode = false;
                        script11.reset = true;
                        script11.on = true;
                        }
                    }
                    else
                    {
                        Application.OpenURL(url);
                    }
                }
            }
        }

        protected virtual void mouseclick2()
        {
            if (DoubleClick() == true)
            {
                if (close == true)
                {
                    RaycastHit hit;
                    var ray = activecam.ScreenPointToRay(Input.mousePosition);

                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform != null)
                        {
                            var selection = hit.transform;
                            if (selection.CompareTag(selectableTag)) {
                                if (lnk != true)
                                {
                                    if (camera1.gameObject.active)
                                    {
                                        activecam = currcam;
                                        s = false;
                                        camera1.gameObject.SetActive(false);
                                        currcam.gameObject.SetActive(true);
                                        turnonui();
                                    }

                                    else
                                    {
                                        camera1.gameObject.SetActive(true);
                                        currcam.gameObject.SetActive(false);
                                        activecam = camera1;
                                        s = true;
                                        turnoffui();
                                    }
                                                                                                           
                                    if (script.on == true)
                                    {
                                        script.on = false;
                                        script2.inspectmode = true;
                                        script3.on = false;
                                        script4.inspectmode = true;
                                        script5.on = false;
                                        script6.inspectmode = true;
                                        script7.on = false;
                                        script8.inspectmode = true;
                                        script9.on = false;
                                        script10.inspectmode = true;

                                    }
                                    else
                                    {
                                        script.on = true;
                                        script2.inspectmode = false;
                                        script.reset = true;
                                        script4.inspectmode = false;
                                        script3.reset = true;
                                        script3.on = true;
                                        script6.inspectmode = false;
                                        script5.reset = true;
                                        script5.on = true;
                                        script8.inspectmode = false;
                                        script7.reset = true;
                                        script7.on = true;
                                        script10.inspectmode = false;
                                        script9.reset = true;
                                        script9.on = true;

                                    }
                                }
                                else
                                {
                                    Application.OpenURL(url);
                                }
                                }
                        }
                    }
                }
            }
        }

        protected virtual void CameraInput()
        {
            if (!cameraMain)
            {
                if (!Camera.main) Debug.Log("Missing a Camera with the tag MainCamera, please add one.");
                else
                {
                    cameraMain = Camera.main;
                    cc.rotateTarget = cameraMain.transform;
                }
            }

            if (cameraMain)
            {
                cc.UpdateMoveDirection(cameraMain.transform);
            }

            if (tpCamera == null)
                return;

            var Y = Input.GetAxis(rotateCameraYInput);
            var X = Input.GetAxis(rotateCameraXInput);

            tpCamera.RotateCamera(X, Y);
        }

        protected virtual void StrafeInput()
        {
            if (Input.GetKeyDown(strafeInput))
                cc.Strafe();
        }

        protected virtual void SprintInput()
        {
            if (Input.GetKeyDown(sprintInput))
                cc.Sprint(true);
            else if (Input.GetKeyUp(sprintInput))
                cc.Sprint(false);
        }

        protected virtual bool JumpConditions()
        {
            return cc.isGrounded && cc.GroundAngle() < cc.slopeLimit && !cc.isJumping && !cc.stopMove;
        }

        protected virtual void JumpInput()
        {
            if (Input.GetKeyDown(jumpInput) && JumpConditions())
                cc.Jump();
        }

        public void updatecam(Camera nc){
            currcam = nc;
        }
        public void updatestand(Sprite titulo,Sprite descripcion,Sprite playera1,Sprite playera2)
        {
            camiseta_show.setsprites(titulo,descripcion,playera1,playera2);
        }
        public void updateurl(string nc, Texture design2)
        {
            design = design2;
            url = nc;
            botonurl.updateurl(url,design);
            botonurl2.updateurl(url, design);
        }

        public void updateshortss(bool nc)
        {
            shorts = nc;
            botonurl2.updateshorts(shorts);
        }

        public void updateshoess(bool nc)
        {
            shos = nc;
            botonurl2.updateshoes(shos);
        }

        public void updatefloatys(bool nc)
        {
            flots = nc;
            botonurl2.updatefloaty(flots);
        }

        public void turnoffui()
        {
            s_l = GameObject.FindGameObjectsWithTag("b_buy");

            foreach (GameObject shoe in s_l)
            {
                b_buy = shoe;
                b_buy.SetActive(false);
            }
        }

        public void turnonui()
        {
            foreach (GameObject shoe in s_l)
            {
                b_buy = shoe;
                b_buy.SetActive(true);
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


        #endregion       
    }
}