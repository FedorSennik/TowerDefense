using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] public int coins;
    private int Health = 3;
    [SerializeField] TextMeshProUGUI textHeath;
    [SerializeField] TextMeshProUGUI cooin;

    public Sprite heartSprite;
    public Transform heartsContainer;
    public Vector2 initialPosition = new Vector2(0, 0);  // Початкова позиція

    private void Start()
    {
        UpdateUI();
        
        coins = 225;
    }


    private void Update()
    {
        cooin.text = $"Coins: {coins.ToString()}";
    }


    public void TakeDamage()
    {
        Health--;
        if (Health <= 0)
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 0;
        }
        UpdateUI();
    }

    private void UpdateUI()
    {

        foreach (Transform child in heartsContainer)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < Health; i++)
        {
            GameObject newHeart = new GameObject("Heart", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
            newHeart.transform.SetParent(heartsContainer);

            RectTransform rectTransform = newHeart.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = initialPosition + new Vector2(-i * 50, 0);  // Задаємо позицію сердець від початкової позиції
            rectTransform.sizeDelta = new Vector2(40, 40);  // Розмір сердець

            Image heartImage = newHeart.GetComponent<Image>();
            heartImage.sprite = heartSprite;
        }
    }
}
