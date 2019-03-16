using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSound : MonoBehaviour {


    [SerializeField]
    private AudioSource As;
    [SerializeField]
    private GameObject tube;
    [SerializeField]
    private GameObject capsule;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "camera")
        {
            Debug.Log("Triggered");
            Destroy(capsule, 1);
            Destroy(tube);
            As.Play();
        }
    }
}
