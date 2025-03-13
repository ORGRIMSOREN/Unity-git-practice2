using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
     GameObject box;  
     
    void Start()
    {
        Debug.Log("遊戲執行 Start");
        
    }

    private void Awake()
    {
        Debug.Log($"Awake");
    }

    private void OnEnable()
    {
        Debug.Log($"OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log($"OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log($"OnDestroy");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log($"碰到地板");
        
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        box.gameObject.SetActive(true);
        if (col.gameObject.tag == "weapon")
        {
            Debug.Log($"武器");
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        box.gameObject.SetActive(false);
    }
}
