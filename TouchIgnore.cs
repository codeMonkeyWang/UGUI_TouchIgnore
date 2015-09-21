
using UnityEngine;
using System.Collections;

public class TouchIgnore : MonoBehaviour, ICanvasRaycastFilter
{
	public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return false;
	}
}
