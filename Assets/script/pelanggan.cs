using UnityEngine;
using System.Collections;

public class pelanggan : MonoBehaviour {

	gerak KomponenGerak;

	void Start() {
		KomponenGerak = GameObject.Find("player").GetComponent<gerak> ();

	}
	void Update() {

	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.transform.tag == "Player") {
			KomponenGerak.pelanggan ++;
			Destroy(gameObject);
		}

	}

}