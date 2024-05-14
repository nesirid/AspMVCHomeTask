using AspMVCHomeTask.Interfaces;
using AspMVCHomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly IPhotoService _photoService;

    public HomeController(IPhotoService photoService)
    {
        _photoService = photoService;
    }

    public async Task<IActionResult> Index()
    {
        var photos = await _photoService.GetPhotosAsync();
        var photoViewModels = photos.Select(p => new PhotoViewModel
        {
            Id = p.Id,
            Title = p.Title,
            Path = p.Path
        }).ToList();

        var viewModel = new IndexViewModel { Photos = photoViewModels };
        return View(viewModel);
    }
}
