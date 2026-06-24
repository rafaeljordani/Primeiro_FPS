using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadWeapon()
    {
        Debug.Log("Reloading weapon...");
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
