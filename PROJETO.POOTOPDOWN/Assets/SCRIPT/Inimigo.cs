using UnityEngine;

public class Inimigo : MonoBehaviour
{
  
    [SerializeField] public int vidas;
    [SerializeField] private int energia;
    [SerializeField] private float velocidade;
  
  
    public void seteVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int getVidas()
    {
        return vidas;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return energia;
    }

    public void setVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public float getVelocidade()
    {
        return this.velocidade;
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
