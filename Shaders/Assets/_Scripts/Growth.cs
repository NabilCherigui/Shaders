using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Growth : MonoBehaviour {
	
	[SerializeField] private Material _shader;
	[SerializeField] private float _size;
	[SerializeField] private float _increase;
	[SerializeField] private float _decrease;
	[SerializeField] private float _deadly;

	private void Update()
	{
		_size -= _decrease;
		_shader.SetFloat("_Amount", _size);
		if (_size <= _deadly)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		_size += _increase;
	}
}
