using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveForce;
	public Rigidbody rig;

	void FixedUpdate()
	{
		float xInput = Input.GetAxis("Horizontal");
		rig.AddForce(Vector3.right * xInput * moveForce);
	}
}
