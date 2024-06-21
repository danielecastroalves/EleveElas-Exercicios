namespace GerenciamentoZoologico.Interfaces
{
    public interface INadar
    {
        int LimiteDeProfundidade { get; set; }
        void Subir(int metros);
        void Descer(int metros);
    }
}
