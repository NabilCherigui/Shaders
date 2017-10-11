using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{       
    private List<GameObject> _bait = new List<GameObject>();
    
    [SerializeField] private GameObject _sardine, _salmon;
    [SerializeField] private int _sardineAmount, _salmonAmount;
    [SerializeField] private Vector3 _sardineStart, _salmonStart;

    public Vector3 SardineStart{get{return _sardineStart;}}
    public Vector3 SalmonStart{get{return _salmonStart;}}
    
    private void Awake()
    {
        for (int i = 0; i < _sardineAmount; i++)
        {
            _bait.Add(Instantiate(_sardine));
            _sardineStart = new Vector3(_sardineStart.x * 1.2f, _sardineStart.y, _sardineStart.z);
            _bait[i].transform.position = _sardineStart;
        }
        
        for (int i = _sardineAmount; i < _sardineAmount + _salmonAmount; i++)
        {
            _bait.Add(Instantiate(_salmon));
            _salmonStart = new Vector3(_salmonStart.x * 1.2f, _salmonStart.y, _salmonStart.z);
            _bait[i].transform.position = _salmonStart;
        }
    }

    private void Update()
    {
        for (int i = 0; i < _bait.Count; i++)
        {
            if (_bait[i].CompareTag("Salmon") && _bait[i].transform.position.x <= 10)
            {
                _bait[i].transform.position += new Vector3(1,0,0) * Time.deltaTime;
            }
            else if(_bait[i].CompareTag("Sardine") && _bait[i].transform.position.x >= -10)
            {
                _bait[i].transform.position += new Vector3(-1,0,0) * Time.deltaTime;
            }

            if (_bait[i].CompareTag("Salmon") && _bait[i].transform.position.x >= 10)
            {
                _bait[i].transform.position = _salmonStart;
            }
            else if (_bait[i].CompareTag("Sardine") && _bait[i].transform.position.x <= -10)
            {
                _bait[i].transform.position = _sardineStart;
            }
        }
    }

}
