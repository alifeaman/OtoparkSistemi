using UnityEngine;

public class OtoparkSistemi : MonoBehaviour
{
    public int parkSuresi = 3;

    void Start()
    {
        switch (parkSuresi)
        {
            case 0:
                Debug.Log("Otoparkta kalınan süre: 0 Saat\nÖdenecek ücret: 0 TL (Ücretsiz çıkış)");
                break;

            case 1:
                Debug.Log("Otoparkta kalınan süre: 1 Saat\nÖdenecek ücret: 120 TL");
                break;

            case 2:
                Debug.Log("Otoparkta kalınan süre: 2 Saat\nÖdenecek ücret: 200 TL");
                break;

            case 3:
                Debug.Log("Otoparkta kalınan süre: 3 Saat\nÖdenecek ücret: 300 TL");
                break;

            case 4:
                Debug.Log("Otoparkta kalınan süre: 4 Saat\nÖdenecek ücret: 400 TL");
                break;

            default:
                Debug.Log("Otoparkta kalınan süre: " + parkSuresi + " Saat\nÖdenecek ücret: 550 TL");
                break;
        }
    }
}
