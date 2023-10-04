using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    // 右から左に動かす

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * moveSpeed * Time.deltaTime;
    }
}
