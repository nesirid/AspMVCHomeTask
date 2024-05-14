using AspMVCHomeTask.Models;

namespace AspMVCHomeTask.ViewModels
{
    public class PhotoViewModel : BaseEntity
    {
      public List<Photo> Photos { get; set; }
      public string Title { get; set; }
      public string Path { get; internal set; }
    }
}
