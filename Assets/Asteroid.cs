using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour 
{

	private Transform _transform;

	[SerializeField] private GameObject crossHair;


	private void Start()
	{
		_transform = transform;
	}

	 private void OnMouseDown()
     {
         print (name); 
		 ToggleCrosshair();


     }

	 private void Update()
	 {
		 _transform.Rotate( Vector3.back * 30.0f * Time.deltaTime ); //Slowly Rotate the asteroid
	 }

	 private void ToggleCrosshair()
	 {
		 if( crossHair.activeSelf )
		 {
			 crossHair.SetActive( false );
		 }
		 else
		 {
			 crossHair.SetActive( true );
		 }
	 }
	
}
