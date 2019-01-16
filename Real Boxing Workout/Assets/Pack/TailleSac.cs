using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TailleSac : MonoBehaviour {

    [SerializeField]
    private Dropdown drop;
    [SerializeField]
    private GameObject Sac;

    [SerializeField]
    static private float taille= 0.57f;

    // Use this for initialization
    void Start () {

        if (Sac != null)
        {
            Sac.gameObject.transform.localScale = new Vector3(Sac.transform.localScale.x, Sac.transform.localScale.y * taille, Sac.transform.localScale.z);
        }
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

    public void GetDropdownValue()
    {

        int val = drop.value;

        switch (val)
        {
            case 0:
                taille = 0.57f;
                break;

            case 1:
                taille = 0.71f;
                break;
            case 2:
                taille = 0.85f;
                break;
            case 3:
                taille = 1f;
                break;
            case 4:
                taille = 1.07f;
                break;

            default:
                taille = 1f;
                break;
        }



    }
}
