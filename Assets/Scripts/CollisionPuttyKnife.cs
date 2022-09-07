using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPuttyKnife : MonoBehaviour
{
    private  AudioSource MyAudioSource;
    public  Spawner _spawner;
    
    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider Collision)
	{
		if (Collision.CompareTag("Player"))
		{
            _spawner.Spawn();
            MyAudioSource.Play();
            ProgresBar._cleaningScore += 1;
            ProgresBar._slider.value = ProgresBar._cleaningScore;
		}
	}

}
