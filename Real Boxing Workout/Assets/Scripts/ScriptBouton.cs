using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBouton : MonoBehaviour {

    public GameObject sac;
    public GameObject coach;
    public Text _horloge;
    public GameObject _Timer;

       private void OnTriggerEnter(Collider other)
    {
        
        float _timeleft = _Timer.GetComponent<CountDown>().TimeTotal;
        sac.GetComponent<FrapsCont>().setTempo(false, _timeleft);
        coach.GetComponent<VoixCoach>().restartTrain();
        string minutes = Mathf.Floor(_timeleft / 60).ToString("00");
        string seconds = (_timeleft % 60).ToString("00");
        _horloge.text = "TEMPS:" + minutes + ":" + seconds;
        FrapsCont._frapcont = 0;
        FrapsCont.FrapsMoy.Clear();
        
    }

}
