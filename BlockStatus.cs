using UnityEngine;
using System.Collections;

public class BlockStatus : MonoBehaviour {
	
	[SerializeField]
	private int HP = 10;
	
	private void Damaged(int amount) {
		HP -= amount;
		if (HP <= 0) {
			Destroy(gameObject);
		}
	}
}
