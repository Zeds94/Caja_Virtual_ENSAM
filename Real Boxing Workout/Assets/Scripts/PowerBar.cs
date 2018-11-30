using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour {

    public bool _in = false;
    public bool _out = true;
    public Rigidbody rb;
    public float _velocity;
    public Text _velocitext;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        _velocity = 0f;
	}
	
	
    private void OnTriggerEnter(Collider other)
    {
        _in = true;
        _out = false;
        _velocity = rb.velocity.sqrMagnitude;
        _velocitext.text = "Velocity " + _velocity;

    }

    private void OnTriggerExit(Collider other)
    {
        _out = true;
        _in = false;
        
    }

    void Update () {
        
    }
}
