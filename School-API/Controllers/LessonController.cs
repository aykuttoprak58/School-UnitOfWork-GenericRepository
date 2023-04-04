using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.DataAccessLayer;
using School.DataAccessLayer.Repositories.Concrete;
using School.Entities;

namespace School_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {

        public LessonRepository LessonRepo;
        public UnitOfWork UOW;

        public LessonController(LessonRepository lessonrepo2, UnitOfWork uOW)
        {
            LessonRepo = lessonrepo2;
            UOW = uOW;
        }

        [HttpGet]
        [Route("A")]
        public IActionResult GetAll()
        {

            var result = LessonRepo.GetAll();

            return Ok(result);

        }

        [HttpGet]
        [Route("B")]
        public IActionResult GetById(int id)
        {

            var result = LessonRepo.GetById(id);

            return Ok(result);

        }



        [HttpPost]
        [Route("C")]
        public IActionResult Add(Lessons entity)
        {

            LessonRepo.Add(entity);
            UOW.Complete();

            return Ok("kayıt eklendi");
        }

        [HttpPost]
        [Route("D")]
        public IActionResult AddRange(IEnumerable<Lessons> entities)
        {

            LessonRepo.AddRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt başarılı");

        }


        [HttpDelete]
        [Route("E")]
        public IActionResult Delete(int id)
        {
            LessonRepo.Remove(id);
            UOW.Complete();
            return Ok("Kayıt Silindi");
        }



        [HttpDelete]
        [Route("F")]
        public IActionResult RemoveRange(IEnumerable<Lessons> entities)
        {

            LessonRepo.RemoveRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt silindi");

        }

        [HttpPut]
        [Route("G")]
        public IActionResult Update(Lessons entity)
        {
            LessonRepo.Update(entity);
            UOW.Complete();
            return Ok("kayıt güncellendi");

        }

        [HttpPut]
        [Route("H")]
        public IActionResult UpdateRange(IEnumerable<Lessons> entities)
        {
            LessonRepo.UpdateRange(entities);
            UOW.Complete();
            return Ok("Toplu Kayıt Güncellendi");

        }



        [HttpGet]
        [Route("I")]
        public IActionResult GetTopDepartmentS(int count)
        {
            var results = LessonRepo.GetTopDepartments(count);

            return Ok(results);

        }


    }
}
