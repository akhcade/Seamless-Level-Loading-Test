using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devexit : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
	}
}
