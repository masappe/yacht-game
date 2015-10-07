using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.Rotate(0,0,-45);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		tacking();
		speed();
		if(Input.GetKeyDown("s")){
			transform.Rotate(0,0,1);
		}
		if(Input.GetKey("d")){
			transform.Rotate(0,0,-1);
		}
		Debug.Log(transform.localEulerAngles.z);
	
	}

	void speed(){
		//transform.localEulerAngleはGameObject自身の角度の取得
		if(transform.localEulerAngles.z == 315){
			this.transform.position += new Vector3(-0.05f,0.05f,0);
		}
		if(transform.localEulerAngles.z == 225){
			this.transform.position += new Vector3(0.05f,0.05f,0);
		}


	}

	void tacking(){
		//iTweenをインストールする
		//時間をかけた回転
		if(transform.localEulerAngles.z > 270){
			if(Input.GetKeyDown("f")){
				iTween.RotateTo(gameObject,iTween.Hash("z",transform.localEulerAngles.z - 90,"time",1.0f));
			}
		}
		if(transform.localEulerAngles.z < 270){
			if(Input.GetKeyDown("f")){
				iTween.RotateTo(gameObject,iTween.Hash("z",transform.localEulerAngles.z + 90,"time",1.0f));
			}
		}

	}

}
