using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour 
{

	private Transform _transform;
	[SerializeField] private Transform cameraTransform;

	private void Start()
	{
		_transform = transform;
	
	}
	void Update() 
    {
        //_transform.forward = cameraTransform.forward;
		_transform.Rotate(Vector3.forward * 30.0f * Time.deltaTime);
    }
}
