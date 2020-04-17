using UnityEngine;
using System.Collections;

public class menuju : MonoBehaviour {


	void Start() {

	}
	void Update() {

	}
	void OnTriggerEnter2D (Collider2D other) {

	}
	public void ketujuan(int yangdituju) {
		Application.LoadLevel(yangdituju);
	}
	public void ClickExit() {
		Application.Quit();
	}

}