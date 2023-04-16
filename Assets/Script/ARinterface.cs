using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ARinterface : MonoBehaviour
{
    public void Back(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void OpenURL(string Link)
    {
        Application.OpenURL(Link);
    }

}
