using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiezasBlancas : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {

		//if (collision.gameObject.CompareTag("Negras") && UIManagment.instance.Blancas)
            Destroy(collision.gameObject);
		Debug.Log("fuck");
    }
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Negras")
			Debug.Log("fuck");
		}
}

