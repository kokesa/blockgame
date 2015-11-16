using UnityEngine;
using System.Collections;

public class BallGenerater : MonoBehaviour {
	
	[SerializeField]
	private GameObject ballPrehab;
	
	void Start () {
		InvokeRepeating("GenerateBall", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void GenerateBall() {
		float width = transform.localScale.x;
		float positionX = Random.Range(-width / 2,width / 2);
		GameObject newBall = Instantiate(ballPrehab,
		                                 new Vector3(positionX, transform.position.y, transform.position.z),
		                                 transform.rotation) as GameObject;
		newBall.transform.parent = transform.parent;
		
		float power = Random.Range(5f,10f);
		newBall.GetComponent<Rigidbody>().AddForce(power * Vector3.back,ForceMode.VelocityChange);
	}
}
