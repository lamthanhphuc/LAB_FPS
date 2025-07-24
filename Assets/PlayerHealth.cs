using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI killText;
    public static int killCount = 0;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHUD();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Debug.Log("You died!");
            Time.timeScale = 0;
        }
        UpdateHUD();
    }

    public void AddKill()
    {
        Debug.Log("Enemy killed!");
        killCount++;
        UpdateHUD();
    }

    void UpdateHUD()
    {
        if (healthText) healthText.text = "HP: " + currentHealth;
        if (killText) killText.text = "Kills: " + killCount;
    }
}