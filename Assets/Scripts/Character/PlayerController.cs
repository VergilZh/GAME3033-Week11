using Character.UI;
using UnityEngine;

namespace Character
{
    public class PlayerController : MonoBehaviour , Ipauseable
    {
        public CrossHairScript CrossHair => CrossHairComponent;
        [SerializeField] private CrossHairScript CrossHairComponent;

        private GameUIController GameUIController;

        public bool IsFiring;
        public bool IsReloading;
        public bool IsJumping;
        public bool IsRunning;

        private void Awake()
        {
            if (GameUIController == null)
            {
                GameUIController = FindObjectOfType<GameUIController>();
            }
        }

        public void PauseGame()
        {
            GameUIController.EnablePauseMeun();
        }

        public void UnPauseGame()
        {
            GameUIController.EnableGameMeun();
        }
    }
}
