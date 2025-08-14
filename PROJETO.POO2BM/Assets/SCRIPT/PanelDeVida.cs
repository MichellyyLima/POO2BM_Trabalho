using UnityEngine;
using UnityEngine.UI;

public class PanelDeVida : MonoBehaviour
{
    public Personagem personagem;
   
    public Slider sliderEnergia;
    public Slider sliderVidas;
    void Start()
    {
        sliderVidas.minValue = 0;
        sliderEnergia.maxValue = personagem.getVidas();

        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = personagem.getEnergia();
    }
    
    void Update()
    {
        sliderVidas.maxValue = personagem.getVidas();
        sliderEnergia.minValue = personagem.getEnergia();
    }
}

