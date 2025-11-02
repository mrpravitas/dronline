using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnInterval;
    [SerializeField] private GameObject[] _obstacles;
    [SerializeField] private Transform[] _positions;

    private float _spawnTime;

    private void Awake()
    {
        _spawnTime = _spawnInterval;
    }

    private void Update()
    {
        _spawnTime -= Time.deltaTime;

        if (_spawnTime <= 0)
        {
            int obstacle = Random.Range(0, _obstacles.Length);
            int position = Random.Range(0, _positions.Length);

            Spawn(_obstacles[obstacle], _positions[position]);

            _spawnTime = _spawnInterval;
        }
    }

    private void Spawn(GameObject obstacle, Transform position)
    {
        Instantiate(obstacle, position);
    }
}
