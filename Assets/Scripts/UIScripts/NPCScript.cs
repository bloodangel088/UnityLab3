using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public bool endDialog;
    public GameObject dialog;
    


    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Time.timeScale == 0)
            endDialog = true;


        if (endDialog == true)
        {
            Time.timeScale = 1;
            dialog.SetActive(false);
            
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        

        if (collider.tag == "Player")
        {
            Time.timeScale = 0;
            dialog.SetActive(true);
            Debug.Log("NPC dialog started");
            
        }
    }
  
}
