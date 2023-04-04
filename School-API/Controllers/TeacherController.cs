using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.DataAccessLayer.Repositories.Concrete;
using School.Entities;

namespace School_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public TeacherRepository teacherRepo;
        public UnitOfWork UOW;
        public TeacherController(TeacherRepository teacherRepository2, UnitOfWork unitOfWork2)
        {
            teacherRepo = teacherRepository2;
            UOW = unitOfWork2;
        }

        [HttpGet]
        [Route("A")]
        public IActionResult GetAll()
        {

            var result = teacherRepo.GetAll();

            return Ok(result);

        }

        [HttpGet]
        [Route("B")]
        public IActionResult GetById(int id)
        {

            var result = teacherRepo.GetById(id);

            return Ok(result);

        }



        [HttpPost]
        [Route("C")]
        public IActionResult Add(Teachers entity)
        {

            teacherRepo.Add(entity);
            UOW.Complete();

            return Ok("kayıt eklendi");
        }

        [HttpPost]
        [Route("D")]
        public IActionResult AddRange(IEnumerable<Teachers> entities)
        {

            teacherRepo.AddRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt başarılı");

        }


        [HttpDelete]
        [Route("E")]
        public IActionResult Delete(int id)
        {
            teacherRepo.Remove(id);
            UOW.Complete();
            return Ok("Kayıt Silindi");
        }



        [HttpDelete]
        [Route("F")]
        public IActionResult RemoveRange(IEnumerable<Teachers> entities)
        {

            teacherRepo.RemoveRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt silindi");

        }

        [HttpPut]
        [Route("G")]
        public IActionResult Update(Teachers entity)
        {
            teacherRepo.Update(entity);
            UOW.Complete();
            return Ok("kayıt güncellendi");

        }

        [HttpPut]
        [Route("H")]
        public IActionResult UpdateRange(IEnumerable<Teachers> entities)
        {
            teacherRepo.UpdateRange(entities);
            UOW.Complete();
            return Ok("Toplu Kayıt Güncellendi");

        }



        [HttpGet]
        [Route("I")]
        public IActionResult GetTopDepartmentS(int count)
        {
            var results = teacherRepo.GetTopDepartments(count);

            return Ok(results);

        }


    }
}
