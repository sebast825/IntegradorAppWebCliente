using Integrador.Dal.Repository.Interface;

namespace Integrador.Dal
{
    public interface IUnitOfWork : IDisposable
    {
        ICamionRepository CamionRepository { get; }
        IViajeRepositorio ViajeRepository { get; }

        /*devuelve  la cabtudad entidades que fueron momdificadas o insertadas, si devuelve 0 es xq no paso nada*/
        Task<int> Save();
    }
}
