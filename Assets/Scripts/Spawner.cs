using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float Radius = 4f;
    [SerializeField] int _numOfObjects = 10;
    // Objects to spawn
    [SerializeField] GameObject _firstObject;
    [SerializeField] GameObject _secondObject;
    //[SerializeField] GameObject _thirdObject;
    [SerializeField] List<GameObject> _enemies = new List<GameObject>();

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        float nextAngle = 2 * Mathf.PI / _numOfObjects;
        float angle = 0;
        for (int i = 0; i < _numOfObjects; i++)
        {
            float x = Mathf.Cos(angle) * Radius;
            float y = Mathf.Sin(angle) * Radius;
            if (i == 3)
            {
                GameObject newObject = Instantiate(_secondObject, new Vector2(x, y), Quaternion.Euler(0, 0, (360 / _numOfObjects) * i), transform);
                _enemies.Add(newObject);
            }
            else { 
            GameObject newObject = Instantiate(_firstObject, new Vector2(x, y), Quaternion.Euler(0, 0, (360 / _numOfObjects) * i), transform);
            _enemies.Add(newObject);
            }
            angle += nextAngle;
        }
    }
}
