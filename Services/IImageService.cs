using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public interface IImageService
    {
        HashSet<Image> GetImages();

        bool AddImage(Image image);

        bool EditImage(string id, Image image);

        bool DeleteImage(string id);

        Image GetImage(string id);

        HashSet<Image> GetImagesByGaleryImage(HashSet<GalleryImage> galleryImages);
    }
}
