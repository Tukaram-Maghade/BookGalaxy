﻿using BookGalaxy.DataAccess.Repository.IRepository;
using BookGalaxy.Models;
using BookGalaxy.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using BookGalaxy.Models.ViewModels;
using System;

namespace BookGalaxyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return View(objProductList);
        }

        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Product = new Product()
            };
            if (id == null || id == 0)
            {
                //create
                return View(productVM);
            }
            else
            {
                //update
                productVM.Product = _unitOfWork.Product.Get(u => u.Id == id);
                return View(productVM);
            }

        }
        [HttpPost]
        public IActionResult Upsert(ProductVM productVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product");

                    if (!string.IsNullOrEmpty(productVM.Product.ImageUrl))
                    {
                        //delete the image
                        var oldImagePath = Path.Combine(wwwRootPath, productVM.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }

                    }

                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    productVM.Product.ImageUrl = @"\images\product\" + fileName;
                }
                if (productVM.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(productVM.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(productVM.Product);
                }

                _unitOfWork.Save();

                 
                TempData["success"] = "Product created/updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                productVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(productVM);
            }
        }


        //  public IActionResult DeleteImage(int imageId)
        // {
        //    var imageToBeDeleted = _unitOfWork.ProductImage.Get(u => u.Id == imageId);
        //    int productId = imageToBeDeleted.ProductId;
        //    if (imageToBeDeleted != null)
        //    {
        //        if (!string.IsNullOrEmpty(imageToBeDeleted.ImageUrl))
        //        {
        //            var oldImagePath =
        //                           Path.Combine(_webHostEnvironment.WebRootPath,
        //                           imageToBeDeleted.ImageUrl.TrimStart('\\'));

        //            if (System.IO.File.Exists(oldImagePath))
        //            {
        //                System.IO.File.Delete(oldImagePath);
        //            }
        //        }

        //        _unitOfWork.ProductImage.Remove(imageToBeDeleted);
        //        _unitOfWork.Save();

        //        TempData["success"] = "Deleted successfully";
        //    }

        //    return RedirectToAction(nameof(Upsert), new { id = productId });
        // }

        //#region API CALLS

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
        //    return Json(new { data = objProductList });
        //}


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? ProductFromDb = _unitOfWork.Product.Get(u => u.Id == id);

            if (ProductFromDb == null)
            {
                return NotFound();
            }
            return View(ProductFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Product? obj = _unitOfWork.Product.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
        //    [HttpDelete]
        //public IActionResult Delete(int? id)
        //{
        //    var productToBeDeleted = _unitOfWork.Product.Get(u => u.Id == id);
        //    if (productToBeDeleted == null)
        //    {
        //        return Json(new { success = false, message = "Error while deleting" });
        //    }

        //    string productPath = @"images\products\product-" + id;
        //    string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, productPath);

        //    if (Directory.Exists(finalPath))
        //    {
        //        string[] filePaths = Directory.GetFiles(finalPath);
        //        foreach (string filePath in filePaths)
        //        {
        //            System.IO.File.Delete(filePath);
        //        }

        //        Directory.Delete(finalPath);
        //    }


        //    _unitOfWork.Product.Remove(productToBeDeleted);
        //    _unitOfWork.Save();

        //    return Json(new { success = true, message = "Delete Successful" });
        //}

        //  #endregion
    }
}
