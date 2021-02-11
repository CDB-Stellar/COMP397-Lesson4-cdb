using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //to change scenes

public class GameController : MonoBehaviour
{
    private void OnGUI() //triggers when unity loads
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "Start")) //when start button is pressed
            SceneManager.LoadScene("Main");
    }
}
