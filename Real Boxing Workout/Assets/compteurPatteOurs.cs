using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compteurPatteOurs : MonoBehaviour {

    public List<Fraps> FrapsMoy = new List<Fraps>();
    public List<float> ForceMoy = new List<float>();

    static public int _frapcont;
   // public GameObject _sac;
  //  public bool enter = true;
  //  static public bool tempo = false;
    public Text _textscore, _moy, _moyF;
  //  static public float _score;
   static public float somme;
    static public float sommeF;
  //  public GameObject _coach;
  //  public GameObject _canvas;
     static public float moy;
     static public float moyF;


    // Use this for initialization
    private void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gant")
        {
            Vector3 v = other.gameObject.GetComponent<PowerTest>().Vel;
            float f = v.magnitude *12 / Time.deltaTime;
            ForceMoy.Add(f);
            FrapsMoy.Add(new Fraps(v));
            Debug.Log("Hit!" + f );
            _frapcont++;
        }

        _textscore.text = "HITS " + _frapcont;
        foreach (Fraps frap in FrapsMoy)
        {
            somme += frap.getMagnitude();
        }

        foreach (float f in ForceMoy)
        {
            sommeF += f;
        }
        moy = somme / FrapsMoy.Count;
        moyF = sommeF / ForceMoy.Count;
        _moyF.text = "Force : " + (int)moyF;
        _moy.text = "Vitesse : " + (int)moy;
    }
}

