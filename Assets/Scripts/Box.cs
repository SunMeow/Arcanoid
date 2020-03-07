using UnityEngine;

[RequireComponent(typeof(Collider2D))] // Напоминание о добавлении определенного компонента.
public class Box : MonoBehaviour
{
    public int boxHP;
    protected GameManager scoreCount;
    protected int sec;

    private void Start()
    {
        scoreCount.score = sec; 
        boxHP = 3;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        boxHP--;
        if (boxHP == 0)
        {
            sec += 10;
            Destroy(gameObject); // Удаляет объект со сцены при коллизии.
        }
    }
}
