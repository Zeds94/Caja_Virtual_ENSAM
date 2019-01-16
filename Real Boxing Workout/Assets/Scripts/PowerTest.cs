using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerTest : MonoBehaviour {

    public float VelMag = 0f, VelMaxMag = 0f, AccMag = 0f, AccMaxMag =0f;
    float TimePrec, TimePos;
    public Vector3 Pos, Vel, VelMax, VelPrec, Acc, AccMax;
    public Text _vel, _acc, _velmax, _accmax, _velmag, _accmag,  _velmaxmag, _accmaxmag;
    private Vector3 PosPrec;
    public GameObject DebogCanvas;
    public bool _canvasactive = false;

    // SteamVR_TrackedObject TrackerDroite;
    //SteamVR_Controller.Device Device = SteamVR_Controller.Input(7);

    void Start ()
    {
        GameObject _canvas = gameObject.GetComponent<GameObject>();
        PosPrec = this.gameObject.transform.position;
        //SteamVR_Controller.Device Device = SteamVR_Controller.Input((int)TrackerDroite.index);
        
    }
	
	void FixedUpdate ()
    {
        /* if (PowerBar._true)
         {
             _veloc =  rb.velocity.sqrMagnitude;
             _veloctest.text = "Velocity " + _veloc;
         }*/
        //vitesse = SteamVR_Controller.Input(7).velocity.magnitude;
        //vitesse = this.gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (_canvasactive == false)
            {
                DebogCanvas.SetActive(true);
                _canvasactive = true;
            }
                
            else if (_canvasactive == true)
            {
                DebogCanvas.SetActive(false);
                _canvasactive = false;
            }
        }
            

        Pos = this.gameObject.transform.position;
        Vel = (Pos - PosPrec)/Time.deltaTime;
        Acc = (Vel - VelPrec) /Time.deltaTime;
        VelMag = Vel.magnitude;
        AccMag = Acc.magnitude;

       // _vel.text = "V:" + Vel.ToString();
        //_velmag.text = "Mag:" + VelMag.ToString();
       // _acc.text = "A:" + Acc.ToString();
      //  _accmag.text = "Mag:" + AccMag.ToString();

    }

    private void LateUpdate()
    {
        if (VelMag > VelMaxMag)
        {
            VelMax = Vel;
            VelMaxMag = VelMax.magnitude;
         //   _velmax.text = "Max:" + VelMax.ToString();
          //  _velmaxmag.text = "Mag:" + VelMaxMag.ToString();
        }

        if (AccMag > AccMaxMag)
        {
            AccMax = Acc;
            AccMaxMag = AccMax.magnitude;
          //  _accmax.text = "Max" + AccMax;
          //  _accmaxmag.text = "Mag" + AccMaxMag;

        }

        VelPrec = Vel;
        PosPrec = Pos;

    }
}
