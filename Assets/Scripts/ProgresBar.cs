using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{
    // public static float _currentCleaning;


    public float _maxCleaning;

    public GameObject _canvas;
    public GameObject _textVictory;

    private Animator _animator;

    public static Slider _slider;

    Text _scoreCleaning;
    public static int _cleaningScore;

    void Start()
    {
        _animator = _canvas.GetComponent<Animator>();

        _slider = GetComponent<Slider>();

        _scoreCleaning = transform.GetChild(2).GetComponent<Text>();
    }

   
    
    void Update()
    {
        
        if(_cleaningScore >=_maxCleaning)
        {
            
            Victory();
        }

        _scoreCleaning.text = _cleaningScore.ToString();
    }

    private void Victory ()
    {
        _textVictory.SetActive(true);
    }
}
