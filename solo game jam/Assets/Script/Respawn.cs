using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    Vector3 spawn;
	void Start () {
        spawn = new Vector3(0, 0.5f, 0); // original position
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5)
        {
            transform.position = spawn;
        }
	}
}
