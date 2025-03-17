using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClockIC : MonoBehaviour
{
public Sprite highlightedSprite; // カーソルが重なったときの画像
private Image buttonImage;
private Sprite normalSprite; // ボタンの通常の画像
[SerializeField] private GameObject anotherObject;    
private ClockRotateManager clockRotateManager;
[SerializeField] private GameObject rotatingClockObject;
private RotatingClock rotatingClock;

void Start()
{
buttonImage = GetComponent<Image>();
normalSprite = buttonImage.sprite; 
clockRotateManager = anotherObject.GetComponent<ClockRotateManager>();
rotatingClock = rotatingClockObject.GetComponent<RotatingClock>();
}

public void OnPointerEnter()
{
buttonImage.sprite = highlightedSprite; 
clockRotateManager.ResumeRotation();
rotatingClock.StopRotation();
}

public void OnPointerExit()
{
buttonImage.sprite = normalSprite;
clockRotateManager.StopRotation();
rotatingClock.ResumeRotation();
}
}