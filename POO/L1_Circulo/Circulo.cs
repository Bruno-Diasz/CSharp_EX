public class Circulo
{
    //Atributos
    public double raio;

    //Metodos
    public double CalcArea(){
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }

    public double CalcCircun(){
        double circunferencia = 2*Math.PI*raio;
        return circunferencia;
    }
}
