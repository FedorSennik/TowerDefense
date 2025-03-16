using UnityEngine;
using UnityEngine.UI;

public class StopResume : MonoBehaviour
{
    public Sprite avatar1;
    public Sprite avatar2;
    public Image targetImage;
    private bool timeRunning = true;
    private Button timeButton;

    void Start()
    {
        timeButton = GetComponent<Button>();
        timeButton.onClick.AddListener(ToggleTime);
        targetImage.sprite = avatar1;
    }

    void ToggleTime()
    {
        timeRunning = !timeRunning;
        if (timeRunning)
        {
            Time.timeScale = 1;
            targetImage.sprite = avatar1;
        }
        else
        {
            Time.timeScale = 0;
            targetImage.sprite = avatar2;
        }
    }
}
