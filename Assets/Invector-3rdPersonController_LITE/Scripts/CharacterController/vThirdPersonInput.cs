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
        public Camera camera2;
        public Camera camera3;
        public Joystick joy;
        Camera activecam;
        public GameObject shoe;
        public GameObject shoe22;
        public turn script;
        public inspect script2;
        public turn script3;
        public inspect script4;
        string selectableTag = "shoeable";
        bool m = true;
        bool s = true;
        GameObject[] s_l;
        GameObject b_buy;
        public int lu = 0;

        public GameObject shoe1;
        public GameObject shoe2;
        public GameObject[] shoes;
        public GameObject[] shoes2;

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
            camera2.gameObject.SetActive(false);
            camera3.gameObject.SetActive(false);
            script = shoe.GetComponent<turn>();
            script2 = shoe.GetComponent<inspect>();
            script3 = shoe22.GetComponent<turn>();
            script4 = shoe22.GetComponent<inspect>();
            activecam = camera1;
            s_l = GameObject.FindGameObjectsWithTag("b_buy");

            foreach (GameObject shoe in s_l) {
                b_buy = shoe;
            }
            b_buy.SetActive(false);




            if (isMobile() == false)
            {
                m = false; ;
            }

            shoes = GameObject.FindGameObjectsWithTag("w_shoe");
            shoes2 = GameObject.FindGameObjectsWithTag("w2_show");
            foreach (GameObject shoe in shoes)
            {

                shoe1 = shoe;
                shoe.SetActive(false);
            }
            foreach (GameObject shoe in shoes2)
            {

                shoe2 = shoe;
                shoe.SetActive(false);
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
                cc.input.x = Input.GetAxis(horizontalInput)- Input.GetAxis(horizontalInput);
                cc.input.z = Input.GetAxis(verticallInput)- Input.GetAxis(verticallInput);
                cc.input.x = joy.Horizontal- joy.Horizontal;
                cc.input.z = joy.Vertical- joy.Vertical;
            }
        }

        public virtual void InteractInput()
        {
            if (Input.GetKeyDown(interactInput))
            {
                if (close == true) {
                    if (camera1.gameObject.active)
                    {
                        s = false;
                        camera1.gameObject.SetActive(false);
                        if (lu == 1)
                        {
                            camera2.gameObject.SetActive(true);
                            b_buy.SetActive(true);
                        }
                        if(lu == 2)
                        {
                            camera3.gameObject.SetActive(true);
                        }
                        ;
                    }
                    else
                    {
                        camera1.gameObject.SetActive(true);
                        camera2.gameObject.SetActive(false);
                        camera3.gameObject.SetActive(false);
                        s = true;
                        b_buy.SetActive(false);
                    }
                    //Debug.Log("Chingue su madre el pechugas");


                    if (script.on == true)
                    {
                        script.on = false;
                        script2.inspectmode = true;
                        script3.on = false;
                        script4.inspectmode = true;

                    }
                    else
                    {
                        script.on = true;
                        script2.inspectmode = false;
                        script.reset = true;
                        script4.inspectmode = false;
                        script3.reset = true;
                        script3.on = true;


                    }
                }
            }
                //Debug.Log("Chingue su madre el pechugas");
        }

        protected virtual void mouseclick2()
        {
            if (DoubleClick()==true)
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
                                if (camera1.gameObject.active)
                                {
                                    camera1.gameObject.SetActive(false);
                                    s = false;
                                    if (lu == 1)
                                    {
                                        camera2.gameObject.SetActive(true);
                                        activecam = camera2;
                                        b_buy.SetActive(true);
                                    }
                                    if (lu == 2)
                                    {
                                        camera3.gameObject.SetActive(true);
                                        activecam = camera3;
                                    } 
                                }

                                else
                                {
                                    camera1.gameObject.SetActive(true);
                                    camera2.gameObject.SetActive(false);
                                    camera3.gameObject.SetActive(false);
                                    activecam = camera1;
                                    s = true;
                                    b_buy.SetActive(false);
                                }
                                //Debug.Log("Chingue su madre el pechugas");


                                if (script.on == true)
                                {
                                    script.on = false;
                                    script2.inspectmode = true;
                                    script3.on = false;
                                    script4.inspectmode = true;

                                }
                                else
                                {
                                    script.on = true;
                                    script2.inspectmode = false;
                                    script.reset = true;
                                    script4.inspectmode = false;
                                    script3.reset = true;
                                    script3.on = true;


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

        /// <summary>
        /// Conditions to trigger the Jump animation & behavior
        /// </summary>
        /// <returns></returns>
        protected virtual bool JumpConditions()
        {
            return cc.isGrounded && cc.GroundAngle() < cc.slopeLimit && !cc.isJumping && !cc.stopMove;
        }

        /// <summary>
        /// Input to trigger the Jump 
        /// </summary>
        protected virtual void JumpInput()
        {
            if (Input.GetKeyDown(jumpInput) && JumpConditions())
                cc.Jump();
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