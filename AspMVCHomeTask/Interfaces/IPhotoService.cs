using AspMVCHomeTask.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspMVCHomeTask.Interfaces
{
    public interface IPhotoService
    {
        Task<List<Photo>> GetPhotosAsync();
    }
}
