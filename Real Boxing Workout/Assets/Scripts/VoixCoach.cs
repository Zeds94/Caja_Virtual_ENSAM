using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoixCoach : MonoBehaviour {

    [SerializeField]
    private AudioClip[] Ac = new AudioClip[5];
    [SerializeField]
    private bool[] ClipPlayer = new bool[5];
    [SerializeField]
    private AudioSource As;
    [SerializeField]
    float secondes;
    [SerializeField]
    bool timeStart;




	// Use this for initialization
	void Start () {

        for (int i = 0; i < ClipPlayer.Length; i++)
        {
            ClipPlayer[i] = false;
        }

		
	}
	
	// Update is called once per frame
	void Update () {
       

       if ( timeStart == true )
        {
            secondes += Time.deltaTime;

            if (ClipPlayer[0] == false)
            {
                ClipPlayer[0] = true;
                As.clip = Ac[0];
                As.Play();
            }


            if (ClipPlayer[1] == false && secondes >= 2.5f)
            {

                ClipPlayer[1] = true;
                As.clip = Ac[1];
                As.Play();

            }
            if (ClipPlayer[2] == false && secondes >= 30f)
            {

                ClipPlayer[2] = true;
                As.clip = Ac[2];
                As.Play();

            }
            if (ClipPlayer[3] == false && secondes >= 60f)
            {

                ClipPlayer[3] = true;
                As.clip = Ac[3];
                As.Play();

            }

            if (ClipPlayer[4] == false && secondes >= 90f)
            {

                ClipPlayer[4] = true;
                As.clip = Ac[4];
                As.Play();

            }






        }


	}

    public void StartTime() {

        timeStart = true;

    }


    public void restartTrain()
    {

        for (int i = 0; i < ClipPlayer.Length; i++)
        {
            ClipPlayer[i] = false;
        }

        timeStart = false;

        secondes = 0.0f;

    }
}
