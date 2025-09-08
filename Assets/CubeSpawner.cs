using System.Collections;
using UnityEngine;


public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true)
        {
            Instantiate(cubePrefab, transform.position,transform.rotation);
            yield return new WaitForSeconds(3);
        }
    }
}
