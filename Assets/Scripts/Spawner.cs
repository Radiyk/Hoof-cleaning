using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;
    [SerializeField] private Transform _spawnerPos;
    [SerializeField] private GameObject _polySurface;

    void Start()
    {
        instance = this;
    }

    public void Spawn()
    {
        Instantiate(_polySurface, _spawnerPos.position, Quaternion.identity);
    }
}
