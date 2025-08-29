using System.Collections;
using System.Collections.Generic;
using ThanhDV.Pool;
using UnityEngine;

public class Tester : MonoBehaviour
{
    [Space]
    [SerializeField] private GameObject testPrefab;

    [SerializeField] private List<GameObject> spawnedGameObject = new();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            NightGameObjectPool pool = NightPoolExtensions.CreatePool(testPrefab);
            pool.SetCapacity(50);
            pool.PopulatePool(25);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject clone = NightPool.Spawn(testPrefab, Random.insideUnitSphere * 5f, Quaternion.identity);
            spawnedGameObject.Add(clone);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Despawn();
        }
    }

    private void Despawn()
    {
        int cloneIndex = Random.Range(0, spawnedGameObject.Count);
        GameObject clone = spawnedGameObject[Random.Range(0, spawnedGameObject.Count)];
        if (!clone.activeSelf)
        {
            Despawn();
        }
        else
        {
            NightPool.Despawn(clone);
        }
    }
}
