using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // PipeÇàÍíËä‘äuÇ≈ê∂ê¨Ç∑ÇÈ
    //ÅEPrefabÇÃê∂ê¨
    //ÅEàÍíËä‘äu

    [SerializeField] Pipe pipePrefab;
    float spawnTime = 2f;// ÇQïbä‘äuÇ≈ê∂ê¨ÇµÇΩÇ¢
    float waitTimer = 0;


    // Update is called once per frame
    void Update()
    {
        waitTimer += Time.deltaTime;
        if (waitTimer >= spawnTime)
        {
            waitTimer = 0;
            Spawn();
        }
        // Debug.Log(waitTimer);
    }

    // ê∂ê¨
    void Spawn()
    {
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}
