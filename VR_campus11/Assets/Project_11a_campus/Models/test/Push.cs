using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
	public float pushPower = 2.0F;
	void OnControllerColliderHit(ControllerColliderHit hit) {
		Rigidbody body = hit.collider.attachedRigidbody;
		if (hit.gameObject.tag == "Move") {               

			if (body == null || body.isKinematic)
				return;

			if (hit.moveDirection.y < -0.3F)
				return;

			Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
			body.velocity = pushDir * pushPower;
		}
	}
}