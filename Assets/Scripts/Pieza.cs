using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieza : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    private void OnMouseDrag()
    {
        Vector3 mouseposition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);
        Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseposition);


        transform.position = mouse;
        
    }
}
