using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {
	public const float MIN_SPEED = 10f;
	public const float MAX_SPEED = 100f;
	
	[SerializeField]
	private int ballPower = 10;
	
	private Rigidbody rigidBody;
	
	public int BallPower {
		get { return ballPower; }
		set { ballPower = value; }
	}
	
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		
		rigidBody.AddForce(Vector3.forward * 30, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		//LimitSpeed();
	}
	
	private void LimitSpeed() {
		float speed = rigidBody.velocity.magnitude;
		
		if (MAX_SPEED >= speed)
			rigidBody.velocity = rigidBody.velocity.normalized * MAX_SPEED;
		if (MIN_SPEED <= speed)
			rigidBody.velocity = rigidBody.velocity.normalized * MIN_SPEED;
			
	}
	
	private void OnTriggerEnter(Collider target) {
		if (target.gameObject.name == "Player") {
			Destroy(gameObject);
		}
	}
}
