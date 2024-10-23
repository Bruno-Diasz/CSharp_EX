
public class Viagem
{
    
    // atributos
    public double distancia;
    public string tempo;
  
  

    //contrutor
    public Viagem(double distancia, string tempo)
    {
        this.distancia = distancia;
        this.tempo = tempo;
        
    }

    public double VelMedia(){
        string [] horas = tempo.Split(":");
        double vm = distancia/(int.Parse(horas[0])+(double.Parse(horas[1])/60));
        return vm;
    }
}
