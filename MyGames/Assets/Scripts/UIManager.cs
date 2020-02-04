using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Image innerHealthBar;
    private Transform playerTransform;
    private float healValue;

    private Transform healthBillboard;
    private float rotateSpeed = 10.0f;

    // Preserve the game object that this component is attached to
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadFirstLevel()
    {
        
        SceneManager.LoadScene(0);
        //SceneManager.sceneLoaded += OnSceneLoaded;

    }

    public void LoadNumSlotScene()
    {
        SceneManager.LoadScene("Number Slot Machine");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex >= 0)
        {
            Button quitButton = GameObject.FindGameObjectWithTag("Back").GetComponent<Button>();
            quitButton.onClick.AddListener(BackToMainMenu);
        }
    }
    void BackToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }

 
}
