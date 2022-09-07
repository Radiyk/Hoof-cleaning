using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCamera : MonoBehaviour
{

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();

        StartCoroutine ("SceneTransition");
    }

   
    IEnumerator SceneTransition()
    {
        yield return new WaitForSeconds (8f);
        animator.SetTrigger("HoofUp");
    }

    public void TwoSceneLoad()
    {
        SceneManager.LoadScene(1);
    }
}
