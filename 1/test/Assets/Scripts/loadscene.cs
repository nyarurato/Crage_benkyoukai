using UnityEngine;
using System.Collections;

public class loadscene : MonoBehaviour {

	public GameObject dlight;
	public float waittimes;
	float times;
	bool button;
	Light lightobj;
	// Use this for initialization
	void Start () {
		lightobj = dlight.GetComponent<Light> ();
	}
	

	// Update is called once per frame
	void Update () {



		if (Time.time > waittimes) {
				//Application.LoadLevel ("gameover");
	
		}

	}

	void OnGUI(){

		button = GUI.Button (new Rect (0, 0, 100, 30), "onoff");
		if (button) {
			//componet --> GetComponent
			gameObject.GetComponent<AudioSource>().enabled =!(gameObject.GetComponent<AudioSource>().enabled);
			lightobj.enabled = !(lightobj.enabled );
		}

	}

	void OnCollisionEnter(Collision other){
		Debug.Log (other.gameObject.name);
		//Application.LoadLevel ("gameover");
	}
}
