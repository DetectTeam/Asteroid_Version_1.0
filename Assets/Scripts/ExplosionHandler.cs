using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionHandler : MonoBehaviour 
{

	[SerializeField] private List<GameObject> particleList = new List<GameObject>();

	private void OnEnable()
	{
		Messenger<Transform>.AddListener( "Explosion", Explosion );
	}

	private void OnDisable()
	{
		Messenger<Transform>.RemoveListener( "Explosion", Explosion );
	}
	private void Awake()
	{
		int nbChild = this.transform.childCount;
		
		for(int i = 0; i < nbChild; i++)
		{
			GameObject child = this.transform.GetChild(i).gameObject;
			particleList.Add(child);
		}
	}

	private void Explosion( Transform destination )
	{
		particleList[0].transform.position = destination.position;
		particleList[0].gameObject.SetActive( true );
	}
}