using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    private double lastInterval;
    public float timeLeft, TimeTotal;
    [SerializeField]
    private AudioSource _speaker;
    [SerializeField]
    static public bool _soundPlayed = false;
    public Text Timer;

    private void Start()
    {
        TimeTotal = timeLeft;
        string minutes = Mathf.Floor(timeLeft / 60).ToString("00");
        string seconds = (timeLeft % 60).ToString("00");
        Timer.text = "TEMPS:" + minutes + ":" + seconds;
        
    }

    void Update()
    {
        if (FrapsCont.tempo == true)
        {
            timeLeft -= Time.deltaTime;
            string minutes = Mathf.Floor(timeLeft / 60).ToString("00");
            string seconds = (timeLeft % 60).ToString("00");
            Timer.text = "TEMPS:" + minutes + ":" + seconds;
        }

        if (timeLeft <= 0f && _soundPlayed == false)
        {
            Timer.text = "TEMPS:00:00";
            _speaker.Play();
            _soundPlayed = true;
            lastInterval = Time.realtimeSinceStartup;
            FrapsCont.tempo = false;
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0f;

                


        }

    }

    public void setTime(float f)
    {
        timeLeft = f;
    }
}
