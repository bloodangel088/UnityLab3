using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngryNPC : MonoBehaviour
{
    
    public GameObject neponyal;
    public GameObject aponyal;
    public GameObject dialog;
    public GameObject inf;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ButtonYes()
    {
        dialog.SetActive(false);
        Time.timeScale = 1;
            neponyal.SetActive(false);
            aponyal.SetActive(true);   
    }
    public void ButtonNo()
    {
        dialog.SetActive(false);
        Time.timeScale = 1;
        FindObjectOfType<ClickToMove>().gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider collider)
    {
        inf.SetActive(true);
        neponyal.SetActive(true);
    }
    void OnTriggerStay(Collider collider)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            inf.SetActive(false);
            Time.timeScale = 0;
            dialog.SetActive(true);
            Debug.Log("NPC dialog started");
        }
    }
    void OnTriggerExit()
    {
        inf.SetActive(false);
        aponyal.SetActive(false);
    }
}
