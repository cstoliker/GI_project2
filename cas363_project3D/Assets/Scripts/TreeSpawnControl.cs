using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawnControl : MonoBehaviour
{
    public GameObject[] trees;

    // Spawn Control for out of bounds
    void Start()
    {
        int rand = Random.Range(0, trees.Length);
        Instantiate(trees[rand], transform.position, Quaternion.identity);
    }
}
