using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PauseManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnPauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        var pausebles = FindObjectsOfType<MonoBehaviour>().OfType<Ipauseable>();
        foreach (Ipauseable pauseObject in pausebles)
        {
            pauseObject.PauseGame();
        }

        Time.timeScale = 0;
        AppEvents.Invoke_OnMouseCursorEnable(true);
    }

    public void UnPauseGame()
    {
        var pausebles = FindObjectsOfType<MonoBehaviour>().OfType<Ipauseable>();
        foreach (Ipauseable pauseObject in pausebles)
        {
            pauseObject.PauseGame();
        }

        Time.timeScale = 1;
        AppEvents.Invoke_OnMouseCursorEnable(false);
    }

    private void OnDestroy()
    {
        UnPauseGame();
    }

}

interface Ipauseable
{
    void PauseGame();
    void UnPauseGame();
}
