using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	public string levelToLoad;
	void Update() {
		if (Input.GetKeyDown ("space"))
			Application.LoadLevel (levelToLoad);
		
	}
}