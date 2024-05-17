using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public void StinkyHead(string Shop)
    {
        SceneManager.LoadScene(Shop);
    }
}
