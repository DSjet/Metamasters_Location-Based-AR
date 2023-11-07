using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenHandler : MonoBehaviour
{
    private float timeCounter = 1f;
    [SerializeField] private float splashScreenTime = 5f;

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        Debug.Log("Changing scene in: " + (splashScreenTime - timeCounter) + " second(s).");
        if (timeCounter > splashScreenTime)
        {
            SceneManager.LoadScene(1);
        }
    }
}
