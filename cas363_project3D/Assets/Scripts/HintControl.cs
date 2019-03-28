using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintControl : MonoBehaviour
{
    public GameObject[] hints;
    public float hintTime = 50;
    GameObject hint;

    //set hints to active at start
    private void Start()
    {
        for(int i=0;i<hints.Length;i++)
        {
            hints[i].SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        RevealHint();
    }

    //remove hints on click [doesnt work]
    private void Update()
    {
        if(hint.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Unhint();
            }
        }
    }

    //reveal hint method
    public void RevealHint()
    {
        int rand = Random.Range(0, hints.Length);
        hint = hints[rand];
        Debug.Log(hint.GetComponentInChildren<Text>().text);
        Instantiate(hint);
    }
    
    //remove hint method
    void Unhint()
    {
        hint.SetActive(false);
    }
}
