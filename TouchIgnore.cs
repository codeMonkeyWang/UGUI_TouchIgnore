//  DUIRayIgnore.cs
//  Fondle
//
//  Created by chuxiang on 09/21/2015.
//
//



using UnityEngine;
using System.Collections;

public class TouchIgnore : MonoBehaviour, ICanvasRaycastFilter
{
	public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return false;
	}
}
