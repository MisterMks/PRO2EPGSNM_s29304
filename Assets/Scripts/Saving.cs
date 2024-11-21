using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saving : MonoBehaviour
{
    
    public void NewGame()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
    public void SaveGame()
    {

    }
    public void LoadGame()
    {

    }
    public void Exit()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
