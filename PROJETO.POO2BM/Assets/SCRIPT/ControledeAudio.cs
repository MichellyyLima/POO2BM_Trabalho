using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;
using Toggle = UnityEngine.UI.Toggle;

public class ControledeAudio : MonoBehaviour
{
    public int Volume;
    public int VolumeSFX;
    public bool musica;
    
    
    public Slider volumeSlider;
    public Slider volumeSFXSlider;
    public Toggle toggleMusica;
    public TMP_Text textomusica; 
    
    
    void Start()
    {
        musica = toggleMusica.isOn;
        Volume = (int)volumeSFXSlider.value;
        VolumeSFX = (int)volumeSFXSlider.value;
    }
    
    void Update()
    {
        musica = toggleMusica.isOn;
        Volume = (int)volumeSFXSlider.value;
        VolumeSFX = (int)volumeSFXSlider.value;

        if (musica == true)
        {
          textomusica.text = "Ligado";
          textomusica.color = Color.magenta;
        }
        else
        {
            textomusica.text = "Desligado";
            textomusica.color = Color.yellow;
        }
            
    }
}

