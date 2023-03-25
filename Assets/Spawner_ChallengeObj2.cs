using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_ChallengeObj2 : MonoBehaviour
{
    
[Header("ChallengeObj Game Object")]
public GameObject challengeObject;
[Header("Default spawn delay time")]
public float spawnDelay = 1f;
[Header("Default spawn time")]
public float spawnTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);

    }

    // Update is called once per frame
    void Update()
    {
           transform.position = new Vector3(16, -2.76f, 1);
    }

void InstantiateObjects()
{
    Instantiate(challengeObject, transform.position, transform.rotation);
}

}
