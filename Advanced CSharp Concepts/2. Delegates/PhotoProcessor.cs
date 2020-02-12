using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_CSharp_Concepts.Delegates
{
    public class PhotoProcessor
    {
        //Generic PhotoFilter Handler
        //public delegate void PhotoFilterHandler(Photo photo);

        //Action Delegate



        public void NonDelegateProcess(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();

            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.ResizePhoto(photo);

            photo.Save();

        }

        public void DelegateProcess(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();

            filterHandler(photo);

            photo.Save();

        }
    }
}
