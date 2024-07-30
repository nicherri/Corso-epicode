using Hotel.Interfaces;
using Hotel.Models;

namespace Hotel.Services
{
    public class CameraService : ICameraService
    {
        private readonly ICameraRepository _cameraRepository;

        public CameraService(ICameraRepository cameraRepository)
        {
            _cameraRepository = cameraRepository;
        }

        public async Task<IEnumerable<TipologiaCamera>> GetAllTipologieCamereAsync()
        {
            return await _cameraRepository.GetAllTipologieCamereAsync();
        }

        public async Task<IEnumerable<Camera>> GetCamereByTipologiaAsync(int tipologiaId)
        {
            return await _cameraRepository.GetCamereByTipologiaAsync(tipologiaId);
        }

        public async Task<Camera> GetCameraByIdAsync(int id)
        {
            return await _cameraRepository.GetCameraByIdAsync(id);
        }
    }
}
