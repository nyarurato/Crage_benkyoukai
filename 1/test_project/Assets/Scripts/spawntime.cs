using UnityEngine;
using System.Collections;

public class spawntime : MonoBehaviour {

	public float time;
	// Use this for initialization
	void Start () {
		Destroy(gameObject,10f);
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		//if (time > 10) {
					
		//}
	}
}
