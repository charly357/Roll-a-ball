﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTrap : MonoBehaviour, TriggerTrap
{
	public void trapTrigger()
	{
		gameObject.SetActive(true);
	}
	public void trapInit()
	{
		gameObject.SetActive(false);
	}
}
