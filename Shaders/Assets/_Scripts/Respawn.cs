using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

	[SerializeField] private Spawner _spawner;

	private void Start()
	{
		_spawner = FindObjectOfType<Spawner>();
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Whale"))
		{
			if (CompareTag("Salmon"))
			{
				transform.position = _spawner.SalmonStart;

			}
			else if (CompareTag("Sardine"))
			{
				transform.position = _spawner.SardineStart;

			}
		}
	}
}
