using UnityEngine;

public class TreeCollisions : MonoBehaviour
{
	public Color onHitColor;
	public MeshRenderer mr;

	private void OnCollisionEnter(Collision collision)
	{
		mr.material.color = onHitColor;

	}
}
