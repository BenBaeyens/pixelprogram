using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitter : MonoBehaviour
{

    [SerializeField] GameObject instantiateObjectTemp;
    [SerializeField] float spitterSpawnDelay = 4f;

    #region Methods

    void Start()
    {
        InvokeRepeating("SpawnObject", spitterSpawnDelay / 2, spitterSpawnDelay);
    }

    public void SpawnObject(){
        Instantiate(instantiateObjectTemp, transform.position + Vector3.forward * 4, transform.rotation);
    }

    #endregion
}
