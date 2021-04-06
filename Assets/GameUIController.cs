using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIController : MonoBehaviour
{
    [SerializeField] private GameHUDWidget GameCanves;
    [SerializeField] private GameHUDWidget PauseCanvas;

    private GameHUDWidget ActiveMenu;
    // Start is called before the first frame update
    void Start()
    {
        DisableAllMenus();
        EnableGameMeun();
    }

    public void EnablePauseMeun()
    {
        if (ActiveMenu)
        {
            ActiveMenu.DisableWidget();
        }

        ActiveMenu = PauseCanvas;
        ActiveMenu.EnableWidget();
    }

    public void EnableGameMeun()
    {
        if (ActiveMenu)
        {
            ActiveMenu.DisableWidget();
        }

        ActiveMenu = GameCanves;
        ActiveMenu.EnableWidget();
    }

    public void DisableAllMenus()
    {
        GameCanves.DisableWidget();
        PauseCanvas.DisableWidget();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
public abstract class GameHUDWidget : MonoBehaviour
{
    public void EnableWidget()
    {
        gameObject.SetActive(true);
    }

    public void DisableWidget()
    {
        gameObject.SetActive(false);
    }
}
