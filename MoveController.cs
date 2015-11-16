using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {
	public const float STAGE_WIDTH = 40f;
	public const float PADDLE_WIDTH = 8f;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}
	
	private void Move() {
		Vector3 delta = new Vector3(
			-Input.GetAxis("Horizontal") * 30 * Time.deltaTime,0,0);
		
		if (delta.x + transform.localPosition.x + PADDLE_WIDTH / 2 > STAGE_WIDTH / 2) 
			return;
		if (delta.x + transform.localPosition.x - PADDLE_WIDTH / 2 < -STAGE_WIDTH / 2)
			return;
		
		transform.Translate(delta);
	}
	
	private void OnCollisionEnter(Collision target) {
		if (target.gameObject.tag == "Ball") {
			Vector3 targetVelocity = target.rigidbody.velocity;
			
			if (targetVelocity.magnitude <= MoveBall.MAX_SPEED) {
				target.rigidbody.AddForce(-1.5f * targetVelocity);
			}
		}
	}
}


