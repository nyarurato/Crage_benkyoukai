using UnityEngine;
using System.Collections;

public class myks_contoroller : MonoBehaviour {

	public float keisuu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Horizontal")) {
			gameObject.transform.position += new Vector3(0,0, keisuu*Input.GetAxis("Horizontal"));
		}
		if (Input.GetButton ("Vertical")) {
			gameObject.transform.position += new Vector3(keisuu*Input.GetAxis("Vertical"),0,0);
		}
	
	}
}
