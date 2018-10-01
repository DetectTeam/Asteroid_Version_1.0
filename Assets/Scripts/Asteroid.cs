using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour 
{

	private Transform _transform;

	[SerializeField] private bool isSelected;

	[SerializeField] private GameObject crossHair;

	private void OnEnable()
	{
		Messenger.AddListener( "Fire" , StartDestructionSequence );
	}

	private void OnDisable()
	{
		Messenger.RemoveListener( "Fire" , StartDestructionSequence );
	}


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

	 private void StartDestructionSequence()
	 {
		 if( crossHair.activeSelf )
		 {
			 Debug.Log( "Ok to destroy me....." );
			 StartCoroutine( ExplodeAsteroid() );
		 }
		 else
		 {
			 Debug.Log( "Not ok to Destroy me...." );
		 }
	 }


	 private IEnumerator ExplodeAsteroid()
	 {
		 yield return null;
		 Debug.Log( "Destroying Asteroid." );
	 }
	
}
