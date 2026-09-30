using System.Collections;
using System.Diagnostics.Metrics;
using UnityEngine;

public class FlappyController : MonoBehaviour
{
    public int _score;

    [SerializeField] FlappyObstacle _obstaclePrefab;

    [SerializeField] float _obstacleSpawnDelay;
    [SerializeField] float _obstacleSpeed;
    private float _counter;
    void Start()
    {
        _counter = _obstacleSpawnDelay;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _counter += Time.deltaTime;
        if (_counter > _obstacleSpawnDelay)
        {
            FlappyObstacle go = Instantiate(_obstaclePrefab,new Vector3(10,Random.Range(-2.5f,2.5f)), Quaternion.identity);
            go._moveSpeed = _obstacleSpeed;
            _counter -= _obstacleSpawnDelay;
        }
    }


}
