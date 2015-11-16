using UnityEngine;
using System.Collections;

public class BlockManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void OnCollisionEnter(Collision target) {
		if (target.gameObject.tag == "Ball") {
			SendMessage("Damaged",target.gameObject.GetComponent<MoveBall>().BallPower);
		}
	}
}