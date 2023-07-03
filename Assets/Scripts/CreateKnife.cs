using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateKnife : MonoBehaviour
{
    public float waitTime = 1f;
    public GameObject knife;
    private bool isSpawn;
    private Coroutine spawn;

    private void Update()
    {
        if (StartGame.isStart && !isSpawn)
        {
            spawn = StartCoroutine(spawnKnifes());
            isSpawn = true;
        }
    }

    IEnumerator spawnKnifes()
    {
        while (true)
        {
            if (StartGame.isStart)
            {
                Instantiate(knife, new Vector2(7, UnityEngine.Random.Range(-2.33f, 3.18f)) ,
                    Quaternion.Euler(new Vector3(0,180,-45)));
            }
            else
            {
                StopCoroutine(spawn);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}
