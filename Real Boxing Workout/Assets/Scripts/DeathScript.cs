using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject instance;
    public bool enter = true;
    public static float time;
    private double lastInterval;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("entered");
            lastInterval = Time.realtimeSinceStartup;
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0f;

        }
    }
}
