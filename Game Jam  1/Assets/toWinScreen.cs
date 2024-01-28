using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toWinScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisonEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        print("hi");
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("YouWin");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
