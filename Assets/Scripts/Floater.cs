using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour 
{

	[SerializeField] private Vector3 floatY;
	[SerializeField] private float originalY;
	[SerializeField] private float originalX;

	[SerializeField] private float floatStrength;

	

	// Use this for initialization
	private IEnumerator Start () 
	{
		originalY = this.transform.position.y;
		originalX = this.transform.position.x;

		float yValue = 0;
		float xValue = 0;


		while( true )
		{
				
				yield return null;
				
				yValue = originalY + ( Mathf.Sin( Time.time ) * floatStrength );
				xValue = originalX + (Mathf.Sin(Time.time) * floatStrength);

				transform.position = new Vector3( xValue, yValue, transform.position.z );
		}

	}
	
	// Update is called once per frame
	
}
