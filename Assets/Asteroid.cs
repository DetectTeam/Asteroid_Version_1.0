using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour 
{

	[SerializeField] private GameObject crossHair;


	 void OnMouseDown()
     {
         print (name); 
		 ToggleCrosshair();


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
