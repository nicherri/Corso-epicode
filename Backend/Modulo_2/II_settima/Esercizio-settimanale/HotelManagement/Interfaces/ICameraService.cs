using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface ICameraService
    {
        Task<IEnumerable<TipologiaCamera>> GetAllTipologieCamereAsync();
        Task<IEnumerable<Camera>> GetCamereByTipologiaAsync(int tipologiaId);
        Task<Camera> GetCameraByIdAsync(int id);
    }
}
