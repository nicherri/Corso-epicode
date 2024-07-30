using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface ICameraRepository
    {
        Task<IEnumerable<TipologiaCamera>> GetAllTipologieCamereAsync();
        Task<IEnumerable<Camera>> GetCamereByTipologiaAsync(int tipologiaId);
        Task<Camera> GetCameraByIdAsync(int id);
    }
}
