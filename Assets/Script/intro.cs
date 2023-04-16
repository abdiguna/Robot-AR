using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    
    public void YesButton(string AR)
    {
        SceneManager.LoadScene(AR);
    }
    public void NoButton(string Robot)
    {
        SceneManager.LoadScene(Robot);
    }
}
