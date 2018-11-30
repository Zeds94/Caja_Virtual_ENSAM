using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fraps : MonoBehaviour {

    public Text _textscore;
    static public float _score;

    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        _textscore.text = "HITS "+ FrapsCont._frapcont;


    }

}
