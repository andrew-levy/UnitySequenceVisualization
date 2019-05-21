using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // adding comment
        transform.position = new Vector3(0, 0, 10);
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 10; i++)
        {
            transform.position = new Vector3(0, 0, -i * 10);
        }
	}
}
