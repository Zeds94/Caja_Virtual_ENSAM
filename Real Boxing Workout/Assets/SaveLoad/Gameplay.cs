using UnityEngine;

public class Gameplay : MonoBehaviour {

	public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		
			GameObject newDude = Instantiate(playerPrefab, Vector3.right, Quaternion.identity) as GameObject;
            newDude.transform.localScale = new Vector3(Game.current.sac.diametre/100f, Game.current.sac.hauteur/100f, Game.current.sac.diametre/100f);
            newDude.AddComponent<Rigidbody>();
            newDude.GetComponent<Rigidbody>().useGravity = false;
            newDude.GetComponent<Rigidbody>().mass = Game.current.sac.masse;

    }



}
