using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "wind"){
			Destroy(collision.gameObject);
		}
		Debug.Log(collision.gameObject.name);
	}
}
