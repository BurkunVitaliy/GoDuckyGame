using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public Color deathColor;
    private SpriteRenderer sr;

    public GameObject explosion, panelLose;
    private AudioSource audioLose;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        audioLose = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Knife"))
        {
            StartGame.isStart = false;
            Destroy(other.transform.parent.gameObject);
            sr.color = deathColor;
            audioLose.Play();

            ContactPoint2D contact = other.contacts[0];
            Vector3 pos = contact.point;
            GameObject exp =  Instantiate(explosion,
                pos, Quaternion.identity) as GameObject;
            Destroy(exp, 1f);
            
            panelLose.SetActive(true);
        }
    }
}
