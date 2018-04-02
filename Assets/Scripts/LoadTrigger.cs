using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTrigger : MonoBehaviour {
	
	public int LevelTarget;
	public Transform targetPoint;
	public float playerTurningDisplace;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			other.SendMessage ("OnLoadTrigger", new object[]{ LevelTarget, (targetPoint.position - transform.position), playerTurningDisplace });
		}
	}

}
