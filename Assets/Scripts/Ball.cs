using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int speed; //скорость мяча.

    bool pullBall; // зажим мяча.
    Platform platform; // объект с типом Platform.
    Rigidbody2D rb; // физика объекта.
    void Start()
    {
        pullBall = false;
        platform = FindObjectOfType<Platform>(); // Находит объект.
        rb = GetComponent<Rigidbody2D>(); //Находит компонент на объекте.
    }

    void Update()
    {
        if (!pullBall)
        {
            LockBallToPlatform();
        }

    }

    private void LockBallToPlatform()
    {
        transform.position = new Vector3(platform.transform.position.x, transform.position.y, 0); //Приклеивание мяча к платформе.
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) //Проверка запуска мяча.
        {
            pullBall = true;
            LaunchBall();
        }
    }

    public void LaunchBall()
    {
        // добавление толчка при нажатии на кнопку.
        Vector2 force = new Vector2(0, speed);
        rb.AddForce(force);
    }
}
