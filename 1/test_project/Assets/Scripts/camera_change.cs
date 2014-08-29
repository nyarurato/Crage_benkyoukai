using UnityEngine;
using System.Collections;

public class camera_change : MonoBehaviour {

	public GameObject camera1,camera2;
	bool is_camera1_on;
	// Use this for initialization
	void Start () {
		is_camera1_on = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			camera2.SetActive(is_camera1_on);
			camera1.SetActive(!is_camera1_on);
			is_camera1_on = !is_camera1_on ;
			
		}
	}
}
