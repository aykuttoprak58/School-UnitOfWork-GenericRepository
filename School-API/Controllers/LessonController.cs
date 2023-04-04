using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.BusinessLayer.Abstract;
using School.BusinessLayer.Concrete;
using School.DataAccessLayer;
using School.DataAccessLayer.Repositories.Concrete;
using School.Entities;

namespace School_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {

        public LessonBusiness LessonBusiness;
        public UnitOfWork UOW;

        public LessonController(UnitOfWork uOW, LessonBusiness lessonBusiness)
        {
            LessonBusiness = lessonBusiness;
            UOW = uOW;
          
        }

        [HttpGet]
        [Route("A")]
        public IActionResult GetAll()
        {

            var result = LessonBusiness.GetAll();

            return Ok(result);

        }

        [HttpGet]
        [Route("B")]
        public IActionResult GetById(int id)
        {

            var result = LessonBusiness.GetById(id);

            return Ok(result);

        }



        [HttpPost]
        [Route("C")]
        public IActionResult Add(Lessons entity)
        {

            LessonBusiness.Add(entity);
            UOW.Complete();
            return Ok("kayıt eklendi");
        }

        [HttpPost]
        [Route("D")]
        public IActionResult AddRange(IEnumerable<Lessons> entities)
        {

            LessonBusiness.AddRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt başarılı");

        }


        [HttpDelete]
        [Route("E")]
        public IActionResult Delete(int id)
        {
            LessonBusiness.Remove(id);
            UOW.Complete();
            return Ok("Kayıt Silindi");
        }



        [HttpDelete]
        [Route("F")]
        public IActionResult RemoveRange(IEnumerable<Lessons> entities)
        {

            LessonBusiness.RemoveRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt silindi");

        }

        [HttpPut]
        [Route("G")]
        public IActionResult Update(Lessons entity)
        {
            LessonBusiness.Update(entity);
            UOW.Complete();
            return Ok("kayıt güncellendi");

        }

        [HttpPut]
        [Route("H")]
        public IActionResult UpdateRange(IEnumerable<Lessons> entities)
        {
            LessonBusiness.UpdateRange(entities);
            UOW.Complete();
            return Ok("Toplu Kayıt Güncellendi");

        }



        [HttpGet]
        [Route("I")]
        public IActionResult GetTopDepartments(int count)
        {
            var results = LessonBusiness.GetTopDepartments(count);

            return Ok(results);

        }


    }
}
