using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour 
{

	private Transform _transform;
	private float speed = 2.0f;
	[SerializeField] private Transform cameraTransform;


	private void OnEnable()
	{
		
		      iTween.ScaleTo ( gameObject, iTween.Hash (
				  
				  "scale", transform.localScale * 0.2f, 
				  "speed", speed, 
				  "easetype", "linear" 
				  
				) );
	
	}

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
