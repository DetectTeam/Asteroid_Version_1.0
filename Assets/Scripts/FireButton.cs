﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour 
{

	public void Fire()
	{
		Messenger.Broadcast( "Fire" );
	}
	
}
