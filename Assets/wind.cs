using UnityEngine;
using System.Collections;

public class wind : MonoBehaviour {
	public Transform kaze;
	int i;
	private Quaternion rotation = Quaternion.Euler(0,0,1);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0, -0.1f, 0);
		if(i == 100){
			Instantiate(kaze,new Vector3(0,10,0),rotation);
			i = 0;
		}
		i++;
	}
}
