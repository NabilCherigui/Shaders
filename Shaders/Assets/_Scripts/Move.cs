	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	[SerializeField] private GameObject _object;
	[SerializeField] private float _max;
	[SerializeField] private float _min;
	[SerializeField] private float _distance;
	

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow) && _object.transform.position.y <= _max)
		{
				_object.transform.position = new Vector3(_object.transform.position.x, _object.transform.position.y  + _distance, _object.transform.position.z);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow) && _object.transform.position.y >= _min)
		{
				_object.transform.position = new Vector3(_object.transform.position.x, _object.transform.position.y  - _distance, _object.transform.position.z);
		}
	}
}
