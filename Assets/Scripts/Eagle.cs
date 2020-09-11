using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eagle : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float speed;

    public float flyPower;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            FlyLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            FlyRight();
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Fly();
        }
    }

    public void FlyLeft()
    {
        rigidBody.AddForce(Vector2.left * speed);

        GetComponent<SpriteRenderer>().flipX = false;
    }

    public void FlyRight()
    {
        rigidBody.AddForce(Vector2.right * speed);

        GetComponent<SpriteRenderer>().flipX = true;
    }

    public void Fly()
    {
        rigidBody.AddForce(Vector2.up * flyPower);

        GetComponent<Animator>().SetTrigger("Fly");
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
