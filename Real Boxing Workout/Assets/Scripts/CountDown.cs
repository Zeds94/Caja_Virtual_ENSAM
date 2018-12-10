using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    private double lastInterval;
    public float timeLeft;
    [SerializeField]
    private AudioSource _speaker;
    [SerializeField]
    // private AudioClip _ring;
    private bool _soundPlayed = false;

    //timer=0f;
    public Text Timer;

	void Update ()
    {
        if (FrapsCont.tempo == true)
        { 
        timeLeft -= Time.deltaTime;
        string minutes = Mathf.Floor(timeLeft / 60).ToString("00");
        string seconds = (timeLeft% 60).ToString("00");
        Timer.text = "TEMPS:" + minutes+ ":" + seconds;
        }
        //string minutes1="minutes";
        //string seconds1= "seconds";
        //Debug.Log(string.Format("{0}:{1}", minutes1, seconds1));
        //timer += Time.deltaTime;

       // Debug.Log(timeLeft);

        if (timeLeft <= 0f && _soundPlayed == false)
        {
           // _speaker.clip = _ring;
            _speaker.Play();
            _soundPlayed = true;
            
                lastInterval = Time.realtimeSinceStartup;
               // if (Time.timeScale == 1.0f)
                  //  Time.timeScale = 0f;
                

        }
    }
}
