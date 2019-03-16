using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCoach : MonoBehaviour {

    bool _startSeq = false;

    public GameObject[] patteours = new GameObject[3];

    float clock = 0f;

    int patteActive = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        clock += Time.deltaTime;


        if ( _startSeq == true && clock > 2f)
        {
            patteours[patteActive].gameObject.SetActive(false);
            clock = 0;

            int rand = (int)Random.Range(0f, 2.99f);
            patteActive = rand;
            patteours[rand].SetActive(true);


        }








		
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "patteours")
        {

            if (_startSeq == false)
            {


                patteours[0].SetActive(false);
                patteours[1].SetActive(false);
                patteours[2].SetActive(false);
                _startSeq = true;
                clock = 0f;
            }

            if ( _startSeq == true)
            {
                col.gameObject.SetActive(false);
            }



        }
    }
}
