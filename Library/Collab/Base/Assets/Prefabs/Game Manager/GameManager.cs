using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool inventoryOpen;
    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
        inventoryOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventoryOpen)
            {
                inventory.SetActive(false);
                inventoryOpen = false;
                Time.timeScale = 1;
            } else
            {
                inventory.SetActive(true);
                inventoryOpen = true;
                Time.timeScale = 0;
            }
        }
    }

    public void backToMainMenu()
    {
        Debug.Log("Backing to Main Menu");
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
