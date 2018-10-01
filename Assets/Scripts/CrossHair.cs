using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour 
{

	private Transform _transform;
	private float speed = 2.0f;
	[SerializeField] private Transform cameraTransform;

	private Vector3 tmpLocalScale; 


	private void Awake()
	{
		tmpLocalScale = transform.localScale;
	}

	private void OnEnable()
	{
		      iTween.ScaleTo ( gameObject, iTween.Hash (
				  
				  "scale", transform.localScale * 0.5f, 
				  "speed", speed, 
				  "easetype", "linear" 
				  
				) );
	}

	private void OnDisable()
	{
		transform.localScale = tmpLocalScale;
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
