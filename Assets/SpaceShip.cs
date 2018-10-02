using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {


	[SerializeField] private float delay = 1.0f;
	// Use this for initialization
	private IEnumerator Start () 
	{
		iTween.MoveTo( gameObject, new Vector3( -2.0f, -1.3f, -11.0f ), delay );
		yield return new WaitForSeconds( delay );
	}
	
	
}
