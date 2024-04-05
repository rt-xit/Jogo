namespace configuração;
public class barras
{
    protected string foto;

    public string Getfoto()
    {
        return foto;
    }
    protected double Fome;
    protected double Sede;
    protected double Felicidade;

    public barras()
    {
        Fome = 0;
        Sede = 0;
        Felicidade = 0;
    }
   public void SetFome(int f)
     {
        if (f <=1 || f >=0)
        Fome = f;
        else if (f > 1)
        Fome = 1;
        else
        Fome = 0;
     }

   public void SetSede(int f)
     {
        if (f <=1 || f >=0)
        Sede = f;
        else if (f > 1)
        Sede = 1;
        else
        Sede = 0;
     }

   public void SetFelicidade(int f)
     {
        if (f <=1 || f >=0)
        Felicidade = f;
        else if (f > 1)
        Felicidade = 1;
        else
        Felicidade = 0;
     }
   public int GetFome()
     {
        return Fome;
     }
   public int GetSede()
     {
        return Sede;
     }
   public int GetFelicidade()
     {
        return Felicidade;
     }
}