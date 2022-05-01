using EasyMektep.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMektep.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly IProjectInterface _repository;
        public ProjectsController(IProjectInterface repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.LastOpened = _repository.GetLastOpened();
            ViewBag.NewCourses = _repository.GetNewCourses();
            ViewBag.AllCourses = _repository.GetAllCourses();
            return View();
        }
        [HttpPost]
        public void Complete(int id)
        {
            _repository.Complete(id);
        }
        [HttpPost]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        [HttpGet]
        public IActionResult Course(int id)
        {
            return View(_repository.GetCourse(id));
        }
        [HttpGet]
        public IActionResult Assignment(int id)
        {
            return View(_repository.GetAssignment(id));
        }
        [HttpPost]
        public void CompleteAssignment(int id)
        {
            _repository.CompleteAssignment(id);
        }
        [HttpPost]
        public void DeleteAssignment(int id)
        {
            _repository.DeleteAssignment(id);
        }
        [HttpPost]
        public bool Add()
        {
            var files = Request.Form.Files;
            using (var ms = new MemoryStream())
            {
                foreach (var item in files)
                {
                    item.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string photo = Convert.ToBase64String(fileBytes);
                }
                
            }
            var b = files;
            return true;
        }
    }
}
