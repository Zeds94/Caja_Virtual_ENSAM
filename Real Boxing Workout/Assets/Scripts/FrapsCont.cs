using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrapsCont : MonoBehaviour {
    static public int _frapcont;
    public GameObject _sac;
    public bool enter = true;
    static public bool tempo = false;
    public Text _textscore;
    static public float _score;

    void Start ()
    {
        _frapcont = 0;
		
	}
	
    private void OnTriggerExit(Collider other)
    {
        //enter = false;
        if (enter)
        {
            tempo = true;
            Debug.Log("entered");

            _frapcont += 1;
        }
    }

    private void Update()
    {
        _textscore.text = "HITS " + _frapcont;
    }

}
