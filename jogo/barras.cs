namespace configuração;
public class barras
{
    protected string foto;

    public string Getfoto()
    {
        return foto;
    }
    protected int fome;
    protected int sede;
    protected int felicidade;

    public barras()
    {
        fome = 0;
        sede = 0;
        felicidade = 0;
    }
     public void Setfome(int f)
     {
        if (f <=1 || f >=0)
        fome = f;
        else if (f > 1)
        fome = 1;
        else
        fome = 0;
     }
     public int GetFome()
     {
        return fome;
     }
     public int GetSede()
     {
        return sede;
     }
     public int GetFelicidade()
     {
        return felicidade;
     }
}