using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class LookAtController : MonoBehaviour {

	public VRInteractiveItem interactive;
	public int rotationRate;

	
	void Update(){
		if(interactive.IsOver){
			Debug.Log ("isOver");
			this.gameObject.transform.Rotate (Vector3.up * Time.deltaTime * rotationRate);
		}
	}
}
