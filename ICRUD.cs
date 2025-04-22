
namespace Meu_Hotel
{
    public interface ICRUD<T>
    {
        public void Criar(T entidade);
        public void Atualizar(T entidade);
        public void Excluir(Guid id);
        public T BuscarPeloID(Guid id);

    }
}
