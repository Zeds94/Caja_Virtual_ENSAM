using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FrapsCont : MonoBehaviour {
    static public int _frapcont;
    public GameObject _sac;
    public bool enter = true;
    static public bool tempo = false;
    public Text _textscore, _moy;
    static public float _score;
    static public List<Fraps> FrapsMoy = new List<Fraps>();

    public float somme;
    public GameObject _coach;
    public GameObject _canvas;
    static public float moy;

    void Start ()
    {
        _frapcont = 0;
    }

	
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "gant")
        {
            if (enter)
            {
                _coach.GetComponent<VoixCoach>().StartTime();
                tempo = true;
                CountDown._soundPlayed = false;
                _frapcont += 1;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gant")
        {
            Vector3 v = other.gameObject.GetComponent<PowerTest>().Vel;
            FrapsMoy.Add(new Fraps(v));
        }
    }

    private void Update()
    {
        _textscore.text = "HITS " + _frapcont;
        somme = 0f;
        foreach (Fraps frap in FrapsMoy)
        {
            somme += frap.getMagnitude();
        }
        moy = somme / FrapsMoy.Count;
        _moy.text = "MOY: " + (int)moy;
    }

    public void setTempo(bool b, float f)
    {
        tempo = b;
        _canvas.GetComponent<CountDown>().setTime(f);

    }

    

}
