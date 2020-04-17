using UnityEngine;
using System.Collections;

public class kembali : MonoBehaviour {


	void Start() {

	}
	void Update() {
		if (Input.GetKey(KeyCode.Escape)){
			Application.LoadLevel(0);
		}
	}

}