using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceBar : MonoBehaviour
{

    //[Range(0.0f, 10.0f)]
    private float _force;

    [SerializeField]
    private GameObject gant;

    public Image _barreDeForce;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        _force = gant.GetComponent<PowerTest>().VelMag;

        if (_force > 10f) _force = 10f;

        _barreDeForce.rectTransform.sizeDelta = new Vector2(400 - (_force * 40), _barreDeForce.rectTransform.sizeDelta.y);
        //Debug.Log(400 - (_force * 40));
    }
}