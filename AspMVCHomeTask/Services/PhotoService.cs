using AspMVCHomeTask.Data;
using AspMVCHomeTask.Interfaces;
using AspMVCHomeTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspMVCHomeTask.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly AppDbContext _context;

        public PhotoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Photo>> GetPhotosAsync()
        {
            return await _context.Photos.ToListAsync();
        }


    }
}
