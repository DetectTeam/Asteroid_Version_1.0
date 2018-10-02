using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHandler : MonoBehaviour 
{
	[SerializeField] private Light light;
	[SerializeField] private float speedTween;

	[SerializeField] Color lerpedColor = Color.white;
	[SerializeField] Color startColor;
	[SerializeField] Color endColor;

	// Use this for initialization
	void Start () 
	{
		light = GetComponent<Light>();

		//  iTween.ValueTo (light.gameObject, iTween.Hash (
		// 	 "from", Color.blue, 
		// 	 "to", Color.red, 
		// 	 "time", speedTween, 
		// 	 "easetype", iTween.EaseType.easeInOutSine,
		// 	 "onUpdate","UpdateColor"));
	}

	private void  Update()
	{

		

		light.color = Color.Lerp( 
			startColor, 
			endColor, 
			Mathf.PingPong(Time.time, 1.5f)
			);
	}

	void UpdateColor(Color newColor)
 	{
    	light.color = newColor;
 	}
	
}
