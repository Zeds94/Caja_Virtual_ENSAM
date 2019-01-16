using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceBar : MonoBehaviour
{

    private float _force;
    [SerializeField]
    private GameObject gant;
    public Image _barreDeForce;

    public bool force = false;

    void Update()
    {
        if (force == false)
        {

            _force = gant.GetComponent<PowerTest>().VelMag;
            if (_force > 120f) _force = 120f;
            _barreDeForce.rectTransform.sizeDelta = new Vector2(400 - (_force * 3.33f), _barreDeForce.rectTransform.sizeDelta.y);
        }

        if ( force == true)
        {
            _force = gant.GetComponent<PowerTest>().VelMag;
            float f = _force * 12 / Time.deltaTime;

            _barreDeForce.rectTransform.sizeDelta = new Vector2(4800 - ( _force * 0.0833f), _barreDeForce.rectTransform.sizeDelta.y);




        }




    }
}