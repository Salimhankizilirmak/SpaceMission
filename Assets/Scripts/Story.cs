using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    public GameObject zeroPage; 
    public GameObject firstPage;
    public GameObject secondPage;
    public GameObject thirdPage;
    
    private int currentTagIndex = 0;

    void Start()
    {
        // İlk tag'ı göster
        ShowTag(currentTagIndex);
    }

    public void ShowNextTag()
    {
        // Eğer son tag'daysak bir şey yapma
        if (currentTagIndex == 3) // 4 tag olduğu için, index 0'dan başladığı için 3'te son tag'dır
        {
            // Oyunu başlat
            StartGame();
            return;
        }

        currentTagIndex++;
        // Sonraki tag'ı göster
        ShowTag(currentTagIndex);
    }

    void ShowTag(int index)
    {
        // Tüm sayfaları gizle
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
        zeroPage.SetActive(false); // Yeni eklendi

        // İstenen tag'ı göster
        switch (index)
        {
            case 0:
                zeroPage.SetActive(true); // zeroPage 0. index'e karşılık geliyor
                break;
            case 1:
                firstPage.SetActive(true);
                break;
            case 2:
                secondPage.SetActive(true);
                break;
            case 3:
                thirdPage.SetActive(true);
                break;
            default:
                break;
        }
    }

    void StartGame()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
