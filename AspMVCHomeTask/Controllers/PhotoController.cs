using AspMVCHomeTask.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspMVCHomeTask.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<IActionResult> Index()
        {
            var photos = await _photoService.GetPhotosAsync();
            return View(photos);
        }
    }
}
