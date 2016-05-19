using UnityEngine;
using System.Collections;

public class CameraDontTurn : MonoBehaviour 
{
	Quaternion rotation;
	void Awake()
	{
		rotation = transform.rotation;
	}
	void LateUpdate()
	{
		transform.rotation = rotation;
	}
}