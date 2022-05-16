using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openChest : MonoBehaviour
{
    [SerializeField]
    private GameObject openChestText;
    [SerializeField]
    private GameObject player;

    private bool indistance = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indistance && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Animate stuff");
            player.GetComponent<PlayerMovement>().transport();
            StartCoroutine(Time());
            StartCoroutine(LoadYourAsyncScene());
        }

    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(3);
    }
    
    IEnumerator LoadYourAsyncScene()
    {
        

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Level 2");

       
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        openChestText.SetActive(true);
        indistance = true;

    }
    
    private void OnTriggerExit(Collider other)
    {
        openChestText.SetActive(false);
        indistance = false;
    }
}
