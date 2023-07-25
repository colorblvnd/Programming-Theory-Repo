using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Timeline;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject currentAnimalIcon;
    [SerializeField] private Camera mainCamera;
    private bool gamePaused;
    private Animal currentAnimal;

    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

        if (Input.GetMouseButtonDown(0))
        {
            SelectCurrent();
        }
    }

    public void SelectCurrent()
    {
        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var animal = hit.collider.GetComponentInParent<Animal>();
            currentAnimal = animal;
        }

        if (currentAnimal != null)
        {
            currentAnimalIcon.SetActive(true);
            currentAnimalIcon.gameObject.transform.position = currentAnimal.transform.position + new Vector3(0, 4, 0);
        }
    }

    public void TogglePause()
    {
        if (gamePaused)
        {
            gamePaused = false;
            Time.timeScale = 1;
            pauseScreen.SetActive(false);
        }
        else
        {
            gamePaused = true;
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
                Application.Quit();
#endif
    }
}
