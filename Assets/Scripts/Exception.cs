using UnityEngine;
using System.Collections;

public class Exception : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Exception Start ...");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUILayout.Button ("Press Me")) {
			Debug.Log ("Hello!");
		}
		
	}
}
