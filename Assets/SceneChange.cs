// Script made by Liam Day, GDD-175, Spring semester 2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    // Scene integer number.
    public int sceneNum = 0;
    
    // String slot for scene name.
    public string sceneName;

    // String number of scene extracted from sceneName string.
    public string numChar;

    // Text to display scene name.
    public Text sceneText;
     // Start() function extracts number from scene name, converts it to an int.
    void Start()
    {
        // Get the active scene, then convert it to a string.
        var getSceneName = SceneManager.GetActiveScene();
        sceneName = getSceneName.name;
        
        // Get the one-digit number from the scene name !!(DOES NOT WORK WITH DOUBLE-DIGIT NUMBERS)!!
        numChar = sceneName.Substring(9, 1);
        
        // Convert sceneNum string to integer.
        sceneNum = int.Parse(numChar);
        
        // Get text component, and set the text to current scene name.
        sceneText = gameObject.GetComponent<Text>();
        sceneText.text = sceneName;
    }
    
    // Update is called once per frame
    void Update()
    {
        // If SPACE pressed...
        if (Input.GetKeyDown("space"))
        {
            // If scene number ranges from 0 to 3, add to scene number.
            if (sceneNum <= 1)
            {
                sceneNum++;
            }
            // ...Else set scene number to 0.
            else
            {
                sceneNum = 1;
            }
            
            // Remove number from scene name string, replace it with new scene number.
            sceneName = sceneName.Remove(9, 1);
            sceneName = sceneName.Insert(9, sceneNum.ToString());
            
            // Change scene based on sceneName string.
            SceneManager.LoadScene(sceneName);
        }
    }
}

