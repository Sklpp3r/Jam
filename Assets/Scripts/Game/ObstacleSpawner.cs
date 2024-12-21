using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private float _obstacleSpawnTime;
    [SerializeField] private float _XSpawnRangeL, _XSpawnRangeR;
    [SerializeField] Transform _parentTransform;

    private void Start()
    {
        StartCoroutine(spawnObstacle());
    }



    private IEnumerator spawnObstacle()
    {
        while (true)
        {
            Instantiate(_obstaclePrefab, new Vector3(UnityEngine.Random.Range(-_XSpawnRangeL, _XSpawnRangeR), 14, 0), quaternion.identity, _parentTransform);
            yield return new WaitForSeconds(_obstacleSpawnTime);
        }
    }
}

