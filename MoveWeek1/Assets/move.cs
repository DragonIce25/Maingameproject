using UnityEngine;
using System.Collections;

public class move : MonoBehaviour 
{
	public float moveSpeed = 10f;

	void Update () 
	{
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}
}