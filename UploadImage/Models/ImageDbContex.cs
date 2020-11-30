using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadImage.Models
{
    public class ImageDbContex: DbContext
    {
        public ImageDbContex (DbContextOptions<ImageDbContex> options): base(options) { }

        public DbSet<ImageModel> Images { get; set; }
    }
}
