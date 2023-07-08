using UnityEngine;
using UnityEngine.UI;

public class EnemyPanel : MonoBehaviour
{
    public Transform enemy;  
    public float panelDistance = 5f;  
    public GameObject panel; 

    private void Update()
    {
        float distance = Vector2.Distance(transform.position, enemy.position);
        if (distance <= panelDistance)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
