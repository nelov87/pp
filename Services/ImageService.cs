using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Migrations.Design;
using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public class ImageService : IImageService
    {
        public ApplicationDbContext db { get; set; }

        public ImageService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public bool AddImage(Image image)
        {
            bool operatinOk = true;

            try
            {
                this.db.Images.Add(image);

                this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- Image Add");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool DeleteImage(string id)
        {
            bool operatinOk = true;

            try
            {
                GalleryImage[] gi = this.db.GalleryImages.Where(x => x.ImageId == id).ToArray();
            this.db.GalleryImages.RemoveRange(gi);
            Page[] pages = this.db.Pages.Where(x => x.Image.Id == id).ToArray();
            this.db.SaveChanges();

            Image imageToRemove = this.db.Images.FirstOrDefault(x => x.Id == id);
            this.db.Remove(imageToRemove);
            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- Image Delete");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool EditImage(string id, Image image)
        {
            bool operatinOk = true;

            try
            {
                Image imageToEdit = this.db.Images.FirstOrDefault(x => x.Id == id);
            imageToEdit = image;

            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- Image Edit");
                operatinOk = false;
            }
            return operatinOk;
        }

        public Image GetImage(string id)
        {
            Image image = this.db.Images.FirstOrDefault();

            return image;
        }

        public HashSet<Image> GetImages()
        {
            HashSet<Image> image = new HashSet<Image>();
            image = this.db.Images.ToHashSet();

            return image;
        }

        public HashSet<Image> GetImagesByGaleryImage(HashSet<GalleryImage> galleryImages)
        {
            HashSet<Image> image = new HashSet<Image>();
            foreach (GalleryImage gi in galleryImages)
            {
                image.Add(this.db.Images.FirstOrDefault(i => i.Id == gi.ImageId));
            }

            return image;
        }
    }
}
