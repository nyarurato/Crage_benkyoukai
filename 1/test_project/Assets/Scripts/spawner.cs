using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public GameObject pepo_prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Instantiate (pepo_prefab, gameObject.transform.position, Quaternion.Euler (90, 90, 90));
		}
	}
}
