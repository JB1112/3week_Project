using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Canvas;
    public GameObject ChangeNamePanel;
    public GameObject CharacterSelectPanel;
    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Canvas.activeSelf == true || ChangeNamePanel.activeSelf == true || CharacterSelectPanel.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else if (Canvas.activeSelf == false && ChangeNamePanel.activeSelf == false && CharacterSelectPanel.activeSelf == false)
        {
            Time.timeScale = 1.0f;
        }
    }
}
