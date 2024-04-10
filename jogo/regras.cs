namespace configuração;
public class regras
{
    protected string foto;

    public string Getfoto()
    {
        return foto;
    }
    protected double Fome;
    protected double Sede;
    protected double Felicidade;

    public regras()
    {
        Fome = 0;
        Sede = 0;
        Felicidade = 0;
    }
   public void SetFome(double f)
     {
        if (f <=1 || f >=0)
        Fome = f;
        else if (f > 1)
        Fome = 1;
        else
        Fome = 0;
     }

   public void SetSede(double f)
     {
        if (f <=1 || f >=0)
        Sede = f;
        else if (f > 1)
        Sede = 1;
        else
        Sede = 0;
     }

   public void SetFelicidade(double f)
     {
        if (f <=1 || f >=0)
        Felicidade = f;
        else if (f > 1)
        Felicidade = 1;
        else
        Felicidade = 0;
     }
   public double GetFome()
     {
        return Fome;
     }
   public double GetSede()
     {
        return Sede;
     }
   public double GetFelicidade()
     {
        return Felicidade;
     }
}